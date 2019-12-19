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
<<<<<<< HEAD
        public frmLctoTED(int op,int caixa,string nome, int turno)
        {
            InitializeComponent();
            if (op == 1)
=======
        public Font printFont;
        public StreamReader streamToPrint;
        public int numcaixa = 0;
        public int numoper = 0;
        public int numturno = 0;
        public string nomeoper = "";
        public int codfunc = 0;
        public string _nomecli = "";
        public string _vlrted = "";
        public int seg = 0;

        public frmLctoTED(int caixa,string nome)
        {
            InitializeComponent();
            
            codfunc = Properties.Settings.Default.Matricula;
            checkBox1.Checked = true;
            btnBusca.Focus();
      
                dgvTed.Visible = true;
                dgvTed.ReadOnly = false;
                txtCaixa.Text = caixa.ToString();
                txtNome.Text = nome.ToString();

                numcaixa = caixa;
    
    
            

        }

        public void AtualizaDGVTransf()

        {

            dgvTed.RowHeadersVisible = true;
            


            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLTransf bll = new BLLTransf(cx);
            dgvTed.DataSource = bll.LocalizarTED(seg,numcaixa);
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
        /*
        private void txtTurno_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter && txtTurno.Text != "" && checkBox1.Checked == true)
            {
                //tbcLcto.Visible = true;
                seg = 2;
                AtualizaDGVTransf();
                dgvTed.Focus();
            }
            if (e.KeyCode == Keys.Enter && txtTurno.Text != "" && checkBox1.Checked == false)
            {
                seg = 1; 
                //tbcLcto.Visible = true;
                AtualizaDGVTransf();
                dgvTed.Focus();
            }
        }
        */

        private void frmLctoTED_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }



 

        private void dgvTed_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                AlterarTED();
                spoolrec("FECHTED1.log");
                //spoolrec("FECHTED2.log");
                this.Close();
            }
            if(e.KeyCode == Keys.Escape)
            {
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
            modelo.CodFunc = codfunc;
            GravarTED(1,dgvTed.CurrentRow.Cells[2].Value.ToString(),dgvTed.CurrentRow.Cells[5].Value.ToString());
            GravarTED(2, dgvTed.CurrentRow.Cells[2].Value.ToString(), dgvTed.CurrentRow.Cells[5].Value.ToString());
            bll.Alterar(modelo);

        }

        public void GravarTED(int via, string nomecliente, string total)
        {
            if(seg == 2)
            {
                StreamWriter STW_Arquivo;
                STW_Arquivo = new StreamWriter("FECHTED" + via + ".log", false);
                STW_Arquivo.WriteLine("");
                STW_Arquivo.WriteLine("              COMPROVANTE DE TED - VIA:" + via);
                STW_Arquivo.WriteLine("");
                STW_Arquivo.WriteLine("Cliente.....:");
                STW_Arquivo.WriteLine(" " + nomecliente);
                STW_Arquivo.WriteLine(" ");
                STW_Arquivo.WriteLine("Total.......: R$ " + total);
                STW_Arquivo.WriteLine("");
                STW_Arquivo.WriteLine("------------------------------------------------");
                STW_Arquivo.WriteLine("");

                STW_Arquivo.WriteLine("Data Emissão: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
                STW_Arquivo.WriteLine("Caixa.......: " + Properties.Settings.Default.NomeW.ToString().Trim());
                STW_Arquivo.WriteLine("Cód Caixa...: " + Properties.Settings.Default.Matricula.ToString().Trim());
                STW_Arquivo.WriteLine("");
                STW_Arquivo.WriteLine("");
                STW_Arquivo.Close();
            } else
            {
                StreamWriter STW_Arquivo;
                STW_Arquivo = new StreamWriter("FECHTED" + via + ".log", false);
                STW_Arquivo.WriteLine("");
                STW_Arquivo.WriteLine("         COMPROVANTE DE RETIRADA - VIA:" + via);
                STW_Arquivo.WriteLine("");
                STW_Arquivo.WriteLine("Cliente.....:");
                STW_Arquivo.WriteLine(" " + nomecliente);
                STW_Arquivo.WriteLine(" ");
                STW_Arquivo.WriteLine("Total.......: R$ " + total);
                STW_Arquivo.WriteLine("");
                STW_Arquivo.WriteLine("------------------------------------------------");
                STW_Arquivo.WriteLine("");

                STW_Arquivo.WriteLine("Data Emissão: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
                STW_Arquivo.WriteLine("Caixa.......: " + Properties.Settings.Default.NomeW.ToString().Trim());
                STW_Arquivo.WriteLine("Cód Caixa...: " + Properties.Settings.Default.Matricula.ToString().Trim());
                STW_Arquivo.WriteLine("");
                STW_Arquivo.WriteLine("");
                STW_Arquivo.Close();
            }
            
        }

        private void dgvTed_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            AlterarTED();
            spoolrec("FECHTED1.log");
            spoolrec("FECHTED2.log");
            this.Close();
            
            
        }
        public void spoolrec(string documento)
        {

            try
>>>>>>> parent of 495a4ae... Atualização Geral
            {
                dgvTed.Visible = true;
            }
            if (op == 2)
            {
                dgvTed.Visible = true;
                txtCaixa.ReadOnly = false;
                txtTurno.ReadOnly = false;
                txtNome.ReadOnly = false;
                txtCaixa.Focus();

            }

            else
<<<<<<< HEAD
            {
                dgvAvulso.Visible = true;
                
=======
                ev.HasMorePages = false;
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                seg = 1;
                AtualizaDGVTransf();
                dgvTed.Focus();

            }else
            {
                seg = 2;
                AtualizaDGVTransf();
                dgvTed.Focus();
>>>>>>> parent of 495a4ae... Atualização Geral
            }
            txtCaixa.Text = caixa.ToString();
            txtTurno.Text = turno.ToString();
            txtNome.Text = nome.ToString();
        }


    }
}
