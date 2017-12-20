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
    public partial class frmConsultaVenda : Form
    {
        public int codigo = 0;
        public frmConsultaVenda()
        {
            InitializeComponent();
        }

        private void frmConsultaCompra_Load(object sender, EventArgs e)
        {
            rbGeral_CheckedChanged(sender, e);
        }
        public void ExecutaConsulta(int op)
        {
            //op = 1 todas as compras
            //op = 2 por fornecedor
            //op = 3 data da compra
            //op = 4 parcelas em aberto
        }
        public void AtualizaCabecalhoDGCompra()
        {
            //dgvDados.Columns[1].Width = 700;
            dgvDados.RowHeadersVisible = false;
            dgvDados.ReadOnly = true;
            dgvDados.Columns[0].HeaderText = "Código";
            dgvDados.Columns[1].HeaderText = "Nome Cliente";
            dgvDados.Columns[2].HeaderText = "Total";
            dgvDados.Columns[3].HeaderText = "Data da Venda";
            dgvDados.Columns[4].Visible = false;
            dgvDados.Columns[1].Width = 280;
            dgvDados.Columns[0].Width = 80;
            //dgvDados.Columns[1].Width = 300;
            
        }
       
        public void AtualizaDGVProdutos()
        {
            dgvItensConsulta.RowHeadersVisible = false;
            dgvItensConsulta.ReadOnly = true;
            dgvItensConsulta.Columns[0].Visible = false;
            //dgvItensConsulta.Columns[0].DisplayIndex = 0;
            dgvItensConsulta.Columns[4].HeaderText = "Cod. Produto";
            dgvItensConsulta.Columns[4].DisplayIndex = 0;
            dgvItensConsulta.Columns[5].HeaderText = "Nome Produto";
            dgvItensConsulta.Columns[5].DisplayIndex = 1;
            dgvItensConsulta.Columns[1].HeaderText = "Quantidade";
            dgvItensConsulta.Columns[1].DisplayIndex = 2;
            dgvItensConsulta.Columns[2].HeaderText = "Valor Unit.";
            dgvItensConsulta.Columns[2].DisplayIndex = 3;
            dgvItensConsulta.Columns[3].Visible = false;
            dgvItensConsulta.Columns[5].Width = 280;
            dgvItensConsulta.Columns[4].Width = 80;
        }
        
        private void btLocFornecedor_Click(object sender, EventArgs e)
        {
            frmConsultaCliente f = new frmConsultaCliente();
            f.ShowDialog();
            if (f.codigo != 0)
            {
               //txtForCod.Text = f.codigo.ToString();
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                ModeloCliente modelo = bll.CarregaModeloCliente(f.codigo);
                lbForNome.Text = "Nome do Cliente: " + modelo.CliNome;
                BLLVenda bllvenda = new BLLVenda(cx);
                dgvDados.DataSource = bllvenda.Localizar(f.codigo);
                f.Dispose();
                this.AtualizaCabecalhoDGCompra();
            }
            else
            {
               // txtForCod.Text = "";
                lbForNome.Text = "Nome do cliente:";
            }
        }

        private void rbGeral_CheckedChanged(object sender, EventArgs e)
        {
            //ocultar paineis
            //pFornecedor.Visible = false;
            //pnlNome.Visible = false;
            dgvDados.DataSource = null;
            // dgvItensConsulta = null;

            if (rbGeral.Checked == true)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLVenda bllvenda = new BLLVenda(cx);
                dgvDados.DataSource = bllvenda.Localizar();
                this.AtualizaCabecalhoDGCompra();
            }
            if (rbFornecedor.Checked == true)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLVenda bllvenda = new BLLVenda(cx);
                dgvDados.DataSource = bllvenda.LocalizarFatura();
                this.AtualizaCabecalhoDGCompra();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && (rbNome.Checked == true))
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLVenda bllvenda = new BLLVenda(cx);
                dgvDados.DataSource = bllvenda.Localizar(textBox1.Text.ToString());
                this.AtualizaCabecalhoDGCompra();
            }
            if (e.KeyCode == Keys.Enter && (rbFornecedor.Checked == true))
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLVenda bllvenda = new BLLVenda(cx);
                dgvDados.DataSource = bllvenda.LocalizarFatura(textBox1.Text.ToString());
                this.AtualizaCabecalhoDGCompra();
            }
        }

        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }

        private void dgvDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value);
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLItensVenda bllitens = new BLLItensVenda(cx);
                dgvItensConsulta.DataSource = bllitens.Localizar(Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value));
                this.AtualizaDGVProdutos();
            }
        }
    }
}
