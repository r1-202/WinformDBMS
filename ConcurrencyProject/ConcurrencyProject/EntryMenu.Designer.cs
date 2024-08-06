using ConcurrencyProject.Repositories;
using ConcurrencyProject.Repositories.Models;
using Microsoft.EntityFrameworkCore;

namespace ConcurrencyProject
{
    partial class EntryMenu
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
            context = new InvEntities();
            context.Database.EnsureCreated();
            context.Invests.Load<Invest>();
            investBindingSource.DataSource = context.Invests.Local.ToBindingList();
            comboBox1.Items.AddRange(context.Invests.Select(e => e.Crime).Where(crime=>crime!=null).Distinct().ToArray());
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            context?.Dispose();
            context= null;
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            label3 = new Label();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            textBox2 = new TextBox();
            dataGridView1 = new DataGridView();
            serialDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dfileDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dmahdarDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            crimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            madboutDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            resumeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            remDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            investBindingSource = new BindingSource(components);
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            dateTimePicker4 = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            dateTimePicker3 = new DateTimePicker();
            flowLayoutPanel2 = new FlowLayoutPanel();
            button6 = new Button();
            vehl = new Button();
            word = new Button();
            InvPers = new Button();
            cancelbtn = new Button();
            newbtn = new Button();
            deletebtn = new Button();
            editbtn = new Button();
            insertbtn = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)investBindingSource).BeginInit();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button5);
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Location = new Point(32, 65);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(105, 231);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(90, 37);
            button1.TabIndex = 0;
            button1.Text = "تقارير";
            button1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Enabled = false;
            button5.Location = new Point(3, 46);
            button5.Name = "button5";
            button5.Size = new Size(90, 37);
            button5.TabIndex = 4;
            button5.Text = "ادخال";
            button5.UseVisualStyleBackColor = true;
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
            // button3
            // 
            button3.Location = new Point(3, 132);
            button3.Name = "button3";
            button3.Size = new Size(90, 37);
            button3.TabIndex = 2;
            button3.Text = "احصائيات";
            button3.UseVisualStyleBackColor = true;
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
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(checkBox2);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(dateTimePicker4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dateTimePicker3);
            panel1.Location = new Point(143, 11);
            panel1.Name = "panel1";
            panel1.Size = new Size(1009, 433);
            panel1.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 5);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 10;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(863, 20);
            checkBox2.Name = "checkBox2";
            checkBox2.RightToLeft = RightToLeft.Yes;
            checkBox2.Size = new Size(124, 19);
            checkBox2.TabIndex = 9;
            checkBox2.Text = "هل يوجد مضبوطات";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(882, 1);
            checkBox1.Name = "checkBox1";
            checkBox1.RightToLeft = RightToLeft.Yes;
            checkBox1.Size = new Size(105, 19);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "هل يوجد ملخص";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(3, 172);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "[موضوع المعاملة]";
            textBox2.RightToLeft = RightToLeft.Yes;
            textBox2.Size = new Size(232, 242);
            textBox2.TabIndex = 7;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { serialDataGridViewTextBoxColumn, dfileDataGridViewTextBoxColumn, dmahdarDataGridViewTextBoxColumn, crimeDataGridViewTextBoxColumn, madboutDataGridViewTextBoxColumn, resumeDataGridViewTextBoxColumn, remDataGridViewTextBoxColumn });
            dataGridView1.DataSource = investBindingSource;
            dataGridView1.Location = new Point(241, 42);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RightToLeft = RightToLeft.Yes;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(746, 372);
            dataGridView1.TabIndex = 6;
            // 
            // serialDataGridViewTextBoxColumn
            // 
            serialDataGridViewTextBoxColumn.DataPropertyName = "Serial";
            serialDataGridViewTextBoxColumn.HeaderText = "المتسلسل";
            serialDataGridViewTextBoxColumn.Name = "serialDataGridViewTextBoxColumn";
            serialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dfileDataGridViewTextBoxColumn
            // 
            dfileDataGridViewTextBoxColumn.DataPropertyName = "Dfile";
            dfileDataGridViewTextBoxColumn.HeaderText = "تاريخ المعاملة";
            dfileDataGridViewTextBoxColumn.Name = "dfileDataGridViewTextBoxColumn";
            dfileDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dmahdarDataGridViewTextBoxColumn
            // 
            dmahdarDataGridViewTextBoxColumn.DataPropertyName = "Dmahdar";
            dmahdarDataGridViewTextBoxColumn.HeaderText = "تاريخ الادخال";
            dmahdarDataGridViewTextBoxColumn.Name = "dmahdarDataGridViewTextBoxColumn";
            dmahdarDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // crimeDataGridViewTextBoxColumn
            // 
            crimeDataGridViewTextBoxColumn.DataPropertyName = "Crime";
            crimeDataGridViewTextBoxColumn.HeaderText = "الجرم";
            crimeDataGridViewTextBoxColumn.Name = "crimeDataGridViewTextBoxColumn";
            // 
            // madboutDataGridViewTextBoxColumn
            // 
            madboutDataGridViewTextBoxColumn.DataPropertyName = "Madbout";
            madboutDataGridViewTextBoxColumn.HeaderText = "مضبوطات";
            madboutDataGridViewTextBoxColumn.Name = "madboutDataGridViewTextBoxColumn";
            // 
            // resumeDataGridViewTextBoxColumn
            // 
            resumeDataGridViewTextBoxColumn.DataPropertyName = "Resume";
            resumeDataGridViewTextBoxColumn.HeaderText = "ملخص";
            resumeDataGridViewTextBoxColumn.Name = "resumeDataGridViewTextBoxColumn";
            // 
            // remDataGridViewTextBoxColumn
            // 
            remDataGridViewTextBoxColumn.DataPropertyName = "Rem";
            remDataGridViewTextBoxColumn.HeaderText = "الموضوع";
            remDataGridViewTextBoxColumn.Name = "remDataGridViewTextBoxColumn";
            // 
            // investBindingSource
            // 
            investBindingSource.DataSource = typeof(Invest);
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 115);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "[ادخال جرم جديد]";
            textBox1.RightToLeft = RightToLeft.Yes;
            textBox1.Size = new Size(232, 23);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(3, 143);
            comboBox1.Name = "comboBox1";
            comboBox1.RightToLeft = RightToLeft.Yes;
            comboBox1.Size = new Size(232, 23);
            comboBox1.TabIndex = 4;
            comboBox1.Tag = "";
            comboBox1.Text = "[الجرم]";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.Location = new Point(35, 86);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.RightToLeft = RightToLeft.Yes;
            dateTimePicker4.RightToLeftLayout = true;
            dateTimePicker4.Size = new Size(200, 23);
            dateTimePicker4.TabIndex = 3;
            dateTimePicker4.ValueChanged += dateTimePicker4_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(160, 68);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 2;
            label2.Text = "تاريخ المعاملة";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(167, 24);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 1;
            label1.Text = "تاريخ الادخال";
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(35, 42);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.RightToLeft = RightToLeft.Yes;
            dateTimePicker3.RightToLeftLayout = true;
            dateTimePicker3.Size = new Size(200, 23);
            dateTimePicker3.TabIndex = 0;
            dateTimePicker3.ValueChanged += dateTimePicker3_ValueChanged;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(button6);
            flowLayoutPanel2.Controls.Add(vehl);
            flowLayoutPanel2.Controls.Add(word);
            flowLayoutPanel2.Controls.Add(InvPers);
            flowLayoutPanel2.Controls.Add(cancelbtn);
            flowLayoutPanel2.Controls.Add(newbtn);
            flowLayoutPanel2.Controls.Add(deletebtn);
            flowLayoutPanel2.Controls.Add(editbtn);
            flowLayoutPanel2.Controls.Add(insertbtn);
            flowLayoutPanel2.Location = new Point(407, 461);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(745, 32);
            flowLayoutPanel2.TabIndex = 8;
            // 
            // button6
            // 
            button6.Location = new Point(3, 3);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 0;
            button6.Text = "ملخص";
            button6.UseVisualStyleBackColor = true;
            // 
            // vehl
            // 
            vehl.Location = new Point(84, 3);
            vehl.Name = "vehl";
            vehl.Size = new Size(75, 23);
            vehl.TabIndex = 1;
            vehl.Text = "سيارات";
            vehl.UseVisualStyleBackColor = true;
            vehl.Click += vehl_Click;
            // 
            // word
            // 
            word.Location = new Point(165, 3);
            word.Name = "word";
            word.Size = new Size(75, 23);
            word.TabIndex = 2;
            word.Text = "تصنيف";
            word.UseVisualStyleBackColor = true;
            word.Click += word_Click;
            // 
            // InvPers
            // 
            InvPers.Location = new Point(246, 3);
            InvPers.Name = "InvPers";
            InvPers.Size = new Size(75, 23);
            InvPers.TabIndex = 3;
            InvPers.Text = "اشخاص";
            InvPers.UseVisualStyleBackColor = true;
            InvPers.Click += InvPers_Click;
            // 
            // cancelbtn
            // 
            cancelbtn.Location = new Point(327, 3);
            cancelbtn.Name = "cancelbtn";
            cancelbtn.Size = new Size(75, 23);
            cancelbtn.TabIndex = 4;
            cancelbtn.Text = "الغاء";
            cancelbtn.UseVisualStyleBackColor = true;
            cancelbtn.Click += cancelbtn_Click;
            // 
            // newbtn
            // 
            newbtn.Location = new Point(408, 3);
            newbtn.Name = "newbtn";
            newbtn.Size = new Size(75, 23);
            newbtn.TabIndex = 5;
            newbtn.Text = "تحديث";
            newbtn.UseVisualStyleBackColor = true;
            newbtn.Click += newbtn_Click;
            // 
            // deletebtn
            // 
            deletebtn.Location = new Point(489, 3);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(75, 23);
            deletebtn.TabIndex = 6;
            deletebtn.Text = "حذف";
            deletebtn.UseVisualStyleBackColor = true;
            deletebtn.Click += deletebtn_Click;
            // 
            // editbtn
            // 
            editbtn.Location = new Point(570, 3);
            editbtn.Name = "editbtn";
            editbtn.Size = new Size(75, 23);
            editbtn.TabIndex = 7;
            editbtn.Text = "تعديل";
            editbtn.Click += editbtn_Click;
            // 
            // insertbtn
            // 
            insertbtn.Location = new Point(651, 3);
            insertbtn.Name = "insertbtn";
            insertbtn.Size = new Size(75, 23);
            insertbtn.TabIndex = 8;
            insertbtn.Text = "ادخال";
            insertbtn.UseVisualStyleBackColor = true;
            insertbtn.Click += insertbtn_Click;
            // 
            // timer1
            // 
            timer1.Interval = 5000;
            timer1.Tick += timer1_Tick;
            // 
            // EntryMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1164, 500);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Name = "EntryMenu";
            Text = "EntryMenu";
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)investBindingSource).EndInit();
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Panel sidebarPanel;
        private Label logoLabel;
        private Panel logoPanel;
        private Panel contentPanel;
        private DataGridView dataGridView;
        private ComboBox comboBox;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Button[] actionButtons;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button button6;
        private Button vehl;
        private Button word;
        private Button InvPers;
        private Button cancelbtn;
        private Button newbtn;
        private Button deletebtn;
        private Button editbtn;
        private Button insertbtn;
        private DateTimePicker dateTimePicker4;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker3;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private BindingSource investBindingSource;
        private TextBox textBox2;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private bool added;
        private Invest inv_to_add;
        private Label label3;
        private System.Windows.Forms.Timer timer1;
        private InvEntities? context;
        private DataGridViewTextBoxColumn serialDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dfileDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dmahdarDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn crimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn madboutDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn resumeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn remDataGridViewTextBoxColumn;
    }
}