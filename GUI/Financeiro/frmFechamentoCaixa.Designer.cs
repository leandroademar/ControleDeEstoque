﻿namespace GUI
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
            this.dgvTABCaixas = new System.Windows.Forms.DataGridView();
            this.dtpMovimento = new System.Windows.Forms.DateTimePicker();
            this.cbxTurno = new System.Windows.Forms.ComboBox();
            this.lblData = new System.Windows.Forms.Label();
            this.lblTurno = new System.Windows.Forms.Label();
            this.gbxTotais = new System.Windows.Forms.GroupBox();
            this.totalOutros = new System.Windows.Forms.Label();
            this.totalCheque = new System.Windows.Forms.Label();
            this.totalCDtks = new System.Windows.Forms.Label();
            this.totalCCtks = new System.Windows.Forms.Label();
            this.totalDinheiro = new System.Windows.Forms.Label();
            this.totalMoedas = new System.Windows.Forms.Label();
            this.totalTed = new System.Windows.Forms.Label();
            this.totalCDrede = new System.Windows.Forms.Label();
            this.totalCCrede = new System.Windows.Forms.Label();
            this.totalBanese = new System.Windows.Forms.Label();
            this.lblVOutras = new System.Windows.Forms.Label();
            this.lblVMoedas = new System.Windows.Forms.Label();
            this.lblVCheque = new System.Windows.Forms.Label();
            this.lblVTed = new System.Windows.Forms.Label();
            this.lblVCDtks = new System.Windows.Forms.Label();
            this.lblVCDRede = new System.Windows.Forms.Label();
            this.lblVCCTks = new System.Windows.Forms.Label();
            this.lblVCCRede = new System.Windows.Forms.Label();
            this.lblVDinheiro = new System.Windows.Forms.Label();
            this.lblVBanese = new System.Windows.Forms.Label();
            this.gbxValores = new System.Windows.Forms.GroupBox();
            this.lblOutros = new System.Windows.Forms.Label();
            this.lblMoedas = new System.Windows.Forms.Label();
            this.txtOutros = new System.Windows.Forms.TextBox();
            this.txtMoedas = new System.Windows.Forms.TextBox();
            this.lblCheque = new System.Windows.Forms.Label();
            this.lblTED = new System.Windows.Forms.Label();
            this.lblCdrede = new System.Windows.Forms.Label();
            this.lblCdtks = new System.Windows.Forms.Label();
            this.lblCCtks = new System.Windows.Forms.Label();
            this.lblCcrede = new System.Windows.Forms.Label();
            this.lblDinheiro = new System.Windows.Forms.Label();
            this.lblBanese = new System.Windows.Forms.Label();
            this.txtCheque = new System.Windows.Forms.TextBox();
            this.txtTEDelet = new System.Windows.Forms.TextBox();
            this.txtCDtks = new System.Windows.Forms.TextBox();
            this.txtCDrede = new System.Windows.Forms.TextBox();
            this.txtCCtks = new System.Windows.Forms.TextBox();
            this.txtCCrede = new System.Windows.Forms.TextBox();
            this.txtDinheiro = new System.Windows.Forms.TextBox();
            this.txtBanese = new System.Windows.Forms.TextBox();
            this.btnTransf = new System.Windows.Forms.Button();
            this.btnAvulso = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gbxSegmento = new System.Windows.Forms.GroupBox();
            this.cbxDia = new System.Windows.Forms.CheckBox();
            this.rbtAtacado = new System.Windows.Forms.RadioButton();
            this.rbtVarejo = new System.Windows.Forms.RadioButton();
            this.txtNumcaixa = new System.Windows.Forms.TextBox();
            this.txtNumoper = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.tbpPrincipal = new System.Windows.Forms.TabControl();
            this.tbpTed = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvRetiradas = new System.Windows.Forms.DataGridView();
            this.dgvTed = new System.Windows.Forms.DataGridView();
            this.pnlTABCaixa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTABCaixas)).BeginInit();
            this.gbxTotais.SuspendLayout();
            this.gbxValores.SuspendLayout();
            this.gbxSegmento.SuspendLayout();
            this.tbpPrincipal.SuspendLayout();
            this.tbpTed.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRetiradas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTed)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTABCaixa
            // 
            this.pnlTABCaixa.Controls.Add(this.dgvTABCaixas);
            this.pnlTABCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlTABCaixa.Location = new System.Drawing.Point(27, 163);
            this.pnlTABCaixa.Name = "pnlTABCaixa";
            this.pnlTABCaixa.Size = new System.Drawing.Size(1080, 335);
            this.pnlTABCaixa.TabIndex = 0;
            // 
            // dgvTABCaixas
            // 
            this.dgvTABCaixas.AllowUserToAddRows = false;
            this.dgvTABCaixas.AllowUserToDeleteRows = false;
            this.dgvTABCaixas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTABCaixas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTABCaixas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTABCaixas.GridColor = System.Drawing.SystemColors.Control;
            this.dgvTABCaixas.Location = new System.Drawing.Point(0, 0);
            this.dgvTABCaixas.Name = "dgvTABCaixas";
            this.dgvTABCaixas.ReadOnly = true;
            this.dgvTABCaixas.RowTemplate.Height = 28;
            this.dgvTABCaixas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvTABCaixas.Size = new System.Drawing.Size(1080, 335);
            this.dgvTABCaixas.TabIndex = 0;
            this.dgvTABCaixas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTABCaixas_CellClick);
            this.dgvTABCaixas.DoubleClick += new System.EventHandler(this.dgvTABCaixas_DoubleClick);
            this.dgvTABCaixas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvTABCaixas_KeyDown);
            // 
            // dtpMovimento
            // 
            this.dtpMovimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpMovimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMovimento.Location = new System.Drawing.Point(28, 41);
            this.dtpMovimento.Name = "dtpMovimento";
            this.dtpMovimento.Size = new System.Drawing.Size(148, 35);
            this.dtpMovimento.TabIndex = 1;
            this.dtpMovimento.ValueChanged += new System.EventHandler(this.dtpMovimento_ValueChanged);
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
            this.cbxTurno.Text = "1";
            this.cbxTurno.SelectedValueChanged += new System.EventHandler(this.cbxTurno_SelectedValueChanged);
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
            this.gbxTotais.Controls.Add(this.totalOutros);
            this.gbxTotais.Controls.Add(this.totalCheque);
            this.gbxTotais.Controls.Add(this.totalCDtks);
            this.gbxTotais.Controls.Add(this.totalCCtks);
            this.gbxTotais.Controls.Add(this.totalDinheiro);
            this.gbxTotais.Controls.Add(this.totalMoedas);
            this.gbxTotais.Controls.Add(this.totalTed);
            this.gbxTotais.Controls.Add(this.totalCDrede);
            this.gbxTotais.Controls.Add(this.totalCCrede);
            this.gbxTotais.Controls.Add(this.totalBanese);
            this.gbxTotais.Controls.Add(this.lblVOutras);
            this.gbxTotais.Controls.Add(this.lblVMoedas);
            this.gbxTotais.Controls.Add(this.lblVCheque);
            this.gbxTotais.Controls.Add(this.lblVTed);
            this.gbxTotais.Controls.Add(this.lblVCDtks);
            this.gbxTotais.Controls.Add(this.lblVCDRede);
            this.gbxTotais.Controls.Add(this.lblVCCTks);
            this.gbxTotais.Controls.Add(this.lblVCCRede);
            this.gbxTotais.Controls.Add(this.lblVDinheiro);
            this.gbxTotais.Controls.Add(this.lblVBanese);
            this.gbxTotais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxTotais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxTotais.Location = new System.Drawing.Point(1125, 12);
            this.gbxTotais.Name = "gbxTotais";
            this.gbxTotais.Size = new System.Drawing.Size(446, 486);
            this.gbxTotais.TabIndex = 7;
            this.gbxTotais.TabStop = false;
            this.gbxTotais.Text = "Totais";
            // 
            // totalOutros
            // 
            this.totalOutros.AutoSize = true;
            this.totalOutros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalOutros.ForeColor = System.Drawing.SystemColors.Desktop;
            this.totalOutros.Location = new System.Drawing.Point(86, 443);
            this.totalOutros.Name = "totalOutros";
            this.totalOutros.Size = new System.Drawing.Size(62, 29);
            this.totalOutros.TabIndex = 19;
            this.totalOutros.Text = "0,00";
            // 
            // totalCheque
            // 
            this.totalCheque.AutoSize = true;
            this.totalCheque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCheque.ForeColor = System.Drawing.SystemColors.Desktop;
            this.totalCheque.Location = new System.Drawing.Point(256, 443);
            this.totalCheque.Name = "totalCheque";
            this.totalCheque.Size = new System.Drawing.Size(62, 29);
            this.totalCheque.TabIndex = 18;
            this.totalCheque.Text = "0,00";
            // 
            // totalCDtks
            // 
            this.totalCDtks.AutoSize = true;
            this.totalCDtks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCDtks.ForeColor = System.Drawing.SystemColors.Desktop;
            this.totalCDtks.Location = new System.Drawing.Point(263, 353);
            this.totalCDtks.Name = "totalCDtks";
            this.totalCDtks.Size = new System.Drawing.Size(62, 29);
            this.totalCDtks.TabIndex = 17;
            this.totalCDtks.Text = "0,00";
            // 
            // totalCCtks
            // 
            this.totalCCtks.AutoSize = true;
            this.totalCCtks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCCtks.ForeColor = System.Drawing.SystemColors.Desktop;
            this.totalCCtks.Location = new System.Drawing.Point(256, 266);
            this.totalCCtks.Name = "totalCCtks";
            this.totalCCtks.Size = new System.Drawing.Size(62, 29);
            this.totalCCtks.TabIndex = 16;
            this.totalCCtks.Text = "0,00";
            // 
            // totalDinheiro
            // 
            this.totalDinheiro.AutoSize = true;
            this.totalDinheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalDinheiro.ForeColor = System.Drawing.SystemColors.Desktop;
            this.totalDinheiro.Location = new System.Drawing.Point(80, 180);
            this.totalDinheiro.Name = "totalDinheiro";
            this.totalDinheiro.Size = new System.Drawing.Size(62, 29);
            this.totalDinheiro.TabIndex = 15;
            this.totalDinheiro.Text = "0,00";
            // 
            // totalMoedas
            // 
            this.totalMoedas.AutoSize = true;
            this.totalMoedas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalMoedas.ForeColor = System.Drawing.SystemColors.Desktop;
            this.totalMoedas.Location = new System.Drawing.Point(257, 180);
            this.totalMoedas.Name = "totalMoedas";
            this.totalMoedas.Size = new System.Drawing.Size(62, 29);
            this.totalMoedas.TabIndex = 14;
            this.totalMoedas.Text = "0,00";
            // 
            // totalTed
            // 
            this.totalTed.AutoSize = true;
            this.totalTed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTed.ForeColor = System.Drawing.SystemColors.Desktop;
            this.totalTed.Location = new System.Drawing.Point(260, 95);
            this.totalTed.Name = "totalTed";
            this.totalTed.Size = new System.Drawing.Size(62, 29);
            this.totalTed.TabIndex = 13;
            this.totalTed.Text = "0,00";
            // 
            // totalCDrede
            // 
            this.totalCDrede.AutoSize = true;
            this.totalCDrede.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCDrede.ForeColor = System.Drawing.SystemColors.Desktop;
            this.totalCDrede.Location = new System.Drawing.Point(86, 353);
            this.totalCDrede.Name = "totalCDrede";
            this.totalCDrede.Size = new System.Drawing.Size(62, 29);
            this.totalCDrede.TabIndex = 12;
            this.totalCDrede.Text = "0,00";
            // 
            // totalCCrede
            // 
            this.totalCCrede.AutoSize = true;
            this.totalCCrede.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCCrede.ForeColor = System.Drawing.SystemColors.Desktop;
            this.totalCCrede.Location = new System.Drawing.Point(80, 266);
            this.totalCCrede.Name = "totalCCrede";
            this.totalCCrede.Size = new System.Drawing.Size(62, 29);
            this.totalCCrede.TabIndex = 11;
            this.totalCCrede.Text = "0,00";
            // 
            // totalBanese
            // 
            this.totalBanese.AutoSize = true;
            this.totalBanese.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalBanese.ForeColor = System.Drawing.SystemColors.Desktop;
            this.totalBanese.Location = new System.Drawing.Point(80, 94);
            this.totalBanese.Name = "totalBanese";
            this.totalBanese.Size = new System.Drawing.Size(62, 29);
            this.totalBanese.TabIndex = 10;
            this.totalBanese.Text = "0,00";
            // 
            // lblVOutras
            // 
            this.lblVOutras.AutoSize = true;
            this.lblVOutras.Location = new System.Drawing.Point(86, 400);
            this.lblVOutras.Name = "lblVOutras";
            this.lblVOutras.Size = new System.Drawing.Size(97, 29);
            this.lblVOutras.TabIndex = 9;
            this.lblVOutras.Text = "Outros: ";
            // 
            // lblVMoedas
            // 
            this.lblVMoedas.AutoSize = true;
            this.lblVMoedas.Location = new System.Drawing.Point(257, 137);
            this.lblVMoedas.Name = "lblVMoedas";
            this.lblVMoedas.Size = new System.Drawing.Size(112, 29);
            this.lblVMoedas.TabIndex = 8;
            this.lblVMoedas.Text = "Moedas: ";
            // 
            // lblVCheque
            // 
            this.lblVCheque.AutoSize = true;
            this.lblVCheque.Location = new System.Drawing.Point(256, 400);
            this.lblVCheque.Name = "lblVCheque";
            this.lblVCheque.Size = new System.Drawing.Size(110, 29);
            this.lblVCheque.TabIndex = 7;
            this.lblVCheque.Text = "Cheque: ";
            // 
            // lblVTed
            // 
            this.lblVTed.AutoSize = true;
            this.lblVTed.Location = new System.Drawing.Point(260, 52);
            this.lblVTed.Name = "lblVTed";
            this.lblVTed.Size = new System.Drawing.Size(74, 29);
            this.lblVTed.TabIndex = 6;
            this.lblVTed.Text = "TED: ";
            // 
            // lblVCDtks
            // 
            this.lblVCDtks.AutoSize = true;
            this.lblVCDtks.Location = new System.Drawing.Point(263, 310);
            this.lblVCDtks.Name = "lblVCDtks";
            this.lblVCDtks.Size = new System.Drawing.Size(113, 29);
            this.lblVCDtks.TabIndex = 5;
            this.lblVCDtks.Text = "CD TKS: ";
            // 
            // lblVCDRede
            // 
            this.lblVCDRede.AutoSize = true;
            this.lblVCDRede.Location = new System.Drawing.Point(86, 310);
            this.lblVCDRede.Name = "lblVCDRede";
            this.lblVCDRede.Size = new System.Drawing.Size(118, 29);
            this.lblVCDRede.TabIndex = 4;
            this.lblVCDRede.Text = "CD Rede:";
            // 
            // lblVCCTks
            // 
            this.lblVCCTks.AutoSize = true;
            this.lblVCCTks.Location = new System.Drawing.Point(256, 223);
            this.lblVCCTks.Name = "lblVCCTks";
            this.lblVCCTks.Size = new System.Drawing.Size(113, 29);
            this.lblVCCTks.TabIndex = 3;
            this.lblVCCTks.Text = "CC TKS: ";
            // 
            // lblVCCRede
            // 
            this.lblVCCRede.AutoSize = true;
            this.lblVCCRede.Location = new System.Drawing.Point(80, 223);
            this.lblVCCRede.Name = "lblVCCRede";
            this.lblVCCRede.Size = new System.Drawing.Size(124, 29);
            this.lblVCCRede.TabIndex = 2;
            this.lblVCCRede.Text = "CC Rede: ";
            // 
            // lblVDinheiro
            // 
            this.lblVDinheiro.AutoSize = true;
            this.lblVDinheiro.Location = new System.Drawing.Point(80, 137);
            this.lblVDinheiro.Name = "lblVDinheiro";
            this.lblVDinheiro.Size = new System.Drawing.Size(116, 29);
            this.lblVDinheiro.TabIndex = 1;
            this.lblVDinheiro.Text = "Dinheiro: ";
            // 
            // lblVBanese
            // 
            this.lblVBanese.AutoSize = true;
            this.lblVBanese.Location = new System.Drawing.Point(80, 51);
            this.lblVBanese.Name = "lblVBanese";
            this.lblVBanese.Size = new System.Drawing.Size(107, 29);
            this.lblVBanese.TabIndex = 0;
            this.lblVBanese.Text = "Banese: ";
            // 
            // gbxValores
            // 
            this.gbxValores.Controls.Add(this.lblOutros);
            this.gbxValores.Controls.Add(this.lblMoedas);
            this.gbxValores.Controls.Add(this.txtOutros);
            this.gbxValores.Controls.Add(this.txtMoedas);
            this.gbxValores.Controls.Add(this.lblCheque);
            this.gbxValores.Controls.Add(this.lblTED);
            this.gbxValores.Controls.Add(this.lblCdrede);
            this.gbxValores.Controls.Add(this.lblCdtks);
            this.gbxValores.Controls.Add(this.lblCCtks);
            this.gbxValores.Controls.Add(this.lblCcrede);
            this.gbxValores.Controls.Add(this.lblDinheiro);
            this.gbxValores.Controls.Add(this.lblBanese);
            this.gbxValores.Controls.Add(this.txtCheque);
            this.gbxValores.Controls.Add(this.txtTEDelet);
            this.gbxValores.Controls.Add(this.txtCDtks);
            this.gbxValores.Controls.Add(this.txtCDrede);
            this.gbxValores.Controls.Add(this.txtCCtks);
            this.gbxValores.Controls.Add(this.txtCCrede);
            this.gbxValores.Controls.Add(this.txtDinheiro);
            this.gbxValores.Controls.Add(this.txtBanese);
            this.gbxValores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxValores.Location = new System.Drawing.Point(29, 512);
            this.gbxValores.Name = "gbxValores";
            this.gbxValores.Size = new System.Drawing.Size(1079, 222);
            this.gbxValores.TabIndex = 8;
            this.gbxValores.TabStop = false;
            this.gbxValores.Text = "Valores";
            // 
            // lblOutros
            // 
            this.lblOutros.AutoSize = true;
            this.lblOutros.Location = new System.Drawing.Point(803, 111);
            this.lblOutros.Name = "lblOutros";
            this.lblOutros.Size = new System.Drawing.Size(137, 29);
            this.lblOutros.TabIndex = 17;
            this.lblOutros.Text = "Outros Val.:";
            // 
            // lblMoedas
            // 
            this.lblMoedas.AutoSize = true;
            this.lblMoedas.Location = new System.Drawing.Point(803, 34);
            this.lblMoedas.Name = "lblMoedas";
            this.lblMoedas.Size = new System.Drawing.Size(106, 29);
            this.lblMoedas.TabIndex = 18;
            this.lblMoedas.Text = "Moedas:";
            // 
            // txtOutros
            // 
            this.txtOutros.Location = new System.Drawing.Point(803, 143);
            this.txtOutros.Name = "txtOutros";
            this.txtOutros.Size = new System.Drawing.Size(133, 35);
            this.txtOutros.TabIndex = 16;
            this.txtOutros.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOutros_KeyDown);
            this.txtOutros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOutros_KeyPress);
            this.txtOutros.Leave += new System.EventHandler(this.txtOutros_Leave);
            // 
            // txtMoedas
            // 
            this.txtMoedas.Location = new System.Drawing.Point(803, 66);
            this.txtMoedas.Name = "txtMoedas";
            this.txtMoedas.Size = new System.Drawing.Size(133, 35);
            this.txtMoedas.TabIndex = 15;
            this.txtMoedas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMoedas_KeyDown);
            this.txtMoedas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMoedas_KeyPress);
            this.txtMoedas.Leave += new System.EventHandler(this.txtMoedas_Leave);
            // 
            // lblCheque
            // 
            this.lblCheque.AutoSize = true;
            this.lblCheque.Location = new System.Drawing.Point(605, 111);
            this.lblCheque.Name = "lblCheque";
            this.lblCheque.Size = new System.Drawing.Size(104, 29);
            this.lblCheque.TabIndex = 14;
            this.lblCheque.Text = "Cheque:";
            // 
            // lblTED
            // 
            this.lblTED.AutoSize = true;
            this.lblTED.Location = new System.Drawing.Point(605, 34);
            this.lblTED.Name = "lblTED";
            this.lblTED.Size = new System.Drawing.Size(122, 29);
            this.lblTED.TabIndex = 14;
            this.lblTED.Text = "TED Elet.:";
            // 
            // lblCdrede
            // 
            this.lblCdrede.AutoSize = true;
            this.lblCdrede.Location = new System.Drawing.Point(407, 34);
            this.lblCdrede.Name = "lblCdrede";
            this.lblCdrede.Size = new System.Drawing.Size(118, 29);
            this.lblCdrede.TabIndex = 14;
            this.lblCdrede.Text = "CD Rede:";
            // 
            // lblCdtks
            // 
            this.lblCdtks.AutoSize = true;
            this.lblCdtks.Location = new System.Drawing.Point(407, 111);
            this.lblCdtks.Name = "lblCdtks";
            this.lblCdtks.Size = new System.Drawing.Size(107, 29);
            this.lblCdtks.TabIndex = 12;
            this.lblCdtks.Text = "CD TKS:";
            // 
            // lblCCtks
            // 
            this.lblCCtks.AutoSize = true;
            this.lblCCtks.Location = new System.Drawing.Point(209, 111);
            this.lblCCtks.Name = "lblCCtks";
            this.lblCCtks.Size = new System.Drawing.Size(107, 29);
            this.lblCCtks.TabIndex = 11;
            this.lblCCtks.Text = "CC TSK:";
            // 
            // lblCcrede
            // 
            this.lblCcrede.AutoSize = true;
            this.lblCcrede.Location = new System.Drawing.Point(209, 34);
            this.lblCcrede.Name = "lblCcrede";
            this.lblCcrede.Size = new System.Drawing.Size(118, 29);
            this.lblCcrede.TabIndex = 10;
            this.lblCcrede.Text = "CC Rede:";
            // 
            // lblDinheiro
            // 
            this.lblDinheiro.AutoSize = true;
            this.lblDinheiro.Location = new System.Drawing.Point(11, 111);
            this.lblDinheiro.Name = "lblDinheiro";
            this.lblDinheiro.Size = new System.Drawing.Size(110, 29);
            this.lblDinheiro.TabIndex = 9;
            this.lblDinheiro.Text = "Dinheiro:";
            // 
            // lblBanese
            // 
            this.lblBanese.AutoSize = true;
            this.lblBanese.Location = new System.Drawing.Point(6, 34);
            this.lblBanese.Name = "lblBanese";
            this.lblBanese.Size = new System.Drawing.Size(158, 29);
            this.lblBanese.TabIndex = 8;
            this.lblBanese.Text = "Dep. Banese:";
            // 
            // txtCheque
            // 
            this.txtCheque.Location = new System.Drawing.Point(605, 143);
            this.txtCheque.Name = "txtCheque";
            this.txtCheque.Size = new System.Drawing.Size(133, 35);
            this.txtCheque.TabIndex = 7;
            this.txtCheque.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCheque_KeyDown);
            this.txtCheque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCheque_KeyPress);
            this.txtCheque.Leave += new System.EventHandler(this.txtCheque_Leave);
            // 
            // txtTEDelet
            // 
            this.txtTEDelet.Location = new System.Drawing.Point(605, 66);
            this.txtTEDelet.Name = "txtTEDelet";
            this.txtTEDelet.Size = new System.Drawing.Size(133, 35);
            this.txtTEDelet.TabIndex = 6;
            this.txtTEDelet.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTEDelet_KeyDown);
            this.txtTEDelet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTEDelet_KeyPress);
            this.txtTEDelet.Leave += new System.EventHandler(this.txtTEDelet_Leave);
            // 
            // txtCDtks
            // 
            this.txtCDtks.Location = new System.Drawing.Point(407, 143);
            this.txtCDtks.Name = "txtCDtks";
            this.txtCDtks.Size = new System.Drawing.Size(133, 35);
            this.txtCDtks.TabIndex = 5;
            this.txtCDtks.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCDtks_KeyDown);
            this.txtCDtks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCDtks_KeyPress);
            this.txtCDtks.Leave += new System.EventHandler(this.txtCDtks_Leave);
            // 
            // txtCDrede
            // 
            this.txtCDrede.Location = new System.Drawing.Point(407, 66);
            this.txtCDrede.Name = "txtCDrede";
            this.txtCDrede.Size = new System.Drawing.Size(133, 35);
            this.txtCDrede.TabIndex = 4;
            this.txtCDrede.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCDrede_KeyDown);
            this.txtCDrede.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCDrede_KeyPress);
            this.txtCDrede.Leave += new System.EventHandler(this.txtCDrede_Leave);
            // 
            // txtCCtks
            // 
            this.txtCCtks.Location = new System.Drawing.Point(209, 143);
            this.txtCCtks.Name = "txtCCtks";
            this.txtCCtks.Size = new System.Drawing.Size(133, 35);
            this.txtCCtks.TabIndex = 3;
            this.txtCCtks.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCCtks_KeyDown);
            this.txtCCtks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCCtks_KeyPress);
            this.txtCCtks.Leave += new System.EventHandler(this.txtCCtks_Leave);
            // 
            // txtCCrede
            // 
            this.txtCCrede.Location = new System.Drawing.Point(209, 66);
            this.txtCCrede.Name = "txtCCrede";
            this.txtCCrede.Size = new System.Drawing.Size(133, 35);
            this.txtCCrede.TabIndex = 2;
            this.txtCCrede.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCCrede_KeyDown);
            this.txtCCrede.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCCrede_KeyPress);
            this.txtCCrede.Leave += new System.EventHandler(this.txtCCrede_Leave);
            // 
            // txtDinheiro
            // 
            this.txtDinheiro.Location = new System.Drawing.Point(11, 143);
            this.txtDinheiro.Name = "txtDinheiro";
            this.txtDinheiro.Size = new System.Drawing.Size(133, 35);
            this.txtDinheiro.TabIndex = 1;
            this.txtDinheiro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDinheiro_KeyDown);
            this.txtDinheiro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDinheiro_KeyPress);
            this.txtDinheiro.Leave += new System.EventHandler(this.txtDinheiro_Leave);
            // 
            // txtBanese
            // 
            this.txtBanese.Location = new System.Drawing.Point(11, 66);
            this.txtBanese.Name = "txtBanese";
            this.txtBanese.Size = new System.Drawing.Size(133, 35);
            this.txtBanese.TabIndex = 0;
            this.txtBanese.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBanese_KeyDown);
            this.txtBanese.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBanese_KeyPress);
            this.txtBanese.Leave += new System.EventHandler(this.txtBanese_Leave);
            // 
            // btnTransf
            // 
            this.btnTransf.Location = new System.Drawing.Point(578, 740);
            this.btnTransf.Name = "btnTransf";
            this.btnTransf.Size = new System.Drawing.Size(130, 45);
            this.btnTransf.TabIndex = 22;
            this.btnTransf.Text = "TED";
            this.btnTransf.UseVisualStyleBackColor = true;
            this.btnTransf.Visible = false;
            this.btnTransf.Click += new System.EventHandler(this.btnTransf_Click);
            // 
            // btnAvulso
            // 
            this.btnAvulso.Location = new System.Drawing.Point(711, 740);
            this.btnAvulso.Name = "btnAvulso";
            this.btnAvulso.Size = new System.Drawing.Size(130, 45);
            this.btnAvulso.TabIndex = 21;
            this.btnAvulso.Text = "Avulso";
            this.btnAvulso.UseVisualStyleBackColor = true;
            this.btnAvulso.Visible = false;
            this.btnAvulso.Click += new System.EventHandler(this.btnAvulso_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(844, 740);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(130, 45);
            this.btnAlterar.TabIndex = 20;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(977, 740);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(130, 45);
            this.btnSalvar.TabIndex = 19;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(276, 38);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(130, 45);
            this.btnBuscar.TabIndex = 23;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // gbxSegmento
            // 
            this.gbxSegmento.Controls.Add(this.cbxDia);
            this.gbxSegmento.Controls.Add(this.rbtAtacado);
            this.gbxSegmento.Controls.Add(this.rbtVarejo);
            this.gbxSegmento.Location = new System.Drawing.Point(27, 83);
            this.gbxSegmento.Name = "gbxSegmento";
            this.gbxSegmento.Size = new System.Drawing.Size(328, 60);
            this.gbxSegmento.TabIndex = 24;
            this.gbxSegmento.TabStop = false;
            // 
            // cbxDia
            // 
            this.cbxDia.AutoSize = true;
            this.cbxDia.Location = new System.Drawing.Point(216, 26);
            this.cbxDia.Name = "cbxDia";
            this.cbxDia.Size = new System.Drawing.Size(100, 24);
            this.cbxDia.TabIndex = 25;
            this.cbxDia.Text = "Por Dia ?";
            this.cbxDia.UseVisualStyleBackColor = true;
            this.cbxDia.CheckedChanged += new System.EventHandler(this.cbxDia_CheckedChanged);
            // 
            // rbtAtacado
            // 
            this.rbtAtacado.AutoSize = true;
            this.rbtAtacado.Location = new System.Drawing.Point(98, 25);
            this.rbtAtacado.Name = "rbtAtacado";
            this.rbtAtacado.Size = new System.Drawing.Size(94, 24);
            this.rbtAtacado.TabIndex = 26;
            this.rbtAtacado.TabStop = true;
            this.rbtAtacado.Text = "Atacado";
            this.rbtAtacado.UseVisualStyleBackColor = true;
            this.rbtAtacado.CheckedChanged += new System.EventHandler(this.rbtAtacado_CheckedChanged);
            // 
            // rbtVarejo
            // 
            this.rbtVarejo.AutoSize = true;
            this.rbtVarejo.Location = new System.Drawing.Point(12, 25);
            this.rbtVarejo.Name = "rbtVarejo";
            this.rbtVarejo.Size = new System.Drawing.Size(80, 24);
            this.rbtVarejo.TabIndex = 25;
            this.rbtVarejo.TabStop = true;
            this.rbtVarejo.Text = "Varejo";
            this.rbtVarejo.UseVisualStyleBackColor = true;
            this.rbtVarejo.CheckedChanged += new System.EventHandler(this.rbtVarejo_CheckedChanged);
            // 
            // txtNumcaixa
            // 
            this.txtNumcaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumcaixa.Location = new System.Drawing.Point(379, 107);
            this.txtNumcaixa.Name = "txtNumcaixa";
            this.txtNumcaixa.ReadOnly = true;
            this.txtNumcaixa.Size = new System.Drawing.Size(100, 35);
            this.txtNumcaixa.TabIndex = 25;
            // 
            // txtNumoper
            // 
            this.txtNumoper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumoper.Location = new System.Drawing.Point(499, 107);
            this.txtNumoper.Name = "txtNumoper";
            this.txtNumoper.ReadOnly = true;
            this.txtNumoper.Size = new System.Drawing.Size(100, 35);
            this.txtNumoper.TabIndex = 26;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(619, 107);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(489, 35);
            this.txtNome.TabIndex = 27;
            // 
            // tbpPrincipal
            // 
            this.tbpPrincipal.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tbpPrincipal.Controls.Add(this.tbpTed);
            this.tbpPrincipal.Controls.Add(this.tabPage2);
            this.tbpPrincipal.Location = new System.Drawing.Point(1125, 504);
            this.tbpPrincipal.Name = "tbpPrincipal";
            this.tbpPrincipal.SelectedIndex = 0;
            this.tbpPrincipal.Size = new System.Drawing.Size(446, 281);
            this.tbpPrincipal.TabIndex = 28;
            // 
            // tbpTed
            // 
            this.tbpTed.BackColor = System.Drawing.SystemColors.Control;
            this.tbpTed.Controls.Add(this.dgvTed);
            this.tbpTed.Location = new System.Drawing.Point(4, 32);
            this.tbpTed.Name = "tbpTed";
            this.tbpTed.Padding = new System.Windows.Forms.Padding(3);
            this.tbpTed.Size = new System.Drawing.Size(438, 245);
            this.tbpTed.TabIndex = 0;
            this.tbpTed.Text = "TED";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.dgvRetiradas);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(438, 245);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Retiradas";
            // 
            // dgvRetiradas
            // 
            this.dgvRetiradas.AllowUserToAddRows = false;
            this.dgvRetiradas.AllowUserToDeleteRows = false;
            this.dgvRetiradas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvRetiradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRetiradas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRetiradas.Location = new System.Drawing.Point(3, 3);
            this.dgvRetiradas.Name = "dgvRetiradas";
            this.dgvRetiradas.ReadOnly = true;
            this.dgvRetiradas.RowTemplate.Height = 28;
            this.dgvRetiradas.Size = new System.Drawing.Size(432, 239);
            this.dgvRetiradas.TabIndex = 0;
            // 
            // dgvTed
            // 
            this.dgvTed.AllowUserToAddRows = false;
            this.dgvTed.AllowUserToDeleteRows = false;
            this.dgvTed.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTed.Location = new System.Drawing.Point(3, 3);
            this.dgvTed.Name = "dgvTed";
            this.dgvTed.ReadOnly = true;
            this.dgvTed.RowTemplate.Height = 28;
            this.dgvTed.Size = new System.Drawing.Size(432, 239);
            this.dgvTed.TabIndex = 0;
            // 
            // frmFechamentoCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1634, 905);
            this.Controls.Add(this.tbpPrincipal);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtNumoper);
            this.Controls.Add(this.txtNumcaixa);
            this.Controls.Add(this.btnTransf);
            this.Controls.Add(this.gbxSegmento);
            this.Controls.Add(this.btnAvulso);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.gbxValores);
            this.Controls.Add(this.gbxTotais);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.cbxTurno);
            this.Controls.Add(this.dtpMovimento);
            this.Controls.Add(this.pnlTABCaixa);
            this.KeyPreview = true;
            this.Name = "frmFechamentoCaixa";
            this.Text = "Fechamento de Caixa";
            this.pnlTABCaixa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTABCaixas)).EndInit();
            this.gbxTotais.ResumeLayout(false);
            this.gbxTotais.PerformLayout();
            this.gbxValores.ResumeLayout(false);
            this.gbxValores.PerformLayout();
            this.gbxSegmento.ResumeLayout(false);
            this.gbxSegmento.PerformLayout();
            this.tbpPrincipal.ResumeLayout(false);
            this.tbpTed.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRetiradas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTed)).EndInit();
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
        private System.Windows.Forms.Label lblOutros;
        private System.Windows.Forms.Label lblMoedas;
        private System.Windows.Forms.TextBox txtOutros;
        private System.Windows.Forms.TextBox txtMoedas;
        private System.Windows.Forms.Label lblCheque;
        private System.Windows.Forms.Label lblTED;
        private System.Windows.Forms.Label lblCdrede;
        private System.Windows.Forms.Label lblCdtks;
        private System.Windows.Forms.Label lblCCtks;
        private System.Windows.Forms.Label lblCcrede;
        private System.Windows.Forms.Label lblDinheiro;
        private System.Windows.Forms.Label lblBanese;
        private System.Windows.Forms.TextBox txtCheque;
        private System.Windows.Forms.TextBox txtTEDelet;
        private System.Windows.Forms.TextBox txtCDtks;
        private System.Windows.Forms.TextBox txtCDrede;
        private System.Windows.Forms.TextBox txtCCtks;
        private System.Windows.Forms.TextBox txtCCrede;
        private System.Windows.Forms.TextBox txtDinheiro;
        private System.Windows.Forms.TextBox txtBanese;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox gbxSegmento;
        private System.Windows.Forms.CheckBox cbxDia;
        private System.Windows.Forms.RadioButton rbtAtacado;
        private System.Windows.Forms.RadioButton rbtVarejo;
        private System.Windows.Forms.Label lblVOutras;
        private System.Windows.Forms.Label lblVMoedas;
        private System.Windows.Forms.Label lblVCheque;
        private System.Windows.Forms.Label lblVTed;
        private System.Windows.Forms.Label lblVCDtks;
        private System.Windows.Forms.Label lblVCDRede;
        private System.Windows.Forms.Label lblVCCTks;
        private System.Windows.Forms.Label lblVCCRede;
        private System.Windows.Forms.Label lblVDinheiro;
        private System.Windows.Forms.Label lblVBanese;
        private System.Windows.Forms.Label totalOutros;
        private System.Windows.Forms.Label totalCheque;
        private System.Windows.Forms.Label totalCDtks;
        private System.Windows.Forms.Label totalCCtks;
        private System.Windows.Forms.Label totalDinheiro;
        private System.Windows.Forms.Label totalMoedas;
        private System.Windows.Forms.Label totalTed;
        private System.Windows.Forms.Label totalCDrede;
        private System.Windows.Forms.Label totalCCrede;
        private System.Windows.Forms.Label totalBanese;
        private System.Windows.Forms.TextBox txtNumcaixa;
        private System.Windows.Forms.TextBox txtNumoper;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TabControl tbpPrincipal;
        private System.Windows.Forms.TabPage tbpTed;
        private System.Windows.Forms.DataGridView dgvTed;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvRetiradas;
    }
}