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
            this.crvRelatorio = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.RelVendasSeparas2 = new GUI.Relatórios.RelVendasSeparas();
            this.RelVendasSeparas1 = new GUI.Relatórios.RelVendasSeparas();
            this.nControleDataSet1 = new GUI.nControleDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.nControleDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // crvRelatorio
            // 
            this.crvRelatorio.ActiveViewIndex = 0;
            this.crvRelatorio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvRelatorio.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvRelatorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvRelatorio.Location = new System.Drawing.Point(0, 0);
            this.crvRelatorio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.crvRelatorio.Name = "crvRelatorio";
            this.crvRelatorio.ReportSource = this.RelVendasSeparas2;
            this.crvRelatorio.ShowCopyButton = false;
            this.crvRelatorio.ShowParameterPanelButton = false;
            this.crvRelatorio.ShowTextSearchButton = false;
            this.crvRelatorio.ShowZoomButton = false;
            this.crvRelatorio.Size = new System.Drawing.Size(1512, 920);
            this.crvRelatorio.TabIndex = 0;
            this.crvRelatorio.ToolPanelWidth = 133;
            // 
            // nControleDataSet1
            // 
            this.nControleDataSet1.DataSetName = "nControleDataSet";
            this.nControleDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmRelatorioVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1512, 920);
            this.Controls.Add(this.crvRelatorio);
            this.Name = "frmRelatorioVendas";
            this.Text = "Relatório de Vendas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRelatorioVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nControleDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvRelatorio;
        private Relatórios.RelVendasSeparas RelVendasSeparas2;
        private Relatórios.RelVendasSeparas RelVendasSeparas1;
        private nControleDataSet nControleDataSet1;
    }
}