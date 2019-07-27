namespace GUI
{
    partial class frmMovimentacaoVenda
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.txtVenCod = new System.Windows.Forms.TextBox();
            this.txtNomeCli = new System.Windows.Forms.TextBox();
            this.txtNomeAtend = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lblAtend = new System.Windows.Forms.Label();
            this.lblNomeCli = new System.Windows.Forms.Label();
            this.lblVenCod = new System.Windows.Forms.Label();
            this.btnLocaliza = new System.Windows.Forms.Button();
            this.gpbRecebimento = new System.Windows.Forms.GroupBox();
            this.lblDin = new System.Windows.Forms.Label();
            this.lblCart = new System.Windows.Forms.Label();
            this.lblWinthor = new System.Windows.Forms.Label();
            this.lblTotalPed = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtCart = new System.Windows.Forms.TextBox();
            this.txtWint = new System.Windows.Forms.TextBox();
            this.txtVlrPed = new System.Windows.Forms.TextBox();
            this.txtTot = new System.Windows.Forms.TextBox();
            this.btnGrava = new System.Windows.Forms.Button();
            this.btnCancela = new System.Windows.Forms.Button();
            this.lblTot = new System.Windows.Forms.Label();
            this.btImprimir = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.abrirCaixaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharCaixaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarTEDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCaixa = new System.Windows.Forms.Label();
            this.btnTED = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gpbRecebimento.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProdutos.BackgroundColor = System.Drawing.SystemColors.Desktop;
            this.dgvProdutos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProdutos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvProdutos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProdutos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dgvProdutos.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvProdutos.Location = new System.Drawing.Point(660, 12);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProdutos.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProdutos.RowHeadersVisible = false;
            this.dgvProdutos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dgvProdutos.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvProdutos.RowTemplate.Height = 28;
            this.dgvProdutos.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(528, 672);
            this.dgvProdutos.TabIndex = 0;
            // 
            // txtVenCod
            // 
            this.txtVenCod.Enabled = false;
            this.txtVenCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVenCod.Location = new System.Drawing.Point(124, 57);
            this.txtVenCod.Name = "txtVenCod";
            this.txtVenCod.Size = new System.Drawing.Size(145, 35);
            this.txtVenCod.TabIndex = 1;
            this.txtVenCod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVenCod_KeyDown);
            this.txtVenCod.Leave += new System.EventHandler(this.txtVenCod_Leave);
            // 
            // txtNomeCli
            // 
            this.txtNomeCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCli.Location = new System.Drawing.Point(124, 141);
            this.txtNomeCli.Name = "txtNomeCli";
            this.txtNomeCli.ReadOnly = true;
            this.txtNomeCli.Size = new System.Drawing.Size(458, 35);
            this.txtNomeCli.TabIndex = 2;
            this.txtNomeCli.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNomeCli_KeyDown);
            // 
            // txtNomeAtend
            // 
            this.txtNomeAtend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeAtend.Location = new System.Drawing.Point(124, 183);
            this.txtNomeAtend.Name = "txtNomeAtend";
            this.txtNomeAtend.ReadOnly = true;
            this.txtNomeAtend.Size = new System.Drawing.Size(283, 35);
            this.txtNomeAtend.TabIndex = 3;
            this.txtNomeAtend.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNomeAtend_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtStatus);
            this.groupBox1.Controls.Add(this.lblAtend);
            this.groupBox1.Controls.Add(this.lblNomeCli);
            this.groupBox1.Controls.Add(this.lblVenCod);
            this.groupBox1.Controls.Add(this.btnLocaliza);
            this.groupBox1.Controls.Add(this.txtNomeCli);
            this.groupBox1.Controls.Add(this.txtNomeAtend);
            this.groupBox1.Controls.Add(this.txtVenCod);
            this.groupBox1.Location = new System.Drawing.Point(12, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(596, 271);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Pedido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Status:";
            // 
            // txtStatus
            // 
            this.txtStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(124, 225);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(283, 35);
            this.txtStatus.TabIndex = 7;
            // 
            // lblAtend
            // 
            this.lblAtend.AutoSize = true;
            this.lblAtend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtend.Location = new System.Drawing.Point(6, 189);
            this.lblAtend.Name = "lblAtend";
            this.lblAtend.Size = new System.Drawing.Size(107, 22);
            this.lblAtend.TabIndex = 5;
            this.lblAtend.Text = "Atendente:";
            // 
            // lblNomeCli
            // 
            this.lblNomeCli.AutoSize = true;
            this.lblNomeCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCli.Location = new System.Drawing.Point(34, 147);
            this.lblNomeCli.Name = "lblNomeCli";
            this.lblNomeCli.Size = new System.Drawing.Size(79, 22);
            this.lblNomeCli.TabIndex = 4;
            this.lblNomeCli.Text = "Cliente:";
            // 
            // lblVenCod
            // 
            this.lblVenCod.AutoSize = true;
            this.lblVenCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenCod.Location = new System.Drawing.Point(35, 63);
            this.lblVenCod.Name = "lblVenCod";
            this.lblVenCod.Size = new System.Drawing.Size(78, 22);
            this.lblVenCod.TabIndex = 3;
            this.lblVenCod.Text = "Pedido:";
            // 
            // btnLocaliza
            // 
            this.btnLocaliza.AutoSize = true;
            this.btnLocaliza.Enabled = false;
            this.btnLocaliza.Location = new System.Drawing.Point(275, 57);
            this.btnLocaliza.Name = "btnLocaliza";
            this.btnLocaliza.Size = new System.Drawing.Size(132, 35);
            this.btnLocaliza.TabIndex = 0;
            this.btnLocaliza.Text = "F2 - Localizar";
            this.btnLocaliza.UseVisualStyleBackColor = true;
            this.btnLocaliza.Click += new System.EventHandler(this.btnLocaliza_Click);
            // 
            // gpbRecebimento
            // 
            this.gpbRecebimento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gpbRecebimento.Controls.Add(this.lblDin);
            this.gpbRecebimento.Controls.Add(this.lblCart);
            this.gpbRecebimento.Controls.Add(this.lblWinthor);
            this.gpbRecebimento.Controls.Add(this.lblTotalPed);
            this.gpbRecebimento.Controls.Add(this.txtTotal);
            this.gpbRecebimento.Controls.Add(this.txtCart);
            this.gpbRecebimento.Controls.Add(this.txtWint);
            this.gpbRecebimento.Controls.Add(this.txtVlrPed);
            this.gpbRecebimento.Location = new System.Drawing.Point(51, 485);
            this.gpbRecebimento.Name = "gpbRecebimento";
            this.gpbRecebimento.Size = new System.Drawing.Size(556, 294);
            this.gpbRecebimento.TabIndex = 5;
            this.gpbRecebimento.TabStop = false;
            this.gpbRecebimento.Text = "Valores Recebidos";
            // 
            // lblDin
            // 
            this.lblDin.AutoSize = true;
            this.lblDin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDin.Location = new System.Drawing.Point(49, 235);
            this.lblDin.Name = "lblDin";
            this.lblDin.Size = new System.Drawing.Size(250, 32);
            this.lblDin.TabIndex = 9;
            this.lblDin.Text = "Valor em Dinheiro:";
            // 
            // lblCart
            // 
            this.lblCart.AutoSize = true;
            this.lblCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCart.Location = new System.Drawing.Point(71, 171);
            this.lblCart.Name = "lblCart";
            this.lblCart.Size = new System.Drawing.Size(228, 32);
            this.lblCart.TabIndex = 8;
            this.lblCart.Text = "Valor em Cartão:";
            // 
            // lblWinthor
            // 
            this.lblWinthor.AutoSize = true;
            this.lblWinthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinthor.Location = new System.Drawing.Point(104, 107);
            this.lblWinthor.Name = "lblWinthor";
            this.lblWinthor.Size = new System.Drawing.Size(195, 32);
            this.lblWinthor.TabIndex = 7;
            this.lblWinthor.Text = "Valor Winthor:";
            // 
            // lblTotalPed
            // 
            this.lblTotalPed.AutoSize = true;
            this.lblTotalPed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPed.Location = new System.Drawing.Point(112, 43);
            this.lblTotalPed.Name = "lblTotalPed";
            this.lblTotalPed.Size = new System.Drawing.Size(187, 32);
            this.lblTotalPed.TabIndex = 6;
            this.lblTotalPed.Text = "Valor Pedido:";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.Desktop;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(312, 232);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(145, 39);
            this.txtTotal.TabIndex = 5;
            this.txtTotal.Text = "0,00";
            this.txtTotal.Leave += new System.EventHandler(this.txtTotal_Leave);
            // 
            // txtCart
            // 
            this.txtCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCart.Location = new System.Drawing.Point(312, 168);
            this.txtCart.Name = "txtCart";
            this.txtCart.Size = new System.Drawing.Size(145, 39);
            this.txtCart.TabIndex = 4;
            this.txtCart.Text = "0,00";
            this.txtCart.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCart_KeyDown);
            this.txtCart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCart_KeyPress);
            this.txtCart.Leave += new System.EventHandler(this.txtCart_Leave);
            // 
            // txtWint
            // 
            this.txtWint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWint.Location = new System.Drawing.Point(312, 104);
            this.txtWint.Name = "txtWint";
            this.txtWint.Size = new System.Drawing.Size(145, 39);
            this.txtWint.TabIndex = 3;
            this.txtWint.Text = "0,00";
            this.txtWint.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtWint_KeyDown);
            this.txtWint.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWint_KeyPress);
            this.txtWint.Leave += new System.EventHandler(this.txtWint_Leave);
            // 
            // txtVlrPed
            // 
            this.txtVlrPed.BackColor = System.Drawing.SystemColors.Desktop;
            this.txtVlrPed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVlrPed.Location = new System.Drawing.Point(312, 40);
            this.txtVlrPed.Name = "txtVlrPed";
            this.txtVlrPed.ReadOnly = true;
            this.txtVlrPed.Size = new System.Drawing.Size(145, 39);
            this.txtVlrPed.TabIndex = 2;
            this.txtVlrPed.Text = "0,00";
            this.txtVlrPed.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVlrPed_KeyDown);
            this.txtVlrPed.Leave += new System.EventHandler(this.txtVlrPed_Leave);
            // 
            // txtTot
            // 
            this.txtTot.BackColor = System.Drawing.SystemColors.Desktop;
            this.txtTot.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTot.Location = new System.Drawing.Point(742, 705);
            this.txtTot.Name = "txtTot";
            this.txtTot.ReadOnly = true;
            this.txtTot.Size = new System.Drawing.Size(176, 41);
            this.txtTot.TabIndex = 6;
            this.txtTot.Text = "0,00";
            this.txtTot.Leave += new System.EventHandler(this.txtTot_Leave);
            // 
            // btnGrava
            // 
            this.btnGrava.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGrava.AutoSize = true;
            this.btnGrava.BackColor = System.Drawing.Color.OrangeRed;
            this.btnGrava.Location = new System.Drawing.Point(232, 831);
            this.btnGrava.Name = "btnGrava";
            this.btnGrava.Size = new System.Drawing.Size(120, 77);
            this.btnGrava.TabIndex = 1;
            this.btnGrava.Text = "F1 - Gravar";
            this.btnGrava.UseVisualStyleBackColor = false;
            this.btnGrava.Click += new System.EventHandler(this.btnGrava_Click);
            // 
            // btnCancela
            // 
            this.btnCancela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancela.AutoSize = true;
            this.btnCancela.BackColor = System.Drawing.Color.OrangeRed;
            this.btnCancela.Location = new System.Drawing.Point(488, 831);
            this.btnCancela.Name = "btnCancela";
            this.btnCancela.Size = new System.Drawing.Size(120, 77);
            this.btnCancela.TabIndex = 7;
            this.btnCancela.Text = "F5 - Cancela";
            this.btnCancela.UseVisualStyleBackColor = false;
            this.btnCancela.Click += new System.EventHandler(this.btnCancela_Click);
            // 
            // lblTot
            // 
            this.lblTot.AutoSize = true;
            this.lblTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTot.Location = new System.Drawing.Point(660, 705);
            this.lblTot.Name = "lblTot";
            this.lblTot.Size = new System.Drawing.Size(76, 40);
            this.lblTot.TabIndex = 10;
            this.lblTot.Text = "R$:";
            // 
            // btImprimir
            // 
            this.btImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btImprimir.AutoSize = true;
            this.btImprimir.BackColor = System.Drawing.Color.OrangeRed;
            this.btImprimir.Location = new System.Drawing.Point(104, 831);
            this.btImprimir.Name = "btImprimir";
            this.btImprimir.Size = new System.Drawing.Size(120, 77);
            this.btImprimir.TabIndex = 11;
            this.btImprimir.Text = "Imprimir";
            this.btImprimir.UseVisualStyleBackColor = false;
            this.btImprimir.Click += new System.EventHandler(this.btImprimir_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirCaixaToolStripMenuItem,
            this.fecharCaixaToolStripMenuItem,
            this.consultarTEDToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(196, 94);
            // 
            // abrirCaixaToolStripMenuItem
            // 
            this.abrirCaixaToolStripMenuItem.Name = "abrirCaixaToolStripMenuItem";
            this.abrirCaixaToolStripMenuItem.Size = new System.Drawing.Size(195, 30);
            this.abrirCaixaToolStripMenuItem.Text = "Abrir Caixa";
            this.abrirCaixaToolStripMenuItem.Click += new System.EventHandler(this.abrirCaixaToolStripMenuItem_Click);
            // 
            // fecharCaixaToolStripMenuItem
            // 
            this.fecharCaixaToolStripMenuItem.Name = "fecharCaixaToolStripMenuItem";
            this.fecharCaixaToolStripMenuItem.Size = new System.Drawing.Size(195, 30);
            this.fecharCaixaToolStripMenuItem.Text = "Fechar Caixa";
            this.fecharCaixaToolStripMenuItem.Click += new System.EventHandler(this.fecharCaixaToolStripMenuItem_Click);
            // 
            // consultarTEDToolStripMenuItem
            // 
            this.consultarTEDToolStripMenuItem.Name = "consultarTEDToolStripMenuItem";
            this.consultarTEDToolStripMenuItem.Size = new System.Drawing.Size(195, 30);
            this.consultarTEDToolStripMenuItem.Text = "Consultar TED";
            this.consultarTEDToolStripMenuItem.Click += new System.EventHandler(this.consultarTEDToolStripMenuItem_Click);
            // 
            // lblCaixa
            // 
            this.lblCaixa.AutoSize = true;
            this.lblCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaixa.Location = new System.Drawing.Point(18, 9);
            this.lblCaixa.Name = "lblCaixa";
            this.lblCaixa.Size = new System.Drawing.Size(0, 29);
            this.lblCaixa.TabIndex = 12;
            // 
            // btnTED
            // 
            this.btnTED.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTED.AutoSize = true;
            this.btnTED.BackColor = System.Drawing.Color.OrangeRed;
            this.btnTED.Location = new System.Drawing.Point(360, 831);
            this.btnTED.Name = "btnTED";
            this.btnTED.Size = new System.Drawing.Size(120, 77);
            this.btnTED.TabIndex = 13;
            this.btnTED.Text = "F10 - TED";
            this.btnTED.UseVisualStyleBackColor = false;
            this.btnTED.Click += new System.EventHandler(this.btnTED_Click);
            // 
            // frmMovimentacaoVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1218, 992);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.ControlBox = false;
            this.Controls.Add(this.btnTED);
            this.Controls.Add(this.lblCaixa);
            this.Controls.Add(this.btImprimir);
            this.Controls.Add(this.lblTot);
            this.Controls.Add(this.btnCancela);
            this.Controls.Add(this.btnGrava);
            this.Controls.Add(this.txtTot);
            this.Controls.Add(this.gpbRecebimento);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmMovimentacaoVenda";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMovimentacaoVenda_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMovimentacaoVenda_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gpbRecebimento.ResumeLayout(false);
            this.gpbRecebimento.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.TextBox txtVenCod;
        private System.Windows.Forms.TextBox txtNomeCli;
        private System.Windows.Forms.TextBox txtNomeAtend;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gpbRecebimento;
        private System.Windows.Forms.TextBox txtTot;
        private System.Windows.Forms.Button btnLocaliza;
        private System.Windows.Forms.Button btnGrava;
        private System.Windows.Forms.Button btnCancela;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtCart;
        private System.Windows.Forms.TextBox txtWint;
        private System.Windows.Forms.TextBox txtVlrPed;
        private System.Windows.Forms.Label lblAtend;
        private System.Windows.Forms.Label lblNomeCli;
        private System.Windows.Forms.Label lblVenCod;
        private System.Windows.Forms.Label lblDin;
        private System.Windows.Forms.Label lblCart;
        private System.Windows.Forms.Label lblWinthor;
        private System.Windows.Forms.Label lblTotalPed;
        private System.Windows.Forms.Label lblTot;
        private System.Windows.Forms.Button btImprimir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem abrirCaixaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharCaixaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarTEDToolStripMenuItem;
        private System.Windows.Forms.Label lblCaixa;
        private System.Windows.Forms.Button btnTED;
    }
}