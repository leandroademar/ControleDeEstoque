namespace GUI
{
    partial class frmSeparacaoPedido
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNomeEquipe = new System.Windows.Forms.ComboBox();
            this.lblNomeEquipe = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNomeCli = new System.Windows.Forms.Label();
            this.lblCod = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnGrava = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.ckbDivide = new System.Windows.Forms.CheckBox();
            this.txtCodVenda = new System.Windows.Forms.TextBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.lblCodEquipe = new System.Windows.Forms.Label();
            this.txtCodEquipe = new System.Windows.Forms.TextBox();
            this.rbtSeparar = new System.Windows.Forms.RadioButton();
            this.rbtSeparados = new System.Windows.Forms.RadioButton();
            this.txtPequisa = new System.Windows.Forms.TextBox();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.rbdFinalizados = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDados.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDados.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDados.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvDados.Location = new System.Drawing.Point(15, 141);
            this.dgvDados.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.RowHeadersVisible = false;
            this.dgvDados.RowTemplate.Height = 28;
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.Size = new System.Drawing.Size(1033, 610);
            this.dgvDados.TabIndex = 0;
            this.dgvDados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellClick);
            this.dgvDados.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDados_CellMouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNomeEquipe);
            this.groupBox1.Controls.Add(this.lblNomeEquipe);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblNomeCli);
            this.groupBox1.Controls.Add(this.lblCod);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnGrava);
            this.groupBox1.Controls.Add(this.txtValor);
            this.groupBox1.Controls.Add(this.ckbDivide);
            this.groupBox1.Controls.Add(this.txtCodVenda);
            this.groupBox1.Controls.Add(this.txtNomeCliente);
            this.groupBox1.Location = new System.Drawing.Point(15, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(559, 99);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pedido a Separar";
            // 
            // txtNomeEquipe
            // 
            this.txtNomeEquipe.FormattingEnabled = true;
            this.txtNomeEquipe.Location = new System.Drawing.Point(7, 70);
            this.txtNomeEquipe.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeEquipe.Name = "txtNomeEquipe";
            this.txtNomeEquipe.Size = new System.Drawing.Size(202, 21);
            this.txtNomeEquipe.TabIndex = 13;
            // 
            // lblNomeEquipe
            // 
            this.lblNomeEquipe.AutoSize = true;
            this.lblNomeEquipe.Location = new System.Drawing.Point(5, 53);
            this.lblNomeEquipe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomeEquipe.Name = "lblNomeEquipe";
            this.lblNomeEquipe.Size = new System.Drawing.Size(86, 13);
            this.lblNomeEquipe.TabIndex = 12;
            this.lblNomeEquipe.Text = "Nome da Equipe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(429, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Valor";
            // 
            // lblNomeCli
            // 
            this.lblNomeCli.AutoSize = true;
            this.lblNomeCli.Location = new System.Drawing.Point(121, 14);
            this.lblNomeCli.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomeCli.Name = "lblNomeCli";
            this.lblNomeCli.Size = new System.Drawing.Size(85, 13);
            this.lblNomeCli.TabIndex = 9;
            this.lblNomeCli.Text = "Nome do Cliente";
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(5, 14);
            this.lblCod.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(40, 13);
            this.lblCod.TabIndex = 8;
            this.lblCod.Text = "Código";
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.Location = new System.Drawing.Point(486, 69);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(61, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "&Cancela";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnGrava
            // 
            this.btnGrava.AutoSize = true;
            this.btnGrava.Location = new System.Drawing.Point(432, 69);
            this.btnGrava.Margin = new System.Windows.Forms.Padding(2);
            this.btnGrava.Name = "btnGrava";
            this.btnGrava.Size = new System.Drawing.Size(50, 23);
            this.btnGrava.TabIndex = 6;
            this.btnGrava.Text = "&Gravar";
            this.btnGrava.UseVisualStyleBackColor = true;
            this.btnGrava.Click += new System.EventHandler(this.btnGrava_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(432, 31);
            this.txtValor.Margin = new System.Windows.Forms.Padding(2);
            this.txtValor.Name = "txtValor";
            this.txtValor.ReadOnly = true;
            this.txtValor.Size = new System.Drawing.Size(115, 20);
            this.txtValor.TabIndex = 5;
            // 
            // ckbDivide
            // 
            this.ckbDivide.AutoSize = true;
            this.ckbDivide.Location = new System.Drawing.Point(343, 71);
            this.ckbDivide.Margin = new System.Windows.Forms.Padding(2);
            this.ckbDivide.Name = "ckbDivide";
            this.ckbDivide.Size = new System.Drawing.Size(83, 17);
            this.ckbDivide.TabIndex = 4;
            this.ckbDivide.Text = "Divir Pedido";
            this.ckbDivide.UseVisualStyleBackColor = true;
            // 
            // txtCodVenda
            // 
            this.txtCodVenda.Location = new System.Drawing.Point(7, 31);
            this.txtCodVenda.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodVenda.Name = "txtCodVenda";
            this.txtCodVenda.Size = new System.Drawing.Size(104, 20);
            this.txtCodVenda.TabIndex = 1;
            this.txtCodVenda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodVenda_KeyDown);
            this.txtCodVenda.Leave += new System.EventHandler(this.txtCodVenda_Leave);
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(123, 31);
            this.txtNomeCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.ReadOnly = true;
            this.txtNomeCliente.Size = new System.Drawing.Size(296, 20);
            this.txtNomeCliente.TabIndex = 0;
            // 
            // lblCodEquipe
            // 
            this.lblCodEquipe.AutoSize = true;
            this.lblCodEquipe.Location = new System.Drawing.Point(588, 39);
            this.lblCodEquipe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodEquipe.Name = "lblCodEquipe";
            this.lblCodEquipe.Size = new System.Drawing.Size(40, 13);
            this.lblCodEquipe.TabIndex = 11;
            this.lblCodEquipe.Text = "Código";
            this.lblCodEquipe.Visible = false;
            // 
            // txtCodEquipe
            // 
            this.txtCodEquipe.Location = new System.Drawing.Point(591, 57);
            this.txtCodEquipe.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodEquipe.Name = "txtCodEquipe";
            this.txtCodEquipe.Size = new System.Drawing.Size(104, 20);
            this.txtCodEquipe.TabIndex = 3;
            this.txtCodEquipe.Visible = false;
            this.txtCodEquipe.Leave += new System.EventHandler(this.txtCodEquipe_Leave);
            // 
            // rbtSeparar
            // 
            this.rbtSeparar.AutoSize = true;
            this.rbtSeparar.Checked = true;
            this.rbtSeparar.Location = new System.Drawing.Point(17, 112);
            this.rbtSeparar.Margin = new System.Windows.Forms.Padding(2);
            this.rbtSeparar.Name = "rbtSeparar";
            this.rbtSeparar.Size = new System.Drawing.Size(76, 17);
            this.rbtSeparar.TabIndex = 2;
            this.rbtSeparar.TabStop = true;
            this.rbtSeparar.Text = "Pendentes";
            this.rbtSeparar.UseVisualStyleBackColor = true;
            this.rbtSeparar.CheckedChanged += new System.EventHandler(this.rbtSeparar_CheckedChanged);
            // 
            // rbtSeparados
            // 
            this.rbtSeparados.AutoSize = true;
            this.rbtSeparados.Location = new System.Drawing.Point(97, 112);
            this.rbtSeparados.Margin = new System.Windows.Forms.Padding(2);
            this.rbtSeparados.Name = "rbtSeparados";
            this.rbtSeparados.Size = new System.Drawing.Size(76, 17);
            this.rbtSeparados.TabIndex = 3;
            this.rbtSeparados.TabStop = true;
            this.rbtSeparados.Text = "Separados";
            this.rbtSeparados.UseVisualStyleBackColor = true;
            this.rbtSeparados.CheckedChanged += new System.EventHandler(this.rbtSeparados_CheckedChanged);
            // 
            // txtPequisa
            // 
            this.txtPequisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPequisa.Location = new System.Drawing.Point(371, 111);
            this.txtPequisa.Margin = new System.Windows.Forms.Padding(2);
            this.txtPequisa.Name = "txtPequisa";
            this.txtPequisa.Size = new System.Drawing.Size(205, 20);
            this.txtPequisa.TabIndex = 13;
            this.txtPequisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPequisa_KeyDown);
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Location = new System.Drawing.Point(313, 113);
            this.lblPesquisa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(56, 13);
            this.lblPesquisa.TabIndex = 13;
            this.lblPesquisa.Text = "Pesquisar:";
            // 
            // rbdFinalizados
            // 
            this.rbdFinalizados.AutoSize = true;
            this.rbdFinalizados.Location = new System.Drawing.Point(178, 112);
            this.rbdFinalizados.Name = "rbdFinalizados";
            this.rbdFinalizados.Size = new System.Drawing.Size(77, 17);
            this.rbdFinalizados.TabIndex = 14;
            this.rbdFinalizados.TabStop = true;
            this.rbdFinalizados.Text = "Finalizados";
            this.rbdFinalizados.UseVisualStyleBackColor = true;
            this.rbdFinalizados.CheckedChanged += new System.EventHandler(this.rbdFinalizados_CheckedChanged);
            // 
            // frmSeparacaoPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 781);
            this.Controls.Add(this.rbdFinalizados);
            this.Controls.Add(this.lblPesquisa);
            this.Controls.Add(this.lblCodEquipe);
            this.Controls.Add(this.txtPequisa);
            this.Controls.Add(this.rbtSeparados);
            this.Controls.Add(this.rbtSeparar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.txtCodEquipe);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmSeparacaoPedido";
            this.Text = "Separação de Pedido";
            this.Load += new System.EventHandler(this.frmSeparacaoPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnGrava;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.CheckBox ckbDivide;
        private System.Windows.Forms.TextBox txtCodEquipe;
        private System.Windows.Forms.TextBox txtCodVenda;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label lblNomeEquipe;
        private System.Windows.Forms.Label lblCodEquipe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNomeCli;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.RadioButton rbtSeparar;
        private System.Windows.Forms.RadioButton rbtSeparados;
        private System.Windows.Forms.TextBox txtPequisa;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.ComboBox txtNomeEquipe;
        private System.Windows.Forms.RadioButton rbdFinalizados;
    }
}