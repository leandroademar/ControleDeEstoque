namespace GUI
{
    partial class frmFechamentoCaixa
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
            this.pnlTABCaixa = new System.Windows.Forms.Panel();
            this.dtpMovimento = new System.Windows.Forms.DateTimePicker();
            this.cbxTurno = new System.Windows.Forms.ComboBox();
            this.lblData = new System.Windows.Forms.Label();
            this.lblTurno = new System.Windows.Forms.Label();
            this.gbxTotais = new System.Windows.Forms.GroupBox();
            this.dgvTABCaixas = new System.Windows.Forms.DataGridView();
            this.gbxValores = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtOutros = new System.Windows.Forms.TextBox();
            this.txtMoedas = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCheque = new System.Windows.Forms.TextBox();
            this.txtTEDelet = new System.Windows.Forms.TextBox();
            this.txtCDtks = new System.Windows.Forms.TextBox();
            this.txtCDrede = new System.Windows.Forms.TextBox();
            this.txtCCtks = new System.Windows.Forms.TextBox();
            this.txtCCrede = new System.Windows.Forms.TextBox();
            this.txtDinheiro = new System.Windows.Forms.TextBox();
            this.txtBanese = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnAvulso = new System.Windows.Forms.Button();
            this.btnTransf = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlTABCaixa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTABCaixas)).BeginInit();
            this.gbxValores.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTABCaixa
            // 
            this.pnlTABCaixa.Controls.Add(this.dgvTABCaixas);
            this.pnlTABCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlTABCaixa.Location = new System.Drawing.Point(27, 104);
            this.pnlTABCaixa.Name = "pnlTABCaixa";
            this.pnlTABCaixa.Size = new System.Drawing.Size(1080, 287);
            this.pnlTABCaixa.TabIndex = 0;
            // 
            // dtpMovimento
            // 
            this.dtpMovimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpMovimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMovimento.Location = new System.Drawing.Point(28, 41);
            this.dtpMovimento.Name = "dtpMovimento";
            this.dtpMovimento.Size = new System.Drawing.Size(148, 35);
            this.dtpMovimento.TabIndex = 1;
            // 
            // cbxTurno
            // 
            this.cbxTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTurno.FormattingEnabled = true;
            this.cbxTurno.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbxTurno.Location = new System.Drawing.Point(182, 40);
            this.cbxTurno.Name = "cbxTurno";
            this.cbxTurno.Size = new System.Drawing.Size(88, 37);
            this.cbxTurno.TabIndex = 2;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(23, 9);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(68, 29);
            this.lblData.TabIndex = 3;
            this.lblData.Text = "Data:";
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurno.Location = new System.Drawing.Point(177, 8);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(83, 29);
            this.lblTurno.TabIndex = 4;
            this.lblTurno.Text = "Turno:";
            // 
            // gbxTotais
            // 
            this.gbxTotais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxTotais.Location = new System.Drawing.Point(22, 696);
            this.gbxTotais.Name = "gbxTotais";
            this.gbxTotais.Size = new System.Drawing.Size(1085, 152);
            this.gbxTotais.TabIndex = 7;
            this.gbxTotais.TabStop = false;
            this.gbxTotais.Text = "Totais";
            // 
            // dgvTABCaixas
            // 
            this.dgvTABCaixas.AllowUserToAddRows = false;
            this.dgvTABCaixas.AllowUserToDeleteRows = false;
            this.dgvTABCaixas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTABCaixas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTABCaixas.Location = new System.Drawing.Point(0, 0);
            this.dgvTABCaixas.Name = "dgvTABCaixas";
            this.dgvTABCaixas.ReadOnly = true;
            this.dgvTABCaixas.RowTemplate.Height = 28;
            this.dgvTABCaixas.Size = new System.Drawing.Size(1080, 287);
            this.dgvTABCaixas.TabIndex = 0;
            // 
            // gbxValores
            // 
            this.gbxValores.Controls.Add(this.btnTransf);
            this.gbxValores.Controls.Add(this.btnAvulso);
            this.gbxValores.Controls.Add(this.btnAlterar);
            this.gbxValores.Controls.Add(this.btnSalvar);
            this.gbxValores.Controls.Add(this.label14);
            this.gbxValores.Controls.Add(this.label15);
            this.gbxValores.Controls.Add(this.txtOutros);
            this.gbxValores.Controls.Add(this.txtMoedas);
            this.gbxValores.Controls.Add(this.label13);
            this.gbxValores.Controls.Add(this.label12);
            this.gbxValores.Controls.Add(this.label11);
            this.gbxValores.Controls.Add(this.label10);
            this.gbxValores.Controls.Add(this.label9);
            this.gbxValores.Controls.Add(this.label8);
            this.gbxValores.Controls.Add(this.label7);
            this.gbxValores.Controls.Add(this.label6);
            this.gbxValores.Controls.Add(this.txtCheque);
            this.gbxValores.Controls.Add(this.txtTEDelet);
            this.gbxValores.Controls.Add(this.txtCDtks);
            this.gbxValores.Controls.Add(this.txtCDrede);
            this.gbxValores.Controls.Add(this.txtCCtks);
            this.gbxValores.Controls.Add(this.txtCCrede);
            this.gbxValores.Controls.Add(this.txtDinheiro);
            this.gbxValores.Controls.Add(this.txtBanese);
            this.gbxValores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxValores.Location = new System.Drawing.Point(28, 397);
            this.gbxValores.Name = "gbxValores";
            this.gbxValores.Size = new System.Drawing.Size(1079, 273);
            this.gbxValores.TabIndex = 8;
            this.gbxValores.TabStop = false;
            this.gbxValores.Text = "Valores";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(803, 111);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(137, 29);
            this.label14.TabIndex = 17;
            this.label14.Text = "Outros Val.:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(803, 34);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 29);
            this.label15.TabIndex = 18;
            this.label15.Text = "Moedas:";
            // 
            // txtOutros
            // 
            this.txtOutros.Location = new System.Drawing.Point(803, 143);
            this.txtOutros.Name = "txtOutros";
            this.txtOutros.Size = new System.Drawing.Size(133, 35);
            this.txtOutros.TabIndex = 16;
            this.txtOutros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCCrede_KeyPress);
            // 
            // txtMoedas
            // 
            this.txtMoedas.Location = new System.Drawing.Point(803, 66);
            this.txtMoedas.Name = "txtMoedas";
            this.txtMoedas.Size = new System.Drawing.Size(133, 35);
            this.txtMoedas.TabIndex = 15;
            this.txtMoedas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCCrede_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(605, 111);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 29);
            this.label13.TabIndex = 14;
            this.label13.Text = "Cheque:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(605, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 29);
            this.label12.TabIndex = 14;
            this.label12.Text = "TED Elet.:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(407, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 29);
            this.label11.TabIndex = 14;
            this.label11.Text = "CD Rede:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(407, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 29);
            this.label10.TabIndex = 12;
            this.label10.Text = "CD TKS:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(209, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 29);
            this.label9.TabIndex = 11;
            this.label9.Text = "CC TSK:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(209, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 29);
            this.label8.TabIndex = 10;
            this.label8.Text = "CC Rede:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 29);
            this.label7.TabIndex = 9;
            this.label7.Text = "Dinheiro:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 29);
            this.label6.TabIndex = 8;
            this.label6.Text = "Dep. Banese:";
            // 
            // txtCheque
            // 
            this.txtCheque.Location = new System.Drawing.Point(605, 143);
            this.txtCheque.Name = "txtCheque";
            this.txtCheque.Size = new System.Drawing.Size(133, 35);
            this.txtCheque.TabIndex = 7;
            this.txtCheque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCCrede_KeyPress);
            // 
            // txtTEDelet
            // 
            this.txtTEDelet.Location = new System.Drawing.Point(605, 66);
            this.txtTEDelet.Name = "txtTEDelet";
            this.txtTEDelet.Size = new System.Drawing.Size(133, 35);
            this.txtTEDelet.TabIndex = 6;
            this.txtTEDelet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCCrede_KeyPress);
            // 
            // txtCDtks
            // 
            this.txtCDtks.Location = new System.Drawing.Point(407, 143);
            this.txtCDtks.Name = "txtCDtks";
            this.txtCDtks.Size = new System.Drawing.Size(133, 35);
            this.txtCDtks.TabIndex = 5;
            this.txtCDtks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCCrede_KeyPress);
            // 
            // txtCDrede
            // 
            this.txtCDrede.Location = new System.Drawing.Point(407, 66);
            this.txtCDrede.Name = "txtCDrede";
            this.txtCDrede.Size = new System.Drawing.Size(133, 35);
            this.txtCDrede.TabIndex = 4;
            this.txtCDrede.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCCrede_KeyPress);
            // 
            // txtCCtks
            // 
            this.txtCCtks.Location = new System.Drawing.Point(209, 143);
            this.txtCCtks.Name = "txtCCtks";
            this.txtCCtks.Size = new System.Drawing.Size(133, 35);
            this.txtCCtks.TabIndex = 3;
            this.txtCCtks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCCrede_KeyPress);
            // 
            // txtCCrede
            // 
            this.txtCCrede.Location = new System.Drawing.Point(209, 66);
            this.txtCCrede.Name = "txtCCrede";
            this.txtCCrede.Size = new System.Drawing.Size(133, 35);
            this.txtCCrede.TabIndex = 2;
            this.txtCCrede.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCCrede_KeyPress);
            // 
            // txtDinheiro
            // 
            this.txtDinheiro.Location = new System.Drawing.Point(11, 143);
            this.txtDinheiro.Name = "txtDinheiro";
            this.txtDinheiro.Size = new System.Drawing.Size(133, 35);
            this.txtDinheiro.TabIndex = 1;
            this.txtDinheiro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCCrede_KeyPress);
            // 
            // txtBanese
            // 
            this.txtBanese.Location = new System.Drawing.Point(11, 66);
            this.txtBanese.Name = "txtBanese";
            this.txtBanese.Size = new System.Drawing.Size(133, 35);
            this.txtBanese.TabIndex = 0;
            this.txtBanese.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBanese_KeyPress);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(942, 222);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(130, 45);
            this.btnSalvar.TabIndex = 19;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(809, 222);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(130, 45);
            this.btnAlterar.TabIndex = 20;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnAvulso
            // 
            this.btnAvulso.Location = new System.Drawing.Point(676, 222);
            this.btnAvulso.Name = "btnAvulso";
            this.btnAvulso.Size = new System.Drawing.Size(130, 45);
            this.btnAvulso.TabIndex = 21;
            this.btnAvulso.Text = "Avulso";
            this.btnAvulso.UseVisualStyleBackColor = true;
            // 
            // btnTransf
            // 
            this.btnTransf.Location = new System.Drawing.Point(543, 222);
            this.btnTransf.Name = "btnTransf";
            this.btnTransf.Size = new System.Drawing.Size(130, 45);
            this.btnTransf.TabIndex = 22;
            this.btnTransf.Text = "TED";
            this.btnTransf.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(276, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 45);
            this.button1.TabIndex = 23;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmFechamentoCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 893);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbxValores);
            this.Controls.Add(this.gbxTotais);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.cbxTurno);
            this.Controls.Add(this.dtpMovimento);
            this.Controls.Add(this.pnlTABCaixa);
            this.Name = "frmFechamentoCaixa";
            this.Text = "Fechamento de Caixa";
            this.pnlTABCaixa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTABCaixas)).EndInit();
            this.gbxValores.ResumeLayout(false);
            this.gbxValores.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTABCaixa;
        private System.Windows.Forms.DateTimePicker dtpMovimento;
        private System.Windows.Forms.ComboBox cbxTurno;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.DataGridView dgvTABCaixas;
        private System.Windows.Forms.GroupBox gbxTotais;
        private System.Windows.Forms.GroupBox gbxValores;
        private System.Windows.Forms.Button btnTransf;
        private System.Windows.Forms.Button btnAvulso;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtOutros;
        private System.Windows.Forms.TextBox txtMoedas;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCheque;
        private System.Windows.Forms.TextBox txtTEDelet;
        private System.Windows.Forms.TextBox txtCDtks;
        private System.Windows.Forms.TextBox txtCDrede;
        private System.Windows.Forms.TextBox txtCCtks;
        private System.Windows.Forms.TextBox txtCCrede;
        private System.Windows.Forms.TextBox txtDinheiro;
        private System.Windows.Forms.TextBox txtBanese;
        private System.Windows.Forms.Button button1;
    }
}