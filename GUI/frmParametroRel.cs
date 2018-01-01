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
            if (tp == 3)
            {
                MessageBox.Show("Ok");
            }
        }
    }
    
}
