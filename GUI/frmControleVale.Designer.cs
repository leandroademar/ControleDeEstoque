namespace GUI
{
    partial class frmControleVale
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtFornec = new System.Windows.Forms.TextBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.txtVlrSaldo = new System.Windows.Forms.TextBox();
            this.txtVlrMerc = new System.Windows.Forms.TextBox();
            this.txtVlrDesc = new System.Windows.Forms.TextBox();
            this.txtDescProd = new System.Windows.Forms.TextBox();
            this.lblFornec = new System.Windows.Forms.Label();
            this.lblNegociacao = new System.Windows.Forms.Label();
            this.lblValorMerc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvDeposito = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDataDep = new System.Windows.Forms.DateTimePicker();
            this.txtVlrDep = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.pnDados.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeposito)).BeginInit();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.label5);
            this.pnDados.Controls.Add(this.txtQuantidade);
            this.pnDados.Controls.Add(this.txtVlrDep);
            this.pnDados.Controls.Add(this.dtpDataDep);
            this.pnDados.Controls.Add(this.label4);
            this.pnDados.Controls.Add(this.panel1);
            this.pnDados.Controls.Add(this.label3);
            this.pnDados.Controls.Add(this.label2);
            this.pnDados.Controls.Add(this.label1);
            this.pnDados.Controls.Add(this.lblValorMerc);
            this.pnDados.Controls.Add(this.lblNegociacao);
            this.pnDados.Controls.Add(this.lblFornec);
            this.pnDados.Controls.Add(this.txtDescProd);
            this.pnDados.Controls.Add(this.txtVlrDesc);
            this.pnDados.Controls.Add(this.txtVlrMerc);
            this.pnDados.Controls.Add(this.txtVlrSaldo);
            this.pnDados.Controls.Add(this.txtObs);
            this.pnDados.Controls.Add(this.txtFornec);
            this.pnDados.Margin = new System.Windows.Forms.Padding(1);
            this.pnDados.Size = new System.Drawing.Size(848, 490);
            // 
            // pnBotoes
            // 
            this.pnBotoes.Margin = new System.Windows.Forms.Padding(1);
            this.pnBotoes.Size = new System.Drawing.Size(875, 40);
            // 
            // btCancelar
            // 
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.TabIndex = 0;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.TabIndex = 4;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.TabIndex = 3;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btLocalizar
            // 
            this.btLocalizar.TabIndex = 2;
            this.btLocalizar.Click += new System.EventHandler(this.btLocalizar_Click);
            // 
            // btInserir
            // 
            this.btInserir.TabIndex = 1;
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // txtFornec
            // 
            this.txtFornec.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFornec.Location = new System.Drawing.Point(99, 16);
            this.txtFornec.Margin = new System.Windows.Forms.Padding(2);
            this.txtFornec.Name = "txtFornec";
            this.txtFornec.Size = new System.Drawing.Size(407, 20);
            this.txtFornec.TabIndex = 0;
            // 
            // txtObs
            // 
            this.txtObs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObs.Location = new System.Drawing.Point(21, 197);
            this.txtObs.Margin = new System.Windows.Forms.Padding(2);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(485, 209);
            this.txtObs.TabIndex = 5;
            // 
            // txtVlrSaldo
            // 
            this.txtVlrSaldo.Location = new System.Drawing.Point(99, 162);
            this.txtVlrSaldo.Margin = new System.Windows.Forms.Padding(2);
            this.txtVlrSaldo.Name = "txtVlrSaldo";
            this.txtVlrSaldo.ReadOnly = true;
            this.txtVlrSaldo.Size = new System.Drawing.Size(121, 20);
            this.txtVlrSaldo.TabIndex = 1;
            this.txtVlrSaldo.TabStop = false;
            this.txtVlrSaldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            this.txtVlrSaldo.Leave += new System.EventHandler(this.txtVlrSaldo_Leave);
            // 
            // txtVlrMerc
            // 
            this.txtVlrMerc.Location = new System.Drawing.Point(99, 104);
            this.txtVlrMerc.Margin = new System.Windows.Forms.Padding(2);
            this.txtVlrMerc.Name = "txtVlrMerc";
            this.txtVlrMerc.Size = new System.Drawing.Size(121, 20);
            this.txtVlrMerc.TabIndex = 3;
            this.txtVlrMerc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            this.txtVlrMerc.Leave += new System.EventHandler(this.txtVlrMerc_Leave);
            // 
            // txtVlrDesc
            // 
            this.txtVlrDesc.Location = new System.Drawing.Point(99, 133);
            this.txtVlrDesc.Margin = new System.Windows.Forms.Padding(2);
            this.txtVlrDesc.Name = "txtVlrDesc";
            this.txtVlrDesc.Size = new System.Drawing.Size(121, 20);
            this.txtVlrDesc.TabIndex = 4;
            this.txtVlrDesc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            this.txtVlrDesc.Leave += new System.EventHandler(this.txtVlrDesc_Leave);
            // 
            // txtDescProd
            // 
            this.txtDescProd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescProd.Location = new System.Drawing.Point(99, 45);
            this.txtDescProd.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescProd.Name = "txtDescProd";
            this.txtDescProd.Size = new System.Drawing.Size(407, 20);
            this.txtDescProd.TabIndex = 1;
            // 
            // lblFornec
            // 
            this.lblFornec.AutoSize = true;
            this.lblFornec.Location = new System.Drawing.Point(31, 18);
            this.lblFornec.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFornec.Name = "lblFornec";
            this.lblFornec.Size = new System.Drawing.Size(64, 13);
            this.lblFornec.TabIndex = 3;
            this.lblFornec.Text = "Fornecedor:";
            // 
            // lblNegociacao
            // 
            this.lblNegociacao.AutoSize = true;
            this.lblNegociacao.Location = new System.Drawing.Point(29, 47);
            this.lblNegociacao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNegociacao.Name = "lblNegociacao";
            this.lblNegociacao.Size = new System.Drawing.Size(68, 13);
            this.lblNegociacao.TabIndex = 14;
            this.lblNegociacao.Text = "Negociação:";
            // 
            // lblValorMerc
            // 
            this.lblValorMerc.AutoSize = true;
            this.lblValorMerc.Location = new System.Drawing.Point(2, 106);
            this.lblValorMerc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValorMerc.Name = "lblValorMerc";
            this.lblValorMerc.Size = new System.Drawing.Size(94, 13);
            this.lblValorMerc.TabIndex = 15;
            this.lblValorMerc.Text = "Valor de Mercado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 182);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Observação:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Valor de Verba:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Valor de Saldo:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvDeposito);
            this.panel1.Location = new System.Drawing.Point(310, 112);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 81);
            this.panel1.TabIndex = 19;
            // 
            // dgvDeposito
            // 
            this.dgvDeposito.AllowUserToAddRows = false;
            this.dgvDeposito.AllowUserToDeleteRows = false;
            this.dgvDeposito.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDeposito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeposito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDeposito.Location = new System.Drawing.Point(0, 0);
            this.dgvDeposito.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDeposito.Name = "dgvDeposito";
            this.dgvDeposito.ReadOnly = true;
            this.dgvDeposito.RowTemplate.Height = 28;
            this.dgvDeposito.Size = new System.Drawing.Size(195, 81);
            this.dgvDeposito.TabIndex = 0;
            this.dgvDeposito.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 77);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Depósito:";
            // 
            // dtpDataDep
            // 
            this.dtpDataDep.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataDep.Location = new System.Drawing.Point(310, 75);
            this.dtpDataDep.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDataDep.Name = "dtpDataDep";
            this.dtpDataDep.Size = new System.Drawing.Size(97, 20);
            this.dtpDataDep.TabIndex = 11;
            this.dtpDataDep.TabStop = false;
            // 
            // txtVlrDep
            // 
            this.txtVlrDep.Location = new System.Drawing.Point(413, 75);
            this.txtVlrDep.Margin = new System.Windows.Forms.Padding(2);
            this.txtVlrDep.Name = "txtVlrDep";
            this.txtVlrDep.Size = new System.Drawing.Size(93, 20);
            this.txtVlrDep.TabIndex = 9;
            this.txtVlrDep.TabStop = false;
            this.txtVlrDep.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.txtVlrDep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.txtVlrDep.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 77);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Quatidade:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(99, 75);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(2);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(121, 20);
            this.txtQuantidade.TabIndex = 2;
            this.txtQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidade_KeyPress);
            this.txtQuantidade.Leave += new System.EventHandler(this.txtQuantidade_Leave);
            // 
            // frmControleVale
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(866, 547);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "frmControleVale";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Controle de Vale e Bonificação";
            this.Load += new System.EventHandler(this.frmControleVale_Load);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeposito)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtFornec;
        private System.Windows.Forms.TextBox txtDescProd;
        private System.Windows.Forms.TextBox txtVlrDesc;
        private System.Windows.Forms.TextBox txtVlrMerc;
        private System.Windows.Forms.TextBox txtVlrSaldo;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Label lblFornec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblValorMerc;
        private System.Windows.Forms.Label lblNegociacao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVlrDep;
        private System.Windows.Forms.DateTimePicker dtpDataDep;
        private System.Windows.Forms.DataGridView dgvDeposito;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQuantidade;
    }
}
