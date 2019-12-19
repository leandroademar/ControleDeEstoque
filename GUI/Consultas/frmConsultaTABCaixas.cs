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
using Modelo;

namespace GUI
{
    public partial class frmConsultaTABCaixas : Form
    {
        public int numcaixa = 0;
        public int numoper = 0;
        public string nomeoper = "";


        public frmConsultaTABCaixas(int seg,string dtmovimento)
        {
            
            InitializeComponent();
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLTABCaixa bll = new BLLTABCaixa(cx);
            ModeloTABCaixa modelo = new ModeloTABCaixa();
            try
            {
                bll.IncluirTBC(modelo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dgvCTABCaixa.DataSource = bll.Buscar(seg,dtmovimento);
            this.AtualizaDGV(seg,dtmovimento);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            
        }
        public void AtualizaDGV(int seg,string dtmovimento)
        {
            dgvCTABCaixa.RowHeadersVisible = false;
            dgvCTABCaixa.ReadOnly = true;
            dgvCTABCaixa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLTABCaixa bll = new BLLTABCaixa(cx);
            dgvCTABCaixa.DataSource = bll.Buscar(seg, dtmovimento);
            dgvCTABCaixa.Columns[0].HeaderText = "Caixa";
            dgvCTABCaixa.Columns[0].Width = 80;
            dgvCTABCaixa.Columns[1].HeaderText = "Operador";
            dgvCTABCaixa.Columns[1].Width = 80;
            dgvCTABCaixa.Columns[2].HeaderText = "Nome";
            dgvCTABCaixa.Columns[2].Width = 360;
            
        }

        private void dgvCTABCaixa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            numcaixa = Convert.ToInt32(dgvCTABCaixa.Rows[e.RowIndex].Cells[0].Value.ToString());
            numoper = Convert.ToInt32(dgvCTABCaixa.Rows[e.RowIndex].Cells[1].Value.ToString());
            nomeoper = dgvCTABCaixa.Rows[e.RowIndex].Cells[2].Value.ToString();
            this.Close();

        }

        private void dgvCTABCaixa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               
                e.SuppressKeyPress = true;
                numcaixa = Convert.ToInt32(dgvCTABCaixa.CurrentRow.Cells[0].Value.ToString());
                numoper = Convert.ToInt32(dgvCTABCaixa.CurrentRow.Cells[1].Value.ToString());
                nomeoper = dgvCTABCaixa.CurrentRow.Cells[0].Value.ToString();
                this.Close();
            }
        }
    }
}
