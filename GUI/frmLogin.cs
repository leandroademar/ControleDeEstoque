using System;
using DAL;
using Modelo;
using BLL;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace GUI
{
    public partial class Login : Form
    {
        public bool Logado { get; internal set; }
        public string Usuario { get; internal set; }
        public string Senha { get; internal set; }
        public int Perfil { get; internal set; }
        public int PerfilTed { get; internal set; }
        public string vUsuario;
        public string vSenha;
        
        public Login()
        {
            //vUsuario = txtUser.Text;
            InitializeComponent();
            txtUser.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter && !String.IsNullOrEmpty(txtUser.Text))
            {
                txtSenha.Focus();
            }
            
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter && !String.IsNullOrEmpty(txtSenha.Text))
                {
                    StreamReader arquivo = new StreamReader("ConfiguracaoBanco.txt");
                    DadosDaConexao.servidor = arquivo.ReadLine();
                    DadosDaConexao.banco = arquivo.ReadLine();
                    DadosDaConexao.usuario = arquivo.ReadLine();
                    DadosDaConexao.senha = arquivo.ReadLine();
                    arquivo.Close();
                    //testar a conexao
                    SqlConnection conexao = new SqlConnection();
                    conexao.ConnectionString = DadosDaConexao.StringDeConexao;
                    conexao.Open();
                    conexao.Close();


                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLUsuario bll = new BLLUsuario(cx);
                    ModeloUsuario modelo = bll.CarregaModeloUsuario(txtUser.Text, txtSenha.Text);
                    vUsuario = modelo.NomeUser.ToString();
                    vSenha = modelo.SenhaUser.ToString();
                    Perfil = modelo.PerfilUser;
                    PerfilTed = modelo.PerfilUser;
                    if (this.txtUser.Text == vUsuario && this.txtSenha.Text == vSenha)
                    {

                        Logado = true;
                        Usuario = txtUser.Text;
                        Perfil = modelo.PerfilUser;
                        PerfilTed = modelo.PerfilTed;
                        //Salvar o nome de usuário nas configurações do aplicativo
                        Properties.Settings.Default.Usuario = txtUser.Text;
                        Properties.Settings.Default.Perfil = modelo.PerfilUser;
                        Properties.Settings.Default.PerfilTed = modelo.PerfilUser;
                        Properties.Settings.Default.Save();
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Login inválido", "Atenção");
                    }

                }
            }
            catch (SqlException errob)
            {
                MessageBox.Show("Erro ao se conectar no banco de dados \n" +
                               "Acesse as configurações do banco de dados e informe os parâmetros de conexao");
                

            }
            catch (Exception erros)
            {
                MessageBox.Show(erros.Message);
                frmConfiguracaoBancoDados f = new frmConfiguracaoBancoDados();
                f.ShowDialog();
                f.Dispose();
            }


        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

            //Vincular Enter ao btnLogin
            //this.AcceptButton ;
            //Vincular ESC ao btnSair
            this.CancelButton = btnSair;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmConfiguracaoBancoDados f = new frmConfiguracaoBancoDados();
            f.Show();
        }
    }
}
