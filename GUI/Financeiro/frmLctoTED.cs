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
    public partial class frmLctoTED : Form
    {
        public int numcaixa = 0;
        public int numoper = 0;
        public string nomeoper = "";

        public frmLctoTED(int op,int caixa,string nome, int turno)
        {
            InitializeComponent();
            if (op == 1)
            {
                dgvTed.Visible = true;
            }
            if (op == 2)
            {
                dgvTed.Visible = true;
                
                txtTurno.ReadOnly = false;
                txtTurno.TabStop = true;
                txtTurno.Focus();
                AtualizaDGV();


            }

            else
            {
                dgvAvulso.Visible = true;
            }

            txtCaixa.Text = caixa.ToString();
            txtTurno.Text = turno.ToString();
            txtNome.Text = nome.ToString();
            

        }

        public void AtualizaDGV()

        {

            dgvTed.RowHeadersVisible = false;
            dgvTed.ReadOnly = true;


            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLTransf bll = new BLLTransf(cx);
            dgvTed.DataSource = bll.Localizar(textBox1.Text);
            dgvTed.Columns[0].HeaderText = "Código";
            dgvTed.Columns[0].Width = 50;
            dgvTed.Columns[1].HeaderText = "Produto";
            dgvTed.Columns[1].Width = 250;
            dgvTed.Columns[6].HeaderText = "Quantidade";
            dgvTed.Columns[6].Width = 50;
            dgvTed.Columns[10].HeaderText = "Unidade de Medida";
            dgvTed.Columns[10].Width = 100;
            dgvTed.Columns[5].HeaderText = "Valor de Venda";
            dgvTed.Columns[5].Width = 100;

            //oculta colunas
            dgvTed.Columns["pro_foto"].Visible = false;
            dgvTed.Columns["pro_descricao"].Visible = false;
            dgvTed.Columns["cat_nome"].Visible = false;
            dgvTed.Columns["scat_nome"].Visible = false;
            dgvTed.Columns["pro_valorpago"].Visible = false;
            dgvTed.Columns["cat_cod"].Visible = false;
            dgvTed.Columns["cat_cod"].Visible = false;
            dgvTed.Columns["scat_cod"].Visible = false;
            dgvTed.Columns["umed_cod"].Visible = false;
        }
    }
}
