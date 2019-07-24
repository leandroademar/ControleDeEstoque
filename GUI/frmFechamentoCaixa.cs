using BLL;
using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmFechamentoCaixa : Form
    {
        public int dia;
        public int seg = 1;
        public int _numtrans = 0;
        public int __caixa = 0;
        public string __nome = "";
        public int __turno = 0;

        public frmFechamentoCaixa()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            rbtAtacado.Checked = true;


            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLTABCaixa bll = new BLLTABCaixa(cx);
            dgvTABCaixas.DataSource = bll.LocalizarCaixas(Convert.ToInt32(cbxTurno.Text), (rbtAtacado.Checked == true) ? 1 : 0, (cbxDia.Checked == true) ? 1 : 0, dtpMovimento.Value.ToString("yyyy-MM-dd"));
            this.AtualizadgvTABCaixa();
            AlteraCampos(1);

        }

        public void LimpaCampos()
        {
            txtDinheiro.Clear();
            txtBanese.Clear();
            txtCDrede.Clear();
            txtTEDelet.Clear();
            txtCheque.Clear();
            txtCCrede.Clear();
            txtCCtks.Clear();
            txtCDtks.Clear();
            txtMoedas.Clear();
            txtOutros.Clear();
        }

        public void AlteraCampos(int op)
        {
            if (op == 1)
            {
                txtDinheiro.Enabled = false;
                txtBanese.Enabled = false;
                txtCDrede.Enabled = false;
                txtTEDelet.Enabled = false;
                txtCheque.Enabled = false;
                txtCCrede.Enabled = false;
                txtCCtks.Enabled = false;
                txtCDtks.Enabled = false;
                txtMoedas.Enabled = false;
                txtOutros.Enabled = false;
                btnAvulso.Visible = false;
                btnTransf.Visible = false;


            }
            else
            {
                txtDinheiro.Enabled = true;
                txtBanese.Enabled = true;
                txtCDrede.Enabled = true;
                txtTEDelet.Enabled = true;
                txtCheque.Enabled = true;
                txtCCrede.Enabled = true;
                txtCCtks.Enabled = true;
                txtCDtks.Enabled = true;
                txtMoedas.Enabled = true;
                txtOutros.Enabled = true;
                btnAvulso.Visible = true;
                btnTransf.Visible = true;
            }

        }

        public void AtualizadgvTABCaixa()
        {
            
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLTABCaixa bll = new BLLTABCaixa(cx);
            dgvTABCaixas.DataSource = bll.LocalizarCaixas(Convert.ToInt32(cbxTurno.Text), (rbtAtacado.Checked == true) ? 1 : 0, (cbxDia.Checked == true) ? 1 : 0, dtpMovimento.Value.ToString("yyyy-MM-dd"));
            dgvTABCaixas.RowHeadersVisible = false;
            dgvTABCaixas.ReadOnly = true;
            dgvTABCaixas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTABCaixas.Columns[1].HeaderText = "Caixa";
            dgvTABCaixas.Columns[2].HeaderText = "Operador";
            dgvTABCaixas.Columns[3].HeaderText = "Nome";
            dgvTABCaixas.Columns[12].HeaderText = "Turno";
            dgvTABCaixas.Columns[3].Width = 420;
            dgvTABCaixas.Columns[0].Visible = false;
            dgvTABCaixas.Columns[4].Visible = false;
            dgvTABCaixas.Columns[5].Visible = false;
            dgvTABCaixas.Columns[6].Visible = false;
            dgvTABCaixas.Columns[7].Visible = false;
            dgvTABCaixas.Columns[8].Visible = false;
            dgvTABCaixas.Columns[9].Visible = false;
            dgvTABCaixas.Columns[10].Visible = false;
            dgvTABCaixas.Columns[11].Visible = false;
            dgvTABCaixas.Columns[13].Visible = false;
            dgvTABCaixas.Columns[14].Visible = false;
            dgvTABCaixas.Columns[15].Visible = false;
            dgvTABCaixas.Columns[16].Visible = false;
            this.AtualizaTotais(1);
        }

        private void txtBanese_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (!txtBanese.Text.Contains(","))
                {
                    e.KeyChar = ',';
                }
                else e.Handled = true;
            }
        }

        private void txtCCrede_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (!txtCCrede.Text.Contains(","))
                {
                    e.KeyChar = ',';
                }
                else e.Handled = true;
            }
        }


        public int _transacao = 0;

        private void dgvTABCaixas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.AlteraCampos(1);
            

            if (e.RowIndex >= 0)
            {
                __caixa = Convert.ToInt32(dgvTABCaixas.Rows[e.RowIndex].Cells[1].Value.ToString());
                __turno = Convert.ToInt32(dgvTABCaixas.Rows[e.RowIndex].Cells[12].Value.ToString());
                __nome = dgvTABCaixas.Rows[e.RowIndex].Cells[3].Value.ToString();

                _transacao = Convert.ToInt32(dgvTABCaixas.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtDinheiro.Text = dgvTABCaixas.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtBanese.Text = dgvTABCaixas.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtCDrede.Text = dgvTABCaixas.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtTEDelet.Text = dgvTABCaixas.Rows[e.RowIndex].Cells[8].Value.ToString();
                txtCheque.Text = dgvTABCaixas.Rows[e.RowIndex].Cells[9].Value.ToString();
                txtCCrede.Text = dgvTABCaixas.Rows[e.RowIndex].Cells[11].Value.ToString();
                txtCCtks.Text = dgvTABCaixas.Rows[e.RowIndex].Cells[13].Value.ToString();
                txtCDtks.Text = dgvTABCaixas.Rows[e.RowIndex].Cells[14].Value.ToString();
                txtMoedas.Text = dgvTABCaixas.Rows[e.RowIndex].Cells[15].Value.ToString();
                txtOutros.Text = dgvTABCaixas.Rows[e.RowIndex].Cells[16].Value.ToString();

            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            AlteraCampos(0);

        }


        private void cbxTurno_SelectedValueChanged(object sender, EventArgs e)
        {
            this.AtualizadgvTABCaixa();
            this.AlteraCampos(1);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloTABCaixa modelo = new ModeloTABCaixa();
                modelo.NumTrans = Convert.ToInt32(_transacao.ToString());
                modelo.VlrDin = Convert.ToDouble(txtDinheiro.Text.ToString());
                modelo.VlrDep = Convert.ToDouble(txtBanese.Text.ToString());
                modelo.VlrDeb = Convert.ToDouble(txtCDrede.Text.ToString());
                modelo.VlrCred = Convert.ToDouble(txtCCrede.Text.ToString());
                modelo.VlrTran = Convert.ToDouble(txtTEDelet.Text.ToString());
                modelo.VlrCheq = Convert.ToDouble(txtCheque.Text.ToString());
                modelo.VlrCctks = Convert.ToDouble(txtCCtks.Text.ToString());
                modelo.VlrCdtks = Convert.ToDouble(txtCDtks.Text.ToString());
                modelo.VlrMoedas = Convert.ToDouble(txtMoedas.Text.ToString());
                modelo.VlrOutros = Convert.ToDouble(txtOutros.Text.ToString());

                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLTABCaixa bll = new BLLTABCaixa(cx);
                bll.Alterar(modelo);
                this.AlteraCampos(1);
                this.AtualizadgvTABCaixa();
                
            }
            catch
            {

            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                frmConsultaTABCaixas f = new frmConsultaTABCaixas(seg, dtpMovimento.Value.ToString("yyyyMMdd"));
                f.ShowDialog();
                if (f.numcaixa != 0)
                {
                    txtNumcaixa.Text = f.numcaixa.ToString();
                    txtNumoper.Text = f.numoper.ToString();
                    txtNome.Text = f.nomeoper.ToString();
                
                    Insert(
                        Convert.ToInt32(this.txtNumcaixa.Text.ToString()),
                        Convert.ToInt32(this.txtNumoper.Text.ToString()),
                        this.txtNome.Text.ToString(),
                        Convert.ToInt32(this.cbxTurno.Text.ToString())
                    );
                }
                

            } catch(Exception)
            {
                //MessageBox.Show(erro.Message);
                MessageBox.Show("Erro ao Cadastrar Movimento de Caixa:" +
                               "\n Verficar: Turno" +
                               "\n Verficar: Número de Caixa" +
                               "\n Verficar: Operadora" +
                               "\n Verficar: Data" +
                               "\n " +
                               "\n É possível que já exista um caixa para essa operadora neste turno!", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbxTurno.Focus();
            }


        }
        public void Insert(int numcaixa, int numoper, string nome, int turno)
        {
            ModeloTABCaixa modelo = new ModeloTABCaixa();
            modelo.NumCaixa = numcaixa;
            modelo.CodCaixa = numoper;
            modelo.NomeCaixa = nome.ToString();
            modelo.Turno = turno;
            modelo.DtCaixa = Convert.ToDateTime(dtpMovimento.Text.ToString());
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLTABCaixa bll = new BLLTABCaixa(cx);
            bll.Incluir(modelo);
            bll.AlterarTBC(modelo);
           

            this.AtualizadgvTABCaixa();
            

        }
        public void AtualizaTotais(int op)
        {
            if (op == 1)
            {
                this.totalDinheiro.Text = dgvTABCaixas.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDecimal(i.Cells[5].Value ?? 0)).ToString("N2");
                this.totalBanese.Text = dgvTABCaixas.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDecimal(i.Cells[6].Value ?? 0)).ToString("N2");
                this.totalCDrede.Text = dgvTABCaixas.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDecimal(i.Cells[7].Value ?? 0)).ToString("N2");
                this.totalTed.Text = dgvTABCaixas.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDecimal(i.Cells[8].Value ?? 0)).ToString("N2");
                this.totalCheque.Text = dgvTABCaixas.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDecimal(i.Cells[9].Value ?? 0)).ToString("N2");
                this.totalCCrede.Text = dgvTABCaixas.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDecimal(i.Cells[11].Value ?? 0)).ToString("N2");
                this.totalCCtks.Text = dgvTABCaixas.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDecimal(i.Cells[13].Value ?? 0)).ToString("N2");
                this.totalCDtks.Text = dgvTABCaixas.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDecimal(i.Cells[14].Value ?? 0)).ToString("N2");
                this.totalMoedas.Text = dgvTABCaixas.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDecimal(i.Cells[15].Value ?? 0)).ToString("N2");
                this.totalOutros.Text = dgvTABCaixas.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDecimal(i.Cells[16].Value ?? 0)).ToString("N2");



            }
            else
            {
                this.totalDinheiro.Text = "0,00";
                this.totalBanese.Text = "0,00";
                this.totalCCrede.Text = "0,00";
                this.totalTed.Text = "0,00";
                this.totalCheque.Text = "0,00";
                this.totalCCrede.Text = "0,00";
                this.totalCCtks.Text = "0,00";
                this.totalCDtks.Text = "0,00";
                this.totalMoedas.Text = "0,00";
                this.totalOutros.Text = "0,00";
            }

        }

        private void rbtVarejo_CheckedChanged(object sender, EventArgs e)
        {
            this.AtualizadgvTABCaixa();
            this.AlteraCampos(1);
        }

        private void rbtAtacado_CheckedChanged(object sender, EventArgs e)
        {
            this.AtualizadgvTABCaixa();
            this.AlteraCampos(1);
            seg = (rbtAtacado.Checked == true) ? 1 : 0;
        }

        private void cbxDia_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxDia.Checked != true) { cbxTurno.Enabled = true; } else { cbxTurno.Enabled = false; };
            this.AtualizadgvTABCaixa();
            this.AlteraCampos(1);

        }

        private void dtpMovimento_ValueChanged(object sender, EventArgs e)
        {
            this.AtualizadgvTABCaixa();
            this.AlteraCampos(1);
        }

        private void dgvTABCaixas_DoubleClick(object sender, EventArgs e)
        {
            AlteraCampos(0);
            txtBanese.Focus();
        }

        private void txtDinheiro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (!txtDinheiro.Text.Contains(","))
                {
                    e.KeyChar = ',';
                }
                else e.Handled = true;
            }
        }

        private void txtBanese_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {                
                txtDinheiro.Focus();
            }
        }

        private void txtDinheiro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCCrede.Focus();
            }
        }

        private void txtCCrede_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCCtks.Focus();
            }
        }

        private void txtCCtks_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCDrede.Focus();
            }
        }

        private void txtCDtks_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtTEDelet.Focus();
            }
        }

        private void txtTEDelet_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCheque.Focus();
            }
        }

        private void txtCheque_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtMoedas.Focus();
            }
        }

        private void txtMoedas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtOutros.Focus();
            }
        }

        private void txtOutros_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSalvar.Focus();
            }
        }

        private void dgvTABCaixas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                AlteraCampos(0);
                txtBanese.Focus();
            }
        }

        private void txtCDrede_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCDtks.Focus();
            }
        }

        private void txtBanese_Leave(object sender, EventArgs e)
        {
            
            if (txtBanese.Text.Contains(",") == false)
            {
                txtBanese.Text += ",00";
            }
            else
            {
                if (txtBanese.Text.IndexOf(",") == txtBanese.Text.Length - 1)
                {
                    txtBanese.Text += "00";
                }
            }
            try
            {
                Double d = Math.Round(Convert.ToDouble(txtBanese.Text), 2);
            }
            catch
            {
                txtBanese.Text = "0,00";
            }

        }

        private void txtCCrede_Leave(object sender, EventArgs e)
        {
            if (txtCCrede.Text.Contains(",") == false)
            {
                txtCCrede.Text += ",00";
            }
            else
            {
                if (txtCCrede.Text.IndexOf(",") == txtCCrede.Text.Length - 1)
                {
                    txtCCrede.Text += "00";
                }
            }
            try
            {
                Double d = Math.Round(Convert.ToDouble(txtCCrede.Text), 2);
            }
            catch
            {
                txtCCrede.Text = "0,00";
            }

        }

        private void txtCDrede_Leave(object sender, EventArgs e)
        {
            if (txtCDrede.Text.Contains(",") == false)
            {
                txtCDrede.Text += ",00";
            }
            else
            {
                if (txtCDrede.Text.IndexOf(",") == txtCDrede.Text.Length - 1)
                {
                    txtCDrede.Text += "00";
                }
            }
            try
            {
                Double d = Math.Round(Convert.ToDouble(txtCDrede.Text), 2);
            }
            catch
            {
                txtCDrede.Text = "0,00";
            }
        }

        private void txtTEDelet_Leave(object sender, EventArgs e)
        {
            if (this.Text.Contains(",") == false)
            {
                this.Text += ",00";
            }
            else
            {
                if (this.Text.IndexOf(",") == this.Text.Length - 1)
                {
                    this.Text += "00";
                }
            }
            try
            {
                Double d = Math.Round(Convert.ToDouble(this.Text), 2);
            }
            catch
            {
                this.Text = "0,00";
            }
        }

        private void txtMoedas_Leave(object sender, EventArgs e)
        {
            if (txtMoedas.Text.Contains(",") == false)
            {
                txtMoedas.Text += ",00";
            }
            else
            {
                if (txtMoedas.Text.IndexOf(",") == txtMoedas.Text.Length - 1)
                {
                    txtMoedas.Text += "00";
                }
            }
            try
            {
                Double d = Math.Round(Convert.ToDouble(txtMoedas.Text), 2);
            }
            catch
            {
                txtMoedas.Text = "0,00";
            }
        }

        private void txtDinheiro_Leave(object sender, EventArgs e)
        {
            if (txtDinheiro.Text.Contains(",") == false)
            {
                txtDinheiro.Text += ",00";
            }
            else
            {
                if (txtDinheiro.Text.IndexOf(",") == txtDinheiro.Text.Length - 1)
                {
                    txtDinheiro.Text += "00";
                }
            }
            try
            {
                Double d = Math.Round(Convert.ToDouble(txtDinheiro.Text), 2);
            }
            catch
            {
                txtDinheiro.Text = "0,00";
            }

        }

        private void txtCCtks_Leave(object sender, EventArgs e)
        {
            if (txtCCtks.Text.Contains(",") == false)
            {
                txtCCtks.Text += ",00";
            }
            else
            {
                if (txtCCtks.Text.IndexOf(",") == txtCCtks.Text.Length - 1)
                {
                    txtCCtks.Text += "00";
                }
            }
            try
            {
                Double d = Math.Round(Convert.ToDouble(txtCCtks.Text), 2);
            }
            catch
            {
                txtCCtks.Text = "0,00";
            }
        }

        private void txtCDtks_Leave(object sender, EventArgs e)
        {
            if (txtCDtks.Text.Contains(",") == false)
            {
                txtCDtks.Text += ",00";
            }
            else
            {
                if (txtCDtks.Text.IndexOf(",") == txtCDtks.Text.Length - 1)
                {
                    txtCDtks.Text += "00";
                }
            }
            try
            {
                Double d = Math.Round(Convert.ToDouble(txtCDtks.Text), 2);
            }
            catch
            {
                txtCDtks.Text = "0,00";
            }
        }

        private void txtCheque_Leave(object sender, EventArgs e)
        {
            if (txtCheque.Text.Contains(",") == false)
            {
                txtCheque.Text += ",00";
            }
            else
            {
                if (txtCheque.Text.IndexOf(",") == txtCheque.Text.Length - 1)
                {
                    txtCheque.Text += "00";
                }
            }
            try
            {
                Double d = Math.Round(Convert.ToDouble(txtCheque.Text), 2);
            }
            catch
            {
                txtCheque.Text = "0,00";
            }
        }

        private void txtOutros_Leave(object sender, EventArgs e)
        {
            if (txtOutros.Text.Contains(",") == false)
            {
                txtOutros.Text += ",00";
            }
            else
            {
                if (txtOutros.Text.IndexOf(",") == txtOutros.Text.Length - 1)
                {
                    txtOutros.Text += "00";
                }
            }
            try
            {
                Double d = Math.Round(Convert.ToDouble(txtOutros.Text), 2);
            }
            catch
            {
                txtOutros.Text = "0,00";
            }
        }

        private void btnTransf_Click(object sender, EventArgs e)
        {
            frmLctoTED frm = new frmLctoTED(1, __caixa, __nome, __turno);
            frm.Show();
        }

        private void btnAvulso_Click(object sender, EventArgs e)
        {
            frmLctoTED frm = new frmLctoTED(2, __caixa, __nome, __turno);
            frm.Show();
        }

        private void txtCCtks_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (!txtCCtks.Text.Contains(","))
                {
                    e.KeyChar = ',';
                }
                else e.Handled = true;
            }
        }

        private void txtCDrede_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (!txtCDrede.Text.Contains(","))
                {
                    e.KeyChar = ',';
                }
                else e.Handled = true;
            }
        }

        private void txtCDtks_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (!txtCDtks.Text.Contains(","))
                {
                    e.KeyChar = ',';
                }
                else e.Handled = true;
            }
        }

        private void txtTEDelet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (!txtTEDelet.Text.Contains(","))
                {
                    e.KeyChar = ',';
                }
                else e.Handled = true;
            }
        }

        private void txtCheque_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (!txtCheque.Text.Contains(","))
                {
                    e.KeyChar = ',';
                }
                else e.Handled = true;
            }
        }

        private void txtMoedas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (!txtMoedas.Text.Contains(","))
                {
                    e.KeyChar = ',';
                }
                else e.Handled = true;
            }
        }

        private void txtOutros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (!txtOutros.Text.Contains(","))
                {
                    e.KeyChar = ',';
                }
                else e.Handled = true;
            }
        }

        private void frmFechamentoCaixa_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
