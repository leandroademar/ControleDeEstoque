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
    public partial class frmRelatorioVendas : Form
    {
        public frmRelatorioVendas(string dtinicial, string dtfinal)
        {
            InitializeComponent();
           
        }

        private void frmRelatorioVendas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'nControleDataSet2.SRE_VENDAS_SEPARADAS'. Você pode movê-la ou removê-la conforme necessário.
            this.SRE_VENDAS_SEPARADASTableAdapter.Fill(this.nControleDataSet2.SRE_VENDAS_SEPARADAS);
            // TODO: esta linha de código carrega dados na tabela 'nControleDataSet2.SRE_VENDAS_SEPARADAS'. Você pode movê-la ou removê-la conforme necessário.
            // this.SRE_VENDAS_SEPARADASTableAdapter.Fill(this.nControleDataSet2.SRE_VENDAS_SEPARADAS);

            this.reportViewer1.RefreshReport();
        }
    }
}
