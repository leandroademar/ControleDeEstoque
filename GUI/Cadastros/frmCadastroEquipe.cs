using BLL;
using DAL;
using Modelo;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmCadastroEquipe : GUI.frmModeloDeFormularioDeCadastro
    {
        public frmCadastroEquipe()
        {
            InitializeComponent();
        }

        public void LimpaTela()
        {
            txtCod.Clear();
            txtNome.Clear();
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alteraBotoes(2);
            txtNome.Focus();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {

                ModeloEquipe modelo = new ModeloEquipe();
                modelo.NomeEquipe = txtNome.Text;
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLEquipe bll = new BLLEquipe(cx);
                if (this.operacao == "inserir")
                {
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado com sucesso");
                }
                else
                {
                    //alterar uma categoria
                    modelo.CodEquipe = Convert.ToInt32(txtCod.Text);
                    modelo.NomeEquipe = txtNome.Text;
                    bll.Alterar(modelo);
                    MessageBox.Show("Cadastro alterado");
                }
                this.LimpaTela();
                this.alteraBotoes(1);

            }catch (Exception erro)

            {
                MessageBox.Show(erro.Message);
            }

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            LimpaTela();
            this.alteraBotoes(1);
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaUsuario f = new frmConsultaUsuario(1);
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLEquipe bll = new BLLEquipe(cx);
                ModeloEquipe modelo = bll.CarregaModeloEquipe(f.codigo);
                txtCod.Text = modelo.CodEquipe.ToString();
                txtNome.Text = modelo.NomeEquipe;
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

        private void btExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLEquipe bll = new BLLEquipe(cx);
                    bll.Excluir(Convert.ToInt32(txtCod.Text));
                    this.LimpaTela();
                    this.alteraBotoes(1);
                }
            }
            catch
            {
                MessageBox.Show("Impossível excluir o registro. \n O registro esta sendo utilizado em outro local.");
                this.alteraBotoes(3);
            }
        }
    }

}
