using BLL;
using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmConsultaTesouraria : Form
    {
        public frmConsultaTesouraria()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            rbtAberto.Checked = true;
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCaixa bll = new BLLCaixa(cx);
            dgvDados.DataSource = bll.LocalizarCaixas(txtNome.Text.ToString(), dtConsultaCaixa.Value.ToString("yyyy-MM-dd"));
            this.AtualizaCabecalhoDGTesourariaA();
        }
        public void AtualizaCabecalhoDGTesourariaA()
        {
            if (rbtAberto.Checked == true)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCaixa bll = new BLLCaixa(cx);
                dgvDados.DataSource = bll.LocalizarCaixas(txtNome.Text.ToString(), dtConsultaCaixa.Value.ToString("yyyy-MM-dd"));
                //dgvDados.Columns[1].Width = 700;
                dgvDados.RowHeadersVisible = false;
                dgvDados.ReadOnly = true;
                dgvDados.Columns[0].HeaderText = "Nome";
                dgvDados.Columns[1].HeaderText = "Cód Caixa";
                dgvDados.Columns[2].HeaderText = "Total Pedido";
                dgvDados.Columns[2].DefaultCellStyle.Format = "N2";
                dgvDados.Columns[3].Visible = false;
                dgvDados.Columns[4].Visible = false;
                dgvDados.Columns[5].Visible = false;
                dgvDados.Columns[6].Visible = false;
                dgvDados.Columns[7].HeaderText = "Data Abertura";
                dgvDados.Columns[8].Visible = false;
            }
            if(rbtFechado.Checked == true)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCaixa bll = new BLLCaixa(cx);
                dgvDados.DataSource = bll.LocalizarCaixasF(txtNome.Text.ToString(), dtConsultaCaixa.Value.ToString("yyyy-MM-dd"));
                //dgvDados.Columns[1].Width = 700;
                dgvDados.RowHeadersVisible = false;
                dgvDados.ReadOnly = true;
                dgvDados.Columns[0].HeaderText = "Nome";
                dgvDados.Columns[1].HeaderText = "Cód Caixa";
                dgvDados.Columns[2].HeaderText = "Total Pedido";
                dgvDados.Columns[2].DefaultCellStyle.Format = "N2";
                dgvDados.Columns[3].Visible = false;
                dgvDados.Columns[4].Visible = false;
                dgvDados.Columns[5].Visible = false;
                dgvDados.Columns[6].Visible = false;
                dgvDados.Columns[7].HeaderText = "Data Abertura";
                dgvDados.Columns[8].Visible = true;
                dgvDados.Columns[8].HeaderText = "Data Fechamento";
            }
        }

        private void rbtAberto_CheckedChanged(object sender, EventArgs e)
        {
            AtualizaCabecalhoDGTesourariaA();
        }

        private void rbtFechado_CheckedChanged(object sender, EventArgs e)
        {
            AtualizaCabecalhoDGTesourariaA();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            AtualizaCabecalhoDGTesourariaA();

        }

        private void btnLocalizar_KeyPress(object sender, KeyPressEventArgs e)
        {
            AtualizaCabecalhoDGTesourariaA();

        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            AtualizaCabecalhoDGTesourariaA();
        }

        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (rbtFechado.Checked == true)
            {
                DialogResult dialogResult = MessageBox.Show("DESEJA CONCILIAR O CAIXA ATUAL ? \n \n Operadora:" +
                    dgvDados.Rows[e.RowIndex].Cells[0].Value.ToString() + " \n Valor: " +
                    dgvDados.Rows[e.RowIndex].Cells[2].Value, "Conciliação", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    if (e.RowIndex >= 0)
                    {
                        ModeloCaixaStatus modelo = new ModeloCaixaStatus();
                        modelo.CaxsCod = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[1].Value);
                        modelo.CaxsFechamento = DateTime.Now;
                        DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                        BLLCaixaStatus bll = new BLLCaixaStatus(cx);
                        bll.FecharC(modelo);
                        AtualizaCabecalhoDGTesourariaA();

                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    AtualizaCabecalhoDGTesourariaA();

                }
            }

        }

        private void frmConsultaTesouraria_Load(object sender, EventArgs e)
        {
            //string cor = "";
            //StreamReader arquivo = new StreamReader("COR");
            //cor = (arquivo.ReadLine());

            //this.BackColor = cor;
            //dgvDados.BackgroundColor = cdgCaixaCores.Color;
        }

        private void btnAlteraCor_Click(object sender, EventArgs e)
        {

        }

        private void btnCorFundo_Click(object sender, EventArgs e)
        {
            if (cdgCaixaCores.ShowDialog() == DialogResult.OK)
            {
                string cor = "";
                this.BackColor = cdgCaixaCores.Color;
                dgvDados.BackgroundColor = cdgCaixaCores.Color;
                cor = cdgCaixaCores.Color.ToString();
                StreamWriter STW_Cor;
                STW_Cor = new StreamWriter("COR", false);
                STW_Cor.WriteLine(cor);
                STW_Cor.Close();
            }
        }
    }
}
