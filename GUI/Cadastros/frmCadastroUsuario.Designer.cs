namespace GUI
{
    partial class frmCadastroUsuario
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
            this.txtCodUser = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.gbxPerfil = new System.Windows.Forms.GroupBox();
            this.rdbSeparador = new System.Windows.Forms.RadioButton();
            this.rbtCaixa = new System.Windows.Forms.RadioButton();
            this.rbtAtendente = new System.Windows.Forms.RadioButton();
            this.rbtGerente = new System.Windows.Forms.RadioButton();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.pnDados.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            this.gbxPerfil.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.lblSenha);
            this.pnDados.Controls.Add(this.lblLogin);
            this.pnDados.Controls.Add(this.lblCodigo);
            this.pnDados.Controls.Add(this.gbxPerfil);
            this.pnDados.Controls.Add(this.txtSenha);
            this.pnDados.Controls.Add(this.txtLogin);
            this.pnDados.Controls.Add(this.txtCodUser);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(146, 4);
            this.btCancelar.Margin = new System.Windows.Forms.Padding(1);
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(112, 4);
            this.btSalvar.Margin = new System.Windows.Forms.Padding(1);
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(290, 4);
            this.btExcluir.Margin = new System.Windows.Forms.Padding(1);
            this.btExcluir.Visible = false;
            // 
            // btAlterar
            // 
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btLocalizar
            // 
            this.btLocalizar.Click += new System.EventHandler(this.btLocalizar_Click);
            // 
            // btInserir
            // 
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // txtCodUser
            // 
            this.txtCodUser.Location = new System.Drawing.Point(96, 18);
            this.txtCodUser.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodUser.Name = "txtCodUser";
            this.txtCodUser.ReadOnly = true;
            this.txtCodUser.Size = new System.Drawing.Size(68, 20);
            this.txtCodUser.TabIndex = 0;
            // 
            // txtLogin
            // 
            this.txtLogin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLogin.Location = new System.Drawing.Point(96, 51);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(2);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(196, 20);
            this.txtLogin.TabIndex = 1;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(96, 86);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(2);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(155, 20);
            this.txtSenha.TabIndex = 2;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // gbxPerfil
            // 
            this.gbxPerfil.Controls.Add(this.rdbSeparador);
            this.gbxPerfil.Controls.Add(this.rbtCaixa);
            this.gbxPerfil.Controls.Add(this.rbtAtendente);
            this.gbxPerfil.Controls.Add(this.rbtGerente);
            this.gbxPerfil.Location = new System.Drawing.Point(21, 115);
            this.gbxPerfil.Margin = new System.Windows.Forms.Padding(2);
            this.gbxPerfil.Name = "gbxPerfil";
            this.gbxPerfil.Padding = new System.Windows.Forms.Padding(2);
            this.gbxPerfil.Size = new System.Drawing.Size(309, 65);
            this.gbxPerfil.TabIndex = 3;
            this.gbxPerfil.TabStop = false;
            this.gbxPerfil.Text = "Perfil do Usuário";
            // 
            // rdbSeparador
            // 
            this.rdbSeparador.AutoSize = true;
            this.rdbSeparador.Location = new System.Drawing.Point(215, 25);
            this.rdbSeparador.Margin = new System.Windows.Forms.Padding(2);
            this.rdbSeparador.Name = "rdbSeparador";
            this.rdbSeparador.Size = new System.Drawing.Size(74, 17);
            this.rdbSeparador.TabIndex = 7;
            this.rdbSeparador.TabStop = true;
            this.rdbSeparador.Text = "Separador";
            this.rdbSeparador.UseVisualStyleBackColor = true;
            // 
            // rbtCaixa
            // 
            this.rbtCaixa.AutoSize = true;
            this.rbtCaixa.Location = new System.Drawing.Point(160, 25);
            this.rbtCaixa.Margin = new System.Windows.Forms.Padding(2);
            this.rbtCaixa.Name = "rbtCaixa";
            this.rbtCaixa.Size = new System.Drawing.Size(51, 17);
            this.rbtCaixa.TabIndex = 6;
            this.rbtCaixa.TabStop = true;
            this.rbtCaixa.Text = "Caixa";
            this.rbtCaixa.UseVisualStyleBackColor = true;
            // 
            // rbtAtendente
            // 
            this.rbtAtendente.AutoSize = true;
            this.rbtAtendente.Location = new System.Drawing.Point(83, 25);
            this.rbtAtendente.Margin = new System.Windows.Forms.Padding(2);
            this.rbtAtendente.Name = "rbtAtendente";
            this.rbtAtendente.Size = new System.Drawing.Size(74, 17);
            this.rbtAtendente.TabIndex = 5;
            this.rbtAtendente.TabStop = true;
            this.rbtAtendente.Text = "Atendente";
            this.rbtAtendente.UseVisualStyleBackColor = true;
            // 
            // rbtGerente
            // 
            this.rbtGerente.AutoSize = true;
            this.rbtGerente.Location = new System.Drawing.Point(17, 25);
            this.rbtGerente.Margin = new System.Windows.Forms.Padding(2);
            this.rbtGerente.Name = "rbtGerente";
            this.rbtGerente.Size = new System.Drawing.Size(63, 17);
            this.rbtGerente.TabIndex = 4;
            this.rbtGerente.TabStop = true;
            this.rbtGerente.Text = "Gerente";
            this.rbtGerente.UseVisualStyleBackColor = true;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(50, 19);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 4;
            this.lblCodigo.Text = "Código:";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(57, 53);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(36, 13);
            this.lblLogin.TabIndex = 5;
            this.lblLogin.Text = "Login:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(52, 88);
            this.lblSenha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(41, 13);
            this.lblSenha.TabIndex = 6;
            this.lblSenha.Text = "Senha:";
            // 
            // frmCadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(586, 449);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "frmCadastroUsuario";
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            this.gbxPerfil.ResumeLayout(false);
            this.gbxPerfil.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodUser;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.GroupBox gbxPerfil;
        private System.Windows.Forms.RadioButton rbtCaixa;
        private System.Windows.Forms.RadioButton rbtAtendente;
        private System.Windows.Forms.RadioButton rbtGerente;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.RadioButton rdbSeparador;
    }
}
