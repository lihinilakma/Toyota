namespace WindowsFormsApplication2
{
    partial class frmCustomerFeedback
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomerFeedback));
            this.label1 = new System.Windows.Forms.Label();
            this.txtFeedbackCustName = new System.Windows.Forms.TextBox();
            this.txtFeedbackFeedbackID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rdobtnFeedbackExcellent = new System.Windows.Forms.RadioButton();
            this.rdobtnFeedbackNeutral = new System.Windows.Forms.RadioButton();
            this.rdobtnFeedbackPoor = new System.Windows.Forms.RadioButton();
            this.rdobtnFeedbackVeryPoor = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.chkboxFeedbackBrandName = new System.Windows.Forms.CheckBox();
            this.chkboxFeedbackPrice = new System.Windows.Forms.CheckBox();
            this.chkboxFeedbackSafetyAndReliability = new System.Windows.Forms.CheckBox();
            this.chkboxFeedbackFuelConsumption = new System.Windows.Forms.CheckBox();
            this.chkboxFeedbackAfterSalesService = new System.Windows.Forms.CheckBox();
            this.chkboxFeedbackMaintenanceCost = new System.Windows.Forms.CheckBox();
            this.chkboxInteriorAndComfort = new System.Windows.Forms.CheckBox();
            this.chkboxFeedbackxteriorDesign = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rdobtnFeedbackYes = new System.Windows.Forms.RadioButton();
            this.rdobtnFeedbackNo = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFeedbackOtherFeedbackForImprovements = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbboxFeedbackLeadSource = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitApplicationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1224515qwsdasd = new System.Windows.Forms.PictureBox();
            this.btnFeedbackFind = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnFeedbackUpdate1 = new System.Windows.Forms.Button();
            this.btnFeedbackDelete1 = new System.Windows.Forms.Button();
            this.btnFeedbackSave1 = new System.Windows.Forms.Button();
            this.btnGenerateFeedbackID = new System.Windows.Forms.Button();
            this.txtFeedbackEnquirerID = new System.Windows.Forms.ComboBox();
            this.enquirerinformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new WindowsFormsApplication2.DataSet1();
            this.enquirer_informationTableAdapter = new WindowsFormsApplication2.DataSet1TableAdapters.enquirer_informationTableAdapter();
            this.dataSet3 = new WindowsFormsApplication2.DataSet3();
            this.enquirerinformation2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enquirer_information2TableAdapter = new WindowsFormsApplication2.DataSet3TableAdapters.enquirer_information2TableAdapter();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1224515qwsdasd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enquirerinformationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enquirerinformation2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 127);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Customer Voice";
            // 
            // txtFeedbackCustName
            // 
            this.txtFeedbackCustName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFeedbackCustName.Location = new System.Drawing.Point(336, 278);
            this.txtFeedbackCustName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFeedbackCustName.Name = "txtFeedbackCustName";
            this.txtFeedbackCustName.Size = new System.Drawing.Size(387, 22);
            this.txtFeedbackCustName.TabIndex = 3;
            // 
            // txtFeedbackFeedbackID
            // 
            this.txtFeedbackFeedbackID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFeedbackFeedbackID.ForeColor = System.Drawing.Color.Red;
            this.txtFeedbackFeedbackID.Location = new System.Drawing.Point(336, 192);
            this.txtFeedbackFeedbackID.Margin = new System.Windows.Forms.Padding(4);
            this.txtFeedbackFeedbackID.MaxLength = 5;
            this.txtFeedbackFeedbackID.Name = "txtFeedbackFeedbackID";
            this.txtFeedbackFeedbackID.Size = new System.Drawing.Size(85, 22);
            this.txtFeedbackFeedbackID.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 278);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "Customer Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 192);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Feedback ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 236);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 25);
            this.label4.TabIndex = 29;
            this.label4.Text = "Enquirer ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 372);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(236, 25);
            this.label5.TabIndex = 31;
            this.label5.Text = "Satisfaction rating from";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 396);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 25);
            this.label6.TabIndex = 32;
            this.label6.Text = "service level:";
            // 
            // rdobtnFeedbackExcellent
            // 
            this.rdobtnFeedbackExcellent.AutoSize = true;
            this.rdobtnFeedbackExcellent.Location = new System.Drawing.Point(20, 6);
            this.rdobtnFeedbackExcellent.Margin = new System.Windows.Forms.Padding(4);
            this.rdobtnFeedbackExcellent.Name = "rdobtnFeedbackExcellent";
            this.rdobtnFeedbackExcellent.Size = new System.Drawing.Size(85, 21);
            this.rdobtnFeedbackExcellent.TabIndex = 0;
            this.rdobtnFeedbackExcellent.TabStop = true;
            this.rdobtnFeedbackExcellent.Text = "Excellent";
            this.rdobtnFeedbackExcellent.UseVisualStyleBackColor = true;
            // 
            // rdobtnFeedbackNeutral
            // 
            this.rdobtnFeedbackNeutral.AutoSize = true;
            this.rdobtnFeedbackNeutral.Location = new System.Drawing.Point(169, 6);
            this.rdobtnFeedbackNeutral.Margin = new System.Windows.Forms.Padding(4);
            this.rdobtnFeedbackNeutral.Name = "rdobtnFeedbackNeutral";
            this.rdobtnFeedbackNeutral.Size = new System.Drawing.Size(75, 21);
            this.rdobtnFeedbackNeutral.TabIndex = 1;
            this.rdobtnFeedbackNeutral.TabStop = true;
            this.rdobtnFeedbackNeutral.Text = "Neutral";
            this.rdobtnFeedbackNeutral.UseVisualStyleBackColor = true;
            // 
            // rdobtnFeedbackPoor
            // 
            this.rdobtnFeedbackPoor.AutoSize = true;
            this.rdobtnFeedbackPoor.Location = new System.Drawing.Point(20, 36);
            this.rdobtnFeedbackPoor.Margin = new System.Windows.Forms.Padding(4);
            this.rdobtnFeedbackPoor.Name = "rdobtnFeedbackPoor";
            this.rdobtnFeedbackPoor.Size = new System.Drawing.Size(59, 21);
            this.rdobtnFeedbackPoor.TabIndex = 2;
            this.rdobtnFeedbackPoor.TabStop = true;
            this.rdobtnFeedbackPoor.Text = "Poor";
            this.rdobtnFeedbackPoor.UseVisualStyleBackColor = true;
            // 
            // rdobtnFeedbackVeryPoor
            // 
            this.rdobtnFeedbackVeryPoor.AutoSize = true;
            this.rdobtnFeedbackVeryPoor.Location = new System.Drawing.Point(169, 36);
            this.rdobtnFeedbackVeryPoor.Margin = new System.Windows.Forms.Padding(4);
            this.rdobtnFeedbackVeryPoor.Name = "rdobtnFeedbackVeryPoor";
            this.rdobtnFeedbackVeryPoor.Size = new System.Drawing.Size(92, 21);
            this.rdobtnFeedbackVeryPoor.TabIndex = 3;
            this.rdobtnFeedbackVeryPoor.TabStop = true;
            this.rdobtnFeedbackVeryPoor.Text = "Very Poor";
            this.rdobtnFeedbackVeryPoor.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, 485);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(523, 25);
            this.label7.TabIndex = 37;
            this.label7.Text = "Most important elements when purchasing a vehicle:-";
            // 
            // chkboxFeedbackBrandName
            // 
            this.chkboxFeedbackBrandName.AutoSize = true;
            this.chkboxFeedbackBrandName.Location = new System.Drawing.Point(376, 523);
            this.chkboxFeedbackBrandName.Margin = new System.Windows.Forms.Padding(4);
            this.chkboxFeedbackBrandName.Name = "chkboxFeedbackBrandName";
            this.chkboxFeedbackBrandName.Size = new System.Drawing.Size(109, 21);
            this.chkboxFeedbackBrandName.TabIndex = 10;
            this.chkboxFeedbackBrandName.Text = "Brand Name";
            this.chkboxFeedbackBrandName.UseVisualStyleBackColor = true;
            // 
            // chkboxFeedbackPrice
            // 
            this.chkboxFeedbackPrice.AutoSize = true;
            this.chkboxFeedbackPrice.Location = new System.Drawing.Point(44, 523);
            this.chkboxFeedbackPrice.Margin = new System.Windows.Forms.Padding(4);
            this.chkboxFeedbackPrice.Name = "chkboxFeedbackPrice";
            this.chkboxFeedbackPrice.Size = new System.Drawing.Size(62, 21);
            this.chkboxFeedbackPrice.TabIndex = 8;
            this.chkboxFeedbackPrice.Text = "Price";
            this.chkboxFeedbackPrice.UseVisualStyleBackColor = true;
            this.chkboxFeedbackPrice.CheckedChanged += new System.EventHandler(this.chkboxFeedbackPrice_CheckedChanged);
            // 
            // chkboxFeedbackSafetyAndReliability
            // 
            this.chkboxFeedbackSafetyAndReliability.AutoSize = true;
            this.chkboxFeedbackSafetyAndReliability.Location = new System.Drawing.Point(376, 553);
            this.chkboxFeedbackSafetyAndReliability.Margin = new System.Windows.Forms.Padding(4);
            this.chkboxFeedbackSafetyAndReliability.Name = "chkboxFeedbackSafetyAndReliability";
            this.chkboxFeedbackSafetyAndReliability.Size = new System.Drawing.Size(162, 21);
            this.chkboxFeedbackSafetyAndReliability.TabIndex = 14;
            this.chkboxFeedbackSafetyAndReliability.Text = "Safety and Reliability";
            this.chkboxFeedbackSafetyAndReliability.UseVisualStyleBackColor = true;
            // 
            // chkboxFeedbackFuelConsumption
            // 
            this.chkboxFeedbackFuelConsumption.AutoSize = true;
            this.chkboxFeedbackFuelConsumption.Location = new System.Drawing.Point(207, 523);
            this.chkboxFeedbackFuelConsumption.Margin = new System.Windows.Forms.Padding(4);
            this.chkboxFeedbackFuelConsumption.Name = "chkboxFeedbackFuelConsumption";
            this.chkboxFeedbackFuelConsumption.Size = new System.Drawing.Size(143, 21);
            this.chkboxFeedbackFuelConsumption.TabIndex = 9;
            this.chkboxFeedbackFuelConsumption.Text = "Fuel Consumption";
            this.chkboxFeedbackFuelConsumption.UseVisualStyleBackColor = true;
            // 
            // chkboxFeedbackAfterSalesService
            // 
            this.chkboxFeedbackAfterSalesService.AutoSize = true;
            this.chkboxFeedbackAfterSalesService.Location = new System.Drawing.Point(44, 553);
            this.chkboxFeedbackAfterSalesService.Margin = new System.Windows.Forms.Padding(4);
            this.chkboxFeedbackAfterSalesService.Name = "chkboxFeedbackAfterSalesService";
            this.chkboxFeedbackAfterSalesService.Size = new System.Drawing.Size(150, 21);
            this.chkboxFeedbackAfterSalesService.TabIndex = 12;
            this.chkboxFeedbackAfterSalesService.Text = "After Sales Service";
            this.chkboxFeedbackAfterSalesService.UseVisualStyleBackColor = true;
            // 
            // chkboxFeedbackMaintenanceCost
            // 
            this.chkboxFeedbackMaintenanceCost.AutoSize = true;
            this.chkboxFeedbackMaintenanceCost.Location = new System.Drawing.Point(207, 553);
            this.chkboxFeedbackMaintenanceCost.Margin = new System.Windows.Forms.Padding(4);
            this.chkboxFeedbackMaintenanceCost.Name = "chkboxFeedbackMaintenanceCost";
            this.chkboxFeedbackMaintenanceCost.Size = new System.Drawing.Size(143, 21);
            this.chkboxFeedbackMaintenanceCost.TabIndex = 13;
            this.chkboxFeedbackMaintenanceCost.Text = "Maintenance Cost";
            this.chkboxFeedbackMaintenanceCost.UseVisualStyleBackColor = true;
            // 
            // chkboxInteriorAndComfort
            // 
            this.chkboxInteriorAndComfort.AutoSize = true;
            this.chkboxInteriorAndComfort.Location = new System.Drawing.Point(568, 524);
            this.chkboxInteriorAndComfort.Margin = new System.Windows.Forms.Padding(4);
            this.chkboxInteriorAndComfort.Name = "chkboxInteriorAndComfort";
            this.chkboxInteriorAndComfort.Size = new System.Drawing.Size(152, 21);
            this.chkboxInteriorAndComfort.TabIndex = 11;
            this.chkboxInteriorAndComfort.Text = "Interior and Confort";
            this.chkboxInteriorAndComfort.UseVisualStyleBackColor = true;
            // 
            // chkboxFeedbackxteriorDesign
            // 
            this.chkboxFeedbackxteriorDesign.AutoSize = true;
            this.chkboxFeedbackxteriorDesign.Location = new System.Drawing.Point(568, 553);
            this.chkboxFeedbackxteriorDesign.Margin = new System.Windows.Forms.Padding(4);
            this.chkboxFeedbackxteriorDesign.Name = "chkboxFeedbackxteriorDesign";
            this.chkboxFeedbackxteriorDesign.Size = new System.Drawing.Size(126, 21);
            this.chkboxFeedbackxteriorDesign.TabIndex = 15;
            this.chkboxFeedbackxteriorDesign.Text = "Exterior Design";
            this.chkboxFeedbackxteriorDesign.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(39, 439);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 25);
            this.label8.TabIndex = 46;
            this.label8.Text = "On time delivery?";
            // 
            // rdobtnFeedbackYes
            // 
            this.rdobtnFeedbackYes.AutoSize = true;
            this.rdobtnFeedbackYes.Location = new System.Drawing.Point(336, 443);
            this.rdobtnFeedbackYes.Margin = new System.Windows.Forms.Padding(4);
            this.rdobtnFeedbackYes.Name = "rdobtnFeedbackYes";
            this.rdobtnFeedbackYes.Size = new System.Drawing.Size(53, 21);
            this.rdobtnFeedbackYes.TabIndex = 6;
            this.rdobtnFeedbackYes.TabStop = true;
            this.rdobtnFeedbackYes.Text = "Yes";
            this.rdobtnFeedbackYes.UseVisualStyleBackColor = true;
            // 
            // rdobtnFeedbackNo
            // 
            this.rdobtnFeedbackNo.AutoSize = true;
            this.rdobtnFeedbackNo.Location = new System.Drawing.Point(401, 443);
            this.rdobtnFeedbackNo.Margin = new System.Windows.Forms.Padding(4);
            this.rdobtnFeedbackNo.Name = "rdobtnFeedbackNo";
            this.rdobtnFeedbackNo.Size = new System.Drawing.Size(47, 21);
            this.rdobtnFeedbackNo.TabIndex = 7;
            this.rdobtnFeedbackNo.TabStop = true;
            this.rdobtnFeedbackNo.Text = "No";
            this.rdobtnFeedbackNo.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(39, 597);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 25);
            this.label9.TabIndex = 53;
            this.label9.Text = "Other feedback ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(39, 623);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(189, 25);
            this.label10.TabIndex = 54;
            this.label10.Text = "for improvements:";
            // 
            // txtFeedbackOtherFeedbackForImprovements
            // 
            this.txtFeedbackOtherFeedbackForImprovements.Location = new System.Drawing.Point(336, 599);
            this.txtFeedbackOtherFeedbackForImprovements.Margin = new System.Windows.Forms.Padding(4);
            this.txtFeedbackOtherFeedbackForImprovements.Name = "txtFeedbackOtherFeedbackForImprovements";
            this.txtFeedbackOtherFeedbackForImprovements.Size = new System.Drawing.Size(387, 47);
            this.txtFeedbackOtherFeedbackForImprovements.TabIndex = 16;
            this.txtFeedbackOtherFeedbackForImprovements.Text = "";
            this.txtFeedbackOtherFeedbackForImprovements.TextChanged += new System.EventHandler(this.txtEnqAddress_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(39, 325);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 25);
            this.label11.TabIndex = 56;
            this.label11.Text = "Lead source:";
            // 
            // cmbboxFeedbackLeadSource
            // 
            this.cmbboxFeedbackLeadSource.FormattingEnabled = true;
            this.cmbboxFeedbackLeadSource.Items.AddRange(new object[] {
            "Phone calls",
            "ikman.lk advertisements",
            "Referral from existing customer",
            "Social media",
            "Website",
            "Promotional event"});
            this.cmbboxFeedbackLeadSource.Location = new System.Drawing.Point(336, 324);
            this.cmbboxFeedbackLeadSource.Margin = new System.Windows.Forms.Padding(4);
            this.cmbboxFeedbackLeadSource.Name = "cmbboxFeedbackLeadSource";
            this.cmbboxFeedbackLeadSource.Size = new System.Drawing.Size(253, 24);
            this.cmbboxFeedbackLeadSource.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdobtnFeedbackExcellent);
            this.panel1.Controls.Add(this.rdobtnFeedbackNeutral);
            this.panel1.Controls.Add(this.rdobtnFeedbackPoor);
            this.panel1.Controls.Add(this.rdobtnFeedbackVeryPoor);
            this.panel1.Location = new System.Drawing.Point(316, 364);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 63);
            this.panel1.TabIndex = 5;
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
            this.menuStrip1.Size = new System.Drawing.Size(809, 26);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 59;
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
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApplication2.Properties.Resources.service_banner_aboutus1;
            this.pictureBox2.Location = new System.Drawing.Point(-3, 722);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(812, 198);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 52;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1224515qwsdasd
            // 
            this.pictureBox1224515qwsdasd.Image = global::WindowsFormsApplication2.Properties.Resources.tlpllogo;
            this.pictureBox1224515qwsdasd.Location = new System.Drawing.Point(552, 39);
            this.pictureBox1224515qwsdasd.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1224515qwsdasd.Name = "pictureBox1224515qwsdasd";
            this.pictureBox1224515qwsdasd.Size = new System.Drawing.Size(220, 148);
            this.pictureBox1224515qwsdasd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1224515qwsdasd.TabIndex = 2;
            this.pictureBox1224515qwsdasd.TabStop = false;
            // 
            // btnFeedbackFind
            // 
            this.btnFeedbackFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFeedbackFind.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFeedbackFind.Location = new System.Drawing.Point(711, 408);
            this.btnFeedbackFind.Margin = new System.Windows.Forms.Padding(4);
            this.btnFeedbackFind.Name = "btnFeedbackFind";
            this.btnFeedbackFind.Size = new System.Drawing.Size(51, 25);
            this.btnFeedbackFind.TabIndex = 2;
            this.btnFeedbackFind.Text = "Find";
            this.btnFeedbackFind.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFeedbackFind.UseVisualStyleBackColor = true;
            this.btnFeedbackFind.Click += new System.EventHandler(this.btnFeedbackFind_Click);
            this.btnFeedbackFind.MouseLeave += new System.EventHandler(this.btnFeedbackFind_MouseLeave);
            this.btnFeedbackFind.MouseHover += new System.EventHandler(this.btnFeedbackFind_MouseHover);
            // 
            // btnFeedbackUpdate1
            // 
            this.btnFeedbackUpdate1.Image = global::WindowsFormsApplication2.Properties.Resources.update_25_252;
            this.btnFeedbackUpdate1.Location = new System.Drawing.Point(485, 657);
            this.btnFeedbackUpdate1.Margin = new System.Windows.Forms.Padding(4);
            this.btnFeedbackUpdate1.Name = "btnFeedbackUpdate1";
            this.btnFeedbackUpdate1.Size = new System.Drawing.Size(142, 50);
            this.btnFeedbackUpdate1.TabIndex = 62;
            this.btnFeedbackUpdate1.Text = "Update Details";
            this.btnFeedbackUpdate1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFeedbackUpdate1.UseVisualStyleBackColor = true;
            this.btnFeedbackUpdate1.Click += new System.EventHandler(this.btnFeedbackUpdate1_Click);
            this.btnFeedbackUpdate1.MouseLeave += new System.EventHandler(this.btnFeedbackUpdate1_MouseLeave);
            this.btnFeedbackUpdate1.MouseHover += new System.EventHandler(this.btnFeedbackUpdate1_MouseHover);
            // 
            // btnFeedbackDelete1
            // 
            this.btnFeedbackDelete1.Image = global::WindowsFormsApplication2.Properties.Resources.delete;
            this.btnFeedbackDelete1.Location = new System.Drawing.Point(318, 657);
            this.btnFeedbackDelete1.Margin = new System.Windows.Forms.Padding(4);
            this.btnFeedbackDelete1.Name = "btnFeedbackDelete1";
            this.btnFeedbackDelete1.Size = new System.Drawing.Size(141, 50);
            this.btnFeedbackDelete1.TabIndex = 61;
            this.btnFeedbackDelete1.Text = "Delete Details";
            this.btnFeedbackDelete1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFeedbackDelete1.UseVisualStyleBackColor = true;
            this.btnFeedbackDelete1.Click += new System.EventHandler(this.btnFeedbackDelete1_Click);
            this.btnFeedbackDelete1.MouseLeave += new System.EventHandler(this.btnFeedbackDelete1_MouseLeave);
            this.btnFeedbackDelete1.MouseHover += new System.EventHandler(this.btnFeedbackDelete1_MouseHover);
            // 
            // btnFeedbackSave1
            // 
            this.btnFeedbackSave1.Image = global::WindowsFormsApplication2.Properties.Resources.saveicon;
            this.btnFeedbackSave1.Location = new System.Drawing.Point(178, 657);
            this.btnFeedbackSave1.Margin = new System.Windows.Forms.Padding(4);
            this.btnFeedbackSave1.Name = "btnFeedbackSave1";
            this.btnFeedbackSave1.Size = new System.Drawing.Size(118, 50);
            this.btnFeedbackSave1.TabIndex = 60;
            this.btnFeedbackSave1.Text = "Save Details";
            this.btnFeedbackSave1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFeedbackSave1.UseVisualStyleBackColor = true;
            this.btnFeedbackSave1.Click += new System.EventHandler(this.btnFeedbackSave1_Click);
            this.btnFeedbackSave1.MouseLeave += new System.EventHandler(this.btnFeedbackSave1_MouseLeave);
            this.btnFeedbackSave1.MouseHover += new System.EventHandler(this.btnFeedbackSave1_MouseHover);
            // 
            // btnGenerateFeedbackID
            // 
            this.btnGenerateFeedbackID.Image = global::WindowsFormsApplication2.Properties.Resources.plusicon1;
            this.btnGenerateFeedbackID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerateFeedbackID.Location = new System.Drawing.Point(425, 190);
            this.btnGenerateFeedbackID.Name = "btnGenerateFeedbackID";
            this.btnGenerateFeedbackID.Size = new System.Drawing.Size(30, 27);
            this.btnGenerateFeedbackID.TabIndex = 64;
            this.btnGenerateFeedbackID.UseVisualStyleBackColor = true;
            this.btnGenerateFeedbackID.Click += new System.EventHandler(this.btnGenerateFeedbackID_Click);
            this.btnGenerateFeedbackID.MouseLeave += new System.EventHandler(this.btnGenerateFeedbackID_MouseLeave);
            this.btnGenerateFeedbackID.MouseHover += new System.EventHandler(this.btnGenerateFeedbackID_MouseHover);
            // 
            // txtFeedbackEnquirerID
            // 
            this.txtFeedbackEnquirerID.DataSource = this.enquirerinformation2BindingSource;
            this.txtFeedbackEnquirerID.DisplayMember = "enquirerid";
            this.txtFeedbackEnquirerID.FormattingEnabled = true;
            this.txtFeedbackEnquirerID.Location = new System.Drawing.Point(334, 235);
            this.txtFeedbackEnquirerID.Name = "txtFeedbackEnquirerID";
            this.txtFeedbackEnquirerID.Size = new System.Drawing.Size(87, 24);
            this.txtFeedbackEnquirerID.TabIndex = 65;
            this.txtFeedbackEnquirerID.ValueMember = "enquirerid";
            this.txtFeedbackEnquirerID.SelectedIndexChanged += new System.EventHandler(this.txtVisitSalesPersonID_SelectedIndexChanged);
            // 
            // enquirerinformationBindingSource
            // 
            this.enquirerinformationBindingSource.DataMember = "enquirer_information";
            this.enquirerinformationBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // enquirer_informationTableAdapter
            // 
            this.enquirer_informationTableAdapter.ClearBeforeFill = true;
            // 
            // dataSet3
            // 
            this.dataSet3.DataSetName = "DataSet3";
            this.dataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // enquirerinformation2BindingSource
            // 
            this.enquirerinformation2BindingSource.DataMember = "enquirer_information2";
            this.enquirerinformation2BindingSource.DataSource = this.dataSet3;
            // 
            // enquirer_information2TableAdapter
            // 
            this.enquirer_information2TableAdapter.ClearBeforeFill = true;
            // 
            // frmCustomerFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(804, 746);
            this.Controls.Add(this.txtFeedbackEnquirerID);
            this.Controls.Add(this.btnGenerateFeedbackID);
            this.Controls.Add(this.btnFeedbackUpdate1);
            this.Controls.Add(this.btnFeedbackDelete1);
            this.Controls.Add(this.btnFeedbackSave1);
            this.Controls.Add(this.btnFeedbackFind);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbboxFeedbackLeadSource);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtFeedbackOtherFeedbackForImprovements);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.rdobtnFeedbackNo);
            this.Controls.Add(this.rdobtnFeedbackYes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.chkboxFeedbackxteriorDesign);
            this.Controls.Add(this.chkboxInteriorAndComfort);
            this.Controls.Add(this.chkboxFeedbackMaintenanceCost);
            this.Controls.Add(this.chkboxFeedbackAfterSalesService);
            this.Controls.Add(this.chkboxFeedbackFuelConsumption);
            this.Controls.Add(this.chkboxFeedbackSafetyAndReliability);
            this.Controls.Add(this.chkboxFeedbackPrice);
            this.Controls.Add(this.chkboxFeedbackBrandName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFeedbackCustName);
            this.Controls.Add(this.txtFeedbackFeedbackID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1224515qwsdasd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCustomerFeedback";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Feedback details";
            this.Load += new System.EventHandler(this.frmCustomerFeedback_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1224515qwsdasd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enquirerinformationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enquirerinformation2BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1224515qwsdasd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFeedbackCustName;
        private System.Windows.Forms.TextBox txtFeedbackFeedbackID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdobtnFeedbackExcellent;
        private System.Windows.Forms.RadioButton rdobtnFeedbackNeutral;
        private System.Windows.Forms.RadioButton rdobtnFeedbackPoor;
        private System.Windows.Forms.RadioButton rdobtnFeedbackVeryPoor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkboxFeedbackBrandName;
        private System.Windows.Forms.CheckBox chkboxFeedbackPrice;
        private System.Windows.Forms.CheckBox chkboxFeedbackSafetyAndReliability;
        private System.Windows.Forms.CheckBox chkboxFeedbackFuelConsumption;
        private System.Windows.Forms.CheckBox chkboxFeedbackAfterSalesService;
        private System.Windows.Forms.CheckBox chkboxFeedbackMaintenanceCost;
        private System.Windows.Forms.CheckBox chkboxInteriorAndComfort;
        private System.Windows.Forms.CheckBox chkboxFeedbackxteriorDesign;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rdobtnFeedbackYes;
        private System.Windows.Forms.RadioButton rdobtnFeedbackNo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox txtFeedbackOtherFeedbackForImprovements;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbboxFeedbackLeadSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitApplicationToolStripMenuItem1;
        private System.Windows.Forms.Button btnFeedbackFind;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnFeedbackUpdate1;
        private System.Windows.Forms.Button btnFeedbackDelete1;
        private System.Windows.Forms.Button btnFeedbackSave1;
        private System.Windows.Forms.Button btnGenerateFeedbackID;
        private System.Windows.Forms.ComboBox txtFeedbackEnquirerID;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource enquirerinformationBindingSource;
        private DataSet1TableAdapters.enquirer_informationTableAdapter enquirer_informationTableAdapter;
        private DataSet3 dataSet3;
        private System.Windows.Forms.BindingSource enquirerinformation2BindingSource;
        private DataSet3TableAdapters.enquirer_information2TableAdapter enquirer_information2TableAdapter;
    }
}