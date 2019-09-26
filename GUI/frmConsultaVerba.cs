using BLL;
using DAL;
using System;
using System.Linq;
using System.Windows.Forms;

namespace GUI.Consultas
{
    public partial class frmConsultaVerba : Form
    {
        public int codigo = 0;
        public frmConsultaVerba()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLVerba bll = new BLLVerba(cx);
            dataGridView1.DataSource = bll.Localizar(textBox1.Text);
            atualizaDGV();
            dataGridView1.Focus(); 
        }
        public void atualizaDGV()
        {
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns[0].HeaderText = "Código";
            dataGridView1.Columns[2].HeaderText = "Fornecedor";
            dataGridView1.Columns[5].HeaderText = "Verba";
            dataGridView1.Columns[11].HeaderText = "Saldo";
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;

            dataGridView1.Columns[2].Width = 260;
            dataGridView1.Columns[0].Width = 80;

            this.txtTotalVerba.Text = dataGridView1.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDecimal(i.Cells[5].Value ?? 0)).ToString("N2");
            this.txtTotalSaldo.Text = dataGridView1.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDecimal(i.Cells[11].Value ?? 0)).ToString("N2");
            this.txtTotalPago.Text = (dataGridView1.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDecimal(i.Cells[5].Value ?? 0)) - dataGridView1.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDecimal(i.Cells[11].Value ?? 0))).ToString("N2");



        }



        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
            
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                int i = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                this.codigo = i;
                this.Close();
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.Focus();
            }
        }
    }
}
