namespace GUI
{
    partial class frmMovimentacaoPedido
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbpPedido = new System.Windows.Forms.TabControl();
            this.tbpCliente = new System.Windows.Forms.TabPage();
            this.gpbPedWint = new System.Windows.Forms.GroupBox();
            this.chkZero = new System.Windows.Forms.CheckBox();
            this.lblVlrWint = new System.Windows.Forms.Label();
            this.dgvPedWint = new System.Windows.Forms.DataGridView();
            this.CodWint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtVlrWint = new System.Windows.Forms.TextBox();
            this.lblVlrTotWint = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.txtTotalWint = new System.Windows.Forms.TextBox();
            this.btnLocalCli = new System.Windows.Forms.Button();
            this.txtDescCli = new System.Windows.Forms.TextBox();
            this.txtAtendente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblObs = new System.Windows.Forms.Label();
            this.txtCodCli = new System.Windows.Forms.TextBox();
            this.lblCodCliente = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.lblCod = new System.Windows.Forms.Label();
            this.tbpItens = new System.Windows.Forms.TabPage();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblInfo2 = new System.Windows.Forms.Label();
            this.lblInfo1 = new System.Windows.Forms.Label();
            this.lblVlrUnit = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblDescProd = new System.Windows.Forms.Label();
            this.lblCodProd = new System.Windows.Forms.Label();
            this.txtVlrUnit = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtDescProd = new System.Windows.Forms.TextBox();
            this.txtCodProd = new System.Windows.Forms.TextBox();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnDados.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            this.tbpPedido.SuspendLayout();
            this.tbpCliente.SuspendLayout();
            this.gpbPedWint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedWint)).BeginInit();
            this.tbpItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.tbpPedido);
            this.pnDados.Margin = new System.Windows.Forms.Padding(2);
            this.pnDados.Size = new System.Drawing.Size(1000, 635);
            // 
            // pnBotoes
            // 
            this.pnBotoes.Margin = new System.Windows.Forms.Padding(2);
            this.pnBotoes.Size = new System.Drawing.Size(1041, 62);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(218, 6);
            this.btCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.toolTip1.SetToolTip(this.btCancelar, "Cancelar Pedido - Pressione F7");
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(64, 6);
            this.btSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.toolTip1.SetToolTip(this.btSalvar, "Para Salvar - Pressione F6");
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(546, 6);
            this.btExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.btExcluir.Visible = false;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Enabled = false;
            this.btAlterar.Location = new System.Drawing.Point(166, 6);
            this.btAlterar.Margin = new System.Windows.Forms.Padding(2);
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btLocalizar
            // 
            this.btLocalizar.Enabled = false;
            this.btLocalizar.Location = new System.Drawing.Point(116, 6);
            this.btLocalizar.Margin = new System.Windows.Forms.Padding(2);
            this.btLocalizar.Click += new System.EventHandler(this.btLocalizar_Click);
            // 
            // btInserir
            // 
            this.toolTip1.SetToolTip(this.btInserir, "Novo Pedido - Pressione F1");
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // tbpPedido
            // 
            this.tbpPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbpPedido.Controls.Add(this.tbpCliente);
            this.tbpPedido.Controls.Add(this.tbpItens);
            this.tbpPedido.Location = new System.Drawing.Point(3, 14);
            this.tbpPedido.Name = "tbpPedido";
            this.tbpPedido.SelectedIndex = 0;
            this.tbpPedido.Size = new System.Drawing.Size(992, 618);
            this.tbpPedido.TabIndex = 0;
            // 
            // tbpCliente
            // 
            this.tbpCliente.BackColor = System.Drawing.SystemColors.Control;
            this.tbpCliente.Controls.Add(this.gpbPedWint);
            this.tbpCliente.Controls.Add(this.lblVlrTotWint);
            this.tbpCliente.Controls.Add(this.txtObs);
            this.tbpCliente.Controls.Add(this.txtTotalWint);
            this.tbpCliente.Controls.Add(this.btnLocalCli);
            this.tbpCliente.Controls.Add(this.txtDescCli);
            this.tbpCliente.Controls.Add(this.txtAtendente);
            this.tbpCliente.Controls.Add(this.label6);
            this.tbpCliente.Controls.Add(this.lblObs);
            this.tbpCliente.Controls.Add(this.txtCodCli);
            this.tbpCliente.Controls.Add(this.lblCodCliente);
            this.tbpCliente.Controls.Add(this.txtCod);
            this.tbpCliente.Controls.Add(this.lblCod);
            this.tbpCliente.Location = new System.Drawing.Point(4, 29);
            this.tbpCliente.Name = "tbpCliente";
            this.tbpCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCliente.Size = new System.Drawing.Size(984, 585);
            this.tbpCliente.TabIndex = 0;
            this.tbpCliente.Text = "F2 - Pedido";
            this.tbpCliente.Click += new System.EventHandler(this.tbpCliente_Click);
            // 
            // gpbPedWint
            // 
            this.gpbPedWint.Controls.Add(this.chkZero);
            this.gpbPedWint.Controls.Add(this.lblVlrWint);
            this.gpbPedWint.Controls.Add(this.dgvPedWint);
            this.gpbPedWint.Controls.Add(this.txtVlrWint);
            this.gpbPedWint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbPedWint.Location = new System.Drawing.Point(40, 162);
            this.gpbPedWint.Name = "gpbPedWint";
            this.gpbPedWint.Size = new System.Drawing.Size(699, 383);
            this.gpbPedWint.TabIndex = 12;
            this.gpbPedWint.TabStop = false;
            this.gpbPedWint.Text = "Pedidos do Winthor";
            // 
            // chkZero
            // 
            this.chkZero.AutoSize = true;
            this.chkZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.chkZero.Location = new System.Drawing.Point(12, 37);
            this.chkZero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkZero.Name = "chkZero";
            this.chkZero.Size = new System.Drawing.Size(140, 24);
            this.chkZero.TabIndex = 17;
            this.chkZero.Text = "Sem Vendas ?";
            this.chkZero.UseVisualStyleBackColor = true;
            // 
            // lblVlrWint
            // 
            this.lblVlrWint.AutoSize = true;
            this.lblVlrWint.Location = new System.Drawing.Point(113, 79);
            this.lblVlrWint.Name = "lblVlrWint";
            this.lblVlrWint.Size = new System.Drawing.Size(75, 29);
            this.lblVlrWint.TabIndex = 14;
            this.lblVlrWint.Text = "Valor:";
            // 
            // dgvPedWint
            // 
            this.dgvPedWint.AllowUserToAddRows = false;
            this.dgvPedWint.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPedWint.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPedWint.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPedWint.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPedWint.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPedWint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedWint.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodWint,
            this.Valor});
            this.dgvPedWint.Location = new System.Drawing.Point(6, 123);
            this.dgvPedWint.MultiSelect = false;
            this.dgvPedWint.Name = "dgvPedWint";
            this.dgvPedWint.ReadOnly = true;
            this.dgvPedWint.RowHeadersVisible = false;
            this.dgvPedWint.RowTemplate.Height = 28;
            this.dgvPedWint.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvPedWint.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedWint.Size = new System.Drawing.Size(388, 240);
            this.dgvPedWint.TabIndex = 2;
            this.dgvPedWint.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedWint_CellDoubleClick);
            // 
            // CodWint
            // 
            this.CodWint.HeaderText = "Item";
            this.CodWint.Name = "CodWint";
            this.CodWint.ReadOnly = true;
            this.CodWint.Width = 150;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor Winthor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            this.Valor.Width = 200;
            // 
            // txtVlrWint
            // 
            this.txtVlrWint.Location = new System.Drawing.Point(194, 76);
            this.txtVlrWint.Name = "txtVlrWint";
            this.txtVlrWint.Size = new System.Drawing.Size(163, 35);
            this.txtVlrWint.TabIndex = 1;
            this.txtVlrWint.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVlrWint_KeyDown);
            this.txtVlrWint.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVlrWint_KeyPress);
            this.txtVlrWint.Leave += new System.EventHandler(this.txtVlrWint_Leave);
            // 
            // lblVlrTotWint
            // 
            this.lblVlrTotWint.AutoSize = true;
            this.lblVlrTotWint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblVlrTotWint.Location = new System.Drawing.Point(518, 28);
            this.lblVlrTotWint.Name = "lblVlrTotWint";
            this.lblVlrTotWint.Size = new System.Drawing.Size(74, 29);
            this.lblVlrTotWint.TabIndex = 16;
            this.lblVlrTotWint.Text = "Total:";
            // 
            // txtObs
            // 
            this.txtObs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObs.Location = new System.Drawing.Point(215, 77);
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(522, 35);
            this.txtObs.TabIndex = 7;
            this.txtObs.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtObs_KeyDown);
            // 
            // txtTotalWint
            // 
            this.txtTotalWint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTotalWint.Location = new System.Drawing.Point(595, 25);
            this.txtTotalWint.Name = "txtTotalWint";
            this.txtTotalWint.ReadOnly = true;
            this.txtTotalWint.Size = new System.Drawing.Size(144, 35);
            this.txtTotalWint.TabIndex = 15;
            this.txtTotalWint.Leave += new System.EventHandler(this.txtTotalWint_Leave);
            // 
            // btnLocalCli
            // 
            this.btnLocalCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocalCli.Location = new System.Drawing.Point(891, 494);
            this.btnLocalCli.Name = "btnLocalCli";
            this.btnLocalCli.Size = new System.Drawing.Size(36, 29);
            this.btnLocalCli.TabIndex = 11;
            this.btnLocalCli.Text = "...";
            this.btnLocalCli.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.btnLocalCli, "Localizar Cliente");
            this.btnLocalCli.UseVisualStyleBackColor = true;
            this.btnLocalCli.Visible = false;
            this.btnLocalCli.Click += new System.EventHandler(this.btnLocalCli_Click);
            // 
            // txtDescCli
            // 
            this.txtDescCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescCli.Location = new System.Drawing.Point(561, 535);
            this.txtDescCli.Name = "txtDescCli";
            this.txtDescCli.ReadOnly = true;
            this.txtDescCli.Size = new System.Drawing.Size(397, 35);
            this.txtDescCli.TabIndex = 10;
            this.txtDescCli.TabStop = false;
            this.txtDescCli.Visible = false;
            // 
            // txtAtendente
            // 
            this.txtAtendente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAtendente.Location = new System.Drawing.Point(215, 25);
            this.txtAtendente.Name = "txtAtendente";
            this.txtAtendente.ReadOnly = true;
            this.txtAtendente.Size = new System.Drawing.Size(292, 35);
            this.txtAtendente.TabIndex = 1;
            this.txtAtendente.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(64, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 29);
            this.label6.TabIndex = 8;
            this.label6.Text = "Atendente:";
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObs.Location = new System.Drawing.Point(25, 80);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(167, 29);
            this.lblObs.TabIndex = 7;
            this.lblObs.Text = "Nome Cliente:";
            // 
            // txtCodCli
            // 
            this.txtCodCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodCli.Location = new System.Drawing.Point(780, 444);
            this.txtCodCli.Name = "txtCodCli";
            this.txtCodCli.Size = new System.Drawing.Size(150, 35);
            this.txtCodCli.TabIndex = 6;
            this.txtCodCli.Text = "1";
            this.txtCodCli.Visible = false;
            this.txtCodCli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodCli_KeyPress);
            this.txtCodCli.Leave += new System.EventHandler(this.txtCodCli_Leave);
            // 
            // lblCodCliente
            // 
            this.lblCodCliente.AutoSize = true;
            this.lblCodCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodCliente.Location = new System.Drawing.Point(775, 371);
            this.lblCodCliente.Name = "lblCodCliente";
            this.lblCodCliente.Size = new System.Drawing.Size(152, 29);
            this.lblCodCliente.TabIndex = 4;
            this.lblCodCliente.Text = "Cód. Cliente:";
            this.lblCodCliente.Visible = false;
            // 
            // txtCod
            // 
            this.txtCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCod.Location = new System.Drawing.Point(777, 403);
            this.txtCod.Name = "txtCod";
            this.txtCod.ReadOnly = true;
            this.txtCod.Size = new System.Drawing.Size(150, 35);
            this.txtCod.TabIndex = 2;
            this.txtCod.TabStop = false;
            this.txtCod.Visible = false;
            this.txtCod.Leave += new System.EventHandler(this.txtCod_Leave);
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCod.Location = new System.Drawing.Point(742, 526);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(216, 29);
            this.lblCod.TabIndex = 0;
            this.lblCod.Text = "Código do Pedido:";
            this.lblCod.Visible = false;
            // 
            // tbpItens
            // 
            this.tbpItens.BackColor = System.Drawing.SystemColors.Control;
            this.tbpItens.Controls.Add(this.txtTotal);
            this.tbpItens.Controls.Add(this.lblTotal);
            this.tbpItens.Controls.Add(this.lblInfo2);
            this.tbpItens.Controls.Add(this.lblInfo1);
            this.tbpItens.Controls.Add(this.lblVlrUnit);
            this.tbpItens.Controls.Add(this.lblQuantidade);
            this.tbpItens.Controls.Add(this.lblDescProd);
            this.tbpItens.Controls.Add(this.lblCodProd);
            this.tbpItens.Controls.Add(this.txtVlrUnit);
            this.tbpItens.Controls.Add(this.txtQuantidade);
            this.tbpItens.Controls.Add(this.txtDescProd);
            this.tbpItens.Controls.Add(this.txtCodProd);
            this.tbpItens.Controls.Add(this.dgvItens);
            this.tbpItens.Location = new System.Drawing.Point(4, 29);
            this.tbpItens.Name = "tbpItens";
            this.tbpItens.Padding = new System.Windows.Forms.Padding(3);
            this.tbpItens.Size = new System.Drawing.Size(984, 585);
            this.tbpItens.TabIndex = 1;
            this.tbpItens.Text = "F4 - Itens";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(710, 552);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(115, 26);
            this.txtTotal.TabIndex = 12;
            this.txtTotal.TabStop = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(650, 558);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(54, 20);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "Total:";
            // 
            // lblInfo2
            // 
            this.lblInfo2.AutoSize = true;
            this.lblInfo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo2.Location = new System.Drawing.Point(2, 558);
            this.lblInfo2.Name = "lblInfo2";
            this.lblInfo2.Size = new System.Drawing.Size(428, 20);
            this.lblInfo2.TabIndex = 10;
            this.lblInfo2.Text = "Pressione Enter - Para gravar os Produtos na Venda";
            // 
            // lblInfo1
            // 
            this.lblInfo1.AutoSize = true;
            this.lblInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo1.Location = new System.Drawing.Point(3, 538);
            this.lblInfo1.Name = "lblInfo1";
            this.lblInfo1.Size = new System.Drawing.Size(339, 20);
            this.lblInfo1.TabIndex = 9;
            this.lblInfo1.Text = "Pressione F5 - Para localizar os Produtos";
            // 
            // lblVlrUnit
            // 
            this.lblVlrUnit.AutoSize = true;
            this.lblVlrUnit.Location = new System.Drawing.Point(706, 16);
            this.lblVlrUnit.Name = "lblVlrUnit";
            this.lblVlrUnit.Size = new System.Drawing.Size(83, 20);
            this.lblVlrUnit.TabIndex = 8;
            this.lblVlrUnit.Text = "Valor Unit.";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(578, 16);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(92, 20);
            this.lblQuantidade.TabIndex = 7;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // lblDescProd
            // 
            this.lblDescProd.AutoSize = true;
            this.lblDescProd.Location = new System.Drawing.Point(140, 16);
            this.lblDescProd.Name = "lblDescProd";
            this.lblDescProd.Size = new System.Drawing.Size(80, 20);
            this.lblDescProd.TabIndex = 6;
            this.lblDescProd.Text = "Descrição";
            // 
            // lblCodProd
            // 
            this.lblCodProd.AutoSize = true;
            this.lblCodProd.Location = new System.Drawing.Point(6, 16);
            this.lblCodProd.Name = "lblCodProd";
            this.lblCodProd.Size = new System.Drawing.Size(59, 20);
            this.lblCodProd.TabIndex = 5;
            this.lblCodProd.Text = "Código";
            // 
            // txtVlrUnit
            // 
            this.txtVlrUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtVlrUnit.Location = new System.Drawing.Point(710, 49);
            this.txtVlrUnit.Name = "txtVlrUnit";
            this.txtVlrUnit.ReadOnly = true;
            this.txtVlrUnit.Size = new System.Drawing.Size(115, 35);
            this.txtVlrUnit.TabIndex = 4;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtQuantidade.Location = new System.Drawing.Point(586, 49);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(110, 35);
            this.txtQuantidade.TabIndex = 9;
            this.txtQuantidade.TextChanged += new System.EventHandler(this.txtQuantidade_TextChanged);
            this.txtQuantidade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuantidade_KeyDown);
            this.txtQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidade_KeyPress);
            this.txtQuantidade.Leave += new System.EventHandler(this.txtQuantidade_Leave);
            // 
            // txtDescProd
            // 
            this.txtDescProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDescProd.Location = new System.Drawing.Point(146, 49);
            this.txtDescProd.Name = "txtDescProd";
            this.txtDescProd.ReadOnly = true;
            this.txtDescProd.Size = new System.Drawing.Size(426, 35);
            this.txtDescProd.TabIndex = 2;
            this.txtDescProd.TabStop = false;
            // 
            // txtCodProd
            // 
            this.txtCodProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCodProd.Location = new System.Drawing.Point(6, 49);
            this.txtCodProd.Name = "txtCodProd";
            this.txtCodProd.Size = new System.Drawing.Size(126, 35);
            this.txtCodProd.TabIndex = 8;
            this.txtCodProd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodProd_KeyDown);
            this.txtCodProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodProd_KeyPress);
            this.txtCodProd.Leave += new System.EventHandler(this.txtCodProd_Leave);
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AllowUserToDeleteRows = false;
            this.dgvItens.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvItens.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Descricao,
            this.Quantidade,
            this.ValorUnit,
            this.ValorTotal});
            this.dgvItens.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvItens.Location = new System.Drawing.Point(6, 100);
            this.dgvItens.MultiSelect = false;
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.RowHeadersVisible = false;
            this.dgvItens.RowHeadersWidth = 10;
            this.dgvItens.RowTemplate.Height = 28;
            this.dgvItens.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItens.Size = new System.Drawing.Size(946, 431);
            this.dgvItens.TabIndex = 0;
            this.dgvItens.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItens_CellDoubleClick);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 80;
            // 
            // Descricao
            // 
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.Width = 250;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            // 
            // ValorUnit
            // 
            this.ValorUnit.HeaderText = "Valor Unitário";
            this.ValorUnit.Name = "ValorUnit";
            this.ValorUnit.ReadOnly = true;
            // 
            // ValorTotal
            // 
            this.ValorTotal.HeaderText = "Valor Total";
            this.ValorTotal.Name = "ValorTotal";
            this.ValorTotal.ReadOnly = true;
            // 
            // frmMovimentacaoPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(1028, 725);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMovimentacaoPedido";
            this.Text = "Pedido de Venda";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMovimentacaoPedido_KeyDown);
            this.pnDados.ResumeLayout(false);
            this.pnBotoes.ResumeLayout(false);
            this.tbpPedido.ResumeLayout(false);
            this.tbpCliente.ResumeLayout(false);
            this.tbpCliente.PerformLayout();
            this.gpbPedWint.ResumeLayout(false);
            this.gpbPedWint.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedWint)).EndInit();
            this.tbpItens.ResumeLayout(false);
            this.tbpItens.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbpPedido;
        private System.Windows.Forms.TabPage tbpCliente;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.TabPage tbpItens;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.TextBox txtCodCli;
        private System.Windows.Forms.Label lblCodCliente;
        private System.Windows.Forms.Label lblVlrUnit;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblDescProd;
        private System.Windows.Forms.Label lblCodProd;
        private System.Windows.Forms.TextBox txtVlrUnit;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtDescProd;
        private System.Windows.Forms.TextBox txtCodProd;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.Button btnLocalCli;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtDescCli;
        private System.Windows.Forms.TextBox txtAtendente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblInfo2;
        private System.Windows.Forms.Label lblInfo1;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorTotal;
        private System.Windows.Forms.GroupBox gpbPedWint;
        private System.Windows.Forms.Label lblVlrWint;
        private System.Windows.Forms.DataGridView dgvPedWint;
        private System.Windows.Forms.TextBox txtVlrWint;
        private System.Windows.Forms.Label lblVlrTotWint;
        private System.Windows.Forms.TextBox txtTotalWint;
        private System.Windows.Forms.CheckBox chkZero;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodWint;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
    }
}
