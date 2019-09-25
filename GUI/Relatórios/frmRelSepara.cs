using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmRelSepara : Form
    {
        public frmRelSepara()
        {
            InitializeComponent();
        }

        private void frmRelSepara_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            //this.reportViewer1.RefreshReport();
        }
    }
}
