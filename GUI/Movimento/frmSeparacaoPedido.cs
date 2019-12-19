using BLL;
using DAL;
using Modelo;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmSeparacaoPedido : Form
    {
        public int codigo = 0;
        public frmSeparacaoPedido()
        {
            InitializeComponent();
        }

        private void frmSeparacaoPedido_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLVenda bllvenda = new BLLVenda(cx);
            dgvDados.DataSource = bllvenda.LocalizarSepara(txtPequisa.Text.ToString());
            this.AtualizaCabecalhoDGCompra();
            BLLEquipe blleq = new BLLEquipe(cx);
            txtNomeEquipe.DataSource = blleq.Localizar("");
            txtNomeEquipe.DisplayMember = "equi_nome";
            txtNomeEquipe.ValueMember = "equi_nome";
        }
        public void AtualizaCabecalhoDGCompra()
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLVenda bllvenda = new BLLVenda(cx);
            dgvDados.DataSource = bllvenda.LocalizarSepara(txtPequisa.Text.ToString());
            //dgvDados.Columns[1].Width = 700;
            dgvDados.RowHeadersVisible = false;
            dgvDados.ReadOnly = true;
            dgvDados.Columns[0].HeaderText = "Código";
            dgvDados.Columns[1].HeaderText = "Nome Cliente";
            dgvDados.Columns[2].HeaderText = "Total";
            dgvDados.Columns[2].DefaultCellStyle.Format = "N2";
            dgvDados.Columns[3].HeaderText = "Data ";
            dgvDados.Columns[4].HeaderText = "Nome da Equipe";
            dgvDados.Columns[1].Width = 230;
            dgvDados.Columns[0].Width = 80;
        }
        public void AtualizaCabecalhoDGSeparados()
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLVenda bllvenda = new BLLVenda(cx);
            dgvDados.DataSource = bllvenda.LocalizarSeparados(txtPequisa.Text.ToString());
            dgvDados.RowHeadersVisible = false;
            dgvDados.ReadOnly = true;
            dgvDados.Columns[0].HeaderText = "Código";
            dgvDados.Columns[1].HeaderText = "Nome Cliente";
            dgvDados.Columns[2].DefaultCellStyle.Format = "N2";
            dgvDados.Columns[2].HeaderText = "Total";
            dgvDados.Columns[3].HeaderText = "Data Ini";
            dgvDados.Columns[4].HeaderText = "Data Fim";
            dgvDados.Columns[5].HeaderText = "Nome da Equipe";
            dgvDados.Columns[1].Width = 210;
            dgvDados.Columns[0].Width = 80;
        }
        public void AtualizaCabecalhoDGFinalizados()
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLVenda bllvenda = new BLLVenda(cx);
            dgvDados.DataSource = bllvenda.LocalizarFinalizados(txtPequisa.Text.ToString());
            dgvDados.RowHeadersVisible = false;
            dgvDados.ReadOnly = true;
            dgvDados.Columns[0].HeaderText = "Código";
            dgvDados.Columns[1].HeaderText = "Nome Cliente";
            dgvDados.Columns[2].HeaderText = "Total";
            dgvDados.Columns[2].DefaultCellStyle.Format = "N2";
            dgvDados.Columns[3].HeaderText = "Data Ini";
            dgvDados.Columns[4].HeaderText = "Data Fim";
            dgvDados.Columns[5].HeaderText = "Nome da Equipe";
            dgvDados.Columns[1].Width = 210;
            dgvDados.Columns[0].Width = 80;
        }

        private void rbtSeparar_CheckedChanged(object sender, EventArgs e)
        {
            btnCancel_Click(sender, e);
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLVenda bllvenda = new BLLVenda(cx);
            dgvDados.DataSource = bllvenda.LocalizarSepara(txtPequisa.Text.ToString());
            this.AtualizaCabecalhoDGCompra();
        }

        private void dgvDados_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtCodVenda.Text = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value).ToString();
                txtCodVenda_Leave(sender, e);
                
                //this.AtualizaCabecalhoDGCompra();
            }
        }

        private void txtCodVenda_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txtCodVenda.Text) > 0)
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLVenda bll = new BLLVenda(cx);
                    ModeloVenda modelo = bll.CarregaModeloFatura(Convert.ToInt32(txtCodVenda.Text));
                    txtCodVenda.Text = modelo.VenCod.ToString();
                    txtNomeCliente.Text = modelo.VenNome.ToString();
                    txtCodEquipe.Text = modelo.CodEquipe.ToString();
                    txtNomeEquipe.Text = modelo.NomeEquipe.ToString();
                    txtValor.Text = modelo.VenTotalgeral.ToString();
                    txtNomeEquipe.Focus();

                }
            }catch (Exception erro)
            {
                MessageBox.Show(erro.Message);

            }

        }

        private void dgvDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           // this.codigo = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value);
           // DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
           // BLLItensVenda bllitens = new BLLItensVenda(cx);
           // dgvItensConsulta.DataSource = bllitens.Localizar(Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value));
           // this.AtualizaDGVProdutos();
        }

        private void btnGrava_Click(object sender, EventArgs e)
        {
            if (rbtSeparar.Checked == true)
            {
               
               
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLVenda bll = new BLLVenda(cx);
                ModeloVenda modelo = bll.CarregaModeloFatura(Convert.ToInt32(txtCodVenda.Text));
                modelo.CodEquipe = Convert.ToInt32(txtCodEquipe.Text);
                modelo.NomeEquipe = txtNomeEquipe.Text;
                modelo.DataIni = DateTime.Now;
                modelo.VenCod = Convert.ToInt32(txtCodVenda.Text);
                modelo.ValorSepara = Convert.ToDouble(txtValor.Text);
                bll.AlterarS(modelo);
                btnCancel_Click(sender, e);
                this.AtualizaCabecalhoDGCompra();
                txtCodVenda.Text = null;
                txtCodVenda.Focus();

            }
            if (rbtSeparados.Checked == true && ckbDivide.Checked == false)
            {
                
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLVenda bll = new BLLVenda(cx);
                ModeloVenda modelo = bll.CarregaModeloFatura(Convert.ToInt32(txtCodVenda.Text));
                modelo.DataFim = DateTime.Now;
                bll.AlterarSf(modelo);
                btnCancel_Click(sender, e);
                this.AtualizaCabecalhoDGSeparados();
                txtCodVenda.Text = null;
                txtCodVenda.Focus();


            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtCodVenda.Clear();
            txtNomeCliente.Clear();
            txtCodEquipe.Clear();
            txtValor.Clear();
            txtNomeEquipe.Text = "";
            ckbDivide.Checked = false;
            txtValor.ReadOnly = true;

        }
        public void NomeEquipe(string nome)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLEquipe bll = new BLLEquipe(cx);
        

        }

        private void txtCodEquipe_Leave(object sender, EventArgs e)
        {

        }

        private void rbtSeparados_CheckedChanged(object sender, EventArgs e)
        {
            btnCancel_Click(sender, e);
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLVenda bllvenda = new BLLVenda(cx);
            dgvDados.DataSource = bllvenda.LocalizarSeparados(txtPequisa.Text.ToString());
            this.AtualizaCabecalhoDGSeparados();
        }

        private void txtPequisa_KeyDown(object sender, KeyEventArgs e)
        {
            if(rbtSeparar.Checked == true)
            {
                
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLVenda bllvenda = new BLLVenda(cx);
                dgvDados.DataSource = bllvenda.LocalizarSepara(txtPequisa.Text.ToString());
                this.AtualizaCabecalhoDGCompra();
            }
            if (rbtSeparados.Checked == true)
            {

                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLVenda bllvenda = new BLLVenda(cx);
                dgvDados.DataSource = bllvenda.LocalizarSeparados(txtPequisa.Text.ToString());
                this.AtualizaCabecalhoDGSeparados();
            }
        }

        private void txtNomeEquipe_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                btnGrava.Focus();
            }
        }

        private void rbdFinalizados_CheckedChanged(object sender, EventArgs e)
        {
            btnCancel_Click(sender, e);
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLVenda bllvenda = new BLLVenda(cx);
            dgvDados.DataSource = bllvenda.LocalizarFinalizados(txtPequisa.Text.ToString());
            this.AtualizaCabecalhoDGFinalizados();
        }

        private void txtCodVenda_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter && rbtSeparados.Checked == true)
            {
                txtCodVenda_Leave(sender, e);
                btnGrava.Focus();
            }
            if (e.KeyCode == Keys.Enter && rbtSeparar.Checked == true)
            {
                txtCodVenda_Leave(sender, e);
                txtNomeEquipe.Focus();
            }

        }
    }
}
