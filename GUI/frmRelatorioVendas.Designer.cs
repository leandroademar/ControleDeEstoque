namespace GUI
{
    partial class frmRelatorioVendas
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.SRE_VENDAS_SEPARADASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nControleDataSet2 = new GUI.nControleDataSet2();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SRE_VENDAS_SEPARADASTableAdapter = new GUI.nControleDataSet2TableAdapters.SRE_VENDAS_SEPARADASTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SRE_VENDAS_SEPARADASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nControleDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // SRE_VENDAS_SEPARADASBindingSource
            // 
            this.SRE_VENDAS_SEPARADASBindingSource.DataMember = "SRE_VENDAS_SEPARADAS";
            this.SRE_VENDAS_SEPARADASBindingSource.DataSource = this.nControleDataSet2;
            // 
            // nControleDataSet2
            // 
            this.nControleDataSet2.DataSetName = "nControleDataSet2";
            this.nControleDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.nControleDataSet2, "SRE_VENDAS_SEPARADAS.ven_cod", true));
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SRE_VENDAS_SEPARADASBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1095, 1284);
            this.reportViewer1.TabIndex = 0;
            // 
            // SRE_VENDAS_SEPARADASTableAdapter
            // 
            this.SRE_VENDAS_SEPARADASTableAdapter.ClearBeforeFill = true;
            // 
            // frmRelatorioVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 1284);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmRelatorioVendas";
            this.Text = "Relatório de Vendas";
            this.Load += new System.EventHandler(this.frmRelatorioVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SRE_VENDAS_SEPARADASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nControleDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SRE_VENDAS_SEPARADASBindingSource;
        private nControleDataSet2 nControleDataSet2;
        private nControleDataSet2TableAdapters.SRE_VENDAS_SEPARADASTableAdapter SRE_VENDAS_SEPARADASTableAdapter;
    }
}