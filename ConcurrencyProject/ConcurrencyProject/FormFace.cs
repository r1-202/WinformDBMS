using ConcurrencyProject.Repositories.Models;
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
    public partial class FormFace : Form
    {
        public FormFace(int serial, int serpers)
        {
            InitializeComponent();
            this.serial = serial;
            this.serpers = serpers;
            filled = new bool[3];
        }

        private bool verify()
        {
            return filled[0] && filled[1] && filled[2];
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            InvAddConfirmation conf = new InvAddConfirmation("Delete images from picture boxes and database?");
            conf.Show();
            conf.FormClosed += async delegate
            {
                if (conf.result)
                {
                    var imf = context.ImageFaces.Select(e => e).Where(e => e.Serial == serial && e.Serpers == serpers);
                    if (imf.Count() != 0)
                    {
                        var imfi = imf.FirstOrDefault();
                        context.ImageFaces.Remove(imfi);
                    }
                    pictureBox1.Image = null;
                    pictureBox2.Image = null;
                    pictureBox3.Image = null;
                    pictureBox1.Tag = null;
                    pictureBox2.Tag = null;
                    pictureBox3.Tag = null;
                    filled[0] = filled[1] = filled[2] = false;
                    await context.SaveChangesAsync();
                }
            };
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            if (verify())
            {
                InvAddConfirmation conf = new InvAddConfirmation("Insert selected images?");
                conf.Show();
                conf.FormClosed += async delegate
                {
                    if (conf.result)
                    {
                        var imf = context.ImageFaces.Select(e => e).Where(e => e.Serial == serial && e.Serpers == serpers);
                        if (imf.Count() != 0)
                        {
                            var imfi = imf.FirstOrDefault();
                            using (MemoryStream ms = new MemoryStream())
                            {
                                pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                                byte[] image = ms.ToArray();
                                imfi.Faceleft = image;
                            }
                            using (MemoryStream ms = new MemoryStream())
                            {
                                pictureBox2.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                                byte[] image = ms.ToArray();
                                imfi.Facefront = image;
                            }
                            using (MemoryStream ms = new MemoryStream())
                            {
                                pictureBox3.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                                byte[] image = ms.ToArray();
                                imfi.Faceright = image;
                            }
                        }
                        else
                        {
                            ImageFace imfi = new ImageFace();
                            imfi.Serial = serial;
                            imfi.Serpers = serpers;
                            using (MemoryStream ms = new MemoryStream())
                            {
                                pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                                byte[] image = ms.ToArray();
                                imfi.Faceleft = image;
                            }
                            using (MemoryStream ms = new MemoryStream())
                            {
                                pictureBox2.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                                byte[] image = ms.ToArray();
                                imfi.Facefront = image;
                            }
                            using (MemoryStream ms = new MemoryStream())
                            {
                                pictureBox3.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                                byte[] image = ms.ToArray();
                                imfi.Faceright = image;
                            }
                            context.ImageFaces.Add(imfi);
                        }
                        await context.SaveChangesAsync();
                    }
                };
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (SelectAndDisplayImage(pictureBox1))
            {
                filled[0] = true;
            }
        }
        private bool SelectAndDisplayImage(PictureBox pictureBox)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Title = "Select an Image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imgLocation = openFileDialog.FileName;
                    pictureBox.Tag = imgLocation;
                    pictureBox.Image = Image.FromFile(imgLocation);
                    return true;
                }
                return false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (SelectAndDisplayImage(pictureBox2))
            {
                filled[1] = true;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (SelectAndDisplayImage(pictureBox3))
            {
                filled[2] = true;
            }
        }
    }
}
