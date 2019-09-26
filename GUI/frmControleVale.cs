using System;
using Modelo;
using DAL;
using BLL;
using GUI.Consultas;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmControleVale : GUI.frmModeloDeFormularioDeCadastro
    {
        public int idtran = 0;
        public frmControleVale()
        {
            InitializeComponent();
            
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alteraBotoes(2);
            dtpDataDep.Enabled = false;
            txtVlrDep.ReadOnly = true;
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaVerba f = new frmConsultaVerba();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLVerba bll = new BLLVerba(cx);
                ModeloVerba modelo = bll.CarregaModeloVerba(f.codigo);
                idtran = modelo.IdTran;
                txtFornec.Text = modelo.NomeFornec.ToString();
                txtDescProd.Text = modelo.DescProd.ToString();
                txtObs.Text = modelo.Obs.ToString();
                txtQuantidade.Text = modelo.Quantidade.ToString();
                txtVlrMerc.Text = modelo.ValorMercado.ToString();
                txtVlrDesc.Text = modelo.ValorDesconto.ToString();
                txtVlrSaldo.Text = modelo.Saldo.ToString();
                txtQuantidade_Leave(sender, e);
                txtVlrDesc_Leave(sender, e);
                txtVlrMerc_Leave(sender, e);
                txtVlrSaldo_Leave(sender, e);
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
            operacao = "alterar";
            alteraBotoes(2);
            txtFornec.ReadOnly = true;
            txtQuantidade.ReadOnly = true;
            txtVlrDesc.ReadOnly = true;
            txtVlrMerc.ReadOnly = true;
            txtDescProd.ReadOnly = true;
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLSubCategoria bll = new BLLSubCategoria(cx);
                    bll.Excluir(Convert.ToInt32(idtran));
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

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //leitura dos dados
                ModeloVerba modelo = new ModeloVerba();
                modelo.CodFornec = 1;
                modelo.NomeFornec = txtFornec.Text.ToString();
                modelo.ValorMercado = Convert.ToDouble(txtVlrMerc.Text.ToString());
                modelo.ValorDesconto = Convert.ToDouble(txtVlrDesc.Text.ToString());
                modelo.Quantidade = Convert.ToDouble(txtQuantidade.Text.ToString());
                modelo.DescProd = txtDescProd.Text.ToString();
                modelo.Obs = txtObs.Text.ToString();

                //obj para gravar os dados no banco
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLVerba bll = new BLLVerba(cx);
                if (this.operacao == "inserir")
                {                 
                    bll.IncluirVerba(modelo);                    
                }
                else
                {
                   
                }
                this.LimpaTela();
                MessageBox.Show("Cadastro alterado");
                this.alteraBotoes(1);
                
            }
            catch (Exception erro)
            {
                System.Windows.MessageBox.Show(erro.Message);
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaTela();
            this.alteraBotoes(1);
        }
        public void LimpaTela()
        {
            txtFornec.Clear();
            txtDescProd.Clear();
            txtObs.Clear();
            txtQuantidade.Clear();
            txtVlrSaldo.Clear();
            txtVlrMerc.Clear();
            txtVlrDesc.Clear();
            txtVlrDep.Clear();


        }

        private void textBox3_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (!txtVlrMerc.Text.Contains(","))
                {
                    e.KeyChar = ',';
                }
                else e.Handled = true;
            }
            
        }

        private void textBox4_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (!txtVlrDesc.Text.Contains(","))
                {
                    e.KeyChar = ',';
                }
                else e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (!txtVlrSaldo.Text.Contains(","))
                {
                    e.KeyChar = ',';
                }
                else e.Handled = true;
            }
        }

        private void txtQuantidade_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (!txtQuantidade.Text.Contains(","))
                {
                    e.KeyChar = ',';
                }
                else e.Handled = true;
            }

        }

        private void txtQuantidade_Leave(object sender, EventArgs e)
        {

            if (txtQuantidade.Text.Contains(",") == false)
            {
                txtQuantidade.Text += ",00";
            }
            else
            {
                if (txtQuantidade.Text.IndexOf(",") == txtQuantidade.Text.Length - 1)
                {
                    txtQuantidade.Text += "00";
                }
            }
            try
            {
                Double d = Math.Round(Convert.ToDouble(txtQuantidade.Text), 2);
            }
            catch
            {
                txtQuantidade.Text = "0,00";
            }
        }

        private void txtVlrMerc_Leave(object sender, EventArgs e)
        {

            if (txtVlrMerc.Text.Contains(",") == false)
            {
                txtVlrMerc.Text += ",00";
            }
            else
            {
                if (txtVlrMerc.Text.IndexOf(",") == txtVlrMerc.Text.Length - 1)
                {
                    txtVlrMerc.Text += "00";
                }
            }
            try
            {
                Double d = Math.Round(Convert.ToDouble(txtVlrMerc.Text), 2);
            }
            catch
            {
                txtVlrMerc.Text = "0,00";
            }
        }

        private void txtVlrDesc_Leave(object sender, EventArgs e)
        {
            if (txtVlrDesc.Text.Contains(",") == false)
            {
                txtVlrDesc.Text += ",00";
            }
            else
            {
                if (txtVlrDesc.Text.IndexOf(",") == txtVlrDesc.Text.Length - 1)
                {
                    txtVlrDesc.Text += "00";
                }
            }
            try
            {
                Double d = Math.Round(Convert.ToDouble(txtVlrDesc.Text), 2);
            }
            catch
            {
                txtVlrDesc.Text = "0,00";
            }

            
        }

        private void txtVlrSaldo_Leave(object sender, EventArgs e)
        {
            if (txtVlrSaldo.Text.Contains(",") == false)
            {
                txtVlrSaldo.Text += ",00";
            }
            else
            {
                if (txtVlrSaldo.Text.IndexOf(",") == txtVlrSaldo.Text.Length - 1)
                {
                    txtVlrSaldo.Text += "00";
                }
            }
            try
            {
                Double d = Math.Round(Convert.ToDouble(txtVlrSaldo.Text), 2);
            }
            catch
            {
                txtVlrSaldo.Text = "0,00";
            }
        }

        private void textBox1_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (!txtVlrDep.Text.Contains(","))
                {
                    e.KeyChar = ',';
                }
                else e.Handled = true;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (txtVlrDep.Text.Contains(",") == false)
            {
                txtVlrDep.Text += ",00";
            }
            else
            {
                if (txtVlrDep.Text.IndexOf(",") == txtVlrDep.Text.Length - 1)
                {
                    txtVlrDep.Text += "00";
                }
            }
            try
            {
                Double d = Math.Round(Convert.ToDouble(txtVlrDep.Text), 2);
            }
            catch
            {
                txtVlrDep.Text = "0,00";
            }
        }

        private void textBox1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            try
            {
                if(e.KeyCode == Keys.Enter)
                {
                    ModeloVerba modelo = new ModeloVerba();
                    modelo.IdTran = idtran;
                    modelo.DataDep = dtpDataDep.Value.ToString("dd/MM/yyyy");
                    modelo.ValorMercado = Convert.ToDouble(txtVlrDep.Text.ToString());
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLVerba bll = new BLLVerba(cx);
                    bll.IncluirVerbaDep(modelo);
                    bll.AtualizaSaldo(modelo);
                    txtVlrSaldo.Text = (Convert.ToDouble(txtVlrSaldo.Text.ToString()) - Convert.ToDouble(txtVlrDep.Text.ToString())).ToString();
                    txtVlrSaldo_Leave(sender, e);
                    txtVlrDep.Clear();

                }


            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }

        private void frmControleVale_Load(object sender, EventArgs e)
        {
          

        }
    }
}
