using ConcurrencyProject.Repositories;
using ConcurrencyProject.Repositories.Models;
using Microsoft.EntityFrameworkCore;

namespace ConcurrencyProject
{
    partial class FormInvPers
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
            context.Invpersons.Load<Invperson>();
            invpersonBindingSource.DataSource = context.Invpersons.Local.ToBindingList().Select(e=>e).Where(e=>e.Serial==person.Serial);
            textBox1.Text = person.Serial.ToString();
            comboBox1.Items.AddRange((string[])context.Nations.Select(e => e.Alabel).Where(label => label != null).ToArray());
            comboBox2.Items.AddRange((string[])context.Villages.Select(e=>e.Label).Where(label=>label!=null).ToArray());
            comboBox3.Items.AddRange((string[])context.Villages.Select(e=>e.Label).Where(label=>label!=null).ToArray());
            comboBox4.Items.AddRange((string[])context.Attrs.Select(e=>e.Label).Where(label=>label!=null).ToArray());

        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            serialDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            serpersDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fnameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lnameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fatherDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            motherDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            regDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pbirthDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dbirthDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            residDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            adrsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            attrDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            exstDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            archDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nicknameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            occupationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idnumDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mobilenoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            genderDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            invpersonBindingSource = new BindingSource(components);
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            textBox11 = new TextBox();
            textBox12 = new TextBox();
            textBox13 = new TextBox();
            comboBox5 = new ComboBox();
            comboBox6 = new ComboBox();
            textBox14 = new TextBox();
            Insert = new Button();
            delete = new Button();
            update = new Button();
            cancel = new Button();
            label3 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)invpersonBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { serialDataGridViewTextBoxColumn, serpersDataGridViewTextBoxColumn, fnameDataGridViewTextBoxColumn, lnameDataGridViewTextBoxColumn, fatherDataGridViewTextBoxColumn, motherDataGridViewTextBoxColumn, nationDataGridViewTextBoxColumn, regDataGridViewTextBoxColumn, pbirthDataGridViewTextBoxColumn, dbirthDataGridViewTextBoxColumn, residDataGridViewTextBoxColumn, adrsDataGridViewTextBoxColumn, attrDataGridViewTextBoxColumn, exstDataGridViewTextBoxColumn, archDataGridViewTextBoxColumn, nicknameDataGridViewTextBoxColumn, occupationDataGridViewTextBoxColumn, idnumDataGridViewTextBoxColumn, mobilenoDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn, genderDataGridViewTextBoxColumn });
            dataGridView1.DataSource = invpersonBindingSource;
            dataGridView1.Location = new Point(378, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RightToLeft = RightToLeft.Yes;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(688, 351);
            dataGridView1.TabIndex = 0;
            // 
            // serialDataGridViewTextBoxColumn
            // 
            serialDataGridViewTextBoxColumn.DataPropertyName = "Serial";
            serialDataGridViewTextBoxColumn.HeaderText = "Serial";
            serialDataGridViewTextBoxColumn.Name = "serialDataGridViewTextBoxColumn";
            // 
            // serpersDataGridViewTextBoxColumn
            // 
            serpersDataGridViewTextBoxColumn.DataPropertyName = "Serpers";
            serpersDataGridViewTextBoxColumn.HeaderText = "Serpers";
            serpersDataGridViewTextBoxColumn.Name = "serpersDataGridViewTextBoxColumn";
            // 
            // fnameDataGridViewTextBoxColumn
            // 
            fnameDataGridViewTextBoxColumn.DataPropertyName = "Fname";
            fnameDataGridViewTextBoxColumn.HeaderText = "Fname";
            fnameDataGridViewTextBoxColumn.Name = "fnameDataGridViewTextBoxColumn";
            // 
            // lnameDataGridViewTextBoxColumn
            // 
            lnameDataGridViewTextBoxColumn.DataPropertyName = "Lname";
            lnameDataGridViewTextBoxColumn.HeaderText = "Lname";
            lnameDataGridViewTextBoxColumn.Name = "lnameDataGridViewTextBoxColumn";
            // 
            // fatherDataGridViewTextBoxColumn
            // 
            fatherDataGridViewTextBoxColumn.DataPropertyName = "Father";
            fatherDataGridViewTextBoxColumn.HeaderText = "Father";
            fatherDataGridViewTextBoxColumn.Name = "fatherDataGridViewTextBoxColumn";
            // 
            // motherDataGridViewTextBoxColumn
            // 
            motherDataGridViewTextBoxColumn.DataPropertyName = "Mother";
            motherDataGridViewTextBoxColumn.HeaderText = "Mother";
            motherDataGridViewTextBoxColumn.Name = "motherDataGridViewTextBoxColumn";
            // 
            // nationDataGridViewTextBoxColumn
            // 
            nationDataGridViewTextBoxColumn.DataPropertyName = "Nation";
            nationDataGridViewTextBoxColumn.HeaderText = "Nation";
            nationDataGridViewTextBoxColumn.Name = "nationDataGridViewTextBoxColumn";
            // 
            // regDataGridViewTextBoxColumn
            // 
            regDataGridViewTextBoxColumn.DataPropertyName = "Reg";
            regDataGridViewTextBoxColumn.HeaderText = "Reg";
            regDataGridViewTextBoxColumn.Name = "regDataGridViewTextBoxColumn";
            // 
            // pbirthDataGridViewTextBoxColumn
            // 
            pbirthDataGridViewTextBoxColumn.DataPropertyName = "Pbirth";
            pbirthDataGridViewTextBoxColumn.HeaderText = "Pbirth";
            pbirthDataGridViewTextBoxColumn.Name = "pbirthDataGridViewTextBoxColumn";
            // 
            // dbirthDataGridViewTextBoxColumn
            // 
            dbirthDataGridViewTextBoxColumn.DataPropertyName = "Dbirth";
            dbirthDataGridViewTextBoxColumn.HeaderText = "Dbirth";
            dbirthDataGridViewTextBoxColumn.Name = "dbirthDataGridViewTextBoxColumn";
            // 
            // residDataGridViewTextBoxColumn
            // 
            residDataGridViewTextBoxColumn.DataPropertyName = "Resid";
            residDataGridViewTextBoxColumn.HeaderText = "Resid";
            residDataGridViewTextBoxColumn.Name = "residDataGridViewTextBoxColumn";
            // 
            // adrsDataGridViewTextBoxColumn
            // 
            adrsDataGridViewTextBoxColumn.DataPropertyName = "Adrs";
            adrsDataGridViewTextBoxColumn.HeaderText = "Adrs";
            adrsDataGridViewTextBoxColumn.Name = "adrsDataGridViewTextBoxColumn";
            // 
            // attrDataGridViewTextBoxColumn
            // 
            attrDataGridViewTextBoxColumn.DataPropertyName = "Attr";
            attrDataGridViewTextBoxColumn.HeaderText = "Attr";
            attrDataGridViewTextBoxColumn.Name = "attrDataGridViewTextBoxColumn";
            // 
            // exstDataGridViewTextBoxColumn
            // 
            exstDataGridViewTextBoxColumn.DataPropertyName = "Exst";
            exstDataGridViewTextBoxColumn.HeaderText = "Exst";
            exstDataGridViewTextBoxColumn.Name = "exstDataGridViewTextBoxColumn";
            // 
            // archDataGridViewTextBoxColumn
            // 
            archDataGridViewTextBoxColumn.DataPropertyName = "Arch";
            archDataGridViewTextBoxColumn.HeaderText = "Arch";
            archDataGridViewTextBoxColumn.Name = "archDataGridViewTextBoxColumn";
            // 
            // nicknameDataGridViewTextBoxColumn
            // 
            nicknameDataGridViewTextBoxColumn.DataPropertyName = "Nickname";
            nicknameDataGridViewTextBoxColumn.HeaderText = "Nickname";
            nicknameDataGridViewTextBoxColumn.Name = "nicknameDataGridViewTextBoxColumn";
            // 
            // occupationDataGridViewTextBoxColumn
            // 
            occupationDataGridViewTextBoxColumn.DataPropertyName = "Occupation";
            occupationDataGridViewTextBoxColumn.HeaderText = "Occupation";
            occupationDataGridViewTextBoxColumn.Name = "occupationDataGridViewTextBoxColumn";
            // 
            // idnumDataGridViewTextBoxColumn
            // 
            idnumDataGridViewTextBoxColumn.DataPropertyName = "Idnum";
            idnumDataGridViewTextBoxColumn.HeaderText = "Idnum";
            idnumDataGridViewTextBoxColumn.Name = "idnumDataGridViewTextBoxColumn";
            // 
            // mobilenoDataGridViewTextBoxColumn
            // 
            mobilenoDataGridViewTextBoxColumn.DataPropertyName = "Mobileno";
            mobilenoDataGridViewTextBoxColumn.HeaderText = "Mobileno";
            mobilenoDataGridViewTextBoxColumn.Name = "mobilenoDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            statusDataGridViewTextBoxColumn.HeaderText = "Status";
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // invpersonBindingSource
            // 
            invpersonBindingSource.DataSource = typeof(Invperson);
            // 
            // textBox1
            // 
            textBox1.Location = new Point(319, 26);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.RightToLeft = RightToLeft.Yes;
            textBox1.Size = new Size(53, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(195, 29);
            label1.Name = "label1";
            label1.Size = new Size(118, 15);
            label1.TabIndex = 2;
            label1.Text = "الرقم المتسلسل للملف";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(136, 26);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.RightToLeft = RightToLeft.Yes;
            textBox2.Size = new Size(53, 23);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(2, 29);
            label2.Name = "label2";
            label2.Size = new Size(128, 15);
            label2.TabIndex = 4;
            label2.Text = "الرقم المتسلسل للشخص";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(195, 55);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "[الاسم]";
            textBox3.RightToLeft = RightToLeft.Yes;
            textBox3.Size = new Size(177, 23);
            textBox3.TabIndex = 5;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(12, 55);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "[الشهرة]";
            textBox4.RightToLeft = RightToLeft.Yes;
            textBox4.Size = new Size(177, 23);
            textBox4.TabIndex = 6;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(12, 84);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "[اسم الام]";
            textBox5.RightToLeft = RightToLeft.Yes;
            textBox5.Size = new Size(177, 23);
            textBox5.TabIndex = 8;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(195, 84);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "[اسم الاب]";
            textBox6.RightToLeft = RightToLeft.Yes;
            textBox6.Size = new Size(177, 23);
            textBox6.TabIndex = 7;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(12, 113);
            textBox7.Name = "textBox7";
            textBox7.PlaceholderText = "[رقم و مكان السجل]";
            textBox7.RightToLeft = RightToLeft.Yes;
            textBox7.Size = new Size(360, 23);
            textBox7.TabIndex = 9;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 142);
            comboBox1.Name = "comboBox1";
            comboBox1.RightToLeft = RightToLeft.Yes;
            comboBox1.Size = new Size(177, 23);
            comboBox1.TabIndex = 10;
            comboBox1.Text = "البلد";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(12, 171);
            comboBox2.Name = "comboBox2";
            comboBox2.RightToLeft = RightToLeft.Yes;
            comboBox2.Size = new Size(177, 23);
            comboBox2.TabIndex = 11;
            comboBox2.Text = "اختر";
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(12, 200);
            comboBox3.Name = "comboBox3";
            comboBox3.RightToLeft = RightToLeft.Yes;
            comboBox3.Size = new Size(177, 23);
            comboBox3.TabIndex = 12;
            comboBox3.Text = "اختر";
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(12, 229);
            comboBox4.Name = "comboBox4";
            comboBox4.RightToLeft = RightToLeft.Yes;
            comboBox4.Size = new Size(177, 23);
            comboBox4.TabIndex = 13;
            comboBox4.Text = "الجرم";
            comboBox4.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(195, 171);
            textBox8.Name = "textBox8";
            textBox8.PlaceholderText = "[محل الولادة]";
            textBox8.RightToLeft = RightToLeft.Yes;
            textBox8.Size = new Size(177, 23);
            textBox8.TabIndex = 14;
            textBox8.TextChanged += textBox8_TextChanged;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(195, 200);
            textBox9.Name = "textBox9";
            textBox9.PlaceholderText = "[محل الاقامة]";
            textBox9.RightToLeft = RightToLeft.Yes;
            textBox9.Size = new Size(177, 23);
            textBox9.TabIndex = 15;
            textBox9.TextChanged += textBox9_TextChanged;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(262, 275);
            textBox10.Name = "textBox10";
            textBox10.PlaceholderText = "[تاريخ الولادة]";
            textBox10.RightToLeft = RightToLeft.Yes;
            textBox10.Size = new Size(110, 23);
            textBox10.TabIndex = 16;
            textBox10.TextChanged += textBox10_TextChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(246, 304);
            checkBox1.Name = "checkBox1";
            checkBox1.RightToLeft = RightToLeft.Yes;
            checkBox1.Size = new Size(126, 19);
            checkBox1.TabIndex = 17;
            checkBox1.Text = "هل يوجد عنوان سكن";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(251, 327);
            checkBox2.Name = "checkBox2";
            checkBox2.RightToLeft = RightToLeft.Yes;
            checkBox2.Size = new Size(121, 19);
            checkBox2.TabIndex = 18;
            checkBox2.Text = "هل يوجد رقم داخلي";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(12, 325);
            textBox11.Name = "textBox11";
            textBox11.PlaceholderText = "[اللقب]";
            textBox11.RightToLeft = RightToLeft.Yes;
            textBox11.Size = new Size(177, 23);
            textBox11.TabIndex = 19;
            textBox11.TextChanged += textBox11_TextChanged;
            // 
            // textBox12
            // 
            textBox12.Location = new Point(12, 354);
            textBox12.Name = "textBox12";
            textBox12.PlaceholderText = "[المهنة]";
            textBox12.RightToLeft = RightToLeft.Yes;
            textBox12.Size = new Size(177, 23);
            textBox12.TabIndex = 20;
            textBox12.TextChanged += textBox12_TextChanged;
            // 
            // textBox13
            // 
            textBox13.Location = new Point(195, 354);
            textBox13.Name = "textBox13";
            textBox13.RightToLeft = RightToLeft.Yes;
            textBox13.Size = new Size(177, 23);
            textBox13.TabIndex = 21;
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "ذكر", "انثى" });
            comboBox5.Location = new Point(378, 383);
            comboBox5.Name = "comboBox5";
            comboBox5.RightToLeft = RightToLeft.Yes;
            comboBox5.Size = new Size(177, 23);
            comboBox5.TabIndex = 22;
            comboBox5.Text = "الجنس";
            comboBox5.SelectedIndexChanged += comboBox5_SelectedIndexChanged;
            // 
            // comboBox6
            // 
            comboBox6.FormattingEnabled = true;
            comboBox6.Items.AddRange(new object[] { "اعزب", "مزوج", "مطلق", "ارمل" });
            comboBox6.Location = new Point(195, 383);
            comboBox6.Name = "comboBox6";
            comboBox6.RightToLeft = RightToLeft.Yes;
            comboBox6.Size = new Size(177, 23);
            comboBox6.TabIndex = 23;
            comboBox6.Text = "الحالة الاجتماعية";
            comboBox6.SelectedIndexChanged += comboBox6_SelectedIndexChanged;
            // 
            // textBox14
            // 
            textBox14.Location = new Point(12, 383);
            textBox14.Name = "textBox14";
            textBox14.RightToLeft = RightToLeft.Yes;
            textBox14.Size = new Size(177, 23);
            textBox14.TabIndex = 24;
            // 
            // Insert
            // 
            Insert.Location = new Point(991, 430);
            Insert.Name = "Insert";
            Insert.Size = new Size(75, 23);
            Insert.TabIndex = 25;
            Insert.Text = "ادخال";
            Insert.UseVisualStyleBackColor = true;
            Insert.Click += Insert_Click;
            // 
            // delete
            // 
            delete.Location = new Point(910, 430);
            delete.Name = "delete";
            delete.Size = new Size(75, 23);
            delete.TabIndex = 26;
            delete.Text = "حذف";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // update
            // 
            update.Location = new Point(829, 430);
            update.Name = "update";
            update.Size = new Size(75, 23);
            update.TabIndex = 27;
            update.Text = "تعديل";
            update.UseVisualStyleBackColor = true;
            update.Click += update_Click;
            // 
            // cancel
            // 
            cancel.Location = new Point(748, 430);
            cancel.Name = "cancel";
            cancel.Size = new Size(75, 23);
            cancel.TabIndex = 28;
            cancel.Text = "الغاء";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += cancel_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 444);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 29;
            // 
            // timer1
            // 
            timer1.Interval = 5000;
            timer1.Tick += timer1_Tick;
            // 
            // button1
            // 
            button1.Location = new Point(12, 430);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 30;
            button1.Text = "Face";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(93, 430);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 31;
            button2.Text = "Fingerprint";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FormInvPers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1078, 468);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(cancel);
            Controls.Add(update);
            Controls.Add(delete);
            Controls.Add(Insert);
            Controls.Add(textBox14);
            Controls.Add(comboBox6);
            Controls.Add(comboBox5);
            Controls.Add(textBox13);
            Controls.Add(textBox12);
            Controls.Add(textBox11);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(textBox10);
            Controls.Add(textBox9);
            Controls.Add(textBox8);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox7);
            Controls.Add(textBox5);
            Controls.Add(textBox6);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Name = "FormInvPers";
            Text = "FormInvPers";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)invpersonBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        Invperson person;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private TextBox textBox11;
        private TextBox textBox12;
        private TextBox textBox13;
        private ComboBox comboBox5;
        private ComboBox comboBox6;
        private TextBox textBox14;
        private Button Insert;
        private Button delete;
        private Button update;
        private Button cancel;
        private DataGridViewTextBoxColumn serialDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn serpersDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fatherDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn motherDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn regDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pbirthDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dbirthDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn residDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn adrsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn attrDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn exstDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn archDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nicknameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn occupationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idnumDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mobilenoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private BindingSource invpersonBindingSource;
        private InvEntities? context;
        private Label label3;
        private System.Windows.Forms.Timer timer1;
        private Button button1;
        private Button button2;
    }
}