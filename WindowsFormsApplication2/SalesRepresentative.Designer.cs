namespace WindowsFormsApplication2
{
    partial class frmSalesRepresentative
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalesRepresentative));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitApplicationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSalesMonthlyTarget = new System.Windows.Forms.TextBox();
            this.lblSalesOrderTaken = new System.Windows.Forms.Label();
            this.lblSalesCustomerVisits = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblSalesNewLeads1 = new System.Windows.Forms.Label();
            this.lblSalesCustomerVisits1 = new System.Windows.Forms.Label();
            this.lblSalesOrderTaken1 = new System.Windows.Forms.Label();
            this.lblSalesNewLeads = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1224515 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSalesFind = new System.Windows.Forms.Button();
            this.txtSalesSalesPersonID = new System.Windows.Forms.ComboBox();
            this.salespersonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new WindowsFormsApplication2.DataSet2();
            this.sales_personTableAdapter = new WindowsFormsApplication2.DataSet2TableAdapters.sales_personTableAdapter();
            this.btnSalesUpdate = new System.Windows.Forms.Button();
            this.btnSalesDelete = new System.Windows.Forms.Button();
            this.btnSalesSave = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1224515)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salespersonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 175);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sales Staff details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 233);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sales Person:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 274);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Annual Target:";
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
            this.menuStrip1.Size = new System.Drawing.Size(1028, 26);
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
            // txtSalesMonthlyTarget
            // 
            this.txtSalesMonthlyTarget.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSalesMonthlyTarget.Location = new System.Drawing.Point(231, 277);
            this.txtSalesMonthlyTarget.Margin = new System.Windows.Forms.Padding(4);
            this.txtSalesMonthlyTarget.Name = "txtSalesMonthlyTarget";
            this.txtSalesMonthlyTarget.Size = new System.Drawing.Size(95, 22);
            this.txtSalesMonthlyTarget.TabIndex = 3;
            this.txtSalesMonthlyTarget.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalesMonthlyTarget_KeyPress);
            // 
            // lblSalesOrderTaken
            // 
            this.lblSalesOrderTaken.AutoSize = true;
            this.lblSalesOrderTaken.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.lblSalesOrderTaken.Location = new System.Drawing.Point(17, 11);
            this.lblSalesOrderTaken.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalesOrderTaken.Name = "lblSalesOrderTaken";
            this.lblSalesOrderTaken.Size = new System.Drawing.Size(276, 25);
            this.lblSalesOrderTaken.TabIndex = 24;
            this.lblSalesOrderTaken.Text = "New Vehicle Orders Taken:-";
            // 
            // lblSalesCustomerVisits
            // 
            this.lblSalesCustomerVisits.AutoSize = true;
            this.lblSalesCustomerVisits.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.lblSalesCustomerVisits.Location = new System.Drawing.Point(17, 64);
            this.lblSalesCustomerVisits.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalesCustomerVisits.Name = "lblSalesCustomerVisits";
            this.lblSalesCustomerVisits.Size = new System.Drawing.Size(348, 25);
            this.lblSalesCustomerVisits.TabIndex = 25;
            this.lblSalesCustomerVisits.Text = "Customer Visits during the Month:-";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.linkLabel2);
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Controls.Add(this.lblSalesNewLeads1);
            this.panel2.Controls.Add(this.lblSalesCustomerVisits1);
            this.panel2.Controls.Add(this.lblSalesOrderTaken1);
            this.panel2.Controls.Add(this.lblSalesNewLeads);
            this.panel2.Controls.Add(this.lblSalesOrderTaken);
            this.panel2.Controls.Add(this.lblSalesCustomerVisits);
            this.panel2.Location = new System.Drawing.Point(77, 363);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(583, 154);
            this.panel2.TabIndex = 26;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(241, 119);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(111, 17);
            this.linkLabel2.TabIndex = 36;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Follow-up Leads";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(326, 16);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(84, 17);
            this.linkLabel1.TabIndex = 35;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "View Details";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblSalesNewLeads1
            // 
            this.lblSalesNewLeads1.AutoSize = true;
            this.lblSalesNewLeads1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.lblSalesNewLeads1.Location = new System.Drawing.Point(204, 114);
            this.lblSalesNewLeads1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalesNewLeads1.Name = "lblSalesNewLeads1";
            this.lblSalesNewLeads1.Size = new System.Drawing.Size(36, 25);
            this.lblSalesNewLeads1.TabIndex = 30;
            this.lblSalesNewLeads1.Text = "00";
            // 
            // lblSalesCustomerVisits1
            // 
            this.lblSalesCustomerVisits1.AutoSize = true;
            this.lblSalesCustomerVisits1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.lblSalesCustomerVisits1.Location = new System.Drawing.Point(362, 64);
            this.lblSalesCustomerVisits1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalesCustomerVisits1.Name = "lblSalesCustomerVisits1";
            this.lblSalesCustomerVisits1.Size = new System.Drawing.Size(36, 25);
            this.lblSalesCustomerVisits1.TabIndex = 29;
            this.lblSalesCustomerVisits1.Text = "00";
            // 
            // lblSalesOrderTaken1
            // 
            this.lblSalesOrderTaken1.AutoSize = true;
            this.lblSalesOrderTaken1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.lblSalesOrderTaken1.Location = new System.Drawing.Point(291, 11);
            this.lblSalesOrderTaken1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalesOrderTaken1.Name = "lblSalesOrderTaken1";
            this.lblSalesOrderTaken1.Size = new System.Drawing.Size(36, 25);
            this.lblSalesOrderTaken1.TabIndex = 27;
            this.lblSalesOrderTaken1.Text = "00";
            // 
            // lblSalesNewLeads
            // 
            this.lblSalesNewLeads.AutoSize = true;
            this.lblSalesNewLeads.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.lblSalesNewLeads.Location = new System.Drawing.Point(17, 114);
            this.lblSalesNewLeads.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalesNewLeads.Name = "lblSalesNewLeads";
            this.lblSalesNewLeads.Size = new System.Drawing.Size(192, 25);
            this.lblSalesNewLeads.TabIndex = 26;
            this.lblSalesNewLeads.Text = "New Leads found:-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(327, 277);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 25);
            this.label5.TabIndex = 27;
            this.label5.Text = "units";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApplication2.Properties.Resources.Top_Banner_11;
            this.pictureBox2.Location = new System.Drawing.Point(-213, 625);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1241, 274);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1224515
            // 
            this.pictureBox1224515.Image = global::WindowsFormsApplication2.Properties.Resources.tlpllogo;
            this.pictureBox1224515.Location = new System.Drawing.Point(556, 38);
            this.pictureBox1224515.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1224515.Name = "pictureBox1224515";
            this.pictureBox1224515.Size = new System.Drawing.Size(220, 148);
            this.pictureBox1224515.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1224515.TabIndex = 1;
            this.pictureBox1224515.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(93, 336);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(233, 25);
            this.label6.TabIndex = 28;
            this.label6.Text = "Achievement Summary";
            // 
            // btnSalesFind
            // 
            this.btnSalesFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalesFind.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalesFind.Location = new System.Drawing.Point(489, 1342);
            this.btnSalesFind.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalesFind.Name = "btnSalesFind";
            this.btnSalesFind.Size = new System.Drawing.Size(51, 25);
            this.btnSalesFind.TabIndex = 1;
            this.btnSalesFind.Text = "Find";
            this.btnSalesFind.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalesFind.UseVisualStyleBackColor = true;
            this.btnSalesFind.Click += new System.EventHandler(this.btnSalesFind_Click);
            this.btnSalesFind.MouseLeave += new System.EventHandler(this.btnSalesFind_MouseLeave);
            this.btnSalesFind.MouseHover += new System.EventHandler(this.btnSalesFind_MouseHover);
            // 
            // txtSalesSalesPersonID
            // 
            this.txtSalesSalesPersonID.DataSource = this.salespersonBindingSource;
            this.txtSalesSalesPersonID.DisplayMember = "employeename";
            this.txtSalesSalesPersonID.FormattingEnabled = true;
            this.txtSalesSalesPersonID.Location = new System.Drawing.Point(232, 233);
            this.txtSalesSalesPersonID.Name = "txtSalesSalesPersonID";
            this.txtSalesSalesPersonID.Size = new System.Drawing.Size(231, 24);
            this.txtSalesSalesPersonID.TabIndex = 29;
            this.txtSalesSalesPersonID.ValueMember = "salespersonid";
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
            // btnSalesUpdate
            // 
            this.btnSalesUpdate.Image = global::WindowsFormsApplication2.Properties.Resources.update_25_252;
            this.btnSalesUpdate.Location = new System.Drawing.Point(478, 567);
            this.btnSalesUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalesUpdate.Name = "btnSalesUpdate";
            this.btnSalesUpdate.Size = new System.Drawing.Size(142, 50);
            this.btnSalesUpdate.TabIndex = 32;
            this.btnSalesUpdate.Text = "Update Details";
            this.btnSalesUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalesUpdate.UseVisualStyleBackColor = true;
            this.btnSalesUpdate.Click += new System.EventHandler(this.btnSalesUpdate_Click_1);
            this.btnSalesUpdate.MouseLeave += new System.EventHandler(this.btnSalesUpdate_MouseLeave);
            this.btnSalesUpdate.MouseHover += new System.EventHandler(this.btnSalesUpdate_MouseHover);
            // 
            // btnSalesDelete
            // 
            this.btnSalesDelete.Image = global::WindowsFormsApplication2.Properties.Resources.delete;
            this.btnSalesDelete.Location = new System.Drawing.Point(311, 567);
            this.btnSalesDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalesDelete.Name = "btnSalesDelete";
            this.btnSalesDelete.Size = new System.Drawing.Size(141, 50);
            this.btnSalesDelete.TabIndex = 31;
            this.btnSalesDelete.Text = "Delete Details";
            this.btnSalesDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalesDelete.UseVisualStyleBackColor = true;
            this.btnSalesDelete.Click += new System.EventHandler(this.btnSalesDelete_Click_1);
            this.btnSalesDelete.MouseLeave += new System.EventHandler(this.btnSalesDelete_MouseLeave);
            this.btnSalesDelete.MouseHover += new System.EventHandler(this.btnSalesDelete_MouseHover);
            // 
            // btnSalesSave
            // 
            this.btnSalesSave.Image = global::WindowsFormsApplication2.Properties.Resources.saveicon;
            this.btnSalesSave.Location = new System.Drawing.Point(171, 567);
            this.btnSalesSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalesSave.Name = "btnSalesSave";
            this.btnSalesSave.Size = new System.Drawing.Size(118, 50);
            this.btnSalesSave.TabIndex = 30;
            this.btnSalesSave.Text = "Save Details";
            this.btnSalesSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalesSave.UseVisualStyleBackColor = true;
            this.btnSalesSave.Click += new System.EventHandler(this.btnSalesSave_Click_1);
            this.btnSalesSave.MouseLeave += new System.EventHandler(this.btnSalesSave_MouseLeave);
            this.btnSalesSave.MouseHover += new System.EventHandler(this.btnSalesSave_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(591, 229);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 132);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1028, 899);
            this.shapeContainer1.TabIndex = 34;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rectangleShape1.BorderWidth = 3;
            this.rectangleShape1.Location = new System.Drawing.Point(588, 226);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(134, 135);
            // 
            // frmSalesRepresentative
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(831, 746);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnSalesUpdate);
            this.Controls.Add(this.btnSalesDelete);
            this.Controls.Add(this.btnSalesSave);
            this.Controls.Add(this.txtSalesSalesPersonID);
            this.Controls.Add(this.btnSalesFind);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSalesMonthlyTarget);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1224515);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmSalesRepresentative";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Person Information";
            this.Load += new System.EventHandler(this.frmEnquirer_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1224515)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salespersonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1224515;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitApplicationToolStripMenuItem1;
        private System.Windows.Forms.TextBox txtSalesMonthlyTarget;
        private System.Windows.Forms.Label lblSalesOrderTaken;
        private System.Windows.Forms.Label lblSalesCustomerVisits;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblSalesNewLeads;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSalesOrderTaken1;
        private System.Windows.Forms.Label lblSalesNewLeads1;
        private System.Windows.Forms.Label lblSalesCustomerVisits1;
        private System.Windows.Forms.Button btnSalesFind;
        private System.Windows.Forms.ComboBox txtSalesSalesPersonID;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource salespersonBindingSource;
        private DataSet2TableAdapters.sales_personTableAdapter sales_personTableAdapter;
        private System.Windows.Forms.Button btnSalesUpdate;
        private System.Windows.Forms.Button btnSalesDelete;
        private System.Windows.Forms.Button btnSalesSave;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}

