namespace WindowsFormsApplication2
{
    partial class frmEnquirerInformation
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEnquirerInformation));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxEnqVehicleModel = new System.Windows.Forms.ComboBox();
            this.txtEnqDateOfEnquiry = new System.Windows.Forms.DateTimePicker();
            this.txtEnqContactNo = new System.Windows.Forms.TextBox();
            this.txtEnqEmailAddress = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitApplicationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.txtEnqEnquireID = new System.Windows.Forms.TextBox();
            this.txtEnqCustName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEnqCompany = new System.Windows.Forms.TextBox();
            this.txtEnqAddress = new System.Windows.Forms.RichTextBox();
            this.pictureBox122ss = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.chkboxEnqTestDrive = new System.Windows.Forms.CheckBox();
            this.chkboxEnqHotProspect = new System.Windows.Forms.CheckBox();
            this.chkboxEnqOrderTaken = new System.Windows.Forms.CheckBox();
            this.chkboxEnqNewLead = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.chkboxEnqQuotationSubmitted = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEnqFind = new System.Windows.Forms.Button();
            this.btnEnqUpdate = new System.Windows.Forms.Button();
            this.btnEnqDelete = new System.Windows.Forms.Button();
            this.btnEnqSave = new System.Windows.Forms.Button();
            this.btnGenerateEnquirerID = new System.Windows.Forms.Button();
            this.txtEnqSalesPersonID1 = new System.Windows.Forms.ComboBox();
            this.salespersonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new WindowsFormsApplication2.DataSet2();
            this.sales_personTableAdapter = new WindowsFormsApplication2.DataSet2TableAdapters.sales_personTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox122ss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salespersonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sales Enquirer Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 176);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enquirer ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 265);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Customer Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 539);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Interested Vehicle Model:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 495);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Date of Enquiry:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 346);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Address:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 409);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Contact No:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 452);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "Email Address:";
            // 
            // comboBoxEnqVehicleModel
            // 
            this.comboBoxEnqVehicleModel.FormattingEnabled = true;
            this.comboBoxEnqVehicleModel.Items.AddRange(new object[] {
            "Toyota Yaris",
            "Toyota Wigo",
            "Toyota Prius C",
            "Toyota Rush",
            "Toyota Hilux",
            "Toyota Coaster",
            "Toyota Hiace",
            "Toyota Corolla",
            "Toyota Camry",
            "Toyota Prius",
            "Toyota Fortuner",
            "Toyota LC 79",
            "Toyota Premio",
            "Toyota Axio",
            "Toyota CHR",
            "Toyota Vitz",
            "Toyota Tank"});
            this.comboBoxEnqVehicleModel.Location = new System.Drawing.Point(294, 538);
            this.comboBoxEnqVehicleModel.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxEnqVehicleModel.Name = "comboBoxEnqVehicleModel";
            this.comboBoxEnqVehicleModel.Size = new System.Drawing.Size(165, 24);
            this.comboBoxEnqVehicleModel.TabIndex = 9;
            // 
            // txtEnqDateOfEnquiry
            // 
            this.txtEnqDateOfEnquiry.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtEnqDateOfEnquiry.Location = new System.Drawing.Point(294, 495);
            this.txtEnqDateOfEnquiry.Margin = new System.Windows.Forms.Padding(4);
            this.txtEnqDateOfEnquiry.Name = "txtEnqDateOfEnquiry";
            this.txtEnqDateOfEnquiry.Size = new System.Drawing.Size(245, 22);
            this.txtEnqDateOfEnquiry.TabIndex = 8;
            this.txtEnqDateOfEnquiry.Value = new System.DateTime(2019, 8, 15, 0, 0, 0, 0);
            // 
            // txtEnqContactNo
            // 
            this.txtEnqContactNo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEnqContactNo.Location = new System.Drawing.Point(294, 409);
            this.txtEnqContactNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtEnqContactNo.MaxLength = 10;
            this.txtEnqContactNo.Name = "txtEnqContactNo";
            this.txtEnqContactNo.Size = new System.Drawing.Size(191, 22);
            this.txtEnqContactNo.TabIndex = 6;
            this.txtEnqContactNo.TextChanged += new System.EventHandler(this.txtContactNo_TextChanged);
            this.txtEnqContactNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEnqContactNo_KeyPress);
            // 
            // txtEnqEmailAddress
            // 
            this.txtEnqEmailAddress.ForeColor = System.Drawing.Color.Blue;
            this.txtEnqEmailAddress.Location = new System.Drawing.Point(294, 452);
            this.txtEnqEmailAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtEnqEmailAddress.Name = "txtEnqEmailAddress";
            this.txtEnqEmailAddress.Size = new System.Drawing.Size(289, 22);
            this.txtEnqEmailAddress.TabIndex = 7;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.exitApplicationToolStripMenuItem,
            this.exitApplicationToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(812, 26);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(59, 22);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(48, 22);
            this.exitToolStripMenuItem.Text = "New";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // exitApplicationToolStripMenuItem
            // 
            this.exitApplicationToolStripMenuItem.Name = "exitApplicationToolStripMenuItem";
            this.exitApplicationToolStripMenuItem.Size = new System.Drawing.Size(72, 22);
            this.exitApplicationToolStripMenuItem.Text = "Log Out";
            this.exitApplicationToolStripMenuItem.Click += new System.EventHandler(this.exitApplicationToolStripMenuItem_Click);
            // 
            // exitApplicationToolStripMenuItem1
            // 
            this.exitApplicationToolStripMenuItem1.Name = "exitApplicationToolStripMenuItem1";
            this.exitApplicationToolStripMenuItem1.Size = new System.Drawing.Size(115, 22);
            this.exitApplicationToolStripMenuItem1.Text = "Exit Application";
            this.exitApplicationToolStripMenuItem1.Click += new System.EventHandler(this.exitApplicationToolStripMenuItem1_Click);
            // 
            // txtEnqEnquireID
            // 
            this.txtEnqEnquireID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEnqEnquireID.ForeColor = System.Drawing.Color.Red;
            this.txtEnqEnquireID.Location = new System.Drawing.Point(331, 176);
            this.txtEnqEnquireID.Margin = new System.Windows.Forms.Padding(4);
            this.txtEnqEnquireID.MaxLength = 5;
            this.txtEnqEnquireID.Name = "txtEnqEnquireID";
            this.txtEnqEnquireID.Size = new System.Drawing.Size(100, 22);
            this.txtEnqEnquireID.TabIndex = 0;
            this.txtEnqEnquireID.TextChanged += new System.EventHandler(this.txtEnqEnquireID_TextChanged);
            // 
            // txtEnqCustName
            // 
            this.txtEnqCustName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEnqCustName.Location = new System.Drawing.Point(294, 265);
            this.txtEnqCustName.Margin = new System.Windows.Forms.Padding(4);
            this.txtEnqCustName.Name = "txtEnqCustName";
            this.txtEnqCustName.Size = new System.Drawing.Size(387, 22);
            this.txtEnqCustName.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(23, 304);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 25);
            this.label9.TabIndex = 25;
            this.label9.Text = "Company:";
            // 
            // txtEnqCompany
            // 
            this.txtEnqCompany.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEnqCompany.Location = new System.Drawing.Point(294, 304);
            this.txtEnqCompany.Margin = new System.Windows.Forms.Padding(4);
            this.txtEnqCompany.Name = "txtEnqCompany";
            this.txtEnqCompany.Size = new System.Drawing.Size(387, 22);
            this.txtEnqCompany.TabIndex = 4;
            // 
            // txtEnqAddress
            // 
            this.txtEnqAddress.Location = new System.Drawing.Point(294, 343);
            this.txtEnqAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtEnqAddress.Name = "txtEnqAddress";
            this.txtEnqAddress.Size = new System.Drawing.Size(387, 47);
            this.txtEnqAddress.TabIndex = 5;
            this.txtEnqAddress.Text = "";
            // 
            // pictureBox122ss
            // 
            this.pictureBox122ss.Image = global::WindowsFormsApplication2.Properties.Resources.tlpllogo;
            this.pictureBox122ss.Location = new System.Drawing.Point(557, 50);
            this.pictureBox122ss.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox122ss.Name = "pictureBox122ss";
            this.pictureBox122ss.Size = new System.Drawing.Size(220, 148);
            this.pictureBox122ss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox122ss.TabIndex = 33;
            this.pictureBox122ss.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApplication2.Properties.Resources.service_banner_contactus;
            this.pictureBox2.Location = new System.Drawing.Point(0, 689);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(812, 198);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(23, 220);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 25);
            this.label11.TabIndex = 37;
            this.label11.Text = "Sales Person:";
            // 
            // chkboxEnqTestDrive
            // 
            this.chkboxEnqTestDrive.AutoSize = true;
            this.chkboxEnqTestDrive.Location = new System.Drawing.Point(273, 25);
            this.chkboxEnqTestDrive.Margin = new System.Windows.Forms.Padding(4);
            this.chkboxEnqTestDrive.Name = "chkboxEnqTestDrive";
            this.chkboxEnqTestDrive.Size = new System.Drawing.Size(95, 21);
            this.chkboxEnqTestDrive.TabIndex = 3;
            this.chkboxEnqTestDrive.Text = "Test Drive";
            this.chkboxEnqTestDrive.UseVisualStyleBackColor = true;
            this.chkboxEnqTestDrive.CheckedChanged += new System.EventHandler(this.chkboxEnqTestDrive_CheckedChanged);
            // 
            // chkboxEnqHotProspect
            // 
            this.chkboxEnqHotProspect.AutoSize = true;
            this.chkboxEnqHotProspect.Location = new System.Drawing.Point(571, 2);
            this.chkboxEnqHotProspect.Margin = new System.Windows.Forms.Padding(4);
            this.chkboxEnqHotProspect.Name = "chkboxEnqHotProspect";
            this.chkboxEnqHotProspect.Size = new System.Drawing.Size(112, 21);
            this.chkboxEnqHotProspect.TabIndex = 2;
            this.chkboxEnqHotProspect.Text = "Hot Prospect";
            this.chkboxEnqHotProspect.UseVisualStyleBackColor = true;
            // 
            // chkboxEnqOrderTaken
            // 
            this.chkboxEnqOrderTaken.AutoSize = true;
            this.chkboxEnqOrderTaken.Location = new System.Drawing.Point(401, 25);
            this.chkboxEnqOrderTaken.Margin = new System.Windows.Forms.Padding(4);
            this.chkboxEnqOrderTaken.Name = "chkboxEnqOrderTaken";
            this.chkboxEnqOrderTaken.Size = new System.Drawing.Size(161, 21);
            this.chkboxEnqOrderTaken.TabIndex = 4;
            this.chkboxEnqOrderTaken.Text = "Vehicle Order Taken";
            this.chkboxEnqOrderTaken.UseVisualStyleBackColor = true;
            // 
            // chkboxEnqNewLead
            // 
            this.chkboxEnqNewLead.AutoSize = true;
            this.chkboxEnqNewLead.Location = new System.Drawing.Point(273, 2);
            this.chkboxEnqNewLead.Margin = new System.Windows.Forms.Padding(4);
            this.chkboxEnqNewLead.Name = "chkboxEnqNewLead";
            this.chkboxEnqNewLead.Size = new System.Drawing.Size(93, 21);
            this.chkboxEnqNewLead.TabIndex = 0;
            this.chkboxEnqNewLead.Text = "New Lead";
            this.chkboxEnqNewLead.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 1);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 25);
            this.label10.TabIndex = 5;
            this.label10.Text = "Enquirer Status:";
            // 
            // chkboxEnqQuotationSubmitted
            // 
            this.chkboxEnqQuotationSubmitted.AutoSize = true;
            this.chkboxEnqQuotationSubmitted.Location = new System.Drawing.Point(401, 2);
            this.chkboxEnqQuotationSubmitted.Margin = new System.Windows.Forms.Padding(4);
            this.chkboxEnqQuotationSubmitted.Name = "chkboxEnqQuotationSubmitted";
            this.chkboxEnqQuotationSubmitted.Size = new System.Drawing.Size(159, 21);
            this.chkboxEnqQuotationSubmitted.TabIndex = 1;
            this.chkboxEnqQuotationSubmitted.Text = "Quotation Submitted";
            this.chkboxEnqQuotationSubmitted.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.chkboxEnqQuotationSubmitted);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.chkboxEnqNewLead);
            this.panel1.Controls.Add(this.chkboxEnqOrderTaken);
            this.panel1.Controls.Add(this.chkboxEnqHotProspect);
            this.panel1.Controls.Add(this.chkboxEnqTestDrive);
            this.panel1.Location = new System.Drawing.Point(-114, 588);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(747, 48);
            this.panel1.TabIndex = 10;
            // 
            // btnEnqFind
            // 
            this.btnEnqFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEnqFind.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEnqFind.Location = new System.Drawing.Point(435, 3135);
            this.btnEnqFind.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnqFind.Name = "btnEnqFind";
            this.btnEnqFind.Size = new System.Drawing.Size(51, 25);
            this.btnEnqFind.TabIndex = 1;
            this.btnEnqFind.Text = "Find";
            this.btnEnqFind.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEnqFind.UseVisualStyleBackColor = true;
            this.btnEnqFind.Click += new System.EventHandler(this.button1_Click);
            this.btnEnqFind.MouseLeave += new System.EventHandler(this.btnEnqFind_MouseLeave);
            this.btnEnqFind.MouseHover += new System.EventHandler(this.btnEnqFind_MouseHover);
            // 
            // btnEnqUpdate
            // 
            this.btnEnqUpdate.Image = global::WindowsFormsApplication2.Properties.Resources.update_25_252;
            this.btnEnqUpdate.Location = new System.Drawing.Point(508, 638);
            this.btnEnqUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnqUpdate.Name = "btnEnqUpdate";
            this.btnEnqUpdate.Size = new System.Drawing.Size(142, 50);
            this.btnEnqUpdate.TabIndex = 40;
            this.btnEnqUpdate.Text = "Update Details";
            this.btnEnqUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEnqUpdate.UseVisualStyleBackColor = true;
            this.btnEnqUpdate.Click += new System.EventHandler(this.btnVisitUpdate_Click);
            this.btnEnqUpdate.MouseLeave += new System.EventHandler(this.btnEnqUpdate_MouseLeave);
            this.btnEnqUpdate.MouseHover += new System.EventHandler(this.btnEnqUpdate_MouseHover);
            // 
            // btnEnqDelete
            // 
            this.btnEnqDelete.Image = global::WindowsFormsApplication2.Properties.Resources.delete;
            this.btnEnqDelete.Location = new System.Drawing.Point(341, 638);
            this.btnEnqDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnqDelete.Name = "btnEnqDelete";
            this.btnEnqDelete.Size = new System.Drawing.Size(141, 50);
            this.btnEnqDelete.TabIndex = 39;
            this.btnEnqDelete.Text = "Delete Details";
            this.btnEnqDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEnqDelete.UseVisualStyleBackColor = true;
            this.btnEnqDelete.Click += new System.EventHandler(this.btnEnqDelete_Click_1);
            this.btnEnqDelete.MouseLeave += new System.EventHandler(this.btnEnqDelete_MouseLeave);
            this.btnEnqDelete.MouseHover += new System.EventHandler(this.btnEnqDelete_MouseHover);
            // 
            // btnEnqSave
            // 
            this.btnEnqSave.Image = global::WindowsFormsApplication2.Properties.Resources.saveicon;
            this.btnEnqSave.Location = new System.Drawing.Point(201, 638);
            this.btnEnqSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnqSave.Name = "btnEnqSave";
            this.btnEnqSave.Size = new System.Drawing.Size(118, 50);
            this.btnEnqSave.TabIndex = 38;
            this.btnEnqSave.Text = "Save Details";
            this.btnEnqSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEnqSave.UseVisualStyleBackColor = true;
            this.btnEnqSave.Click += new System.EventHandler(this.btnEnqSave_Click_1);
            this.btnEnqSave.MouseLeave += new System.EventHandler(this.btnEnqSave_MouseLeave);
            this.btnEnqSave.MouseHover += new System.EventHandler(this.btnEnqSave_MouseHover);
            // 
            // btnGenerateEnquirerID
            // 
            this.btnGenerateEnquirerID.Image = global::WindowsFormsApplication2.Properties.Resources.plusicon1;
            this.btnGenerateEnquirerID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerateEnquirerID.Location = new System.Drawing.Point(297, 173);
            this.btnGenerateEnquirerID.Name = "btnGenerateEnquirerID";
            this.btnGenerateEnquirerID.Size = new System.Drawing.Size(30, 27);
            this.btnGenerateEnquirerID.TabIndex = 64;
            this.btnGenerateEnquirerID.UseVisualStyleBackColor = true;
            this.btnGenerateEnquirerID.Click += new System.EventHandler(this.btnGenerateVisitID_Click);
            this.btnGenerateEnquirerID.MouseLeave += new System.EventHandler(this.btnGenerateEnquirerID_MouseLeave);
            this.btnGenerateEnquirerID.MouseHover += new System.EventHandler(this.btnGenerateEnquirerID_MouseHover);
            // 
            // txtEnqSalesPersonID1
            // 
            this.txtEnqSalesPersonID1.DataSource = this.salespersonBindingSource;
            this.txtEnqSalesPersonID1.DisplayMember = "employeename";
            this.txtEnqSalesPersonID1.FormattingEnabled = true;
            this.txtEnqSalesPersonID1.Location = new System.Drawing.Point(294, 220);
            this.txtEnqSalesPersonID1.Name = "txtEnqSalesPersonID1";
            this.txtEnqSalesPersonID1.Size = new System.Drawing.Size(247, 24);
            this.txtEnqSalesPersonID1.TabIndex = 65;
            this.txtEnqSalesPersonID1.ValueMember = "salespersonid";
            // 
            // salespersonBindingSource
            // 
            this.salespersonBindingSource.DataMember = "sales_person";
            this.salespersonBindingSource.DataSource = this.dataSet2;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sales_personTableAdapter
            // 
            this.sales_personTableAdapter.ClearBeforeFill = true;
            // 
            // frmEnquirerInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(831, 746);
            this.Controls.Add(this.txtEnqSalesPersonID1);
            this.Controls.Add(this.btnGenerateEnquirerID);
            this.Controls.Add(this.btnEnqUpdate);
            this.Controls.Add(this.btnEnqDelete);
            this.Controls.Add(this.btnEnqSave);
            this.Controls.Add(this.btnEnqFind);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox122ss);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtEnqAddress);
            this.Controls.Add(this.txtEnqCompany);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtEnqCustName);
            this.Controls.Add(this.txtEnqEnquireID);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtEnqEmailAddress);
            this.Controls.Add(this.txtEnqContactNo);
            this.Controls.Add(this.txtEnqDateOfEnquiry);
            this.Controls.Add(this.comboBoxEnqVehicleModel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmEnquirerInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Enquirer details";
            this.Load += new System.EventHandler(this.frmEnquirerInformation_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox122ss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salespersonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEnquirerID;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.ComboBox comboBoxEnqVehicleModel;
        private System.Windows.Forms.DateTimePicker txtEnqDateOfEnquiry;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox txtEnqContactNo;
        private System.Windows.Forms.TextBox txtEnqEmailAddress;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitApplicationToolStripMenuItem1;
        private System.Windows.Forms.TextBox txtEnqEnquireID;
        private System.Windows.Forms.TextBox txtEnqCustName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEnqCompany;
        private System.Windows.Forms.RichTextBox txtEnqAddress;
        private System.Windows.Forms.PictureBox pictureBox122ss;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox chkboxEnqTestDrive;
        private System.Windows.Forms.CheckBox chkboxEnqHotProspect;
        private System.Windows.Forms.CheckBox chkboxEnqOrderTaken;
        private System.Windows.Forms.CheckBox chkboxEnqNewLead;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chkboxEnqQuotationSubmitted;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEnqFind;
        private System.Windows.Forms.Button btnEnqUpdate;
        private System.Windows.Forms.Button btnEnqDelete;
        private System.Windows.Forms.Button btnEnqSave;
        private System.Windows.Forms.Button btnGenerateEnquirerID;
        private System.Windows.Forms.ComboBox txtEnqSalesPersonID1;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource salespersonBindingSource;
        private DataSet2TableAdapters.sales_personTableAdapter sales_personTableAdapter;
    }
}

