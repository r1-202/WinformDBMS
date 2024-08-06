
using ConcurrencyProject.Repositories;
using ConcurrencyProject.Repositories.Models;

namespace ConcurrencyProject
{
    partial class FormFace
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
            var imf = context.ImageFaces.Select(e=>e).Where(e => e.Serial == serial && e.Serpers == serpers);
            if(imf.Count()==0)
            {
                filled[0] = filled[1] = filled[2] = false;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                filled[0] = filled[1] = filled[2] = true;
                ImageFace imfi = imf.FirstOrDefault();
                byte[] imdata = imfi.Faceleft;
                using (MemoryStream ms = new MemoryStream(imdata))
                {
                    Image image = Image.FromStream(ms);
                    pictureBox1.Image = image;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                imdata = imfi.Facefront;
                using(MemoryStream ms = new MemoryStream(imdata))
                {
                    Image image = Image.FromStream(ms);
                    pictureBox2.Image = image;
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                imdata = imfi.Faceright;
                using (MemoryStream ms = new MemoryStream(imdata))
                {
                    Image image = Image.FromStream(ms);
                    pictureBox3.Image = image;
                    pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            editbtn = new Button();
            deletebtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(60, 119);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(195, 270);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(324, 119);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(195, 270);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Location = new Point(576, 119);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(195, 270);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Yellow;
            label1.Location = new Point(324, 101);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 3;
            label1.Text = "وجه امامي";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 38);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 4;
            label2.Text = "الموقوف";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 9);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 5;
            label3.Text = "المتسلسل";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Yellow;
            label4.Location = new Point(576, 101);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 6;
            label4.Text = "وجه ايمن";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Yellow;
            label5.Location = new Point(60, 101);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 7;
            label5.Text = "وجه ايسر";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(17, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(37, 23);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(17, 35);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(37, 23);
            textBox2.TabIndex = 9;
            // 
            // editbtn
            // 
            editbtn.Location = new Point(696, 415);
            editbtn.Name = "editbtn";
            editbtn.Size = new Size(75, 23);
            editbtn.TabIndex = 11;
            editbtn.Text = "تعديل";
            editbtn.UseVisualStyleBackColor = true;
            editbtn.Click += editbtn_Click;
            // 
            // deletebtn
            // 
            deletebtn.Location = new Point(615, 415);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(75, 23);
            deletebtn.TabIndex = 12;
            deletebtn.Text = "حذف";
            deletebtn.UseVisualStyleBackColor = true;
            deletebtn.Click += deletebtn_Click;
            // 
            // FormFace
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(deletebtn);
            Controls.Add(editbtn);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "FormFace";
            Text = "FormFace";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button editbtn;
        private Button deletebtn;
        private int serial;
        private int serpers;
        private InvEntities? context;
        private bool[] filled;
    }
}