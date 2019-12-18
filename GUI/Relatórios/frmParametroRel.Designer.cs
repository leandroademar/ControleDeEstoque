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
            this.dtpInicial.Location = new System.Drawing.Point(15, 67);
            this.dtpInicial.Name = "dtpInicial";
            this.dtpInicial.Size = new System.Drawing.Size(96, 20);
            this.dtpInicial.TabIndex = 0;
            // 
            // dtpFinal
            // 
            this.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinal.Location = new System.Drawing.Point(131, 67);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(96, 20);
            this.dtpFinal.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtPendente);
            this.groupBox1.Controls.Add(this.rbtFaturado);
            this.groupBox1.Location = new System.Drawing.Point(4, 302);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 54);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            // 
            // rbtPendente
            // 
            this.rbtPendente.AutoSize = true;
            this.rbtPendente.Location = new System.Drawing.Point(116, 19);
            this.rbtPendente.Name = "rbtPendente";
            this.rbtPendente.Size = new System.Drawing.Size(78, 20);
            this.rbtPendente.TabIndex = 1;
            this.rbtPendente.TabStop = true;
            this.rbtPendente.Text = "Pendente";
            this.rbtPendente.UseVisualStyleBackColor = true;
            // 
            // rbtFaturado
            // 
            this.rbtFaturado.AutoSize = true;
            this.rbtFaturado.Location = new System.Drawing.Point(11, 19);
            this.rbtFaturado.Name = "rbtFaturado";
            this.rbtFaturado.Size = new System.Drawing.Size(74, 20);
            this.rbtFaturado.TabIndex = 0;
            this.rbtFaturado.TabStop = true;
            this.rbtFaturado.Text = "Faturado";
            this.rbtFaturado.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(231, 63);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 29);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "Imprimir";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(312, 63);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 29);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblDtIni
            // 
            this.lblDtIni.AutoSize = true;
            this.lblDtIni.Location = new System.Drawing.Point(12, 51);
            this.lblDtIni.Name = "lblDtIni";
            this.lblDtIni.Size = new System.Drawing.Size(60, 13);
            this.lblDtIni.TabIndex = 5;
            this.lblDtIni.Text = "Data Inicial";
            // 
            // lblDtFim
            // 
            this.lblDtFim.AutoSize = true;
            this.lblDtFim.Location = new System.Drawing.Point(128, 51);
            this.lblDtFim.Name = "lblDtFim";
            this.lblDtFim.Size = new System.Drawing.Size(55, 13);
            this.lblDtFim.TabIndex = 6;
            this.lblDtFim.Text = "Data Final";
            // 
            // lblTipoRel
            // 
            this.lblTipoRel.AutoSize = true;
            this.lblTipoRel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoRel.Location = new System.Drawing.Point(9, 9);
            this.lblTipoRel.Name = "lblTipoRel";
            this.lblTipoRel.Size = new System.Drawing.Size(212, 32);
            this.lblTipoRel.TabIndex = 7;
            this.lblTipoRel.Text = "Nome Relatorio";
            // 
            // frmParametroRel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(459, 447);
            this.Controls.Add(this.lblTipoRel);
            this.Controls.Add(this.lblDtFim);
            this.Controls.Add(this.lblDtIni);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpFinal);
            this.Controls.Add(this.dtpInicial);
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