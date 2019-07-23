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
