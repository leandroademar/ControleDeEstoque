using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Movimento
{
    public partial class frmMessagePedido : Form
    {
        public frmMessagePedido(string pedido,string vlrped, string vlrwint,string vlrtot)
        {
            InitializeComponent();
            txtNumero.Text = pedido;
            txtVlrPed.Text = vlrped;
            txtVlrWint.Text = vlrwint;
            txtVlrTot.Text = vlrtot;

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
