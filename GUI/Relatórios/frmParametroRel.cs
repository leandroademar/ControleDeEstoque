using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmParametroRel : Form
    {
        public int tp = 1;

        public frmParametroRel(int tpr)
        {
            InitializeComponent();
            if (tpr == 1)
            {
                lblTipoRel.Text = "Relatório de Vendas";
                tp = 1;
            }
            if (tpr == 2)
            {
                lblTipoRel.Text = "Relatório de Caixa";
                tp = 2;
                groupBox1.Visible = false;

            }
            if (tpr == 3)
            {
                lblTipoRel.Text = "Relatório de Separação";
                tp = 3;
                groupBox1.Visible = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (tp == 1)
            {
                
            }

            if (tp == 3)
            {
                

                frmRelatorioVendas f = new frmRelatorioVendas(dtpInicial.Value.ToString("yyyy-MM-dd"), dtpFinal.Value.ToString("yyyy-MM-dd"));
               
                f.Show();
            }
        }

        private void frmParametroRel_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
    
}
