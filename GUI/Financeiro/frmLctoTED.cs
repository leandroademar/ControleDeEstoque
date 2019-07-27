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
    public partial class frmLctoTED : Form
    {
        public int numcaixa = 0;
        public int numoper = 0;
        public int numturno = 0;
        public string nomeoper = "";
        public int codfunc = 0;


        public frmLctoTED(int caixa,string nome, int turno)
        {
            InitializeComponent();
            
            codfunc = Properties.Settings.Default.Matricula;
      
                dgvTed.Visible = true;
                dgvTed.ReadOnly = false;
                //AtualizaDGVTransf(turno);
                txtCaixa.Text = caixa.ToString();
                txtNome.Text = nome.ToString();
                txtTurno.Text = turno.ToString();
                numcaixa = caixa;
                numturno = turno;
    
            

        }

        public void AtualizaDGVTransf()

        {

            dgvTed.RowHeadersVisible = true;
            


            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLTransf bll = new BLLTransf(cx);
            dgvTed.DataSource = bll.LocalizarTED(numturno,2,0);
            dgvTed.Columns[2].HeaderText = "Nome";
            dgvTed.Columns[2].Width = 250;
            dgvTed.Columns[5].HeaderText = "Valor";
            dgvTed.Columns[5].Width = 95;
            dgvTed.Columns[4].HeaderText = "Hora";
            dgvTed.Columns[4].Width = 80;
            

            //oculta colunas
            dgvTed.Columns[0].Visible = false;
            dgvTed.Columns[1].Visible = false;
            dgvTed.Columns[3].Visible = false;
            dgvTed.Columns[6].Visible = false;
            dgvTed.Columns[7].Visible = false;
            dgvTed.Columns[8].Visible = false;



        }

        private void txtTurno_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter && txtTurno.Text != "")
            {
                //tbcLcto.Visible = true;
                AtualizaDGVTransf();
                dgvTed.Focus();
            }
        }

        private void frmLctoTED_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void txtTurno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '1' && e.KeyChar != '2')
            {
                e.Handled = true;
            }
            
        }

 

        private void dgvTed_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter && txtTurno.Text != "")
            {
                e.SuppressKeyPress = true;
                AlterarTED();
                this.Close();
            }
            
        }
        public void AlterarTED()
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLTransf bll = new BLLTransf(cx);
            ModeloTransf modelo = new ModeloTransf();
            modelo.NumTrans = Convert.ToInt32(dgvTed.CurrentRow.Cells[0].Value.ToString());
            modelo.NumCaixa = Convert.ToInt32(txtCaixa.Text.ToString());
            modelo.Turno = Convert.ToInt32(txtTurno.Text.ToString());
            modelo.CodFunc = codfunc;
            bll.Alterar(modelo);
        }

        private void dgvTed_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(txtTurno.Text!="")
            {
                AlterarTED();
                this.Close();
            }
            
        }
    }
}
