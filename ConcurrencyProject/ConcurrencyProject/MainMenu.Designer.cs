namespace ConcurrencyProject
{
    partial class MainMenu
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            flowLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(90, 37);
            button1.TabIndex = 0;
            button1.Text = "تقارير";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(3, 175);
            button2.Name = "button2";
            button2.Size = new Size(90, 37);
            button2.TabIndex = 1;
            button2.Text = "الجرائم";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(3, 132);
            button3.Name = "button3";
            button3.Size = new Size(90, 37);
            button3.TabIndex = 2;
            button3.Text = "احصائيات";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(3, 89);
            button4.Name = "button4";
            button4.Size = new Size(90, 37);
            button4.TabIndex = 3;
            button4.Text = "المتهمين";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(3, 46);
            button5.Name = "button5";
            button5.Size = new Size(90, 37);
            button5.TabIndex = 4;
            button5.Text = "ادخال";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button5);
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Location = new Point(18, 81);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(105, 227);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(15, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(108, 65);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ButtonFace;
            textBox1.Dock = DockStyle.Bottom;
            textBox1.Enabled = false;
            textBox1.Location = new Point(3, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(102, 23);
            textBox1.TabIndex = 0;
            textBox1.Text = "MyLogo";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(167, 81);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(198, 198);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 321);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Controls.Add(flowLayoutPanel1);
            Name = "MainMenu";
            Text = "MainMenu";
            flowLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private FlowLayoutPanel flowLayoutPanel1;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private PictureBox pictureBox1;
    }
}