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
                txtCaixa.ReadOnly = false;
                txtTurno.ReadOnly = false;
                txtNome.ReadOnly = false;
                txtCaixa.Focus();

            }

            else
            {
                dgvAvulso.Visible = true;
                
            }
            txtCaixa.Text = caixa.ToString();
            txtTurno.Text = turno.ToString();
            txtNome.Text = nome.ToString();
        }


    }
}
