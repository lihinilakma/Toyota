namespace WindowsFormsApplication2.CrystalReportsFolder
{
    partial class FeedbackAnalyze
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FeedbackAnalyze));
            this.crystalReportViewer222 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrystalReportAnalyzeFeedback11 = new WindowsFormsApplication2.CrystalReportsFolder.CrystalReportAnalyzeFeedback1();
            this.SuspendLayout();
            // 
            // crystalReportViewer222
            // 
            this.crystalReportViewer222.ActiveViewIndex = 0;
            this.crystalReportViewer222.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer222.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer222.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer222.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer222.Name = "crystalReportViewer222";
            this.crystalReportViewer222.ReportSource = this.CrystalReportAnalyzeFeedback11;
            this.crystalReportViewer222.Size = new System.Drawing.Size(1370, 748);
            this.crystalReportViewer222.TabIndex = 0;
            this.crystalReportViewer222.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crystalReportViewer222.Load += new System.EventHandler(this.crystalReportViewer222_Load);
            // 
            // FeedbackAnalyze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 748);
            this.Controls.Add(this.crystalReportViewer222);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FeedbackAnalyze";
            this.Text = "[REPORT] Analysis of Customer Feedback";
            this.Load += new System.EventHandler(this.FeedbackAnalyze_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalReportAnalyzeFeedback1 CrystalReportAnalyzeFeedback1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer222;
        private CrystalReportAnalyzeFeedback1 CrystalReportAnalyzeFeedback11;
    }
}