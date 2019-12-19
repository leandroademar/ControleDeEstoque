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
<<<<<<< HEAD
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.SRE_VENDAS_SEPARADASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nControleDataSet2 = new GUI.nControleDataSet2();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SRE_VENDAS_SEPARADASTableAdapter = new GUI.nControleDataSet2TableAdapters.SRE_VENDAS_SEPARADASTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SRE_VENDAS_SEPARADASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nControleDataSet2)).BeginInit();
=======
            this.crvRelatorio = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.RelVendasSeparas1 = new GUI.Relatórios.RelVendasSeparas();
            this.RelVendasSeparas2 = new GUI.Relatórios.RelVendasSeparas();
            this.nControleDataSet1 = new GUI.nControleDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.nControleDataSet1)).BeginInit();
>>>>>>> parent of 495a4ae... Atualização Geral
            this.SuspendLayout();
            // 
            // SRE_VENDAS_SEPARADASBindingSource
            // 
<<<<<<< HEAD
            this.SRE_VENDAS_SEPARADASBindingSource.DataMember = "SRE_VENDAS_SEPARADAS";
            this.SRE_VENDAS_SEPARADASBindingSource.DataSource = this.nControleDataSet2;
=======
            this.crvRelatorio.ActiveViewIndex = 0;
            this.crvRelatorio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvRelatorio.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvRelatorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvRelatorio.Location = new System.Drawing.Point(0, 0);
            this.crvRelatorio.Name = "crvRelatorio";
            this.crvRelatorio.ReportSource = this.RelVendasSeparas2;
            this.crvRelatorio.ShowCopyButton = false;
            this.crvRelatorio.ShowParameterPanelButton = false;
            this.crvRelatorio.ShowTextSearchButton = false;
            this.crvRelatorio.ShowZoomButton = false;
            this.crvRelatorio.Size = new System.Drawing.Size(896, 852);
            this.crvRelatorio.TabIndex = 0;
>>>>>>> parent of 495a4ae... Atualização Geral
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
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(597, 554);
            this.reportViewer1.TabIndex = 0;
            // 
            // SRE_VENDAS_SEPARADASTableAdapter
            // 
            this.SRE_VENDAS_SEPARADASTableAdapter.ClearBeforeFill = true;
            // 
            // frmRelatorioVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(597, 554);
            this.Controls.Add(this.reportViewer1);
=======
            this.ClientSize = new System.Drawing.Size(896, 852);
            this.Controls.Add(this.crvRelatorio);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
>>>>>>> parent of 495a4ae... Atualização Geral
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