using BLL;
using DAL;
using GUI.Consultas;
using Modelo;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmLctoVerba : Form
    {
        public int idtran = 0;
        public string operacao = "";
        public frmLctoVerba()
        {
            InitializeComponent();
        }

        private void BtLocalizar_Click(object sender, EventArgs e)
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
                TxtQuantidade_Leave(sender, e);
                TxtVlrDesc_Leave(sender, e);
                TxtVlrMerc_Leave(sender, e);
                TxtVlrSaldo_Leave(sender, e);
                AtualizaDgvDep();
                alteraBotoes(3);
            }
            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            f.Dispose();
        }
        public void alteraBotoes(int op)
        {
            // op = operaçoes que serao feitas com os botoes
            // 1  = Preparar os botoes para inserir e localizar
            // 2  = preparar os para inserir/alterar um registro
            // 3  = preparar a tela para excluir ou alterar

            pnDados.Enabled = false;
            btInserir.Enabled = false;
            btAlterar.Enabled = false;
            btLocalizar.Enabled = false;
            btExcluir.Enabled = false;
            btCancelar.Enabled = false;
            btSalvar.Enabled = false;

            if (op == 1)
            {
                btInserir.Enabled = true;
                btLocalizar.Enabled = true;
            }
            if (op == 2)
            {
                pnDados.Enabled = true;
                btSalvar.Enabled = true;
                btCancelar.Enabled = true;
            }
            if (op == 3)
            {
                btAlterar.Enabled = true;
                btExcluir.Enabled = true;
                btCancelar.Enabled = true;
            }
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
            dgvDeposito.DataSource = "";


        }

        private void TxtQuantidade_Leave(object sender, EventArgs e)
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

        private void TxtVlrMerc_Leave(object sender, EventArgs e)
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

        private void TxtVlrDesc_Leave(object sender, EventArgs e)
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

        private void TxtVlrSaldo_Leave(object sender, EventArgs e)
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

        private void TxtVlrDep_Leave(object sender, EventArgs e)
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

        private void FrmLctoVerba_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.alteraBotoes(1);
        }

        private void BtInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alteraBotoes(2);
            txtFornec.Focus();
            txtFornec.ReadOnly = false;
            txtQuantidade.ReadOnly = false;
            txtVlrDesc.ReadOnly = false;
            txtVlrMerc.ReadOnly = false;
            txtDescProd.ReadOnly = false;
            txtObs.ReadOnly = false;
            dtpDataDep.Enabled = false;
            txtVlrDep.ReadOnly = true;

        }

        private void BtAlterar_Click(object sender, EventArgs e)
        {
            operacao = "alterar";
           
            alteraBotoes(2);
            dtpDataDep.Focus();
            txtFornec.ReadOnly = true;
            txtQuantidade.ReadOnly = true;
            txtVlrDesc.ReadOnly = true;
            txtVlrMerc.ReadOnly = true;
            dtpDataDep.Enabled = true;
            txtVlrDep.ReadOnly = false;
            txtDescProd.ReadOnly = true;
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaTela();
            this.alteraBotoes(1);
        }

        private void BtSalvar_Click(object sender, EventArgs e)
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
                MessageBox.Show("Registro Salvo com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.alteraBotoes(1);

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void TxtVlrDep_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    ModeloVerba modelo = new ModeloVerba();
                    modelo.IdTran = idtran;
                    modelo.DataDep = dtpDataDep.Value.ToString("yyyy-MM-dd");
                    modelo.ValorMercado = Convert.ToDouble(txtVlrDep.Text.ToString());
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLVerba bll = new BLLVerba(cx);
                    bll.IncluirVerbaDep(modelo);
                    bll.AtualizaSaldo(modelo);
                    txtVlrSaldo.Text = (Convert.ToDouble(txtVlrSaldo.Text.ToString()) - Convert.ToDouble(txtVlrDep.Text.ToString())).ToString();
                    TxtVlrSaldo_Leave(sender, e);
                    AtualizaDgvDep();
                    txtVlrDep.Clear();

                }
            }

            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void TxtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TxtVlrMerc_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TxtVlrDesc_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TxtVlrSaldo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TxtVlrDep_KeyPress(object sender, KeyPressEventArgs e)
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



        private void FrmLctoVerba_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void BtExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (d.ToString() == "Yes")
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLVerba bll = new BLLVerba(cx);
                    ModeloVerba modelo = new ModeloVerba();
                    modelo.IdTran = idtran;
                    bll.Excluir(modelo);
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
        public void AtualizaDgvDep()
        {

       
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLVerba bll = new BLLVerba(cx);
            ModeloVerba modelo = new ModeloVerba();
            modelo.IdTran = idtran;
            dgvDeposito.DataSource = bll.LocalizarDep(idtran);
            bll.AtualizaSaldo(modelo);
            dgvDeposito.Columns[2].Visible = false;
   
   

        }

        private void DgvDeposito_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Deseja excluir da verba selecionada este valor ?", "Exclusão de Deposito", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dialogResult == DialogResult.Yes)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLVerba bll = new BLLVerba(cx);
                ModeloVerba modelo = new ModeloVerba();
                modelo.IdTran = Convert.ToInt32(dgvDeposito.CurrentRow.Cells[2].Value.ToString());
                bll.Deleta(modelo);
                AtualizaDgvDep();


            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }
    }

}
