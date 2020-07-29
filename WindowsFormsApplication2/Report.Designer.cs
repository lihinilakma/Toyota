namespace WindowsFormsApplication2
{
    partial class frmReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReport));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitApplicationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.enquirerinformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new WindowsFormsApplication2.DataSet1();
            this.enquirer_informationTableAdapter = new WindowsFormsApplication2.DataSet1TableAdapters.enquirer_informationTableAdapter();
            this.btnGenerateQuotation = new System.Windows.Forms.Button();
            this.btnEnquirerFollowup = new System.Windows.Forms.Button();
            this.btnVehicleOrdersTaken = new System.Windows.Forms.Button();
            this.btnAnalyzeFeedback = new System.Windows.Forms.Button();
            this.pictureBox1224adasd515qwsdasd = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enquirerinformationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1224adasd515qwsdasd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(715, 26);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 77;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 209);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 36);
            this.label1.TabIndex = 79;
            this.label1.Text = "Reports Generation";
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
            // btnGenerateQuotation
            // 
            this.btnGenerateQuotation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerateQuotation.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGenerateQuotation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateQuotation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGenerateQuotation.Image = global::WindowsFormsApplication2.Properties.Resources.generatequotation;
            this.btnGenerateQuotation.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGenerateQuotation.Location = new System.Drawing.Point(207, 276);
            this.btnGenerateQuotation.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerateQuotation.Name = "btnGenerateQuotation";
            this.btnGenerateQuotation.Size = new System.Drawing.Size(147, 153);
            this.btnGenerateQuotation.TabIndex = 92;
            this.btnGenerateQuotation.Text = "Print Vehicle Quotation";
            this.btnGenerateQuotation.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGenerateQuotation.UseVisualStyleBackColor = false;
            this.btnGenerateQuotation.Click += new System.EventHandler(this.btnGenerateQuotation_Click);
            // 
            // btnEnquirerFollowup
            // 
            this.btnEnquirerFollowup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnquirerFollowup.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnEnquirerFollowup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnquirerFollowup.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEnquirerFollowup.Image = global::WindowsFormsApplication2.Properties.Resources.enquierfollowup;
            this.btnEnquirerFollowup.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEnquirerFollowup.Location = new System.Drawing.Point(52, 276);
            this.btnEnquirerFollowup.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnquirerFollowup.Name = "btnEnquirerFollowup";
            this.btnEnquirerFollowup.Size = new System.Drawing.Size(147, 153);
            this.btnEnquirerFollowup.TabIndex = 91;
            this.btnEnquirerFollowup.Text = "Follow-up Enquirer Leads";
            this.btnEnquirerFollowup.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEnquirerFollowup.UseVisualStyleBackColor = false;
            this.btnEnquirerFollowup.Click += new System.EventHandler(this.btnEnquirerFollowup_Click);
            // 
            // btnVehicleOrdersTaken
            // 
            this.btnVehicleOrdersTaken.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVehicleOrdersTaken.BackColor = System.Drawing.Color.DarkGreen;
            this.btnVehicleOrdersTaken.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVehicleOrdersTaken.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVehicleOrdersTaken.Image = global::WindowsFormsApplication2.Properties.Resources.vehicleorderstaken;
            this.btnVehicleOrdersTaken.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVehicleOrdersTaken.Location = new System.Drawing.Point(517, 276);
            this.btnVehicleOrdersTaken.Margin = new System.Windows.Forms.Padding(4);
            this.btnVehicleOrdersTaken.Name = "btnVehicleOrdersTaken";
            this.btnVehicleOrdersTaken.Size = new System.Drawing.Size(147, 153);
            this.btnVehicleOrdersTaken.TabIndex = 90;
            this.btnVehicleOrdersTaken.Text = "Vehicle  Orders Taken";
            this.btnVehicleOrdersTaken.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVehicleOrdersTaken.UseVisualStyleBackColor = false;
            this.btnVehicleOrdersTaken.Click += new System.EventHandler(this.btnVehicleOrdersTaken_Click);
            // 
            // btnAnalyzeFeedback
            // 
            this.btnAnalyzeFeedback.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnalyzeFeedback.BackColor = System.Drawing.Color.Teal;
            this.btnAnalyzeFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalyzeFeedback.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAnalyzeFeedback.Image = global::WindowsFormsApplication2.Properties.Resources.analyzefeedbackicon;
            this.btnAnalyzeFeedback.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAnalyzeFeedback.Location = new System.Drawing.Point(362, 276);
            this.btnAnalyzeFeedback.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnalyzeFeedback.Name = "btnAnalyzeFeedback";
            this.btnAnalyzeFeedback.Size = new System.Drawing.Size(147, 153);
            this.btnAnalyzeFeedback.TabIndex = 89;
            this.btnAnalyzeFeedback.Text = "Analyze Feedback";
            this.btnAnalyzeFeedback.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAnalyzeFeedback.UseVisualStyleBackColor = false;
            this.btnAnalyzeFeedback.Click += new System.EventHandler(this.btnAnalyzeFeedback_Click);
            // 
            // pictureBox1224adasd515qwsdasd
            // 
            this.pictureBox1224adasd515qwsdasd.Image = global::WindowsFormsApplication2.Properties.Resources.tlpllogo;
            this.pictureBox1224adasd515qwsdasd.Location = new System.Drawing.Point(465, 45);
            this.pictureBox1224adasd515qwsdasd.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1224adasd515qwsdasd.Name = "pictureBox1224adasd515qwsdasd";
            this.pictureBox1224adasd515qwsdasd.Size = new System.Drawing.Size(220, 148);
            this.pictureBox1224adasd515qwsdasd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1224adasd515qwsdasd.TabIndex = 78;
            this.pictureBox1224adasd515qwsdasd.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication2.Properties.Resources.stocks_banner;
            this.pictureBox1.Location = new System.Drawing.Point(0, 497);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(715, 223);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 93;
            this.pictureBox1.TabStop = false;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(715, 722);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGenerateQuotation);
            this.Controls.Add(this.btnEnquirerFollowup);
            this.Controls.Add(this.btnVehicleOrdersTaken);
            this.Controls.Add(this.btnAnalyzeFeedback);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1224adasd515qwsdasd);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generate Reports";
            this.Load += new System.EventHandler(this.frmReport_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enquirerinformationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1224adasd515qwsdasd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitApplicationToolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1224adasd515qwsdasd;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource enquirerinformationBindingSource;
        private DataSet1TableAdapters.enquirer_informationTableAdapter enquirer_informationTableAdapter;
        private System.Windows.Forms.Button btnVehicleOrdersTaken;
        private System.Windows.Forms.Button btnAnalyzeFeedback;
        private System.Windows.Forms.Button btnEnquirerFollowup;
        private System.Windows.Forms.Button btnGenerateQuotation;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}