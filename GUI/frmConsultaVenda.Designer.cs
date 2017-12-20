namespace GUI
{
    partial class frmConsultaVenda
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbGeral = new System.Windows.Forms.RadioButton();
            this.rbNome = new System.Windows.Forms.RadioButton();
            this.rbFornecedor = new System.Windows.Forms.RadioButton();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.pFornecedor = new System.Windows.Forms.Panel();
            this.lbForNome = new System.Windows.Forms.Label();
            this.lblNomeCli = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbcDadosVenda = new System.Windows.Forms.TabControl();
            this.tbpVenda = new System.Windows.Forms.TabPage();
            this.tbpItensVenda = new System.Windows.Forms.TabPage();
            this.dgvItensConsulta = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.pFornecedor.SuspendLayout();
            this.tbcDadosVenda.SuspendLayout();
            this.tbpVenda.SuspendLayout();
            this.tbpItensVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItensConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbGeral);
            this.groupBox1.Controls.Add(this.rbNome);
            this.groupBox1.Controls.Add(this.rbFornecedor);
            this.groupBox1.Location = new System.Drawing.Point(20, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(840, 57);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consultar pelo:";
            // 
            // rbGeral
            // 
            this.rbGeral.AutoSize = true;
            this.rbGeral.Checked = true;
            this.rbGeral.Location = new System.Drawing.Point(18, 26);
            this.rbGeral.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbGeral.Name = "rbGeral";
            this.rbGeral.Size = new System.Drawing.Size(158, 24);
            this.rbGeral.TabIndex = 3;
            this.rbGeral.TabStop = true;
            this.rbGeral.Text = "Todas as Vendas";
            this.rbGeral.UseVisualStyleBackColor = true;
            this.rbGeral.CheckedChanged += new System.EventHandler(this.rbGeral_CheckedChanged);
            // 
            // rbNome
            // 
            this.rbNome.AutoSize = true;
            this.rbNome.Location = new System.Drawing.Point(182, 26);
            this.rbNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbNome.Name = "rbNome";
            this.rbNome.Size = new System.Drawing.Size(151, 24);
            this.rbNome.TabIndex = 1;
            this.rbNome.Text = "Nome do Cliente";
            this.rbNome.UseVisualStyleBackColor = true;
            this.rbNome.CheckedChanged += new System.EventHandler(this.rbGeral_CheckedChanged);
            // 
            // rbFornecedor
            // 
            this.rbFornecedor.AutoSize = true;
            this.rbFornecedor.Location = new System.Drawing.Point(339, 26);
            this.rbFornecedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbFornecedor.Name = "rbFornecedor";
            this.rbFornecedor.Size = new System.Drawing.Size(128, 24);
            this.rbFornecedor.TabIndex = 0;
            this.rbFornecedor.Text = "Reimpressão";
            this.rbFornecedor.UseVisualStyleBackColor = true;
            this.rbFornecedor.CheckedChanged += new System.EventHandler(this.rbGeral_CheckedChanged);
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDados.Location = new System.Drawing.Point(3, 3);
            this.dgvDados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvDados.RowTemplate.Height = 24;
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.Size = new System.Drawing.Size(823, 490);
            this.dgvDados.TabIndex = 12;
            this.dgvDados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellClick);
            this.dgvDados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellDoubleClick);
            // 
            // pFornecedor
            // 
            this.pFornecedor.Controls.Add(this.textBox1);
            this.pFornecedor.Controls.Add(this.lbForNome);
            this.pFornecedor.Controls.Add(this.lblNomeCli);
            this.pFornecedor.Location = new System.Drawing.Point(22, 78);
            this.pFornecedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pFornecedor.Name = "pFornecedor";
            this.pFornecedor.Size = new System.Drawing.Size(840, 50);
            this.pFornecedor.TabIndex = 14;
            // 
            // lbForNome
            // 
            this.lbForNome.AutoSize = true;
            this.lbForNome.Location = new System.Drawing.Point(252, 46);
            this.lbForNome.Name = "lbForNome";
            this.lbForNome.Size = new System.Drawing.Size(0, 20);
            this.lbForNome.TabIndex = 3;
            // 
            // lblNomeCli
            // 
            this.lblNomeCli.AutoSize = true;
            this.lblNomeCli.Location = new System.Drawing.Point(11, 13);
            this.lblNomeCli.Name = "lblNomeCli";
            this.lblNomeCli.Size = new System.Drawing.Size(126, 20);
            this.lblNomeCli.TabIndex = 0;
            this.lblNomeCli.Text = "Nome do Cliente";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(143, 10);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(452, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // tbcDadosVenda
            // 
            this.tbcDadosVenda.Controls.Add(this.tbpVenda);
            this.tbcDadosVenda.Controls.Add(this.tbpItensVenda);
            this.tbcDadosVenda.Location = new System.Drawing.Point(23, 137);
            this.tbcDadosVenda.Name = "tbcDadosVenda";
            this.tbcDadosVenda.SelectedIndex = 0;
            this.tbcDadosVenda.Size = new System.Drawing.Size(837, 529);
            this.tbcDadosVenda.TabIndex = 16;
            // 
            // tbpVenda
            // 
            this.tbpVenda.Controls.Add(this.dgvDados);
            this.tbpVenda.Location = new System.Drawing.Point(4, 29);
            this.tbpVenda.Name = "tbpVenda";
            this.tbpVenda.Padding = new System.Windows.Forms.Padding(3);
            this.tbpVenda.Size = new System.Drawing.Size(829, 496);
            this.tbpVenda.TabIndex = 0;
            this.tbpVenda.Text = "Vendas";
            this.tbpVenda.UseVisualStyleBackColor = true;
            // 
            // tbpItensVenda
            // 
            this.tbpItensVenda.Controls.Add(this.dgvItensConsulta);
            this.tbpItensVenda.Location = new System.Drawing.Point(4, 29);
            this.tbpItensVenda.Name = "tbpItensVenda";
            this.tbpItensVenda.Padding = new System.Windows.Forms.Padding(3);
            this.tbpItensVenda.Size = new System.Drawing.Size(829, 496);
            this.tbpItensVenda.TabIndex = 1;
            this.tbpItensVenda.Text = "Produtos da Venda";
            this.tbpItensVenda.UseVisualStyleBackColor = true;
            // 
            // dgvItensConsulta
            // 
            this.dgvItensConsulta.AllowUserToAddRows = false;
            this.dgvItensConsulta.AllowUserToDeleteRows = false;
            this.dgvItensConsulta.AllowUserToResizeRows = false;
            this.dgvItensConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItensConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItensConsulta.Location = new System.Drawing.Point(3, 3);
            this.dgvItensConsulta.Name = "dgvItensConsulta";
            this.dgvItensConsulta.ReadOnly = true;
            this.dgvItensConsulta.RowTemplate.Height = 28;
            this.dgvItensConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItensConsulta.Size = new System.Drawing.Size(823, 490);
            this.dgvItensConsulta.TabIndex = 0;
            // 
            // frmConsultaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 691);
            this.Controls.Add(this.pFornecedor);
            this.Controls.Add(this.tbcDadosVenda);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmConsultaVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Vendas";
            this.Load += new System.EventHandler(this.frmConsultaCompra_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.pFornecedor.ResumeLayout(false);
            this.pFornecedor.PerformLayout();
            this.tbcDadosVenda.ResumeLayout(false);
            this.tbpVenda.ResumeLayout(false);
            this.tbpItensVenda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItensConsulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbNome;
        private System.Windows.Forms.RadioButton rbFornecedor;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.RadioButton rbGeral;
        private System.Windows.Forms.Panel pFornecedor;
        private System.Windows.Forms.Label lbForNome;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblNomeCli;
        private System.Windows.Forms.TabControl tbcDadosVenda;
        private System.Windows.Forms.TabPage tbpVenda;
        private System.Windows.Forms.TabPage tbpItensVenda;
        private System.Windows.Forms.DataGridView dgvItensConsulta;
    }
}