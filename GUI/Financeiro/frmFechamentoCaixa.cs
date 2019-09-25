using BLL;
using DAL;
using Modelo;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
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
        public string User = "";
        public string opera = "";
        public int _xcaixa = 0;
        public int _xturno = 0;
        public int _xfunc = 0;

        public frmFechamentoCaixa()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            rbtAtacado.Checked = true;
            //btnAvulso.Visible = false;
            User = Properties.Settings.Default.Usuario;
            AlteraP(2);


            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLTABCaixa bll = new BLLTABCaixa(cx);
            dgvTABCaixas.DataSource = bll.LocalizarCaixas( (rbtAtacado.Checked == true) ? 1 : 0,  dtpMovimento.Value.ToString("yyyy-MM-dd"));
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
            if (op == 0)
            {
                txtDinheiro.ReadOnly = false;
                txtBanese.ReadOnly = false;
                txtCDrede.ReadOnly = false;
                txtTEDelet.ReadOnly = false;
                txtCheque.ReadOnly = false;
                txtCCrede.ReadOnly = false;
                txtCCtks.ReadOnly = false;
                txtCDtks.ReadOnly = false;
                txtMoedas.ReadOnly = false;
                txtOutros.ReadOnly = false;
                //cbxTurnoDet.Enabled = true;
                button1.Visible = true;
                btnAvulso.Visible = true;


            }
            else
            {
                txtDinheiro.ReadOnly = true;
                txtBanese.ReadOnly = true;
                txtCDrede.ReadOnly = true;
                txtTEDelet.ReadOnly = true;
                txtCheque.ReadOnly = true;
                txtCCrede.ReadOnly = true;
                txtCCtks.ReadOnly = true;
                txtCDtks.ReadOnly = true;
                txtMoedas.ReadOnly = true;
                txtOutros.ReadOnly = true;
                btnAvulso.Visible = false;
               // cbxTurnoDet.Enabled = false;
                button1.Visible = false;


            }

        }
        public void AtualizadgvTed()
        {
            dgvTed.RowHeadersVisible = false;
            dgvTed.ReadOnly = true;
            dgvTed.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLTransf bll = new BLLTransf(cx);
            dgvTed.DataSource = bll.LocalizardgvTED(_xcaixa, _xturno,_xfunc,dtpMovimento.Value.ToString("dd/MM/yyyy"));
            dgvTed.Columns[0].HeaderText = "Nome";
            dgvTed.Columns[0].Width = 205;
            dgvTed.Columns[1].HeaderText = "Valor";
            dgvTed.Columns[1].Width = 80;
            dgvTed.RowHeadersVisible = false;
            dgvTed.ReadOnly = true;
            dgvTed.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        public void AtualizaAvulso(int _caixa,int _turno, int _func, string datamov)
        {
            dgvRetiradas.RowHeadersVisible = false;
            dgvRetiradas.ReadOnly = true;
            dgvRetiradas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLTransf bll = new BLLTransf(cx);
            dgvRetiradas.DataSource = bll.LocalizarAvulso(_caixa, _turno, _func,dtpMovimento.Value.ToString("dd/MM/yyyy"));
            dgvRetiradas.Columns[0].HeaderText = "Nome";
            dgvRetiradas.Columns[0].Width = 205;
            dgvRetiradas.Columns[1].HeaderText = "Valor";
            dgvRetiradas.Columns[1].Width = 80;
            dgvRetiradas.Columns[2].Visible = false;
            dgvRetiradas.RowHeadersVisible = false;
            dgvRetiradas.ReadOnly = true;
            dgvRetiradas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        public void AtualizadgvTABCaixa()
        {
            
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLTABCaixa bll = new BLLTABCaixa(cx);
            dgvTABCaixas.DataSource = bll.LocalizarCaixas( (rbtAtacado.Checked == true) ? 1 : 0, dtpMovimento.Value.ToString("yyyy-MM-dd"));
            dgvTABCaixas.RowHeadersVisible = false;
            dgvTABCaixas.ReadOnly = true;
            dgvTABCaixas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTABCaixas.Columns[1].HeaderText = "Caixa";
            dgvTABCaixas.Columns[2].HeaderText = "Operador";
            dgvTABCaixas.Columns[3].HeaderText = "Nome";
          
            dgvTABCaixas.Columns[3].Width = 530;
            dgvTABCaixas.Columns[0].Visible = false;
            dgvTABCaixas.Columns[4].Visible = false;
            dgvTABCaixas.Columns[5].Visible = false;
            dgvTABCaixas.Columns[6].Visible = false;
            dgvTABCaixas.Columns[7].Visible = false;
            dgvTABCaixas.Columns[8].Visible = false;
            dgvTABCaixas.Columns[9].Visible = false;
            dgvTABCaixas.Columns[10].Visible = false;
            dgvTABCaixas.Columns[11].Visible = false;
            dgvTABCaixas.Columns[12].Visible = false;
            dgvTABCaixas.Columns[13].Visible = false;
            dgvTABCaixas.Columns[14].Visible = false;
            dgvTABCaixas.Columns[15].Visible = false;
            dgvTABCaixas.Columns[16].Visible = false;
            this.AtualizaTotais(1);
            AtualizaTotal();
            AtualizadgvTed();
            AtualizaAvulso(_xcaixa,_xturno,_xfunc, dtpMovimento.Value.ToString("dd/MM/yyyy"));
        }




        public double acumula = 0 ;

        private void txtBanese_KeyPress(object sender, KeyPressEventArgs e)
        {
            double[] soma = new double[2];

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
            if (e.KeyChar == '+')
            {
                acumula += double.Parse(txtBanese.Text);
                txtBanese.Text = "";

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
            if (e.KeyChar == '+')
            {
                acumula += double.Parse(txtCCrede.Text);
                txtCCrede.Text = "";

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
                _xcaixa = Convert.ToInt32(dgvTABCaixas.Rows[e.RowIndex].Cells[1].Value.ToString());
                _xturno = Convert.ToInt32(dgvTABCaixas.Rows[e.RowIndex].Cells[12].Value.ToString());
                _xfunc = Convert.ToInt32(dgvTABCaixas.Rows[e.RowIndex].Cells[2].Value.ToString());
                AtualizaAvulso(_xcaixa, _xturno, _xfunc, dtpMovimento.Value.ToString("dd/MM/yyyy"));
                AtualizadgvTed();
                AtualizaTotal();

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
                //cbxTurnoDet.Text = dgvTABCaixas.Rows[e.RowIndex].Cells[12].Value.ToString();

            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            AlteraCampos(0);
            //btnAvulso.Visible = true;

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
               // modelo.Turno = Convert.ToInt32(cbxTurnoDet.Text.ToString());

                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLTABCaixa bll = new BLLTABCaixa(cx);
                bll.Alterar(modelo);
                AtualizaAvulso(modelo.NumCaixa, modelo.Turno, modelo.CodCaixa, dtpMovimento.Value.ToString("dd/MM/yyyy"));
                this.AlteraCampos(1);
                this.AtualizadgvTABCaixa();
                AtualizadgvTed();
                AtualizaTotais(1);
                //LimpaCampos();
                
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
                        Convert.ToInt32(1)
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
                
            }


        }
        public void Insert(int numcaixa, int numoper, string nome, int turno)
        {
            ModeloTABCaixa modelo = new ModeloTABCaixa();
            modelo.NumCaixa = numcaixa;
            modelo.CodCaixa = numoper;
            modelo.NomeCaixa = nome.ToString();
            modelo.Turno = turno;
            modelo.DtCaixa = Convert.ToDateTime(dtpMovimento.Value.ToString("yyyy-MM-dd"));
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
        public void AtualizaTotal()
        {
           
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLTotal bll = new BLLTotal(cx);
                ModeloTotal modelo = bll.CarregaTotal(_xcaixa, _xturno, dtpMovimento.Value.ToString("dd/MM/yyyy"), _xfunc);
                lblRpVEntradas.Text = String.Format("{0:C2}", modelo.VlrEnt);
                lblRpVSaidas.Text = String.Format("{0:C2}", modelo.VlrSai);
                lblRpVtotal.Text = String.Format("{0:C2}", modelo.VlrTotal);
                ModeloTotal modelotg = bll.CarregaTotalGeral(dtpMovimento.Value.ToString("dd/MM/yyyy"));
                lblTgEnt.Text = String.Format("{0:C2}", modelotg.VlrEnt);
                lblTgRed.Text = String.Format("{0:C2}", modelotg.VlrRed);
                lblTgTks.Text = String.Format("{0:C2}", modelotg.VlrTks);
                lblTgTed.Text = String.Format("{0:C2}", modelotg.VlrTed);
                lblTgSai.Text = String.Format("{0:C2}", modelotg.VlrSai);
                lblTgTot.Text = String.Format("{0:C2}", modelotg.VlrTotal);
           
            


        }
        public void atualizatotal(int op,int numcaixa, int turno, int codfunc, string datamov)
        {
            if (op == 0)
            {


            }
            else
            {
                this.lblRpVEntradas.Text = "0,00";
                this.lblRpVSaidas.Text = "0,00";
                this.lblRpVtotal.Text = "0,00";
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

       

        private void dtpMovimento_ValueChanged(object sender, EventArgs e)
        {
            this.AtualizadgvTABCaixa();
            this.AlteraCampos(1);
        }
        public void LimpaTela()
        {
            //btnAvulso.Visible = false;
            this.AtualizadgvTABCaixa();
            this.AlteraCampos(1);
        }

        private void dgvTABCaixas_DoubleClick(object sender, EventArgs e)
        {
            AlteraCampos(0);
            //btnAvulso.Visible = true;
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
            if (e.KeyChar == '+')
            {
                acumula += double.Parse(txtDinheiro.Text);
                txtDinheiro.Text = "";

            }
        }

        private void txtBanese_KeyDown(object sender, KeyEventArgs e)

        {
            if (e.KeyCode == Keys.Enter)
            {
                acumula += double.Parse(string.IsNullOrWhiteSpace(txtBanese.Text)?"0":txtBanese.Text);
                txtBanese.Text = acumula.ToString();
                acumula = 0;

                txtDinheiro.Focus();
            }
        }

        private void txtDinheiro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                acumula += double.Parse(string.IsNullOrWhiteSpace(txtDinheiro.Text) ? "0" : txtDinheiro.Text);
                txtDinheiro.Text = acumula.ToString();
                acumula = 0;
                txtCCrede.Focus();
            }
        }

        private void txtCCrede_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                acumula += double.Parse(string.IsNullOrWhiteSpace(txtCCrede.Text) ? "0" : txtCCrede.Text);
                txtCCrede.Text = acumula.ToString();
                acumula = 0;
                txtCCtks.Focus();
            }
        }

        private void txtCCtks_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                acumula += double.Parse(string.IsNullOrWhiteSpace(txtCCtks.Text) ? "0" : txtCCtks.Text);
                txtCCtks.Text = acumula.ToString();
                acumula = 0;
                txtCDrede.Focus();
            }
        }

        private void txtCDtks_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                acumula += double.Parse(string.IsNullOrWhiteSpace(txtCDtks.Text) ? "0" : txtCDtks.Text);
                txtCDtks.Text = acumula.ToString();
                acumula = 0;
                txtTEDelet.Focus();
            }
        }

        private void txtTEDelet_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                acumula += double.Parse(string.IsNullOrWhiteSpace(txtTEDelet.Text) ? "0" : txtTEDelet.Text);
                txtTEDelet.Text = acumula.ToString();
                acumula = 0;
                txtCheque.Focus();
            }
        }

        private void txtCheque_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                acumula += double.Parse(string.IsNullOrWhiteSpace(txtCheque.Text) ? "0" : txtCheque.Text);
                txtCheque.Text = acumula.ToString();
                acumula = 0;
                txtMoedas.Focus();
            }
        }

        private void txtMoedas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                acumula += double.Parse(string.IsNullOrWhiteSpace(txtMoedas.Text) ? "0" : txtMoedas.Text);
                txtMoedas.Text = acumula.ToString();
                acumula = 0;
                txtOutros.Focus();
            }
        }

        private void txtOutros_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                acumula += double.Parse(txtOutros.Text);
                txtOutros.Text = acumula.ToString();
                acumula = 0;
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
                acumula += double.Parse(string.IsNullOrWhiteSpace(txtCDrede.Text) ? "0" : txtCDrede.Text);
                txtCDrede.Text = acumula.ToString();
                acumula = 0;
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
            if (txtTEDelet.Text.Contains(",") == false)
            {
                txtTEDelet.Text += ",00";
            }
            else
            {
                if (txtTEDelet.Text.IndexOf(",") == txtTEDelet.Text.Length - 1)
                {
                    txtTEDelet.Text += "00";
                }
            }
            try
            {
                Double d = Math.Round(Convert.ToDouble(txtTEDelet.Text), 2);
            }
            catch
            {
                txtTEDelet.Text = "0,00";
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
            AlteraP(0);
        }

        private void btnAvulso_Click(object sender, EventArgs e)
        {
            AlteraP(1);
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
            if (e.KeyChar == '+')
            {
                acumula += double.Parse(txtCCtks.Text);
                txtCCtks.Text = "";

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
            if (e.KeyChar == '+')
            {
                acumula += double.Parse(txtCDrede.Text);
                txtCDrede.Text = "";

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
            if (e.KeyChar == '+')
            {
                acumula += double.Parse(txtCDtks.Text);
                txtCDtks.Text = "";

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
            if (e.KeyChar == '+')
            {
                acumula += double.Parse(txtTEDelet.Text);
                txtTEDelet.Text = "";

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
            if (e.KeyChar == '+')
            {
                acumula += double.Parse(txtCheque.Text);
                txtCheque.Text = "";

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
            if (e.KeyChar == '+')
            {
                acumula += double.Parse(txtMoedas.Text);
                txtMoedas.Text = "";

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
            if (e.KeyChar == '+')
            {
                acumula += double.Parse(txtOutros.Text);
                txtOutros.Text = "";

            }
        }

        private void frmFechamentoCaixa_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        public void AlteraP(int op)
        {
            if(op == 0)
            {
                opera = "ted";
                //pnlInsere.Visible = true;
                lblBanco.Visible = true;
                lblDesc.Visible = true;
                lblDataLanc.Visible = true;
                lblHora.Visible = true;
                lblValorLanc.Visible = true;
                txtValor.Visible = true;
                cbxBanco.Visible = true;
                dtpData.Visible = true;
                maskedTextBox1.Visible = true;
                txtCliente.Visible = true;
                panel1.Visible = false;

            }
            if (op == 1)
            {
                opera = "avulso";
                //pnlInsere.Visible = true;
                lblBanco.Visible = false;
                lblDesc.Visible = true;
                lblDataLanc.Visible = false;
                lblHora.Visible = false;
                lblValorLanc.Visible = true;
                txtValor.Visible = true;
                cbxBanco.Visible = false;
                dtpData.Visible = false;
                maskedTextBox1.Visible = false;
                txtCliente.Visible = true;
                panel1.Visible = false;

            }
            if(op==2)
            {

                //pnlInsere.Visible = false;
                lblBanco.Visible = false;
                lblDesc.Visible = false;
                lblDataLanc.Visible = false;
                lblHora.Visible = false;
                lblValorLanc.Visible = false;
                txtValor.Visible = false;
                cbxBanco.Visible = false;
                dtpData.Visible = false;
                maskedTextBox1.Visible = false;
                txtCliente.Visible = false;
                panel1.Visible = true;
            }
        }
        private void txtValor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && opera =="ted")
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
                    bll.Incluir(modelo);
                    txtCliente.Clear();
                    txtValor.Clear();
                    //AlteraCampos(0);
                    AlteraP(2);
                   

                  
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
            if (e.KeyCode == Keys.Enter && opera == "avulso")
            {
                try
                {
                    //leitura dos dados
                    ModeloTransf modelo = new ModeloTransf();
                    modelo.NomeCliente = txtCliente.Text;
                    modelo.Usuario = User;
                    modelo.Valor = Convert.ToDouble(txtValor.Text.ToString());
                    modelo.Turno = _xturno;
                    modelo.NumCaixa = _xcaixa;
                    modelo.CodFunc = _xfunc;
                    modelo.DtTransf = dtpMovimento.Text.ToString();

                    //obj para gravar os dados no banco
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLTransf bll = new BLLTransf(cx);
                    bll.IncluirRet(modelo);
                    txtCliente.Clear();
                    txtValor.Clear();
                    AlteraCampos(1);
                    AlteraP(2);
                    AtualizaAvulso(_xcaixa,_xturno,_xfunc, dtpMovimento.Value.ToString("dd/MM/yyyy"));
                    
                    //btnAvulso.Visible = false;



                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }

        }

        private void frmFechamentoCaixa_KeyDown(object sender, KeyEventArgs e)
        {
            LimpaTela();
        }

        private void txtCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtCliente.Text != "") 
            {
                txtValor.Focus();
            }
        }

        private void dgvRetiradas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja excluir do caixa e turno selecionado este valor ?", "Exclusão de Avulso", MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
            if (dialogResult == DialogResult.Yes)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLTransf bll = new BLLTransf(cx);
                ModeloTransf modelo = new ModeloTransf();
                modelo.NumTrans = Convert.ToInt32(dgvRetiradas.CurrentRow.Cells[2].Value.ToString());
                bll.Deleta(modelo);
                AtualizaAvulso(_xcaixa, _xturno, _xfunc, dtpMovimento.Value.ToString("dd/MM/yyyy"));
                AtualizadgvTed();
                AtualizaTotal();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModeloTABCaixa modelo = new ModeloTABCaixa();
            modelo.NumTrans = Convert.ToInt32(_transacao.ToString());
            modelo.CodCaixa = _xfunc;
            modelo.NumCaixa = _xcaixa;
            modelo.DtCaixast = (dtpMovimento.Value.ToString("dd/MM/yyyy"));


        
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLTABCaixa bll = new BLLTABCaixa(cx);
            bll.DeletaT(modelo);
            bll.Deleta(modelo);

            AtualizadgvTABCaixa();
            AtualizaAvulso(_xcaixa, _xturno, _xfunc, dtpMovimento.Value.ToString("dd/MM/yyyy"));
            AtualizadgvTed();
            AtualizaTotal();

        }

        private void frmFechamentoCaixa_KeyDown_1(object sender, KeyEventArgs e)
        {
           
        }

        private void btnCor_Click(object sender, EventArgs e)
        {
            if (cdgCaixaCores.ShowDialog() == DialogResult.OK)
            {
                string corR = "";
                string corG = "";
                string corB = "";


                this.BackColor = cdgCaixaCores.Color;
                dgvRetiradas.BackgroundColor = cdgCaixaCores.Color;
                dgvTABCaixas.BackgroundColor = cdgCaixaCores.Color;
                dgvTed.BackgroundColor = cdgCaixaCores.Color;


                corR = cdgCaixaCores.Color.R.ToString();
                corG = cdgCaixaCores.Color.G.ToString();
                corB = cdgCaixaCores.Color.B.ToString();
                StreamWriter STW_Cor;
                STW_Cor = new StreamWriter("COR", false);
                STW_Cor.WriteLine(corR);
                STW_Cor.WriteLine(corG);
                STW_Cor.WriteLine(corB);

                STW_Cor.Close();
            }
        }

        private void frmFechamentoCaixa_Load(object sender, EventArgs e)
        {
            try
            {
                string corR = "";
                string corG = "";
                string corB = "";
                StreamReader arquivo = new StreamReader("COR");
                corR = arquivo.ReadLine();
                corG = arquivo.ReadLine();
                corB = arquivo.ReadLine();

                
                this.BackColor = Color.FromArgb(Convert.ToInt32(corR), Convert.ToInt32(corG), Convert.ToInt32(corB));
                dgvRetiradas.BackgroundColor = Color.FromArgb(Convert.ToInt32(corR), Convert.ToInt32(corG), Convert.ToInt32(corB));
                dgvTABCaixas.BackgroundColor = Color.FromArgb(Convert.ToInt32(corR), Convert.ToInt32(corG), Convert.ToInt32(corB));
                dgvTed.BackgroundColor = Color.FromArgb(Convert.ToInt32(corR), Convert.ToInt32(corG), Convert.ToInt32(corB));
                

                arquivo.Close();
            }
            catch (Exception erro)
            {
                
            }
        }

        private void cbxBanco_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && cbxBanco.Text != "")
            {
                //cbxBanco.Visible = true;
                //maskedTextBox1.Visible = true;
                //txtCliente.Visible = true;
                //panel1.Visible = false;

                dtpData.Focus();
                
            }
        }

        private void dtpData_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && dtpData.Text != "")
            {
               

                maskedTextBox1.Focus();

            }
        }

        private void maskedTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && maskedTextBox1.Text != "")
            {
               

                txtCliente.Focus();

            }
        }
    }
}
