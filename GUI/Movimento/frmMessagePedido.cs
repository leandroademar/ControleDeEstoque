using System;
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
