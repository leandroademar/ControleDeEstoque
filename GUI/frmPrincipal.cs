using DAL;
using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmPrincipal : Form
    {
        
        public frmPrincipal(string usuario, int perfil,int perfilted)
        {
            InitializeComponent();
            tstNomeUser.Text = " Usuário: " + usuario;
            perfilusuario(perfil);
            if(perfilted==1)
            {
                financeiroToolStripMenuItem.Visible = true;
            }
            if (perfilted == 3)
            {
                AbrirCaixa();
            }

        }
        public void AbrirCaixa()
        {
            frmMovimentacaoVenda f = new frmMovimentacaoVenda();
            if (Application.OpenForms[f.Name] == null)
            {
                f.ShowDialog();
                f.Dispose();
            }
            else
            {
                Application.OpenForms[f.Name].Focus();
            }
        }
        private void CheckMdiChildren(Form form)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.GetType() == form.GetType())
                {
                    frm.Focus();
                    return;
                }
            }
            form.MdiParent = this;
            form.Show();
        }
        public void perfilusuario(int pf)
        {
            if(pf==1)
            {
                toolStrip1.Visible = false;
            }
            if(pf==2)
            {
                menuStrip1.Visible = false;
                toolStripButton1.Visible = false;
                toolStripButton3.Visible = true;
                toolStripButton4.Visible = false;
                toolStripButton5.Visible = false;
                toolStripButton6.Visible = false;
                toolStripButton2.Visible = false;

            }
            if (pf == 3)
            {
                menuStrip1.Visible = false;
                toolStripButton1.Visible = true;
                toolStripButton3.Visible = false;
                toolStripButton4.Visible = false;
                toolStripButton6.Visible = false;
                toolStripButton2.Visible = false;
                toolStripButton5.Visible = false;

            }
            if (pf == 4)
            {
                menuStrip1.Visible = false;
                toolStripButton1.Visible = false;
                toolStripButton3.Visible = false;
                toolStripButton2.Visible = true;
                toolStripButton6.Visible = false;
                toolStripButton4.Visible = false;
                toolStripButton5.Visible = false;

            }
            if (pf == 0)
            {
                menuStrip1.Visible = false;
                toolStripButton1.Visible = false;
                toolStripButton2.Visible = false;
                toolStripButton3.Visible = false;
                toolStripButton4.Visible = false;
                toolStripButton6.Visible = false;
                toolStripButton5.Visible = false;

            }
        }



        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroCategoria f = new frmCadastroCategoria();
            CheckMdiChildren(f);
        }

        private void categoriaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaCategoria f = new frmConsultaCategoria();
            CheckMdiChildren(f);
        }

        private void subCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroSubCategoria f = new frmCadastroSubCategoria();
            CheckMdiChildren(f);
        }

        private void subCategoriaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaSubCategoria f = new frmConsultaSubCategoria();
            CheckMdiChildren(f);
        }

        private void unidadeDeMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastrounidadeDeMedida f = new frmCadastrounidadeDeMedida();
            CheckMdiChildren(f);
        }

        private void unidadeDeMedidaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaUnidadeDeMedida f = new frmConsultaUnidadeDeMedida();
            CheckMdiChildren(f);
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroProduto f = new frmCadastroProduto();
            CheckMdiChildren(f);
        }

        private void produtoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaProduto f = new frmConsultaProduto(0);
            CheckMdiChildren(f);
        }

        private void configuraçãoDoBancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConfiguracaoBancoDados f = new frmConfiguracaoBancoDados();
            CheckMdiChildren(f);
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //verifica conexao com o banco
            

            try
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
                tssBanco.Text = "Banco de Dados: " + DadosDaConexao.banco.ToString() +" | ";
                tssServer.Text = "Servidor: " + DadosDaConexao.servidor.ToString();
                




            }
            catch (SqlException errob)
            {
                MessageBox.Show("Erro ao se conectar no banco de dados \n" +
                                "Acesse as configurações do banco de dados e informe os parâmetros de conexao");
                frmConfiguracaoBancoDados f = new frmConfiguracaoBancoDados();
                f.ShowDialog();
                f.Dispose();
                
            }
            catch (Exception erros)
            {
                MessageBox.Show(erros.Message);
            }

        }

        private void backupDoBancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBackupBancoDeDados f = new frmBackupBancoDeDados();
            CheckMdiChildren(f);
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void explorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer");
        }

        private void blocoDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad");
        }

        private void tipoDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroTipoPagamento f = new frmCadastroTipoPagamento();
            CheckMdiChildren(f);
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroCliente f = new frmCadastroCliente();
            CheckMdiChildren(f);
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaCliente f = new frmConsultaCliente();
            CheckMdiChildren(f);
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroFornecedor f = new frmCadastroFornecedor();
            CheckMdiChildren(f);
        }

        private void fornecedorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaFornecedor f = new frmConsultaFornecedor();
            CheckMdiChildren(f);
        }

        private void tipoDePagamentoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaTipoPagamento f = new frmConsultaTipoPagamento();
            CheckMdiChildren(f);
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void todasHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void fecharTodasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        public void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmMovimentacaoVenda f = new frmMovimentacaoVenda();
            if (Application.OpenForms[f.Name] == null)
            {
                f.ShowDialog();
                f.Dispose();
            }
            else
            {
                Application.OpenForms[f.Name].Focus();
            }

        }
        


        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMovimentacaoPedido f = new frmMovimentacaoPedido();
            CheckMdiChildren(f);
        }

        private void receberVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMovimentacaoVenda f = new frmMovimentacaoVenda();
            if (Application.OpenForms[f.Name] == null)
            {
                f.ShowDialog();
                f.Dispose();
            }
            else
            {
                Application.OpenForms[f.Name].Focus();
            }
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login f = new Login();
            f.Visible = true;
            f.Close();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            frmMovimentacaoPedido f = new frmMovimentacaoPedido();
            CheckMdiChildren(f);
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroUsuario f = new frmCadastroUsuario();
            CheckMdiChildren(f);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            frmFechamentoCaixa f = new frmFechamentoCaixa();
            CheckMdiChildren(f);
        }

        private void mapaDeSeparaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSeparacaoPedido f = new frmSeparacaoPedido();
            CheckMdiChildren(f);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmSeparacaoPedido f = new frmSeparacaoPedido();
            CheckMdiChildren(f);
        }

        private void tlsLogoff_Click(object sender, EventArgs e)
        {


        }

        private void tlsLogoff_DoubleClick(object sender, EventArgs e)
        {

           
        }

        private void frmPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F2)
            {
                frmMovimentacaoPedido f = new frmMovimentacaoPedido();
                CheckMdiChildren(f);
            }
        }

        private void suprirEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {

                frmSuprirEstoque f = new frmSuprirEstoque();
                CheckMdiChildren(f);
            

        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            frmSuprirEstoque f = new frmSuprirEstoque();
            CheckMdiChildren(f);
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmParametroRel f = new frmParametroRel(1);
            CheckMdiChildren(f);
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            frmConsultaProduto f = new frmConsultaProduto(0);
            CheckMdiChildren(f);

        }

        private void tesourariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmParametroRel f = new frmParametroRel(2);
            CheckMdiChildren(f);
        }

        private void separaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelSepara f = new frmRelSepara();
            CheckMdiChildren(f);
        }

        private void equipeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroEquipe f = new frmCadastroEquipe();
            CheckMdiChildren(f);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            frmParametroRel f = new frmParametroRel(3);
            CheckMdiChildren(f);
        }

        private void atualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("O sistema será fechado para você \n" +
                                                        "prosseguir com a atualização.","Atualização",MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(@"P:\ATUALIZACAO\nAtualizador.exe");
                Application.Exit();
                
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            atualizarToolStripMenuItem_Click(sender, e);
        }

        private void tesourariaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmFechamentoCaixa f = new frmFechamentoCaixa();
            CheckMdiChildren(f);
        }

        private void tesourariaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmFechamentoCaixa f = new frmFechamentoCaixa();
            CheckMdiChildren(f);
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            frmCadastroTED f = new frmCadastroTED();
            CheckMdiChildren(f);
        }

        private void transferênciasTEDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroTED f = new frmCadastroTED();
            CheckMdiChildren(f);
        }

        private void controleDeValeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmControleVale f = new frmControleVale();
            CheckMdiChildren(f);
        }

        private void retiradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLctoFin f = new frmLctoFin();
            CheckMdiChildren(f);
        }

        private void separaçãoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmParametroRel f = new frmParametroRel(3);
            CheckMdiChildren(f);
        }
    }
}
