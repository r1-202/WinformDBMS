using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConcurrencyProject.Repositories;
using ConcurrencyProject.Repositories.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace ConcurrencyProject
{
    public partial class FormVehicles : Form
    {
        public FormVehicles(int serial)
        {
            vehicle = new Vehicle();
            InitializeComponent();
            Controls["textBox1"].Text = serial.ToString();
            vehicle.SerialNb = serial;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            vehicle.ActualNb = Controls["textBox2"].Text;
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            vehicle.Name = Controls["textBox10"].Text;
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            vehicle.MotherName = Controls["textBox9"].Text;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            vehicle.Lastname = Controls["textBox8"].Text;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            vehicle.AgeProp = Controls["numericUpDown1"].Text;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            vehicle.BirthPlace = Controls["textBox6"].Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            vehicle.Address = Controls["textBox5"].Text;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            vehicle.Dateaquisition = Controls["numericUpDown2"].Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            vehicle.NoRegProp = Controls["textBox3"].Text;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
        }

        private void insertbtn_Click(object sender, EventArgs e)
        {
            InvAddConfirmation conf = new InvAddConfirmation("Add new car to current investigation?");
            conf.Show();
            conf.FormClosed += async delegate
            {
                if (conf.result)
                {
                    if (verify())
                    {
                        var context1 = new InvEntities();
                        var db = context.Vehicles.Select(e => e).Where(e => e.SerialNb == vehicle.SerialNb);
                        if (db.IsNullOrEmpty()) vehicle.Vid = 1;
                        else vehicle.Vid = (await db.MaxAsync(e => e.Vid)) + 1;
                        context1.Vehicles.Add(vehicle);
                        await context1.SaveChangesAsync();
                        sync();
                    }
                }
                else
                {
                }
            };
        }

        private bool verify()
        {
            return true;
        }

        private void sync()
        {
            context = new InvEntities();
            context.Database.EnsureCreated();
            context.Vehicles.Load<Vehicle>();
            vehicleBindingSource.DataSource = context.Vehicles.Local.ToBindingList().Select(e => e).Where(e => e.SerialNb == vehicle.SerialNb);
            if (context.Vehicles.Local.ToBindingList().Count != 0)
            { Controls["textBox18"].Text = context.Vehicles.Local.ToBindingList().Count.ToString(); }
            else
            { Controls["textBox18"].Text = "No vehicles for the current invest"; }
            dataGridView1.Refresh();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 && dataGridView1.SelectedRows[0].Cells[0].Value != null)
            {
                int serial = (int)dataGridView1.SelectedRows[0].Cells[1].Value;
                int vid = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                InvAddConfirmation conf = new InvAddConfirmation("Update selected vehicle?");
                conf.Show();
                conf.FormClosed += async delegate
                {
                    if (conf.result)
                    {
                        var context1 = new InvEntities();
                        var vehicle = await context1.Vehicles.SingleOrDefaultAsync(e =>
                        e.SerialNb == serial && e.Vid == vid);
                        if (vehicle != null)
                        {

                            vehicle.PreMiseCirc = this.vehicle.PreMiseCirc;
                            vehicle.AgeProp = this.vehicle.AgeProp;
                            vehicle.NoRegProp = this.vehicle.NoRegProp;
                            vehicle.TelProp = this.vehicle.TelProp;
                            vehicle.BirthPlace = this.vehicle.BirthPlace;
                            vehicle.Brand = this.vehicle.Brand;
                            vehicle.Address = this.vehicle.Address;
                            vehicle.ActualNb = this.vehicle.ActualNb;
                            vehicle.Chassis = this.vehicle.Chassis;
                            //copy rest of values
                            await context1.SaveChangesAsync();
                            sync();

                        }
                        else
                        {
                        }
                    }
                    else
                    {
                    }
                };
            }
            else
            {
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 && dataGridView1.SelectedRows[0].Cells[0].Value != null)
            {
                int serial = (int)dataGridView1.SelectedRows[0].Cells[1].Value;
                int vid = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                InvAddConfirmation conf = new InvAddConfirmation("Delete selected car?");
                conf.Show();
                conf.FormClosed += async delegate
                {
                    if (conf.result)
                    {
                        var context1 = new InvEntities();
                        var vehicle = await context1.Vehicles.SingleOrDefaultAsync(e =>
                        (e.SerialNb == serial && e.Vid == vid));
                        if (vehicle != null)
                        {
                            context1.Vehicles.Remove(vehicle);
                            await context1.SaveChangesAsync();
                            sync();
                        }
                        else
                        {
                        }
                    }
                    else
                    {
                    }
                };
            }
            else
            {
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //reset all fields manually
        }
    }
}
