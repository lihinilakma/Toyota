namespace WindowsFormsApplication2
{
    partial class frmVisitDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVisitDetails));
            this.txtVisitVisitID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtVisitDate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxVisitType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtVisitVisitDetails = new System.Windows.Forms.RichTextBox();
            this.btnVisitUpdate = new System.Windows.Forms.Button();
            this.btnVisitDelete = new System.Windows.Forms.Button();
            this.btnVisitSave = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitApplicationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2sd = new System.Windows.Forms.PictureBox();
            this.pictureBox122ss = new System.Windows.Forms.PictureBox();
            this.txtVisitSalesPersonID = new System.Windows.Forms.ComboBox();
            this.salespersonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new WindowsFormsApplication2.DataSet2();
            this.sales_personTableAdapter = new WindowsFormsApplication2.DataSet2TableAdapters.sales_personTableAdapter();
            this.btnGenerateVisitID = new System.Windows.Forms.Button();
            this.enquirer_informationTableAdapter1 = new WindowsFormsApplication2.DataSet1TableAdapters.enquirer_informationTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2sd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox122ss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salespersonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtVisitVisitID
            // 
            this.txtVisitVisitID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVisitVisitID.ForeColor = System.Drawing.Color.Red;
            this.txtVisitVisitID.Location = new System.Drawing.Point(323, 190);
            this.txtVisitVisitID.Margin = new System.Windows.Forms.Padding(4);
            this.txtVisitVisitID.MaxLength = 5;
            this.txtVisitVisitID.Name = "txtVisitVisitID";
            this.txtVisitVisitID.Size = new System.Drawing.Size(126, 22);
            this.txtVisitVisitID.TabIndex = 0;
            this.txtVisitVisitID.TextChanged += new System.EventHandler(this.txtVisitVisitID_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 187);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 35;
            this.label2.Text = "Visit ID:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 36);
            this.label1.TabIndex = 34;
            this.label1.Text = "Sales Visit details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 241);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 25);
            this.label3.TabIndex = 38;
            this.label3.Text = "Sales Person:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(60, 292);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 25);
            this.label7.TabIndex = 41;
            this.label7.Text = "Customer visit date:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtVisitDate
            // 
            this.txtVisitDate.Location = new System.Drawing.Point(323, 290);
            this.txtVisitDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtVisitDate.Name = "txtVisitDate";
            this.txtVisitDate.Size = new System.Drawing.Size(247, 22);
            this.txtVisitDate.TabIndex = 2;
            // 
            // comboBoxVisitType
            // 
            this.comboBoxVisitType.FormattingEnabled = true;
            this.comboBoxVisitType.Items.AddRange(new object[] {
            "Prospect customer enquiry",
            "Taking demo vehicle for a test drive",
            "Handing of vehicle brochures",
            "Submittion of quotation",
            "Collection of a payment",
            "Sales promotion with bank"});
            this.comboBoxVisitType.Location = new System.Drawing.Point(323, 342);
            this.comboBoxVisitType.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxVisitType.Name = "comboBoxVisitType";
            this.comboBoxVisitType.Size = new System.Drawing.Size(447, 24);
            this.comboBoxVisitType.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 343);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 25);
            this.label4.TabIndex = 42;
            this.label4.Text = "Visit Type:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(60, 401);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(196, 25);
            this.label8.TabIndex = 44;
            this.label8.Text = "Specify visit details:";
            // 
            // txtVisitVisitDetails
            // 
            this.txtVisitVisitDetails.Location = new System.Drawing.Point(323, 401);
            this.txtVisitVisitDetails.Margin = new System.Windows.Forms.Padding(4);
            this.txtVisitVisitDetails.Name = "txtVisitVisitDetails";
            this.txtVisitVisitDetails.Size = new System.Drawing.Size(447, 115);
            this.txtVisitVisitDetails.TabIndex = 4;
            this.txtVisitVisitDetails.Text = "";
            // 
            // btnVisitUpdate
            // 
            this.btnVisitUpdate.Image = global::WindowsFormsApplication2.Properties.Resources.update_25_252;
            this.btnVisitUpdate.Location = new System.Drawing.Point(449, 524);
            this.btnVisitUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnVisitUpdate.Name = "btnVisitUpdate";
            this.btnVisitUpdate.Size = new System.Drawing.Size(142, 50);
            this.btnVisitUpdate.TabIndex = 7;
            this.btnVisitUpdate.Text = "Update Details";
            this.btnVisitUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVisitUpdate.UseVisualStyleBackColor = true;
            this.btnVisitUpdate.Click += new System.EventHandler(this.btnVisitUpdate_Click);
            this.btnVisitUpdate.MouseLeave += new System.EventHandler(this.btnVisitUpdate_MouseLeave);
            this.btnVisitUpdate.MouseHover += new System.EventHandler(this.btnVisitUpdate_MouseHover);
            // 
            // btnVisitDelete
            // 
            this.btnVisitDelete.Image = global::WindowsFormsApplication2.Properties.Resources.delete;
            this.btnVisitDelete.Location = new System.Drawing.Point(282, 524);
            this.btnVisitDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnVisitDelete.Name = "btnVisitDelete";
            this.btnVisitDelete.Size = new System.Drawing.Size(141, 50);
            this.btnVisitDelete.TabIndex = 6;
            this.btnVisitDelete.Text = "Delete Details";
            this.btnVisitDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVisitDelete.UseVisualStyleBackColor = true;
            this.btnVisitDelete.Click += new System.EventHandler(this.btnVisitDelete_Click);
            this.btnVisitDelete.MouseLeave += new System.EventHandler(this.btnVisitDelete_MouseLeave);
            this.btnVisitDelete.MouseHover += new System.EventHandler(this.btnVisitDelete_MouseHover);
            // 
            // btnVisitSave
            // 
            this.btnVisitSave.Image = global::WindowsFormsApplication2.Properties.Resources.saveicon;
            this.btnVisitSave.Location = new System.Drawing.Point(142, 524);
            this.btnVisitSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnVisitSave.Name = "btnVisitSave";
            this.btnVisitSave.Size = new System.Drawing.Size(118, 50);
            this.btnVisitSave.TabIndex = 5;
            this.btnVisitSave.Text = "Save Details";
            this.btnVisitSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVisitSave.UseVisualStyleBackColor = true;
            this.btnVisitSave.Click += new System.EventHandler(this.btnVisitSave_Click);
            this.btnVisitSave.MouseLeave += new System.EventHandler(this.btnVisitSave_MouseLeave);
            this.btnVisitSave.MouseHover += new System.EventHandler(this.btnVisitSave_MouseHover);
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
            this.menuStrip1.Size = new System.Drawing.Size(833, 26);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 61;
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
            // pictureBox2sd
            // 
            this.pictureBox2sd.Image = global::WindowsFormsApplication2.Properties.Resources.promotion_banner;
            this.pictureBox2sd.Location = new System.Drawing.Point(0, 592);
            this.pictureBox2sd.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2sd.Name = "pictureBox2sd";
            this.pictureBox2sd.Size = new System.Drawing.Size(833, 234);
            this.pictureBox2sd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2sd.TabIndex = 57;
            this.pictureBox2sd.TabStop = false;
            // 
            // pictureBox122ss
            // 
            this.pictureBox122ss.Image = global::WindowsFormsApplication2.Properties.Resources.tlpllogo;
            this.pictureBox122ss.Location = new System.Drawing.Point(551, 46);
            this.pictureBox122ss.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox122ss.Name = "pictureBox122ss";
            this.pictureBox122ss.Size = new System.Drawing.Size(220, 148);
            this.pictureBox122ss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox122ss.TabIndex = 37;
            this.pictureBox122ss.TabStop = false;
            // 
            // txtVisitSalesPersonID
            // 
            this.txtVisitSalesPersonID.DataSource = this.salespersonBindingSource;
            this.txtVisitSalesPersonID.DisplayMember = "employeename";
            this.txtVisitSalesPersonID.FormattingEnabled = true;
            this.txtVisitSalesPersonID.Location = new System.Drawing.Point(323, 241);
            this.txtVisitSalesPersonID.Name = "txtVisitSalesPersonID";
            this.txtVisitSalesPersonID.Size = new System.Drawing.Size(247, 24);
            this.txtVisitSalesPersonID.TabIndex = 62;
            this.txtVisitSalesPersonID.ValueMember = "salespersonid";
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
            // btnGenerateVisitID
            // 
            this.btnGenerateVisitID.Image = global::WindowsFormsApplication2.Properties.Resources.plusicon1;
            this.btnGenerateVisitID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerateVisitID.Location = new System.Drawing.Point(455, 188);
            this.btnGenerateVisitID.Name = "btnGenerateVisitID";
            this.btnGenerateVisitID.Size = new System.Drawing.Size(30, 27);
            this.btnGenerateVisitID.TabIndex = 63;
            this.btnGenerateVisitID.UseVisualStyleBackColor = true;
            this.btnGenerateVisitID.Click += new System.EventHandler(this.btnGenerateVisitID_Click);
            this.btnGenerateVisitID.MouseLeave += new System.EventHandler(this.btnGenerateVisitID_MouseLeave);
            this.btnGenerateVisitID.MouseHover += new System.EventHandler(this.btnGenerateVisitID_MouseHover);
            // 
            // enquirer_informationTableAdapter1
            // 
            this.enquirer_informationTableAdapter1.ClearBeforeFill = true;
            // 
            // frmVisitDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(833, 748);
            this.Controls.Add(this.btnGenerateVisitID);
            this.Controls.Add(this.txtVisitSalesPersonID);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnVisitUpdate);
            this.Controls.Add(this.btnVisitDelete);
            this.Controls.Add(this.btnVisitSave);
            this.Controls.Add(this.pictureBox2sd);
            this.Controls.Add(this.txtVisitVisitDetails);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxVisitType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtVisitDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox122ss);
            this.Controls.Add(this.txtVisitVisitID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmVisitDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Visit details";
            this.Load += new System.EventHandler(this.frmVisitDetails_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2sd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox122ss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salespersonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox122ss;
        private System.Windows.Forms.TextBox txtVisitVisitID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker txtVisitDate;
        private System.Windows.Forms.ComboBox comboBoxVisitType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox txtVisitVisitDetails;
        private System.Windows.Forms.Button btnVisitUpdate;
        private System.Windows.Forms.Button btnVisitDelete;
        private System.Windows.Forms.Button btnVisitSave;
        private System.Windows.Forms.PictureBox pictureBox2sd;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitApplicationToolStripMenuItem1;
        private System.Windows.Forms.ComboBox txtVisitSalesPersonID;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource salespersonBindingSource;
        private DataSet2TableAdapters.sales_personTableAdapter sales_personTableAdapter;
        private System.Windows.Forms.Button btnGenerateVisitID;
        private DataSet1TableAdapters.enquirer_informationTableAdapter enquirer_informationTableAdapter1;
    }
}