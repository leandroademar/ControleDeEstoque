using BLL;
using DAL;
using GUI.Relatórios;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace GUI
{
    public partial class frmRelatorioVendas : Form
    {

        public string _dtinicial;
        public string _dtfinal;

        public frmRelatorioVendas(string dtinicial, string dtfinal)
        {
            InitializeComponent();
            _dtinicial = dtinicial;
            _dtfinal = dtfinal;
           
        }

        private void frmRelatorioVendas_Load(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLVenda bll = new BLLVenda(cx);
            //DataSet da = new DataSet();
            RelVendasSeparas rel = new RelVendasSeparas();
            rel.SetDataSource(bll.LocalizarSeparadas(_dtinicial, _dtfinal));
            crvRelatorio.ReportSource = rel;
            crvRelatorio.Refresh();
            
        }
    }
}
