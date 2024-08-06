using ConcurrencyProject.Repositories;
using ConcurrencyProject.Repositories.Models;
using Microsoft.EntityFrameworkCore;

namespace ConcurrencyProject
{
    partial class FormVehicles
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
            FormVehicles_Load();

        }

        protected void FormVehicles_Load()
        {
            context = new InvEntities();
            context.Database.EnsureCreated();
            context.Vehicles.Load<Vehicle>();
            vehicleBindingSource.DataSource = context.Vehicles.Local.ToBindingList().Select(e => e).Where(e => e.SerialNb == vehicle.SerialNb);
            if (context.Vehicles.Local.ToBindingList().Count!=0)
            { Controls["textBox18"].Text = context.Vehicles.Local.ToBindingList().Count.ToString(); }
            else
            { Controls["textBox18"].Text = "No vehicles for the current invest"; }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Label label1;
            TextBox textBox1;
            TextBox textBox2;
            Label label2;
            TextBox textBox3;
            Label label3;
            Label label4;
            TextBox textBox5;
            Label label5;
            TextBox textBox6;
            Label label6;
            Label label7;
            TextBox textBox8;
            Label label8;
            TextBox textBox9;
            Label label9;
            TextBox textBox10;
            Label label10;
            Label label11;
            TextBox textBox7;
            Label label12;
            TextBox textBox4;
            Label label13;
            Label label14;
            TextBox textBox11;
            Label label15;
            TextBox textBox12;
            Label label16;
            TextBox textBox13;
            Label label17;
            Label label18;
            TextBox textBox14;
            Label label19;
            TextBox textBox15;
            Label label20;
            Label label21;
            TextBox textBox16;
            Label label22;
            TextBox textBox17;
            Label label23;
            TextBox textBox18;
            Label label24;
            TextBox textBox19;
            TextBox textBox20;
            TextBox textBox21;
            dataGridView1 = new DataGridView();
            vidDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            serialNbDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            actualNbDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            codeDescDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            proddateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            chassisDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            motorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateaquisitionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            preMiseCircDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            colorDescDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            brandDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            modelDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            utilisDescDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastnameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            noRegPropDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cityIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            districtIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            governateIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            motherNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telPropDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            agePropDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            birthPlaceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            horsserviceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vehicleBindingSource = new BindingSource(components);
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            checkBox2 = new CheckBox();
            insertbtn = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnReset = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            textBox6 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            textBox8 = new TextBox();
            label8 = new Label();
            textBox9 = new TextBox();
            label9 = new Label();
            textBox10 = new TextBox();
            label10 = new Label();
            label11 = new Label();
            textBox7 = new TextBox();
            label12 = new Label();
            textBox4 = new TextBox();
            label13 = new Label();
            label14 = new Label();
            textBox11 = new TextBox();
            label15 = new Label();
            textBox12 = new TextBox();
            label16 = new Label();
            textBox13 = new TextBox();
            label17 = new Label();
            label18 = new Label();
            textBox14 = new TextBox();
            label19 = new Label();
            textBox15 = new TextBox();
            label20 = new Label();
            label21 = new Label();
            textBox16 = new TextBox();
            label22 = new Label();
            textBox17 = new TextBox();
            label23 = new Label();
            textBox18 = new TextBox();
            label24 = new Label();
            textBox19 = new TextBox();
            textBox20 = new TextBox();
            textBox21 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vehicleBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(322, 15);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "المتسلسل";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(216, 12);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.RightToLeft = RightToLeft.Yes;
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(216, 41);
            textBox2.Name = "textBox2";
            textBox2.RightToLeft = RightToLeft.Yes;
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(322, 44);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(61, 15);
            label2.TabIndex = 3;
            label2.Text = "رقم السيارة";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(216, 270);
            textBox3.Name = "textBox3";
            textBox3.RightToLeft = RightToLeft.Yes;
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 6;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(322, 273);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(83, 15);
            label3.TabIndex = 5;
            label3.Text = "رقم قيد النفوس";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(322, 244);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(94, 15);
            label4.TabIndex = 7;
            label4.Text = "الوضع في الخدمة";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(216, 212);
            textBox5.Name = "textBox5";
            textBox5.RightToLeft = RightToLeft.Yes;
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 10;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(322, 215);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.Yes;
            label5.Size = new Size(42, 15);
            label5.TabIndex = 9;
            label5.Text = "العنوان";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(216, 186);
            textBox6.Name = "textBox6";
            textBox6.RightToLeft = RightToLeft.Yes;
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 12;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(322, 189);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.Yes;
            label6.Size = new Size(64, 15);
            label6.TabIndex = 11;
            label6.Text = "محل الولادة";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(322, 160);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.Yes;
            label7.Size = new Size(33, 15);
            label7.TabIndex = 13;
            label7.Text = "العمر";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(216, 128);
            textBox8.Name = "textBox8";
            textBox8.RightToLeft = RightToLeft.Yes;
            textBox8.Size = new Size(100, 23);
            textBox8.TabIndex = 16;
            textBox8.TextChanged += textBox8_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(322, 131);
            label8.Name = "label8";
            label8.RightToLeft = RightToLeft.Yes;
            label8.Size = new Size(38, 15);
            label8.TabIndex = 15;
            label8.Text = "العائلة";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(216, 99);
            textBox9.Name = "textBox9";
            textBox9.RightToLeft = RightToLeft.Yes;
            textBox9.Size = new Size(100, 23);
            textBox9.TabIndex = 18;
            textBox9.TextChanged += textBox9_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(322, 102);
            label9.Name = "label9";
            label9.RightToLeft = RightToLeft.Yes;
            label9.Size = new Size(47, 15);
            label9.TabIndex = 17;
            label9.Text = "اسم الام";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(216, 70);
            textBox10.Name = "textBox10";
            textBox10.RightToLeft = RightToLeft.Yes;
            textBox10.Size = new Size(100, 23);
            textBox10.TabIndex = 20;
            textBox10.TextChanged += textBox10_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(322, 73);
            label10.Name = "label10";
            label10.RightToLeft = RightToLeft.Yes;
            label10.Size = new Size(34, 15);
            label10.TabIndex = 19;
            label10.Text = "الاسم";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(322, 302);
            label11.Name = "label11";
            label11.RightToLeft = RightToLeft.Yes;
            label11.Size = new Size(93, 15);
            label11.TabIndex = 23;
            label11.Text = "موضوع في السير";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(216, 328);
            textBox7.Name = "textBox7";
            textBox7.RightToLeft = RightToLeft.Yes;
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 26;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(322, 331);
            label12.Name = "label12";
            label12.RightToLeft = RightToLeft.Yes;
            label12.Size = new Size(39, 15);
            label12.TabIndex = 25;
            label12.Text = "الاقامة";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(12, 328);
            textBox4.Name = "textBox4";
            textBox4.RightToLeft = RightToLeft.Yes;
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 51;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(118, 331);
            label13.Name = "label13";
            label13.RightToLeft = RightToLeft.Yes;
            label13.Size = new Size(41, 15);
            label13.TabIndex = 50;
            label13.Text = "المدينة";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(118, 302);
            label14.Name = "label14";
            label14.RightToLeft = RightToLeft.Yes;
            label14.Size = new Size(62, 15);
            label14.TabIndex = 49;
            label14.Text = "تاريخ الشراء";
            // 
            // textBox11
            // 
            textBox11.Location = new Point(12, 70);
            textBox11.Name = "textBox11";
            textBox11.RightToLeft = RightToLeft.Yes;
            textBox11.Size = new Size(100, 23);
            textBox11.TabIndex = 46;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(118, 73);
            label15.Name = "label15";
            label15.RightToLeft = RightToLeft.Yes;
            label15.Size = new Size(59, 15);
            label15.TabIndex = 45;
            label15.Text = "رقم الهاتف";
            // 
            // textBox12
            // 
            textBox12.Location = new Point(12, 99);
            textBox12.Name = "textBox12";
            textBox12.RightToLeft = RightToLeft.Yes;
            textBox12.Size = new Size(100, 23);
            textBox12.TabIndex = 44;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(118, 102);
            label16.Name = "label16";
            label16.RightToLeft = RightToLeft.Yes;
            label16.Size = new Size(64, 15);
            label16.TabIndex = 43;
            label16.Text = "تاريخ الصنع";
            // 
            // textBox13
            // 
            textBox13.Location = new Point(12, 128);
            textBox13.Name = "textBox13";
            textBox13.RightToLeft = RightToLeft.Yes;
            textBox13.Size = new Size(100, 23);
            textBox13.TabIndex = 42;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(118, 131);
            label17.Name = "label17";
            label17.RightToLeft = RightToLeft.Yes;
            label17.Size = new Size(58, 15);
            label17.TabIndex = 41;
            label17.Text = "رقم الهيكل";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(118, 160);
            label18.Name = "label18";
            label18.RightToLeft = RightToLeft.Yes;
            label18.Size = new Size(62, 15);
            label18.TabIndex = 40;
            label18.Text = "رقم المحرك";
            // 
            // textBox14
            // 
            textBox14.Location = new Point(12, 186);
            textBox14.Name = "textBox14";
            textBox14.RightToLeft = RightToLeft.Yes;
            textBox14.Size = new Size(100, 23);
            textBox14.TabIndex = 39;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(118, 189);
            label19.Name = "label19";
            label19.RightToLeft = RightToLeft.Yes;
            label19.Size = new Size(32, 15);
            label19.TabIndex = 38;
            label19.Text = "اللون";
            // 
            // textBox15
            // 
            textBox15.Location = new Point(12, 212);
            textBox15.Name = "textBox15";
            textBox15.RightToLeft = RightToLeft.Yes;
            textBox15.Size = new Size(100, 23);
            textBox15.TabIndex = 37;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(118, 215);
            label20.Name = "label20";
            label20.RightToLeft = RightToLeft.Yes;
            label20.Size = new Size(36, 15);
            label20.TabIndex = 36;
            label20.Text = "الطراز";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(118, 244);
            label21.Name = "label21";
            label21.RightToLeft = RightToLeft.Yes;
            label21.Size = new Size(34, 15);
            label21.TabIndex = 35;
            label21.Text = "االنوع";
            // 
            // textBox16
            // 
            textBox16.Location = new Point(12, 270);
            textBox16.Name = "textBox16";
            textBox16.RightToLeft = RightToLeft.Yes;
            textBox16.Size = new Size(100, 23);
            textBox16.TabIndex = 34;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(118, 273);
            label22.Name = "label22";
            label22.RightToLeft = RightToLeft.Yes;
            label22.Size = new Size(62, 15);
            label22.TabIndex = 33;
            label22.Text = "المواصفات";
            // 
            // textBox17
            // 
            textBox17.Location = new Point(12, 41);
            textBox17.Name = "textBox17";
            textBox17.RightToLeft = RightToLeft.Yes;
            textBox17.Size = new Size(100, 23);
            textBox17.TabIndex = 32;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(118, 44);
            label23.Name = "label23";
            label23.RightToLeft = RightToLeft.Yes;
            label23.Size = new Size(30, 15);
            label23.TabIndex = 31;
            label23.Text = "الرمز";
            // 
            // textBox18
            // 
            textBox18.Location = new Point(12, 12);
            textBox18.Name = "textBox18";
            textBox18.RightToLeft = RightToLeft.Yes;
            textBox18.Size = new Size(100, 23);
            textBox18.TabIndex = 30;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(118, 15);
            label24.Name = "label24";
            label24.RightToLeft = RightToLeft.Yes;
            label24.Size = new Size(58, 15);
            label24.TabIndex = 29;
            label24.Text = "Vehicle ID";
            // 
            // textBox19
            // 
            textBox19.Location = new Point(12, 158);
            textBox19.Name = "textBox19";
            textBox19.RightToLeft = RightToLeft.Yes;
            textBox19.Size = new Size(100, 23);
            textBox19.TabIndex = 53;
            // 
            // textBox20
            // 
            textBox20.Location = new Point(12, 240);
            textBox20.Name = "textBox20";
            textBox20.RightToLeft = RightToLeft.Yes;
            textBox20.Size = new Size(100, 23);
            textBox20.TabIndex = 54;
            // 
            // textBox21
            // 
            textBox21.Location = new Point(12, 298);
            textBox21.Name = "textBox21";
            textBox21.RightToLeft = RightToLeft.Yes;
            textBox21.Size = new Size(100, 23);
            textBox21.TabIndex = 55;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { vidDataGridViewTextBoxColumn, serialNbDataGridViewTextBoxColumn, actualNbDataGridViewTextBoxColumn, codeDescDataGridViewTextBoxColumn, proddateDataGridViewTextBoxColumn, chassisDataGridViewTextBoxColumn, motorDataGridViewTextBoxColumn, dateaquisitionDataGridViewTextBoxColumn, preMiseCircDataGridViewTextBoxColumn, colorDescDataGridViewTextBoxColumn, brandDataGridViewTextBoxColumn, modelDataGridViewTextBoxColumn, utilisDescDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, lastnameDataGridViewTextBoxColumn, noRegPropDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn, cityIdDataGridViewTextBoxColumn, districtIdDataGridViewTextBoxColumn, governateIdDataGridViewTextBoxColumn, motherNameDataGridViewTextBoxColumn, telPropDataGridViewTextBoxColumn, agePropDataGridViewTextBoxColumn, birthPlaceDataGridViewTextBoxColumn, horsserviceDataGridViewTextBoxColumn });
            dataGridView1.DataSource = vehicleBindingSource;
            dataGridView1.Location = new Point(419, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RightToLeft = RightToLeft.Yes;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(508, 339);
            dataGridView1.TabIndex = 1;
            // 
            // vidDataGridViewTextBoxColumn
            // 
            vidDataGridViewTextBoxColumn.DataPropertyName = "Vid";
            vidDataGridViewTextBoxColumn.HeaderText = "Vid";
            vidDataGridViewTextBoxColumn.Name = "vidDataGridViewTextBoxColumn";
            // 
            // serialNbDataGridViewTextBoxColumn
            // 
            serialNbDataGridViewTextBoxColumn.DataPropertyName = "SerialNb";
            serialNbDataGridViewTextBoxColumn.HeaderText = "SerialNb";
            serialNbDataGridViewTextBoxColumn.Name = "serialNbDataGridViewTextBoxColumn";
            // 
            // actualNbDataGridViewTextBoxColumn
            // 
            actualNbDataGridViewTextBoxColumn.DataPropertyName = "ActualNb";
            actualNbDataGridViewTextBoxColumn.HeaderText = "ActualNb";
            actualNbDataGridViewTextBoxColumn.Name = "actualNbDataGridViewTextBoxColumn";
            // 
            // codeDescDataGridViewTextBoxColumn
            // 
            codeDescDataGridViewTextBoxColumn.DataPropertyName = "CodeDesc";
            codeDescDataGridViewTextBoxColumn.HeaderText = "CodeDesc";
            codeDescDataGridViewTextBoxColumn.Name = "codeDescDataGridViewTextBoxColumn";
            // 
            // proddateDataGridViewTextBoxColumn
            // 
            proddateDataGridViewTextBoxColumn.DataPropertyName = "Proddate";
            proddateDataGridViewTextBoxColumn.HeaderText = "Proddate";
            proddateDataGridViewTextBoxColumn.Name = "proddateDataGridViewTextBoxColumn";
            // 
            // chassisDataGridViewTextBoxColumn
            // 
            chassisDataGridViewTextBoxColumn.DataPropertyName = "Chassis";
            chassisDataGridViewTextBoxColumn.HeaderText = "Chassis";
            chassisDataGridViewTextBoxColumn.Name = "chassisDataGridViewTextBoxColumn";
            // 
            // motorDataGridViewTextBoxColumn
            // 
            motorDataGridViewTextBoxColumn.DataPropertyName = "Motor";
            motorDataGridViewTextBoxColumn.HeaderText = "Motor";
            motorDataGridViewTextBoxColumn.Name = "motorDataGridViewTextBoxColumn";
            // 
            // dateaquisitionDataGridViewTextBoxColumn
            // 
            dateaquisitionDataGridViewTextBoxColumn.DataPropertyName = "Dateaquisition";
            dateaquisitionDataGridViewTextBoxColumn.HeaderText = "Dateaquisition";
            dateaquisitionDataGridViewTextBoxColumn.Name = "dateaquisitionDataGridViewTextBoxColumn";
            // 
            // preMiseCircDataGridViewTextBoxColumn
            // 
            preMiseCircDataGridViewTextBoxColumn.DataPropertyName = "PreMiseCirc";
            preMiseCircDataGridViewTextBoxColumn.HeaderText = "PreMiseCirc";
            preMiseCircDataGridViewTextBoxColumn.Name = "preMiseCircDataGridViewTextBoxColumn";
            // 
            // colorDescDataGridViewTextBoxColumn
            // 
            colorDescDataGridViewTextBoxColumn.DataPropertyName = "ColorDesc";
            colorDescDataGridViewTextBoxColumn.HeaderText = "ColorDesc";
            colorDescDataGridViewTextBoxColumn.Name = "colorDescDataGridViewTextBoxColumn";
            // 
            // brandDataGridViewTextBoxColumn
            // 
            brandDataGridViewTextBoxColumn.DataPropertyName = "Brand";
            brandDataGridViewTextBoxColumn.HeaderText = "Brand";
            brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            // 
            // modelDataGridViewTextBoxColumn
            // 
            modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            modelDataGridViewTextBoxColumn.HeaderText = "Model";
            modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            // 
            // utilisDescDataGridViewTextBoxColumn
            // 
            utilisDescDataGridViewTextBoxColumn.DataPropertyName = "UtilisDesc";
            utilisDescDataGridViewTextBoxColumn.HeaderText = "UtilisDesc";
            utilisDescDataGridViewTextBoxColumn.Name = "utilisDescDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            lastnameDataGridViewTextBoxColumn.DataPropertyName = "Lastname";
            lastnameDataGridViewTextBoxColumn.HeaderText = "Lastname";
            lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            // 
            // noRegPropDataGridViewTextBoxColumn
            // 
            noRegPropDataGridViewTextBoxColumn.DataPropertyName = "NoRegProp";
            noRegPropDataGridViewTextBoxColumn.HeaderText = "NoRegProp";
            noRegPropDataGridViewTextBoxColumn.Name = "noRegPropDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            addressDataGridViewTextBoxColumn.HeaderText = "Address";
            addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // cityIdDataGridViewTextBoxColumn
            // 
            cityIdDataGridViewTextBoxColumn.DataPropertyName = "CityId";
            cityIdDataGridViewTextBoxColumn.HeaderText = "CityId";
            cityIdDataGridViewTextBoxColumn.Name = "cityIdDataGridViewTextBoxColumn";
            // 
            // districtIdDataGridViewTextBoxColumn
            // 
            districtIdDataGridViewTextBoxColumn.DataPropertyName = "DistrictId";
            districtIdDataGridViewTextBoxColumn.HeaderText = "DistrictId";
            districtIdDataGridViewTextBoxColumn.Name = "districtIdDataGridViewTextBoxColumn";
            // 
            // governateIdDataGridViewTextBoxColumn
            // 
            governateIdDataGridViewTextBoxColumn.DataPropertyName = "GovernateId";
            governateIdDataGridViewTextBoxColumn.HeaderText = "GovernateId";
            governateIdDataGridViewTextBoxColumn.Name = "governateIdDataGridViewTextBoxColumn";
            // 
            // motherNameDataGridViewTextBoxColumn
            // 
            motherNameDataGridViewTextBoxColumn.DataPropertyName = "MotherName";
            motherNameDataGridViewTextBoxColumn.HeaderText = "MotherName";
            motherNameDataGridViewTextBoxColumn.Name = "motherNameDataGridViewTextBoxColumn";
            // 
            // telPropDataGridViewTextBoxColumn
            // 
            telPropDataGridViewTextBoxColumn.DataPropertyName = "TelProp";
            telPropDataGridViewTextBoxColumn.HeaderText = "TelProp";
            telPropDataGridViewTextBoxColumn.Name = "telPropDataGridViewTextBoxColumn";
            // 
            // agePropDataGridViewTextBoxColumn
            // 
            agePropDataGridViewTextBoxColumn.DataPropertyName = "AgeProp";
            agePropDataGridViewTextBoxColumn.HeaderText = "AgeProp";
            agePropDataGridViewTextBoxColumn.Name = "agePropDataGridViewTextBoxColumn";
            // 
            // birthPlaceDataGridViewTextBoxColumn
            // 
            birthPlaceDataGridViewTextBoxColumn.DataPropertyName = "BirthPlace";
            birthPlaceDataGridViewTextBoxColumn.HeaderText = "BirthPlace";
            birthPlaceDataGridViewTextBoxColumn.Name = "birthPlaceDataGridViewTextBoxColumn";
            // 
            // horsserviceDataGridViewTextBoxColumn
            // 
            horsserviceDataGridViewTextBoxColumn.DataPropertyName = "Horsservice";
            horsserviceDataGridViewTextBoxColumn.HeaderText = "Horsservice";
            horsserviceDataGridViewTextBoxColumn.Name = "horsserviceDataGridViewTextBoxColumn";
            // 
            // vehicleBindingSource
            // 
            vehicleBindingSource.DataSource = typeof(Vehicle);
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(216, 158);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(100, 23);
            numericUpDown1.TabIndex = 21;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(216, 241);
            numericUpDown2.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            numericUpDown2.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(100, 23);
            numericUpDown2.TabIndex = 22;
            numericUpDown2.Value = new decimal(new int[] { 1900, 0, 0, 0 });
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(216, 302);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(91, 19);
            checkBox2.TabIndex = 28;
            checkBox2.Text = "Out of order";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // insertbtn
            // 
            insertbtn.Location = new Point(852, 391);
            insertbtn.Name = "insertbtn";
            insertbtn.Size = new Size(75, 23);
            insertbtn.TabIndex = 56;
            insertbtn.Text = "ادخال";
            insertbtn.UseVisualStyleBackColor = true;
            insertbtn.Click += insertbtn_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(771, 391);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 57;
            btnUpdate.Text = "تعديل";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(690, 391);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 58;
            btnDelete.Text = "حذف";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(609, 391);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 59;
            btnReset.Text = "الغاء";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // FormVehicles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(939, 450);
            Controls.Add(btnReset);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(insertbtn);
            Controls.Add(textBox21);
            Controls.Add(textBox20);
            Controls.Add(textBox19);
            Controls.Add(textBox4);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(textBox11);
            Controls.Add(label15);
            Controls.Add(textBox12);
            Controls.Add(label16);
            Controls.Add(textBox13);
            Controls.Add(label17);
            Controls.Add(label18);
            Controls.Add(textBox14);
            Controls.Add(label19);
            Controls.Add(textBox15);
            Controls.Add(label20);
            Controls.Add(label21);
            Controls.Add(textBox16);
            Controls.Add(label22);
            Controls.Add(textBox17);
            Controls.Add(label23);
            Controls.Add(textBox18);
            Controls.Add(label24);
            Controls.Add(checkBox2);
            Controls.Add(textBox7);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(textBox10);
            Controls.Add(label10);
            Controls.Add(textBox9);
            Controls.Add(label9);
            Controls.Add(textBox8);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textBox6);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "FormVehicles";
            RightToLeft = RightToLeft.No;
            Text = "FormVehicles";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)vehicleBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Vehicle vehicle;
        private Label label1;
        private DataGridView dataGridView1;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private CheckBox checkBox2;
        private Button insertbtn;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnReset;
        private DataGridViewTextBoxColumn vidDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn serialNbDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn actualNbDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn codeDescDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn proddateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn chassisDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn motorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateaquisitionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn preMiseCircDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn colorDescDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn utilisDescDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn noRegPropDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cityIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn districtIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn governateIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn motherNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telPropDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn agePropDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn birthPlaceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn horsserviceDataGridViewTextBoxColumn;
        private BindingSource vehicleBindingSource;
        private InvEntities? context;
    }
}