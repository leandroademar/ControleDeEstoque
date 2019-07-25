namespace GUI
{
    partial class frmParametroRel
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
            this.dtpInicial = new System.Windows.Forms.DateTimePicker();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtPendente = new System.Windows.Forms.RadioButton();
            this.rbtFaturado = new System.Windows.Forms.RadioButton();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblDtIni = new System.Windows.Forms.Label();
            this.lblDtFim = new System.Windows.Forms.Label();
            this.lblTipoRel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpInicial
            // 
            this.dtpInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicial.Location = new System.Drawing.Point(22, 65);
            this.dtpInicial.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtpInicial.Name = "dtpInicial";
            this.dtpInicial.Size = new System.Drawing.Size(173, 29);
            this.dtpInicial.TabIndex = 0;
            // 
            // dtpFinal
            // 
            this.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinal.Location = new System.Drawing.Point(235, 65);
            this.dtpFinal.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(173, 29);
            this.dtpFinal.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtPendente);
            this.groupBox1.Controls.Add(this.rbtFaturado);
            this.groupBox1.Location = new System.Drawing.Point(22, 199);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(403, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            // 
            // rbtPendente
            // 
            this.rbtPendente.AutoSize = true;
            this.rbtPendente.Location = new System.Drawing.Point(213, 35);
            this.rbtPendente.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rbtPendente.Name = "rbtPendente";
            this.rbtPendente.Size = new System.Drawing.Size(121, 29);
            this.rbtPendente.TabIndex = 1;
            this.rbtPendente.TabStop = true;
            this.rbtPendente.Text = "Pendente";
            this.rbtPendente.UseVisualStyleBackColor = true;
            // 
            // rbtFaturado
            // 
            this.rbtFaturado.AutoSize = true;
            this.rbtFaturado.Location = new System.Drawing.Point(20, 35);
            this.rbtFaturado.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rbtFaturado.Name = "rbtFaturado";
            this.rbtFaturado.Size = new System.Drawing.Size(115, 29);
            this.rbtFaturado.TabIndex = 0;
            this.rbtFaturado.TabStop = true;
            this.rbtFaturado.Text = "Faturado";
            this.rbtFaturado.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(139, 319);
            this.btnOk.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(138, 54);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "Imprimir";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(288, 319);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(138, 54);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblDtIni
            // 
            this.lblDtIni.AutoSize = true;
            this.lblDtIni.Location = new System.Drawing.Point(17, 35);
            this.lblDtIni.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDtIni.Name = "lblDtIni";
            this.lblDtIni.Size = new System.Drawing.Size(107, 25);
            this.lblDtIni.TabIndex = 5;
            this.lblDtIni.Text = "Data Inicial";
            // 
            // lblDtFim
            // 
            this.lblDtFim.AutoSize = true;
            this.lblDtFim.Location = new System.Drawing.Point(229, 35);
            this.lblDtFim.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDtFim.Name = "lblDtFim";
            this.lblDtFim.Size = new System.Drawing.Size(100, 25);
            this.lblDtFim.TabIndex = 6;
            this.lblDtFim.Text = "Data Final";
            // 
            // lblTipoRel
            // 
            this.lblTipoRel.AutoSize = true;
            this.lblTipoRel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoRel.Location = new System.Drawing.Point(15, 126);
            this.lblTipoRel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTipoRel.Name = "lblTipoRel";
            this.lblTipoRel.Size = new System.Drawing.Size(243, 38);
            this.lblTipoRel.TabIndex = 7;
            this.lblTipoRel.Text = "Nome Relatorio";
            // 
            // frmParametroRel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(442, 395);
            this.Controls.Add(this.lblTipoRel);
            this.Controls.Add(this.lblDtFim);
            this.Controls.Add(this.lblDtIni);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpFinal);
            this.Controls.Add(this.dtpInicial);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmParametroRel";
            this.Text = "Filtros de Relatório";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmParametroRel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpInicial;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblDtIni;
        private System.Windows.Forms.Label lblDtFim;
        private System.Windows.Forms.RadioButton rbtPendente;
        private System.Windows.Forms.RadioButton rbtFaturado;
        private System.Windows.Forms.Label lblTipoRel;
    }
}