﻿namespace GUI
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
            this.SuspendLayout();
            // 
            // crvRelatorio
            // 
            this.crvRelatorio.ActiveViewIndex = -1;
            this.crvRelatorio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvRelatorio.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvRelatorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvRelatorio.Location = new System.Drawing.Point(0, 0);
            this.crvRelatorio.Name = "crvRelatorio";
            this.crvRelatorio.ShowCopyButton = false;
            this.crvRelatorio.ShowLogo = false;
            this.crvRelatorio.ShowParameterPanelButton = false;
            this.crvRelatorio.ShowTextSearchButton = false;
            this.crvRelatorio.ShowZoomButton = false;
            this.crvRelatorio.Size = new System.Drawing.Size(896, 852);
            this.crvRelatorio.TabIndex = 0;
            // 
            // frmRelatorioVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 852);
            this.Controls.Add(this.crvRelatorio);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmRelatorioVendas";
            this.Text = "Relatório de Vendas";
            this.Load += new System.EventHandler(this.frmRelatorioVendas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvRelatorio;
    }
}