using WindowsFormsApplication2.CrystalReportsFolder;
namespace WindowsFormsApplication2
{
    partial class QuotationCrystalReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuotationCrystalReport));
            this.crystalReportViewer2 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrystalReporthelp1 = new WindowsFormsApplication2.CrystalReportsFolder.CrystalReportGenerateQuotation();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuotationQuotationID = new System.Windows.Forms.TextBox();
            this.btnSearchQuotation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crystalReportViewer2
            // 
            this.crystalReportViewer2.ActiveViewIndex = 0;
            this.crystalReportViewer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer2.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer2.Location = new System.Drawing.Point(12, 46);
            this.crystalReportViewer2.Name = "crystalReportViewer2";
            this.crystalReportViewer2.ReportSource = this.CrystalReporthelp1;
            this.crystalReportViewer2.Size = new System.Drawing.Size(1357, 700);
            this.crystalReportViewer2.TabIndex = 0;
            this.crystalReportViewer2.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Quotation ID:";
            // 
            // txtQuotationQuotationID
            // 
            this.txtQuotationQuotationID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtQuotationQuotationID.ForeColor = System.Drawing.Color.Red;
            this.txtQuotationQuotationID.Location = new System.Drawing.Point(103, 11);
            this.txtQuotationQuotationID.MaxLength = 5;
            this.txtQuotationQuotationID.Name = "txtQuotationQuotationID";
            this.txtQuotationQuotationID.Size = new System.Drawing.Size(100, 22);
            this.txtQuotationQuotationID.TabIndex = 17;
            // 
            // btnSearchQuotation
            // 
            this.btnSearchQuotation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchQuotation.Image = global::WindowsFormsApplication2.Properties.Resources.search_icon_16;
            this.btnSearchQuotation.Location = new System.Drawing.Point(209, 4);
            this.btnSearchQuotation.Name = "btnSearchQuotation";
            this.btnSearchQuotation.Size = new System.Drawing.Size(85, 36);
            this.btnSearchQuotation.TabIndex = 18;
            this.btnSearchQuotation.Text = "Search";
            this.btnSearchQuotation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchQuotation.UseVisualStyleBackColor = true;
            this.btnSearchQuotation.Click += new System.EventHandler(this.btnSearchInvoice_Click);
            this.btnSearchQuotation.MouseLeave += new System.EventHandler(this.btnSearchQuotation_MouseLeave);
            this.btnSearchQuotation.MouseHover += new System.EventHandler(this.btnSearchInvoice_MouseHover);
            // 
            // QuotationCrystalReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1370, 748);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQuotationQuotationID);
            this.Controls.Add(this.btnSearchQuotation);
            this.Controls.Add(this.crystalReportViewer2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QuotationCrystalReport";
            this.Text = "[REPORT] Generate Quotation";
            this.Load += new System.EventHandler(this.QuotationCrystalReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer2;
        private CrystalReportGenerateQuotation CrystalReporthelp1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtQuotationQuotationID;
        private System.Windows.Forms.Button btnSearchQuotation;
        private CrystalReportsFolder.CrystalReportGenerateQuotation CrystalReportGenerateQuotation;
    }
}