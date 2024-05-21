namespace BankProject
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tbcBank = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btncreate = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxDeleteCustomer = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddLoan = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtPresentValue = new System.Windows.Forms.TextBox();
            this.cbxAddLoanToCustomer = new System.Windows.Forms.ComboBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnDltLoan = new System.Windows.Forms.Button();
            this.cbxDltCsLoans = new System.Windows.Forms.ComboBox();
            this.cbxDltLoanFromCs = new System.Windows.Forms.ComboBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.crtLoan = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNewAddress = new System.Windows.Forms.TextBox();
            this.cbxUpdateCustomer = new System.Windows.Forms.ComboBox();
            this.dgvUpdateCustomer = new System.Windows.Forms.DataGridView();
            this.tbcBank.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crtLoan)).BeginInit();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpdateCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcBank
            // 
            this.tbcBank.Controls.Add(this.tabPage1);
            this.tbcBank.Controls.Add(this.tabPage2);
            this.tbcBank.Controls.Add(this.tabPage3);
            this.tbcBank.Controls.Add(this.tabPage4);
            this.tbcBank.Controls.Add(this.tabPage5);
            this.tbcBank.Controls.Add(this.tabPage6);
            this.tbcBank.Controls.Add(this.tabPage7);
            this.tbcBank.Location = new System.Drawing.Point(24, 41);
            this.tbcBank.Name = "tbcBank";
            this.tbcBank.SelectedIndex = 0;
            this.tbcBank.Size = new System.Drawing.Size(751, 310);
            this.tbcBank.TabIndex = 0;
            this.tbcBank.SelectedIndexChanged += new System.EventHandler(this.tbcBank_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btncreate);
            this.tabPage1.Controls.Add(this.txtAddress);
            this.tabPage1.Controls.Add(this.txtName);
            this.tabPage1.Controls.Add(this.txtID);
            this.tabPage1.Controls.Add(this.txtCustomerID);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(743, 284);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Customer";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Customer ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name Surname";
            // 
            // btncreate
            // 
            this.btncreate.Location = new System.Drawing.Point(412, 124);
            this.btncreate.Name = "btncreate";
            this.btncreate.Size = new System.Drawing.Size(75, 23);
            this.btncreate.TabIndex = 4;
            this.btncreate.Text = "Confirm";
            this.btncreate.UseVisualStyleBackColor = true;
            this.btncreate.Click += new System.EventHandler(this.btncreate_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(174, 176);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 20);
            this.txtAddress.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(174, 26);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 0;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(174, 124);
            this.txtID.MaxLength = 11;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 2;
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Enabled = false;
            this.txtCustomerID.Location = new System.Drawing.Point(174, 74);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerID.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.cbxDeleteCustomer);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(743, 284);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Delete Customer";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(403, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Delete Customer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Customer ID";
            // 
            // cbxDeleteCustomer
            // 
            this.cbxDeleteCustomer.FormattingEnabled = true;
            this.cbxDeleteCustomer.Location = new System.Drawing.Point(171, 55);
            this.cbxDeleteCustomer.Name = "cbxDeleteCustomer";
            this.cbxDeleteCustomer.Size = new System.Drawing.Size(121, 21);
            this.cbxDeleteCustomer.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.comboBox1);
            this.tabPage3.Controls.Add(this.dgvCustomers);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(743, 284);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "List Loans Of Customer";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(256, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Customer ID";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(358, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(70, 78);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.Size = new System.Drawing.Size(603, 187);
            this.dgvCustomers.TabIndex = 0;
            this.dgvCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomers_CellContentClick);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.btnAddLoan);
            this.tabPage4.Controls.Add(this.radioButton2);
            this.tabPage4.Controls.Add(this.radioButton1);
            this.tabPage4.Controls.Add(this.txtInterestRate);
            this.tabPage4.Controls.Add(this.txtTime);
            this.tabPage4.Controls.Add(this.txtPresentValue);
            this.tabPage4.Controls.Add(this.cbxAddLoanToCustomer);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(743, 284);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Add Loan to Customer";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(397, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Interest %";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(397, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(394, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Present Value";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Customer ID";
            // 
            // btnAddLoan
            // 
            this.btnAddLoan.Location = new System.Drawing.Point(159, 214);
            this.btnAddLoan.Name = "btnAddLoan";
            this.btnAddLoan.Size = new System.Drawing.Size(75, 23);
            this.btnAddLoan.TabIndex = 6;
            this.btnAddLoan.Text = "Add Loan";
            this.btnAddLoan.UseVisualStyleBackColor = true;
            this.btnAddLoan.Click += new System.EventHandler(this.btnAddLoan_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(397, 220);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(94, 17);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Simple Interest";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(397, 181);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(114, 17);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Compound Interest";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.Location = new System.Drawing.Point(516, 130);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(100, 20);
            this.txtInterestRate.TabIndex = 3;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(516, 88);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(100, 20);
            this.txtTime.TabIndex = 2;
            // 
            // txtPresentValue
            // 
            this.txtPresentValue.Location = new System.Drawing.Point(516, 37);
            this.txtPresentValue.Name = "txtPresentValue";
            this.txtPresentValue.Size = new System.Drawing.Size(100, 20);
            this.txtPresentValue.TabIndex = 1;
            // 
            // cbxAddLoanToCustomer
            // 
            this.cbxAddLoanToCustomer.FormattingEnabled = true;
            this.cbxAddLoanToCustomer.Location = new System.Drawing.Point(159, 36);
            this.cbxAddLoanToCustomer.Name = "cbxAddLoanToCustomer";
            this.cbxAddLoanToCustomer.Size = new System.Drawing.Size(121, 21);
            this.cbxAddLoanToCustomer.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label11);
            this.tabPage5.Controls.Add(this.label10);
            this.tabPage5.Controls.Add(this.btnDltLoan);
            this.tabPage5.Controls.Add(this.cbxDltCsLoans);
            this.tabPage5.Controls.Add(this.cbxDltLoanFromCs);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(743, 284);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Delete Loan From Customer";
            this.tabPage5.UseVisualStyleBackColor = true;
            this.tabPage5.Click += new System.EventHandler(this.tabPage5_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(69, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Customer Loans";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(69, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Customer ID";
            // 
            // btnDltLoan
            // 
            this.btnDltLoan.Location = new System.Drawing.Point(234, 208);
            this.btnDltLoan.Name = "btnDltLoan";
            this.btnDltLoan.Size = new System.Drawing.Size(75, 23);
            this.btnDltLoan.TabIndex = 2;
            this.btnDltLoan.Text = "Delete Loan ";
            this.btnDltLoan.UseVisualStyleBackColor = true;
            this.btnDltLoan.Click += new System.EventHandler(this.btnDltLoan_Click);
            // 
            // cbxDltCsLoans
            // 
            this.cbxDltCsLoans.FormattingEnabled = true;
            this.cbxDltCsLoans.Location = new System.Drawing.Point(234, 116);
            this.cbxDltCsLoans.Name = "cbxDltCsLoans";
            this.cbxDltCsLoans.Size = new System.Drawing.Size(121, 21);
            this.cbxDltCsLoans.TabIndex = 1;
            // 
            // cbxDltLoanFromCs
            // 
            this.cbxDltLoanFromCs.FormattingEnabled = true;
            this.cbxDltLoanFromCs.Location = new System.Drawing.Point(234, 38);
            this.cbxDltLoanFromCs.Name = "cbxDltLoanFromCs";
            this.cbxDltLoanFromCs.Size = new System.Drawing.Size(121, 21);
            this.cbxDltLoanFromCs.TabIndex = 0;
            this.cbxDltLoanFromCs.SelectedIndexChanged += new System.EventHandler(this.cbxDltLoanFromCs_SelectedIndexChanged);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.crtLoan);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(743, 284);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Chart Of Loans";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // crtLoan
            // 
            chartArea2.Name = "ChartArea1";
            this.crtLoan.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.crtLoan.Legends.Add(legend2);
            this.crtLoan.Location = new System.Drawing.Point(120, 17);
            this.crtLoan.Name = "crtLoan";
            this.crtLoan.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Legend = "Legend1";
            series2.Name = "Loan";
            series2.XValueMember = "CustomerId";
            series2.YValueMembers = "Accumulated_Value";
            series2.YValuesPerPoint = 2;
            this.crtLoan.Series.Add(series2);
            this.crtLoan.Size = new System.Drawing.Size(526, 261);
            this.crtLoan.TabIndex = 0;
            this.crtLoan.Text = "crtLoan";
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.dgvUpdateCustomer);
            this.tabPage7.Controls.Add(this.btnUpdate);
            this.tabPage7.Controls.Add(this.label13);
            this.tabPage7.Controls.Add(this.label12);
            this.tabPage7.Controls.Add(this.txtNewAddress);
            this.tabPage7.Controls.Add(this.cbxUpdateCustomer);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(743, 284);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Update Customer";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(552, 100);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(409, 45);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "New Address";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(32, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Customer ID";
            // 
            // txtNewAddress
            // 
            this.txtNewAddress.Location = new System.Drawing.Point(495, 37);
            this.txtNewAddress.Multiline = true;
            this.txtNewAddress.Name = "txtNewAddress";
            this.txtNewAddress.Size = new System.Drawing.Size(132, 27);
            this.txtNewAddress.TabIndex = 1;
            // 
            // cbxUpdateCustomer
            // 
            this.cbxUpdateCustomer.FormattingEnabled = true;
            this.cbxUpdateCustomer.Location = new System.Drawing.Point(173, 37);
            this.cbxUpdateCustomer.Name = "cbxUpdateCustomer";
            this.cbxUpdateCustomer.Size = new System.Drawing.Size(121, 21);
            this.cbxUpdateCustomer.TabIndex = 0;
            this.cbxUpdateCustomer.SelectedIndexChanged += new System.EventHandler(this.cbxUpdateCustomer_SelectedIndexChanged);
            // 
            // dgvUpdateCustomer
            // 
            this.dgvUpdateCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUpdateCustomer.Location = new System.Drawing.Point(6, 100);
            this.dgvUpdateCustomer.Name = "dgvUpdateCustomer";
            this.dgvUpdateCustomer.Size = new System.Drawing.Size(473, 154);
            this.dgvUpdateCustomer.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbcBank);
            this.Name = "Form1";
            this.Text = "Bank Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tbcBank.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.crtLoan)).EndInit();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpdateCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcBank;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncreate;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxDeleteCustomer;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddLoan;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtPresentValue;
        private System.Windows.Forms.ComboBox cbxAddLoanToCustomer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnDltLoan;
        private System.Windows.Forms.ComboBox cbxDltCsLoans;
        private System.Windows.Forms.ComboBox cbxDltLoanFromCs;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNewAddress;
        private System.Windows.Forms.ComboBox cbxUpdateCustomer;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart crtLoan;
        private System.Windows.Forms.DataGridView dgvUpdateCustomer;
    }
}

