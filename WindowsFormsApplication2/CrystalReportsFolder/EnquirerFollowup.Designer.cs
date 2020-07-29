namespace WindowsFormsApplication2.CrystalReportsFolder
{
    partial class EnquirerFollowup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnquirerFollowup));
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            //this.CrystalReportEnquirerFollowup = new WindowsFormsApplication2.CrystalReportsFolder.CrystalReportEnquirerFollowup();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFollowupDate = new System.Windows.Forms.DateTimePicker();
            this.btnSearchDate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(3, 44);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            //this.crystalReportViewer1.ReportSource = this.CrystalReportEnquirerFollowup;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1366, 697);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Date:";
            // 
            // txtFollowupDate
            // 
            this.txtFollowupDate.Location = new System.Drawing.Point(88, 7);
            this.txtFollowupDate.Name = "txtFollowupDate";
            this.txtFollowupDate.Size = new System.Drawing.Size(260, 22);
            this.txtFollowupDate.TabIndex = 2;
            // 
            // btnSearchDate
            // 
            this.btnSearchDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchDate.Image = global::WindowsFormsApplication2.Properties.Resources.search_icon_16;
            this.btnSearchDate.Location = new System.Drawing.Point(354, 2);
            this.btnSearchDate.Name = "btnSearchDate";
            this.btnSearchDate.Size = new System.Drawing.Size(85, 36);
            this.btnSearchDate.TabIndex = 19;
            this.btnSearchDate.Text = "Search";
            this.btnSearchDate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchDate.UseVisualStyleBackColor = true;
            this.btnSearchDate.Click += new System.EventHandler(this.btnSearchDate_Click);
            this.btnSearchDate.MouseLeave += new System.EventHandler(this.btnSearchDate_MouseLeave);
            this.btnSearchDate.MouseHover += new System.EventHandler(this.btnSearchDate_MouseHover);
            // 
            // EnquirerFollowup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1370, 748);
            this.Controls.Add(this.btnSearchDate);
            this.Controls.Add(this.txtFollowupDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.crystalReportViewer1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EnquirerFollowup";
            this.Text = "[REPORT] New Customer Leads";
            this.Load += new System.EventHandler(this.EnquirerFollowup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        //private CrystalReportEnquirerFollowup CrystalReportEnquirerFollowup1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker txtFollowupDate;
        private System.Windows.Forms.Button btnSearchDate;
        //private CrystalReportsFolder.CrystalReportEnquirerFollowup CrystalReportEnquirerFollowup1;
    }
}