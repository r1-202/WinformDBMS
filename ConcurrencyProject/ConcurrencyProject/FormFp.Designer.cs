using ConcurrencyProject.Repositories;
using ConcurrencyProject.Repositories.Models;
using System.Windows.Forms;

namespace ConcurrencyProject
{
    partial class FormFp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            textBox1.Text = serial.ToString();
            textBox2.Text = serpers.ToString();
            context = new InvEntities();
            var imf = context.ImageFps.Select(e => e).Where(e => e.Serial == serial && e.Serpers == serpers);
            if (imf.Count() == 0)
            {
                filled[0] = filled[1] = false;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                filled[0] = filled[1] = true;
                ImageFp imfi = imf.FirstOrDefault();
                byte[] imdata = imfi.Fpleft;
                using (MemoryStream ms = new MemoryStream(imdata))
                {
                    Image image = Image.FromStream(ms);
                    pictureBox1.Image = image;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                imdata = imfi.Fpright;
                using (MemoryStream ms = new MemoryStream(imdata))
                {
                    Image image = Image.FromStream(ms);
                    pictureBox2.Image = image;
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            deletebtn = new Button();
            editbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 9);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 6;
            label3.Text = "المتسلسل";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(15, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(37, 23);
            textBox1.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 35);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 10;
            label2.Text = "الموقوف";
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(15, 32);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(37, 23);
            textBox2.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(152, 71);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(195, 270);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(427, 71);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(195, 270);
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Yellow;
            label5.Location = new Point(152, 53);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 14;
            label5.Text = "ابهام ايسر";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Yellow;
            label4.Location = new Point(427, 53);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 15;
            label4.Text = "ابهام ايمن";
            // 
            // deletebtn
            // 
            deletebtn.Location = new Point(466, 389);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(75, 23);
            deletebtn.TabIndex = 16;
            deletebtn.Text = "حذف";
            deletebtn.UseVisualStyleBackColor = true;
            deletebtn.Click += deletebtn_Click;
            // 
            // editbtn
            // 
            editbtn.Location = new Point(547, 389);
            editbtn.Name = "editbtn";
            editbtn.Size = new Size(75, 23);
            editbtn.TabIndex = 17;
            editbtn.Text = "تعديل";
            editbtn.UseVisualStyleBackColor = true;
            editbtn.Click += editbtn_Click;
            // 
            // FormFp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(673, 424);
            Controls.Add(editbtn);
            Controls.Add(deletebtn);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Name = "FormFp";
            Text = "FormFp";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private int serial;
        private int serpers;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label5;
        private Label label4;
        private Button deletebtn;
        private Button editbtn;
        private bool[] filled;
        private InvEntities? context;
    }
}