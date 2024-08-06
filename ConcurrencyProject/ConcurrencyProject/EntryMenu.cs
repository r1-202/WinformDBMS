using ConcurrencyProject.Repositories;
using ConcurrencyProject.Repositories.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConcurrencyProject
{
    public partial class EntryMenu : Form
    {
        public EntryMenu()
        {
            InitializeComponent();
            textBox1.KeyDown += textBox1_KeyDown;
            inv_to_add = new Invest();
            inv_to_add.Resume = "N";
            inv_to_add.Madbout = "N";
            inv_to_add.Dfile = DateOnly.FromDateTime(dateTimePicker3.Value);
            inv_to_add.Dmahdar = DateOnly.FromDateTime(dateTimePicker4.Value);

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string temp = textBox1.Text;
                textBox1.Clear();
                comboBox1.Items.Add(temp);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                inv_to_add.Resume = "Y";
                string temp = textBox2.Text;
                inv_to_add.Rem = temp;
            }
            else
            {
                inv_to_add.Resume = "N";
                inv_to_add.Rem = null;
            }
        }

        private void insertbtn_Click(object sender, EventArgs e)
        {
            InvAddConfirmation conf = new InvAddConfirmation("Add new investigation?");
            conf.Show();
            conf.FormClosed += async delegate
            {
                if (conf.result)
                {
                    var context1 = new InvEntities();
                    if (context1.Invests.IsNullOrEmpty()) inv_to_add.Serial = 1;
                    else inv_to_add.Serial = (await context1.Invests.MaxAsync(e => e.Serial)) + 1;
                    context1.Invests.Add(inv_to_add);
                    await context1.SaveChangesAsync();
                    label3.BackColor = Color.Green;
                    ShowTempMessage("Investigation saved succesfully.");
                }
                else
                {
                    label3.BackColor = Color.Red;
                    ShowTempMessage("Investigation addition operation cancelled.");
                }
            };
        }

        private void ShowTempMessage(string s)
        {
            label3.Text = s;
            timer1.Start();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                inv_to_add.Madbout = "Y";
            }
            else
            {
                inv_to_add.Madbout = "N";
            }
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            inv_to_add.Dfile = DateOnly.FromDateTime(dateTimePicker3.Value);
        }

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {
            inv_to_add.Dmahdar = DateOnly.FromDateTime(dateTimePicker4.Value);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                string temp = textBox2.Text;
                inv_to_add.Rem = temp;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
                inv_to_add.Crime = (string)comboBox1.Items[comboBox1.SelectedIndex];
            else inv_to_add.Crime = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = string.Empty;
            timer1.Stop();
        }

        private void newbtn_Click(object sender, EventArgs e)
        {
            context = new InvEntities();
            context.Invests.Load<Invest>();
            investBindingSource.DataSource = context.Invests.Local.ToBindingList();
            dataGridView1.Refresh();
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 && dataGridView1.SelectedRows[0].Cells[0].Value != null)
            {
                int serial = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                InvAddConfirmation conf = new InvAddConfirmation("Update selected investigation?");
                conf.Show();
                conf.FormClosed += async delegate
                {
                    if (conf.result)
                    {
                        var context1 = new InvEntities();
                        var invest = await context1.Invests.SingleOrDefaultAsync(e => e.Serial == serial);
                        if (invest != null)
                        {
                            invest.Dfile = inv_to_add.Dfile;
                            invest.Dmahdar = inv_to_add.Dmahdar;
                            invest.Crime = inv_to_add.Crime;
                            invest.Madbout = inv_to_add.Madbout;
                            invest.Resume = inv_to_add.Resume;
                            invest.Rem = inv_to_add.Rem;
                            await context1.SaveChangesAsync();
                            label3.BackColor = Color.Green;
                            ShowTempMessage("Row updated successfully.");
                        }
                        else
                        {
                            label3.BackColor = Color.Red;
                            ShowTempMessage("Database error!");
                        }
                    }
                    else
                    {
                        label3.BackColor = Color.Red;
                        ShowTempMessage("Investigation edit operation cancelled.");
                    }
                };
            }
            else
            {
                label3.BackColor = Color.Red;
                ShowTempMessage("Select one row.");
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0 && dataGridView1.SelectedRows[0].Cells[0].Value != null)
            {
                int serial = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                InvAddConfirmation conf = new InvAddConfirmation("Delete selected investigation?");
                conf.Show();
                conf.FormClosed += async delegate
                {
                    if (conf.result)
                    {
                        var context1 = new InvEntities();
                        var invest = await context1.Invests.SingleOrDefaultAsync(e => e.Serial == serial);
                        if (invest != null)
                        {
                            context1.Invests.Remove(invest);
                            var associated_images = await context1.ImageFps.Where(e => e.Serial == serial).ToListAsync();
                            foreach (var v in associated_images)
                            {
                                context1.ImageFps.Remove(v);
                            }
                            var associated_persons = await context1.Invpersons.Where(e => e.Serial == serial).ToListAsync();
                            foreach (var v in associated_persons)
                            {
                                context1.Invpersons.Remove(v);
                            }
                            var associated_vehicles = await context1.Vehicles.Where(e => e.SerialNb == serial).ToListAsync();
                            foreach (var v in associated_vehicles)
                            {
                                context1.Vehicles.Remove(v);
                            }
                            var associated_imfp = await context1.ImageFps.Where(e => e.Serial == serial).ToListAsync();
                            foreach(var v in associated_imfp)
                            {
                                context1.ImageFps.Remove(v);
                            }
                            var associated_imface = await context1.ImageFaces.Where(e => e.Serial == serial).ToListAsync();
                            foreach(var v in associated_imface)
                            {
                                context1.ImageFaces.Remove(v);
                            }
                            await context1.SaveChangesAsync();
                            label3.BackColor = Color.Green;
                            ShowTempMessage("Investigation deleted.");
                        }
                        else
                        {
                            label3.BackColor = Color.Red;
                            ShowTempMessage("Database error!");
                        }
                    }
                    else
                    {
                        label3.BackColor = Color.Red;
                        ShowTempMessage("Investigation delete operation cancelled.");
                    }
                };
            }
            else
            {
                label3.BackColor = Color.Red;
                ShowTempMessage("Select one row.");
            }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
        private void ResetForm()
        {
            dateTimePicker3.Value = DateTime.Now;
            dateTimePicker4.Value = DateTime.Now;
            textBox1.Clear();
            comboBox1.SelectedIndex = -1;
            textBox2.Clear();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            context = new InvEntities();
            context.Invests.Load<Invest>();
            investBindingSource.DataSource = context.Invests.Local.ToBindingList();
            dataGridView1.Refresh();
        }

        private void InvPers_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 && dataGridView1.SelectedRows[0].Cells[0].Value != null)
            {
                int serial = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                FormInvPers form = new FormInvPers(serial);
                Hide();
                form.Show();
                form.FormClosing += delegate { Show(); };
            }
            else
            {
                label3.BackColor = Color.Red;
                ShowTempMessage("Select one row.");
            }
        }

        private void word_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 && dataGridView1.SelectedRows[0].Cells[0].Value != null)
            {
                int serial = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                FormWord form = new FormWord(serial);
                Hide();
                form.Show();
                form.FormClosing += delegate { Show(); };
            }
            else
            {
                label3.BackColor = Color.Red;
                ShowTempMessage("Select one row.");
            }
        }

        private void vehl_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 && dataGridView1.SelectedRows[0].Cells[0].Value != null)
            {
                int serial = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                FormVehicles form = new FormVehicles(serial);
                Hide();
                form.Show();
                form.FormClosing += delegate { Show(); };
            }
            else
            {
                label3.BackColor = Color.Red;
                ShowTempMessage("Select one row.");
            }
        }
    }
}
