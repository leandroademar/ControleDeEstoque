using DAL;
using Modelo;
using System;
using System.Windows.Forms;
using BLL;

namespace GUI
{
    public partial class frmCadastroTED : GUI.frmModeloDeFormularioDeCadastro
    {
        public string User="";
        public frmCadastroTED()
        {
            InitializeComponent();
            User = Properties.Settings.Default.Usuario;
            this.WindowState = FormWindowState.Maximized;
            dtpData.Value = Convert.ToDateTime("01/01/2000 00:00");
            btAlterar.Visible = false;
            btExcluir.Visible = false;

        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alteraBotoes(2);
          
            dtpData.Value = Convert.ToDateTime("01/01/2000 00:00");
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {

        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.alteraBotoes(2);
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //leitura dos dados
                ModeloTransf modelo = new ModeloTransf();
                modelo.NomeBanco = cbxBanco.Text;
                modelo.NomeCliente = txtCliente.Text;
                modelo.DtTransf = dtpData.Text.ToString();
                modelo.Hora = maskedTextBox1.Text.ToString();
                modelo.Usuario = User;
                modelo.Valor = Convert.ToDouble(txtValor.Text.ToString());

                //obj para gravar os dados no banco
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLTransf bll = new BLLTransf(cx);
                if (this.operacao == "inserir")
                {
                    //cadastrar uma categoria
                    bll.Incluir(modelo);
                    LimpaTela();
                    //MessageBox.Show("Cadastro efetuado: Código " + modelo.CatCod.ToString());

                }
                else
                {
                    //alterar uma categoria
                    //modelo.CatCod = Convert.ToInt32(txtCodigo.Text);
                    //bll.Alterar(modelo);
                    //MessageBox.Show("Cadastro alterado");
                }
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            this.LimpaTela();
        }
        public void LimpaTela()
        {
            cbxBanco.Text = "";
            txtCliente.Clear();
            dtpData.Value = Convert.ToDateTime("01/01/2000 00:00");
            txtValor.Clear();
            maskedTextBox1.Clear();


        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter && cbxBanco.Text != "")
            {
                txtCliente.Focus();
            }
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
           

            

            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.' ) 
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (!txtValor.Text.Contains(","))
                {
                    e.KeyChar = ',';
                }
                else e.Handled = true;
            }
        }
    }
}
