namespace WindowsFormsApplication2.CrystalReportsFolder
{
    partial class VehicleOrdersTaken
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehicleOrdersTaken));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.salespersonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new WindowsFormsApplication2.DataSet2();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchSalesPersonID = new System.Windows.Forms.Button();
            this.crystalReportViewer5 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrystalReportVehicleOrdersTaken1 = new WindowsFormsApplication2.CrystalReportsFolder.CrystalReportVehicleOrdersTaken();
            this.sales_personTableAdapter = new WindowsFormsApplication2.DataSet2TableAdapters.sales_personTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.salespersonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.salespersonBindingSource;
            this.comboBox1.DisplayMember = "employeename";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(130, 9);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(212, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "salespersonid";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sales Person:";
            // 
            // btnSearchSalesPersonID
            // 
            this.btnSearchSalesPersonID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchSalesPersonID.Image = global::WindowsFormsApplication2.Properties.Resources.search_icon_16;
            this.btnSearchSalesPersonID.Location = new System.Drawing.Point(348, 3);
            this.btnSearchSalesPersonID.Name = "btnSearchSalesPersonID";
            this.btnSearchSalesPersonID.Size = new System.Drawing.Size(85, 36);
            this.btnSearchSalesPersonID.TabIndex = 19;
            this.btnSearchSalesPersonID.Text = "Search";
            this.btnSearchSalesPersonID.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchSalesPersonID.UseVisualStyleBackColor = true;
            this.btnSearchSalesPersonID.Click += new System.EventHandler(this.btnSearchSalesPersonID_Click);
            this.btnSearchSalesPersonID.MouseLeave += new System.EventHandler(this.btnSearchSalesPersonID_MouseLeave);
            this.btnSearchSalesPersonID.MouseHover += new System.EventHandler(this.btnSearchSalesPersonID_MouseHover);
            // 
            // crystalReportViewer5
            // 
            this.crystalReportViewer5.ActiveViewIndex = 0;
            this.crystalReportViewer5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer5.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer5.Location = new System.Drawing.Point(-3, 45);
            this.crystalReportViewer5.Name = "crystalReportViewer5";
            this.crystalReportViewer5.ReportSource = this.CrystalReportVehicleOrdersTaken1;
            this.crystalReportViewer5.Size = new System.Drawing.Size(1361, 696);
            this.crystalReportViewer5.TabIndex = 20;
            this.crystalReportViewer5.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // sales_personTableAdapter
            // 
            this.sales_personTableAdapter.ClearBeforeFill = true;
            // 
            // VehicleOrdersTaken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1370, 748);
            this.Controls.Add(this.crystalReportViewer5);
            this.Controls.Add(this.btnSearchSalesPersonID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VehicleOrdersTaken";
            this.Text = "[REPORT] New Vehicle Orders Taken";
            this.Load += new System.EventHandler(this.VehicleOrdersTaken_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salespersonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchSalesPersonID;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer5;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource salespersonBindingSource;
        private DataSet2TableAdapters.sales_personTableAdapter sales_personTableAdapter;
        private CrystalReportVehicleOrdersTaken CrystalReportVehicleOrdersTaken1;
    }
}