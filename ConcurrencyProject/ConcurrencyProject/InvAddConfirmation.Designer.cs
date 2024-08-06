namespace ConcurrencyProject
{
    partial class InvAddConfirmation
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(39, 9);
            label1.Name = "label1";
            label1.Size = new Size(331, 98);
            label1.TabIndex = 0;
            label1.Text = "Add an investigation with the filled parameters?";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(214, 138);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "yes";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(295, 138);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "no";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // InvAddConfirmation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 201);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "InvAddConfirmation";
            Text = "InvAddConfirmation";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        public bool result;
    }
}