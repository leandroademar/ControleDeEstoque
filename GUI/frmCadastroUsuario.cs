using System;
using BLL;
using DAL;
using Modelo;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmCadastroUsuario : GUI.frmModeloDeFormularioDeCadastro
    {
        public int perfil = 0;
        public int codigo = 0;
        public frmCadastroUsuario()
        {
            InitializeComponent();
        }
        
            
        


    
        public void LimpaTela()
        {
            txtCodUser.Clear();
            txtLogin.Clear();
            txtSenha.Clear();
            rbtAtendente.Checked = false;
            rbtGerente.Checked = false;
            rbtCaixa.Checked = false;
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alteraBotoes(2);
            txtLogin.Focus();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaTela();
            this.alteraBotoes(1);
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {   
            try
            {
                // 0 - Gerente
                // 1 - Atendente
                // 2 - Caixa
                int perfil = 0;

                if (rbtGerente.Checked == true)
                {
                    perfil = 1;
                }
                if (rbtAtendente.Checked == true)
                {
                    perfil = 2;
                }
                if (rbtCaixa.Checked == true)
                {
                    perfil = 3;
                }
                if (rdbSeparador.Checked == true)
                {
                    perfil = 4;
                }

                ModeloUsuario modelo = new ModeloUsuario();
                modelo.NomeUser = txtLogin.Text;
                modelo.SenhaUser = txtSenha.Text;
                modelo.PerfilUser = Convert.ToInt32(perfil);
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLUsuario bll = new BLLUsuario(cx);
            if (this.operacao == "inserir")
            {
                bll.Incluir(modelo);
                MessageBox.Show("Cadastro efetuado com sucesso");
            }
            else
            {
                //alterar uma categoria
                    modelo.CodUser = Convert.ToInt32(txtCodUser.Text);
                    modelo.SenhaUser = txtSenha.Text;
                    modelo.PerfilUser = Convert.ToInt32(perfil);
                    bll.Alterar(modelo);
                    MessageBox.Show("Cadastro alterado");
            }
            this.LimpaTela();
            this.alteraBotoes(1);
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaUsuario f = new frmConsultaUsuario();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLUsuario bll = new BLLUsuario(cx);
                ModeloUsuario modelo = bll.CarregaModeloUsuarioC(f.codigo);
                txtCodUser.Text = modelo.CodUser.ToString();
                txtLogin.Text = modelo.NomeUser;
                txtSenha.Text = modelo.SenhaUser;
                alteraBotoes(3);
            }
            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            f.Dispose();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.alteraBotoes(2);
        }
    }
}
