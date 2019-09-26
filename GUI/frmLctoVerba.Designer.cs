namespace GUI
{
    partial class frmLctoVerba
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLctoVerba));
            this.label5 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtVlrDep = new System.Windows.Forms.TextBox();
            this.dtpDataDep = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvDeposito = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblValorMerc = new System.Windows.Forms.Label();
            this.lblNegociacao = new System.Windows.Forms.Label();
            this.lblFornec = new System.Windows.Forms.Label();
            this.txtDescProd = new System.Windows.Forms.TextBox();
            this.txtVlrDesc = new System.Windows.Forms.TextBox();
            this.txtVlrMerc = new System.Windows.Forms.TextBox();
            this.txtVlrSaldo = new System.Windows.Forms.TextBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.txtFornec = new System.Windows.Forms.TextBox();
            this.pnBotoes = new System.Windows.Forms.Panel();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btLocalizar = new System.Windows.Forms.Button();
            this.btInserir = new System.Windows.Forms.Button();
            this.pnDados = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeposito)).BeginInit();
            this.pnBotoes.SuspendLayout();
            this.pnDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 88);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 42;
            this.label5.Text = "Quatidade:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.Location = new System.Drawing.Point(162, 84);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(2);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(121, 28);
            this.txtQuantidade.TabIndex = 2;
            this.txtQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtQuantidade_KeyPress);
            this.txtQuantidade.Leave += new System.EventHandler(this.TxtQuantidade_Leave);
            // 
            // txtVlrDep
            // 
            this.txtVlrDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVlrDep.Location = new System.Drawing.Point(496, 127);
            this.txtVlrDep.Margin = new System.Windows.Forms.Padding(2);
            this.txtVlrDep.Name = "txtVlrDep";
            this.txtVlrDep.Size = new System.Drawing.Size(111, 28);
            this.txtVlrDep.TabIndex = 7;
            this.txtVlrDep.TabStop = false;
            this.txtVlrDep.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtVlrDep_KeyDown);
            this.txtVlrDep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtVlrDep_KeyPress);
            this.txtVlrDep.Leave += new System.EventHandler(this.TxtVlrDep_Leave);
            // 
            // dtpDataDep
            // 
            this.dtpDataDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataDep.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataDep.Location = new System.Drawing.Point(360, 127);
            this.dtpDataDep.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDataDep.Name = "dtpDataDep";
            this.dtpDataDep.Size = new System.Drawing.Size(132, 28);
            this.dtpDataDep.TabIndex = 6;
            this.dtpDataDep.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(356, 105);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 41;
            this.label4.Text = "Depósito:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvDeposito);
            this.panel1.Location = new System.Drawing.Point(336, 164);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 134);
            this.panel1.TabIndex = 40;
            // 
            // dgvDeposito
            // 
            this.dgvDeposito.AllowUserToAddRows = false;
            this.dgvDeposito.AllowUserToDeleteRows = false;
            this.dgvDeposito.AllowUserToResizeColumns = false;
            this.dgvDeposito.AllowUserToResizeRows = false;
            this.dgvDeposito.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDeposito.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDeposito.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDeposito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDeposito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDeposito.EnableHeadersVisualStyles = false;
            this.dgvDeposito.Location = new System.Drawing.Point(0, 0);
            this.dgvDeposito.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDeposito.MultiSelect = false;
            this.dgvDeposito.Name = "dgvDeposito";
            this.dgvDeposito.ReadOnly = true;
            this.dgvDeposito.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvDeposito.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvDeposito.RowHeadersVisible = false;
            this.dgvDeposito.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDeposito.RowTemplate.Height = 28;
            this.dgvDeposito.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvDeposito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDeposito.Size = new System.Drawing.Size(271, 134);
            this.dgvDeposito.TabIndex = 0;
            this.dgvDeposito.TabStop = false;
            this.dgvDeposito.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDeposito_CellDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 208);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 39;
            this.label3.Text = "Valor de Saldo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 168);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "Valor de Verba:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 280);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Observação:";
            // 
            // lblValorMerc
            // 
            this.lblValorMerc.AutoSize = true;
            this.lblValorMerc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorMerc.Location = new System.Drawing.Point(10, 128);
            this.lblValorMerc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValorMerc.Name = "lblValorMerc";
            this.lblValorMerc.Size = new System.Drawing.Size(138, 20);
            this.lblValorMerc.TabIndex = 36;
            this.lblValorMerc.Text = "Valor de Mercado:";
            // 
            // lblNegociacao
            // 
            this.lblNegociacao.AutoSize = true;
            this.lblNegociacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNegociacao.Location = new System.Drawing.Point(10, 48);
            this.lblNegociacao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNegociacao.Name = "lblNegociacao";
            this.lblNegociacao.Size = new System.Drawing.Size(97, 20);
            this.lblNegociacao.TabIndex = 35;
            this.lblNegociacao.Text = "Negociação:";
            // 
            // lblFornec
            // 
            this.lblFornec.AutoSize = true;
            this.lblFornec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFornec.Location = new System.Drawing.Point(10, 8);
            this.lblFornec.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFornec.Name = "lblFornec";
            this.lblFornec.Size = new System.Drawing.Size(95, 20);
            this.lblFornec.TabIndex = 30;
            this.lblFornec.Text = "Fornecedor:";
            // 
            // txtDescProd
            // 
            this.txtDescProd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescProd.Location = new System.Drawing.Point(149, 44);
            this.txtDescProd.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescProd.Name = "txtDescProd";
            this.txtDescProd.Size = new System.Drawing.Size(458, 28);
            this.txtDescProd.TabIndex = 1;
            // 
            // txtVlrDesc
            // 
            this.txtVlrDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVlrDesc.Location = new System.Drawing.Point(162, 164);
            this.txtVlrDesc.Margin = new System.Windows.Forms.Padding(2);
            this.txtVlrDesc.Name = "txtVlrDesc";
            this.txtVlrDesc.Size = new System.Drawing.Size(121, 28);
            this.txtVlrDesc.TabIndex = 4;
            this.txtVlrDesc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtVlrDesc_KeyPress);
            this.txtVlrDesc.Leave += new System.EventHandler(this.TxtVlrDesc_Leave);
            // 
            // txtVlrMerc
            // 
            this.txtVlrMerc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVlrMerc.Location = new System.Drawing.Point(162, 124);
            this.txtVlrMerc.Margin = new System.Windows.Forms.Padding(2);
            this.txtVlrMerc.Name = "txtVlrMerc";
            this.txtVlrMerc.Size = new System.Drawing.Size(121, 28);
            this.txtVlrMerc.TabIndex = 3;
            this.txtVlrMerc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtVlrMerc_KeyPress);
            this.txtVlrMerc.Leave += new System.EventHandler(this.TxtVlrMerc_Leave);
            // 
            // txtVlrSaldo
            // 
            this.txtVlrSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVlrSaldo.Location = new System.Drawing.Point(162, 204);
            this.txtVlrSaldo.Margin = new System.Windows.Forms.Padding(2);
            this.txtVlrSaldo.Name = "txtVlrSaldo";
            this.txtVlrSaldo.ReadOnly = true;
            this.txtVlrSaldo.Size = new System.Drawing.Size(121, 28);
            this.txtVlrSaldo.TabIndex = 10;
            this.txtVlrSaldo.TabStop = false;
            this.txtVlrSaldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtVlrSaldo_KeyPress);
            this.txtVlrSaldo.Leave += new System.EventHandler(this.TxtVlrSaldo_Leave);
            // 
            // txtObs
            // 
            this.txtObs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObs.Location = new System.Drawing.Point(25, 302);
            this.txtObs.Margin = new System.Windows.Forms.Padding(2);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(582, 184);
            this.txtObs.TabIndex = 5;
            // 
            // txtFornec
            // 
            this.txtFornec.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFornec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFornec.Location = new System.Drawing.Point(149, 4);
            this.txtFornec.Margin = new System.Windows.Forms.Padding(2);
            this.txtFornec.Name = "txtFornec";
            this.txtFornec.Size = new System.Drawing.Size(458, 28);
            this.txtFornec.TabIndex = 0;
            // 
            // pnBotoes
            // 
            this.pnBotoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnBotoes.Controls.Add(this.btCancelar);
            this.pnBotoes.Controls.Add(this.btSalvar);
            this.pnBotoes.Controls.Add(this.btExcluir);
            this.pnBotoes.Controls.Add(this.btAlterar);
            this.pnBotoes.Controls.Add(this.btLocalizar);
            this.pnBotoes.Controls.Add(this.btInserir);
            this.pnBotoes.Location = new System.Drawing.Point(1, 2);
            this.pnBotoes.Margin = new System.Windows.Forms.Padding(2);
            this.pnBotoes.Name = "pnBotoes";
            this.pnBotoes.Size = new System.Drawing.Size(806, 40);
            this.pnBotoes.TabIndex = 43;
            // 
            // btCancelar
            // 
            this.btCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btCancelar.Image")));
            this.btCancelar.Location = new System.Drawing.Point(180, 4);
            this.btCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(30, 30);
            this.btCancelar.TabIndex = 5;
            this.btCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.BtCancelar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btSalvar.Image")));
            this.btSalvar.Location = new System.Drawing.Point(146, 4);
            this.btSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(30, 30);
            this.btSalvar.TabIndex = 0;
            this.btSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.BtSalvar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btExcluir.Image")));
            this.btExcluir.Location = new System.Drawing.Point(112, 4);
            this.btExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(30, 30);
            this.btExcluir.TabIndex = 3;
            this.btExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.BtExcluir_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btAlterar.Image")));
            this.btAlterar.Location = new System.Drawing.Point(78, 4);
            this.btAlterar.Margin = new System.Windows.Forms.Padding(2);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(30, 30);
            this.btAlterar.TabIndex = 2;
            this.btAlterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.BtAlterar_Click);
            // 
            // btLocalizar
            // 
            this.btLocalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLocalizar.Image = ((System.Drawing.Image)(resources.GetObject("btLocalizar.Image")));
            this.btLocalizar.Location = new System.Drawing.Point(44, 4);
            this.btLocalizar.Margin = new System.Windows.Forms.Padding(2);
            this.btLocalizar.Name = "btLocalizar";
            this.btLocalizar.Size = new System.Drawing.Size(30, 30);
            this.btLocalizar.TabIndex = 1;
            this.btLocalizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btLocalizar.UseVisualStyleBackColor = true;
            this.btLocalizar.Click += new System.EventHandler(this.BtLocalizar_Click);
            // 
            // btInserir
            // 
            this.btInserir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInserir.Image = ((System.Drawing.Image)(resources.GetObject("btInserir.Image")));
            this.btInserir.Location = new System.Drawing.Point(10, 4);
            this.btInserir.Margin = new System.Windows.Forms.Padding(2);
            this.btInserir.Name = "btInserir";
            this.btInserir.Size = new System.Drawing.Size(30, 30);
            this.btInserir.TabIndex = 0;
            this.btInserir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btInserir.UseVisualStyleBackColor = true;
            this.btInserir.Click += new System.EventHandler(this.BtInserir_Click);
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.lblNegociacao);
            this.pnDados.Controls.Add(this.txtFornec);
            this.pnDados.Controls.Add(this.label5);
            this.pnDados.Controls.Add(this.txtObs);
            this.pnDados.Controls.Add(this.txtQuantidade);
            this.pnDados.Controls.Add(this.txtVlrSaldo);
            this.pnDados.Controls.Add(this.txtVlrDep);
            this.pnDados.Controls.Add(this.txtVlrMerc);
            this.pnDados.Controls.Add(this.dtpDataDep);
            this.pnDados.Controls.Add(this.txtVlrDesc);
            this.pnDados.Controls.Add(this.label4);
            this.pnDados.Controls.Add(this.txtDescProd);
            this.pnDados.Controls.Add(this.panel1);
            this.pnDados.Controls.Add(this.lblFornec);
            this.pnDados.Controls.Add(this.label3);
            this.pnDados.Controls.Add(this.lblValorMerc);
            this.pnDados.Controls.Add(this.label2);
            this.pnDados.Controls.Add(this.label1);
            this.pnDados.Location = new System.Drawing.Point(1, 47);
            this.pnDados.Name = "pnDados";
            this.pnDados.Size = new System.Drawing.Size(675, 569);
            this.pnDados.TabIndex = 44;
            // 
            // frmLctoVerba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 639);
            this.Controls.Add(this.pnDados);
            this.Controls.Add(this.pnBotoes);
            this.KeyPreview = true;
            this.Name = "frmLctoVerba";
            this.Text = "Lançamento de Verba";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmLctoVerba_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLctoVerba_KeyDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeposito)).EndInit();
            this.pnBotoes.ResumeLayout(false);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtVlrDep;
        private System.Windows.Forms.DateTimePicker dtpDataDep;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvDeposito;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblValorMerc;
        private System.Windows.Forms.Label lblNegociacao;
        private System.Windows.Forms.Label lblFornec;
        private System.Windows.Forms.TextBox txtDescProd;
        private System.Windows.Forms.TextBox txtVlrDesc;
        private System.Windows.Forms.TextBox txtVlrMerc;
        private System.Windows.Forms.TextBox txtVlrSaldo;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.TextBox txtFornec;
        protected System.Windows.Forms.Panel pnBotoes;
        protected System.Windows.Forms.Button btCancelar;
        protected System.Windows.Forms.Button btSalvar;
        protected System.Windows.Forms.Button btExcluir;
        protected System.Windows.Forms.Button btAlterar;
        protected System.Windows.Forms.Button btLocalizar;
        protected System.Windows.Forms.Button btInserir;
        private System.Windows.Forms.Panel pnDados;
    }
}