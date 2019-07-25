using BLL;
using DAL;
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
    public partial class frmConsultaProduto : Form
    {
        public int codigo = 0;
        public int perfilus = 0;

        public frmConsultaProduto(int perfil)
        {
            InitializeComponent();
            perfilus = perfil;
        }

        

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLProduto bll = new BLLProduto(cx);
            dgvDados.DataSource = bll.Localizar(txtValor.Text);
            if (perfilus == 2)
            {
                dgvDados.DataSource = bll.LocalizarPositivo(txtValor.Text);
            }
        }

        private void frmConsultaProduto_Load(object sender, EventArgs e)
        {
            btLocalizar_Click(sender, e);
            dgvDados.Columns[0].HeaderText = "Código";
            dgvDados.Columns[0].Width = 50;
            dgvDados.Columns[1].HeaderText = "Produto";
            dgvDados.Columns[1].Width = 250;
            dgvDados.Columns[6].HeaderText = "Quantidade";
            dgvDados.Columns[6].Width = 50;
            dgvDados.Columns[10].HeaderText = "Unidade de Medida";
            dgvDados.Columns[10].Width = 100;
            dgvDados.Columns[5].HeaderText = "Valor de Venda";
            dgvDados.Columns[5].Width = 100;

            //oculta colunas
            dgvDados.Columns["pro_foto"].Visible = false;
            dgvDados.Columns["pro_descricao"].Visible = false;
            dgvDados.Columns["cat_nome"].Visible = false;
            dgvDados.Columns["scat_nome"].Visible = false;
            dgvDados.Columns["pro_valorpago"].Visible = false;
            dgvDados.Columns["cat_cod"].Visible = false;
            dgvDados.Columns["cat_cod"].Visible = false;
            dgvDados.Columns["scat_cod"].Visible = false;
            dgvDados.Columns["umed_cod"].Visible = false;
        }

        private void txtValor_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btLocalizar_Click(sender, e);
                dgvDados.Focus();
            }
        }

        private void dgvDados_KeyDown(object sender, KeyEventArgs e)
        {

           if(e.KeyCode == Keys.Enter)
           {
                e.SuppressKeyPress = true;
                int i = Convert.ToInt32(dgvDados.CurrentRow.Cells[0].Value);
                this.codigo = i;
                this.Close();
           }
            
        }

        private void frmConsultaProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) 
            {
                this.Close();
            }
        }

        private void dgvDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }

    }
}
