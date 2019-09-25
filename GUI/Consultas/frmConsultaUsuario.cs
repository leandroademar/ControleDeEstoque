using System;
using DAL;
using BLL;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmConsultaUsuario : Form
    {
        public int tipo = 0;
        public int codigo = 0;
        public frmConsultaUsuario(int tip)
        {
            if (tip==1)
            {
                tipo = 1;
            }

            InitializeComponent();
        }

        private void frmConsultaUsuario_Load(object sender, EventArgs e)
        {
            btnLocalizar_Click(sender, e);
            dgvDados.Columns[0].HeaderText = "Código";
            dgvDados.Columns[0].Width = 50;
            dgvDados.Columns[1].HeaderText = "Categoria";
            dgvDados.Columns[1].Width = 700;
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            if (tipo == 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLUsuario bll = new BLLUsuario(cx);
                dgvDados.DataSource = bll.Localizar(textBox1.Text);
            }
            else
            {
                lblUsuario.Visible = false;
                textBox1.Visible = false;
                btnLocalizar.Visible = false;
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLEquipe blle = new BLLEquipe(cx);
                dgvDados.DataSource = blle.Localizar(textBox1.Text);
            }

        }

        private void dgvDados_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }
    }
}
