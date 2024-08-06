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
    public partial class FormInvPers : Form
    {
        public FormInvPers(int serial)
        {
            person = new Invperson();
            person.Serial = serial;
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            bool t = int.TryParse(textBox2.Text, out int n);
            if (t) person.Serpers = n;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            person.Fname = textBox3.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            person.Lname = textBox4.Text;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            person.Father = textBox6.Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            person.Mother = textBox5.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                person.Nation = context.Nations.Select(e => e).Where(e => e.Fname == comboBox1.Items[comboBox1.SelectedIndex]).ToArray()[0].Code;
            }
            else
            {
                person.Nation = 0;
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            person.Pbirth = textBox8.Text;
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            person.Resid = textBox9.Text;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            person.Reg = textBox7.Text;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex != -1) person.Pbirth = (string)comboBox2.Items[comboBox2.SelectedIndex];
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex != -1) person.Resid = (string)comboBox3.Items[comboBox3.SelectedIndex];
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex != -1)
                person.Attr = context.Attrs.Select(e => e).Where(e => e.Label == comboBox4.Items[comboBox4.SelectedIndex]).ToArray()[0].Code;
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            bool t = int.TryParse(textBox10.Text, out int n);
            if (t) person.Dbirth = n;
            else person.Dbirth = null;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            person.Nickname = textBox11.Text;
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            person.Occupation = textBox12.Text;
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox6.SelectedIndex != -1) person.Status = (string)comboBox6.Items[comboBox6.SelectedIndex];
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox5.SelectedIndex != -1) person.Gender = (string)comboBox5.Items[comboBox5.SelectedIndex];
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            InvAddConfirmation conf = new InvAddConfirmation("Add new person to current investigation?");
            conf.Show();
            conf.FormClosed += async delegate
            {
                if (conf.result)
                {
                    if (verify())
                    {
                        var context1 = new InvEntities();
                        var db = context.Invpersons.Select(e => e).Where(e => e.Serial == person.Serial);
                        if (db.IsNullOrEmpty()) person.Serpers = 1;
                        else person.Serpers = (await db.MaxAsync(e => e.Serpers)) + 1;
                        context1.Invpersons.Add(person);
                        await context1.SaveChangesAsync();
                        label3.BackColor = Color.Green;
                        ShowTempMessage("Person added.");
                        sync();
                    }
                }
                else
                {
                    label3.BackColor = Color.Red;
                    ShowTempMessage("Person addition operation canceled.");
                }
            };
        }
        private void ShowTempMessage(string s)
        {
            label3.Text = s;
            timer1.Start();
        }

        private void sync()
        {
            context = new InvEntities();
            context.Invpersons.Load<Invperson>();
            invpersonBindingSource.DataSource = context.Invpersons.Local.ToBindingList().Select(e => e).Where(e => e.Serial == person.Serial);
            dataGridView1.Refresh();
        }

        private bool verify()
        {
            if (person.Fname != null && person.Lname != null) return true;
            else
            {
                label3.BackColor = Color.Red;
                ShowTempMessage("Invalid information.");
                return false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = string.Empty;
            timer1.Stop();
        }

        private void Resetform()
        {
            textBox4.Clear();
            textBox3.Clear();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Resetform();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 && dataGridView1.SelectedRows[0].Cells[0].Value != null)
            {
                int serial = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                int serperson = (int)dataGridView1.SelectedRows[0].Cells[1].Value;
                InvAddConfirmation conf = new InvAddConfirmation("Delete selected person?");
                conf.Show();
                conf.FormClosed += async delegate
                {
                    if (conf.result)
                    {
                        var context1 = new InvEntities();
                        var person = await context1.Invpersons.SingleOrDefaultAsync(e =>
                        (e.Serial == serial && e.Serpers == serperson));
                        if (person != null)
                        {
                            context1.Invpersons.Remove(person);
                            await context1.SaveChangesAsync();
                            label3.BackColor = Color.Green;
                            ShowTempMessage("Person deleted.");
                            sync();
                            Resetform();
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
                        ShowTempMessage("Person delete operation cancelled.");
                    }
                };
            }
            else
            {
                label3.BackColor = Color.Red;
                ShowTempMessage("Select one row.");
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 && dataGridView1.SelectedRows[0].Cells[0].Value != null)
            {
                int serial = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                int serpers = (int)dataGridView1.SelectedRows[0].Cells[1].Value;
                InvAddConfirmation conf = new InvAddConfirmation("Update selected person?");
                conf.Show();
                conf.FormClosed += async delegate
                {
                    if (conf.result)
                    {
                        var context1 = new InvEntities();
                        var person = await context1.Invpersons.SingleOrDefaultAsync(e =>
                        e.Serial == serial && e.Serpers == serpers);
                        if (person != null)
                        {
                            person.Fname = this.person.Fname;
                            person.Lname = this.person.Lname;
                            person.Father = this.person.Father;
                            person.Mother = this.person.Mother;
                            person.Nation = this.person.Nation;
                            person.Reg = this.person.Reg;
                            person.Pbirth = this.person.Pbirth;
                            person.Dbirth = this.person.Dbirth;
                            person.Resid = this.person.Resid;
                            person.Adrs = this.person.Adrs;
                            person.Attr = this.person.Exst;
                            person.Arch = this.person.Arch;
                            person.Nickname = this.person.Nickname;
                            person.Occupation = this.person.Occupation;
                            person.Idnum = this.person.Idnum;
                            person.Mobileno = this.person.Mobileno;
                            person.Status = this.person.Status;
                            person.Gender = this.person.Gender;

                            await context1.SaveChangesAsync();
                            label3.BackColor = Color.Green;
                            ShowTempMessage("Row updated successfully.");
                            sync();

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
                        ShowTempMessage("Person edit operation cancelled.");
                    }
                };
            }
            else
            {
                label3.BackColor = Color.Red;
                ShowTempMessage("Select one row.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 && dataGridView1.SelectedRows[0].Cells[0].Value != null)
            {
                int serial = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                int serpers = (int)dataGridView1.SelectedRows[0].Cells[1].Value;
                FormFace form = new FormFace(serial, serpers);
                form.Show();
                Hide();
                form.FormClosed += delegate
                {
                    Show();
                };
            }
            else
            {
                label3.BackColor = Color.Red;
                ShowTempMessage("Select one row.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 && dataGridView1.SelectedRows[0].Cells[0].Value != null)
            {
                int serial = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                int serpers = (int)dataGridView1.SelectedRows[0].Cells[1].Value;
                FormFp form = new FormFp(serial, serpers);
                form.Show();
                Hide();
                form.FormClosed += delegate
                {
                    Show();
                };
            }
            else
            {
                label3.BackColor = Color.Red;
                ShowTempMessage("Select one row.");
            }
        }
    }
}
