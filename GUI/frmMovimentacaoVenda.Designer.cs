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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dgvProdutos.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dgvProdutos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProdutos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvProdutos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProdutos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dgvProdutos.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvProdutos.Location = new System.Drawing.Point(440, 8);
            this.dgvProdutos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProdutos.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProdutos.RowHeadersVisible = false;
            this.dgvProdutos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Unicode MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dgvProdutos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProdutos.RowTemplate.Height = 28;
            this.dgvProdutos.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(352, 437);
            this.dgvProdutos.TabIndex = 0;
            // 
            // txtVenCod
            // 
            this.txtVenCod.Enabled = false;
            this.txtVenCod.Location = new System.Drawing.Point(83, 37);
            this.txtVenCod.Margin = new System.Windows.Forms.Padding(2);
            this.txtVenCod.Name = "txtVenCod";
            this.txtVenCod.Size = new System.Drawing.Size(98, 20);
            this.txtVenCod.TabIndex = 1;
            this.txtVenCod.Leave += new System.EventHandler(this.txtVenCod_Leave);
            // 
            // txtNomeCli
            // 
            this.txtNomeCli.Location = new System.Drawing.Point(83, 68);
            this.txtNomeCli.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeCli.Name = "txtNomeCli";
            this.txtNomeCli.ReadOnly = true;
            this.txtNomeCli.Size = new System.Drawing.Size(307, 20);
            this.txtNomeCli.TabIndex = 2;
            this.txtNomeCli.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNomeCli_KeyDown);
            // 
            // txtNomeAtend
            // 
            this.txtNomeAtend.Location = new System.Drawing.Point(83, 94);
            this.txtNomeAtend.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeAtend.Name = "txtNomeAtend";
            this.txtNomeAtend.ReadOnly = true;
            this.txtNomeAtend.Size = new System.Drawing.Size(190, 20);
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
            this.groupBox1.Location = new System.Drawing.Point(8, 34);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(397, 155);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Pedido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Status:";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(83, 119);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(2);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(190, 20);
            this.txtStatus.TabIndex = 7;
            // 
            // lblAtend
            // 
            this.lblAtend.AutoSize = true;
            this.lblAtend.Location = new System.Drawing.Point(23, 96);
            this.lblAtend.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAtend.Name = "lblAtend";
            this.lblAtend.Size = new System.Drawing.Size(59, 13);
            this.lblAtend.TabIndex = 5;
            this.lblAtend.Text = "Atendente:";
            // 
            // lblNomeCli
            // 
            this.lblNomeCli.AutoSize = true;
            this.lblNomeCli.Location = new System.Drawing.Point(40, 70);
            this.lblNomeCli.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomeCli.Name = "lblNomeCli";
            this.lblNomeCli.Size = new System.Drawing.Size(42, 13);
            this.lblNomeCli.TabIndex = 4;
            this.lblNomeCli.Text = "Cliente:";
            // 
            // lblVenCod
            // 
            this.lblVenCod.AutoSize = true;
            this.lblVenCod.Location = new System.Drawing.Point(4, 39);
            this.lblVenCod.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVenCod.Name = "lblVenCod";
            this.lblVenCod.Size = new System.Drawing.Size(79, 13);
            this.lblVenCod.TabIndex = 3;
            this.lblVenCod.Text = "Código Pedido:";
            // 
            // btnLocaliza
            // 
            this.btnLocaliza.AutoSize = true;
            this.btnLocaliza.Enabled = false;
            this.btnLocaliza.Location = new System.Drawing.Point(183, 36);
            this.btnLocaliza.Margin = new System.Windows.Forms.Padding(2);
            this.btnLocaliza.Name = "btnLocaliza";
            this.btnLocaliza.Size = new System.Drawing.Size(59, 23);
            this.btnLocaliza.TabIndex = 0;
            this.btnLocaliza.Text = "Localizar";
            this.btnLocaliza.UseVisualStyleBackColor = true;
            this.btnLocaliza.Click += new System.EventHandler(this.btnLocaliza_Click);
            // 
            // gpbRecebimento
            // 
            this.gpbRecebimento.Controls.Add(this.lblDin);
            this.gpbRecebimento.Controls.Add(this.lblCart);
            this.gpbRecebimento.Controls.Add(this.lblWinthor);
            this.gpbRecebimento.Controls.Add(this.lblTotalPed);
            this.gpbRecebimento.Controls.Add(this.txtTotal);
            this.gpbRecebimento.Controls.Add(this.txtCart);
            this.gpbRecebimento.Controls.Add(this.txtWint);
            this.gpbRecebimento.Controls.Add(this.txtVlrPed);
            this.gpbRecebimento.Location = new System.Drawing.Point(34, 315);
            this.gpbRecebimento.Margin = new System.Windows.Forms.Padding(2);
            this.gpbRecebimento.Name = "gpbRecebimento";
            this.gpbRecebimento.Padding = new System.Windows.Forms.Padding(2);
            this.gpbRecebimento.Size = new System.Drawing.Size(371, 191);
            this.gpbRecebimento.TabIndex = 5;
            this.gpbRecebimento.TabStop = false;
            this.gpbRecebimento.Text = "Valores Recebidos";
            // 
            // lblDin
            // 
            this.lblDin.AutoSize = true;
            this.lblDin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDin.Location = new System.Drawing.Point(37, 139);
            this.lblDin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDin.Name = "lblDin";
            this.lblDin.Size = new System.Drawing.Size(167, 24);
            this.lblDin.TabIndex = 9;
            this.lblDin.Text = "Valor em Dinheiro:";
            // 
            // lblCart
            // 
            this.lblCart.AutoSize = true;
            this.lblCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCart.Location = new System.Drawing.Point(54, 105);
            this.lblCart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCart.Name = "lblCart";
            this.lblCart.Size = new System.Drawing.Size(150, 24);
            this.lblCart.TabIndex = 8;
            this.lblCart.Text = "Valor em Cartão:";
            // 
            // lblWinthor
            // 
            this.lblWinthor.AutoSize = true;
            this.lblWinthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinthor.Location = new System.Drawing.Point(75, 60);
            this.lblWinthor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWinthor.Name = "lblWinthor";
            this.lblWinthor.Size = new System.Drawing.Size(129, 24);
            this.lblWinthor.TabIndex = 7;
            this.lblWinthor.Text = "Valor Winthor:";
            // 
            // lblTotalPed
            // 
            this.lblTotalPed.AutoSize = true;
            this.lblTotalPed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPed.Location = new System.Drawing.Point(80, 28);
            this.lblTotalPed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalPed.Name = "lblTotalPed";
            this.lblTotalPed.Size = new System.Drawing.Size(124, 24);
            this.lblTotalPed.TabIndex = 6;
            this.lblTotalPed.Text = "Valor Pedido:";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(208, 139);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(98, 29);
            this.txtTotal.TabIndex = 5;
            this.txtTotal.Text = "0,00";
            this.txtTotal.Leave += new System.EventHandler(this.txtTotal_Leave);
            // 
            // txtCart
            // 
            this.txtCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCart.Location = new System.Drawing.Point(208, 106);
            this.txtCart.Margin = new System.Windows.Forms.Padding(2);
            this.txtCart.Name = "txtCart";
            this.txtCart.Size = new System.Drawing.Size(98, 29);
            this.txtCart.TabIndex = 4;
            this.txtCart.Text = "0,00";
            this.txtCart.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCart_KeyDown);
            this.txtCart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCart_KeyPress);
            this.txtCart.Leave += new System.EventHandler(this.txtCart_Leave);
            // 
            // txtWint
            // 
            this.txtWint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWint.Location = new System.Drawing.Point(208, 60);
            this.txtWint.Margin = new System.Windows.Forms.Padding(2);
            this.txtWint.Name = "txtWint";
            this.txtWint.Size = new System.Drawing.Size(98, 29);
            this.txtWint.TabIndex = 3;
            this.txtWint.Text = "0,00";
            this.txtWint.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtWint_KeyDown);
            this.txtWint.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWint_KeyPress);
            this.txtWint.Leave += new System.EventHandler(this.txtWint_Leave);
            // 
            // txtVlrPed
            // 
            this.txtVlrPed.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtVlrPed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVlrPed.Location = new System.Drawing.Point(208, 28);
            this.txtVlrPed.Margin = new System.Windows.Forms.Padding(2);
            this.txtVlrPed.Name = "txtVlrPed";
            this.txtVlrPed.ReadOnly = true;
            this.txtVlrPed.Size = new System.Drawing.Size(98, 29);
            this.txtVlrPed.TabIndex = 2;
            this.txtVlrPed.Text = "0,00";
            this.txtVlrPed.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVlrPed_KeyDown);
            this.txtVlrPed.Leave += new System.EventHandler(this.txtVlrPed_Leave);
            // 
            // txtTot
            // 
            this.txtTot.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtTot.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTot.Location = new System.Drawing.Point(687, 458);
            this.txtTot.Margin = new System.Windows.Forms.Padding(2);
            this.txtTot.Name = "txtTot";
            this.txtTot.ReadOnly = true;
            this.txtTot.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTot.Size = new System.Drawing.Size(98, 25);
            this.txtTot.TabIndex = 6;
            this.txtTot.Text = "0,00";
            this.txtTot.Leave += new System.EventHandler(this.txtTot_Leave);
            // 
            // btnGrava
            // 
            this.btnGrava.AutoSize = true;
            this.btnGrava.BackColor = System.Drawing.Color.OrangeRed;
            this.btnGrava.Location = new System.Drawing.Point(244, 540);
            this.btnGrava.Margin = new System.Windows.Forms.Padding(2);
            this.btnGrava.Name = "btnGrava";
            this.btnGrava.Size = new System.Drawing.Size(80, 50);
            this.btnGrava.TabIndex = 1;
            this.btnGrava.Text = "F1 - Gravar";
            this.btnGrava.UseVisualStyleBackColor = false;
            this.btnGrava.Click += new System.EventHandler(this.btnGrava_Click);
            // 
            // btnCancela
            // 
            this.btnCancela.AutoSize = true;
            this.btnCancela.BackColor = System.Drawing.Color.OrangeRed;
            this.btnCancela.Location = new System.Drawing.Point(328, 540);
            this.btnCancela.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancela.Name = "btnCancela";
            this.btnCancela.Size = new System.Drawing.Size(80, 50);
            this.btnCancela.TabIndex = 7;
            this.btnCancela.Text = "F5 - Cancela";
            this.btnCancela.UseVisualStyleBackColor = false;
            this.btnCancela.Click += new System.EventHandler(this.btnCancela_Click);
            // 
            // lblTot
            // 
            this.lblTot.AutoSize = true;
            this.lblTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTot.Location = new System.Drawing.Point(641, 458);
            this.lblTot.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTot.Name = "lblTot";
            this.lblTot.Size = new System.Drawing.Size(49, 26);
            this.lblTot.TabIndex = 10;
            this.lblTot.Text = "R$:";
            // 
            // btImprimir
            // 
            this.btImprimir.AutoSize = true;
            this.btImprimir.BackColor = System.Drawing.Color.OrangeRed;
            this.btImprimir.Location = new System.Drawing.Point(244, 540);
            this.btImprimir.Margin = new System.Windows.Forms.Padding(2);
            this.btImprimir.Name = "btImprimir";
            this.btImprimir.Size = new System.Drawing.Size(80, 50);
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
            this.fecharCaixaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(141, 48);
            // 
            // abrirCaixaToolStripMenuItem
            // 
            this.abrirCaixaToolStripMenuItem.Name = "abrirCaixaToolStripMenuItem";
            this.abrirCaixaToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.abrirCaixaToolStripMenuItem.Text = "Abrir Caixa";
            this.abrirCaixaToolStripMenuItem.Click += new System.EventHandler(this.abrirCaixaToolStripMenuItem_Click);
            // 
            // fecharCaixaToolStripMenuItem
            // 
            this.fecharCaixaToolStripMenuItem.Name = "fecharCaixaToolStripMenuItem";
            this.fecharCaixaToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.fecharCaixaToolStripMenuItem.Text = "Fechar Caixa";
            this.fecharCaixaToolStripMenuItem.Click += new System.EventHandler(this.fecharCaixaToolStripMenuItem_Click);
            // 
            // frmMovimentacaoVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(821, 645);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.btImprimir);
            this.Controls.Add(this.lblTot);
            this.Controls.Add(this.btnCancela);
            this.Controls.Add(this.btnGrava);
            this.Controls.Add(this.txtTot);
            this.Controls.Add(this.gpbRecebimento);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMovimentacaoVenda";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receber Venda";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMovimentacaoVenda_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtWint_KeyDown);
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
    }
}