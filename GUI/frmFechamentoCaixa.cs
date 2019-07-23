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
    public partial class frmFechamentoCaixa : Form
    {
        public int dia;
        public int seg;

      
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

        public void AlteraCampos(int op)
        {
            if(op==1)
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
            }
            
        }

        public void AtualizadgvTABCaixa()
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLTABCaixa bll = new BLLTABCaixa(cx);
            dgvTABCaixas.DataSource = bll.LocalizarCaixas(Convert.ToInt32(cbxTurno.Text),(rbtAtacado.Checked == true) ? 1 : 0, (cbxDia.Checked == true) ? 1 : 0, dtpMovimento.Value.ToString("yyyy-MM-dd"));
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
                if (!this.Text.Contains(","))
                {
                    e.KeyChar = ',';
                }
                else e.Handled = true;
            }
        }




        private void dgvTABCaixas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.AlteraCampos(1);

            if (e.RowIndex >= 0)
            {
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
            this.AlteraCampos(1);
            

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmConsultaTABCaixas f = new frmConsultaTABCaixas();
            f.ShowDialog();
            
        }

        public void AtualizaTotais(int op)
        {
            if (op == 1)
            {
                this.totalDinheiro.Text = dgvTABCaixas.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDecimal(i.Cells[5].Value ?? 0)).ToString("N2");

            }else
            {
                this.totalDinheiro.Text = "0,00";
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
    }
}
