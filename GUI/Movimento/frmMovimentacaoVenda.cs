using System;
using Ferramentas;
using System.Drawing.Printing;
using System.IO;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using BLL;
using DAL;
using Modelo;

namespace GUI
{
    public partial class frmMovimentacaoVenda : Form
    {
        public Font printFont;
        public StreamReader streamToPrint;
        public int codigo = 0;
        public int codigov = 0;
        //public int idcaixa = 0;
        public int IdCaixa { get; internal set; }
        public int opp = 0;
        public double totalVenda = 0;
        public double totaldin = 0;
        public double totalcart = 0;
        public string cliente = "Cliente Tabajara";
        public string User = Properties.Settings.Default.Usuario;
        public int Matricula = Properties.Settings.Default.Matricula;
        public string NomeW = Properties.Settings.Default.NomeW;
        public int Caixa = Properties.Settings.Default.Caixa;
        public string xnomecli;
        public string xvlrted;
        public int xturno;






        public frmMovimentacaoVenda()
        {
            InitializeComponent();
            lblCaixa.Text = Caixa.ToString()+" - "+NomeW.ToString();
           
        }

        private void frmMovimentacaoVenda_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader arquivo = new StreamReader("CAIXA");
                IdCaixa = Convert.ToInt32(arquivo.ReadLine());
                btnLocaliza.Enabled = true;
                txtVenCod.Enabled = true;
                arquivo.Close();
                btnCancela_Click(sender, e);

            }
            catch
            {
                MessageBox.Show("Para Iniciar as Vendas, Favor Abrir o Caixa","Informativo",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            txtVenCod.Text = null;
            txtNomeAtend.Clear();
            txtNomeCli.Clear();
            txtStatus.Clear();
            dgvProdutos.DataSource = null;
            txtTotal.Text = "0,00";
            txtWint.Text = "0,00";
            txtCart.Text = "0,00";
            txtVlrPed.Text = "0,00";
            txtTot.Text = "0,00";
            txtVenCod.Focus();
            txtVenCod.ReadOnly = false;
            btnLocaliza.Visible = true;
            btnGrava.Visible = false;
            txtCart.ReadOnly = false;
            operacao(0);
        }

        private void btnLocaliza_Click(object sender, EventArgs e)
        {
            try
            {
                frmConsultaVenda f = new frmConsultaVenda();
                f.ShowDialog();
                

                if (f.codigo != 0)
                {
                    
                    txtVenCod.Text = f.codigo.ToString();
                    txtVenCod_Leave(sender, e);
                }
               

                f.Dispose();
            }
            catch { }

        }

        public void btnGrava_Click(object sender, EventArgs e)
        {
            //DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
   

            try
            {
                if (this.opp == 0)
                {
                    txtWint_Leave(sender, e);
                    codigov = Convert.ToInt32(txtVenCod.Text);
                    ModeloVenda modelo = new ModeloVenda();
                    modelo.VenWinthor = Math.Round(Convert.ToDouble(txtWint.Text), 2);
                    modelo.VenCartao = Math.Round(Convert.ToDouble(txtCart.Text), 2);
                    modelo.VenDinheiro = Math.Round(Convert.ToDouble(txtTotal.Text), 2);
                    modelo.VenTotalgeral = Math.Round(Convert.ToDouble(txtTot.Text), 2);
                    modelo.CliCod = 1;
                    modelo.VenCaixa = User;
                    modelo.VenStatus = "FATURADO";
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLVenda bll = new BLLVenda(cx);
                    modelo.VenCod = Convert.ToInt32(codigov);
                    bll.Alterar(modelo);
                    VendaCaixa();
                    btImprimir_Click(sender, e);
                    btnCancela_Click(sender, e);
                    
                }
                if(this.opp == 1)
                {
                    ModeloVenda modelovenda = new ModeloVenda();
                    modelovenda.VenAtend = txtNomeAtend.Text;
                    modelovenda.VenNome = txtNomeCli.Text;
                    modelovenda.VenWinthor = Math.Round(Convert.ToDouble(txtWint.Text), 2);
                    modelovenda.VenCartao = Math.Round(Convert.ToDouble(txtCart.Text), 2);
                    modelovenda.VenDinheiro = Math.Round(Convert.ToDouble(txtTotal.Text), 2);
                    modelovenda.VenTotalgeral = Math.Round(Convert.ToDouble(txtTot.Text), 2);
                    modelovenda.VenTotal = 0;
                    modelovenda.CliCod = 1;
                    modelovenda.VenCaixa = User;
                    modelovenda.VenStatus = "WINTHOR";
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLVenda bll = new BLLVenda(cx);
                    bll.IncluirW(modelovenda);
                    codigov = modelovenda.VenCod;
                    btImprimir_Click(sender, e);
                    btnCancela_Click(sender, e);
               
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);

            }
        }

        public void imprimerecibo()
        {
            this.codigov = Convert.ToInt32(codigov);
            this.totalVenda = Math.Round(Convert.ToDouble(txtTot.Text), 2);
            this.totaldin = Math.Round(Convert.ToDouble(txtTotal.Text), 2);
            this.totalcart = Math.Round(Convert.ToDouble(txtCart.Text), 2);
            this.cliente = txtNomeCli.ToString();

            clsArquivoTxt LCLS_ArquivoTxt = new clsArquivoTxt();
            LCLS_ArquivoTxt.FU_Gravar(txtVenCod.Text, txtNomeCli.Text, totalcart.ToString(), totaldin.ToString(),totalVenda.ToString());
        }

        public void spoolrec(string documento)
        {
            
            try
            {
                streamToPrint = new StreamReader
                (documento,false);
                printFont = new Font("Arial", 10);
                PrintDocument pd = new PrintDocument();
                pd.PrintPage += new PrintPageEventHandler
                (this.pd_PrintPage);
                //PrintController pc = new PrintControllerWithStatusDialog(pd.PrintController);
                pd.PrintController = new System.Drawing.Printing.StandardPrintController();
                pd.Print();
                streamToPrint.Close();
                pd.Dispose();

            }
 
        
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public void pd_PrintPage(object sender, PrintPageEventArgs ev)
        {
            float linesPerPage = 0;
            float yPos = 0;
            int count = 0;
            float leftMargin = 2;
            float topMargin = 1;
            string line = null;

            // Calculate the number of lines per page.
            linesPerPage = ev.MarginBounds.Height /
               printFont.GetHeight(ev.Graphics);

            // Print each line of the file.
            while (count < linesPerPage &&
               ((line = streamToPrint.ReadLine()) != null))
            {
                yPos = topMargin + (count *
                   printFont.GetHeight(ev.Graphics));
                ev.Graphics.DrawString(line, printFont, Brushes.Black,
                   leftMargin, yPos, new StringFormat());
                count++;
            }

            // If more lines exist, print another page.
            if (line != null)
                ev.HasMorePages = true;
            else
                ev.HasMorePages = false;
        }

        public void AtualizaDGVProdutosVenda()
        {
            dgvProdutos.RowHeadersVisible = false;
            dgvProdutos.ReadOnly = true;
            dgvProdutos.Columns[0].Visible = false;
            dgvProdutos.Columns[4].Visible = false;
            dgvProdutos.Columns[5].HeaderText = "Nome do Produto";
            dgvProdutos.Columns[5].DisplayIndex = 0;
            dgvProdutos.Columns[1].HeaderText = "Quantidade";
            dgvProdutos.Columns[1].DisplayIndex = 1;
            dgvProdutos.Columns[2].HeaderText = "Valor Unit.";
            dgvProdutos.Columns[2].DisplayIndex = 2;
            dgvProdutos.Columns[3].Visible = false;
            dgvProdutos.Columns[5].Width = 350;
            dgvProdutos.Columns[2].Width = 70;
            dgvProdutos.Columns[1].Width = 70;
            dgvProdutos.Sort(dgvProdutos.Columns[5], ListSortDirection.Ascending);
        }
        

        private void txtVenCod_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtVenCod.Text != null)
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLVenda bll = new BLLVenda(cx);
                    ModeloVenda modelo = bll.CarregaModeloVenda(Convert.ToInt32(txtVenCod.Text));
                    btnLocaliza.Visible = false;
                    txtVenCod.Text = modelo.VenCod.ToString();
                    txtNomeCli.Text = modelo.VenNome.ToString();
                    txtNomeAtend.Text = modelo.VenAtend.ToString();
                    txtVlrPed.Text = modelo.VenTotal.ToString();
                    txtStatus.Text = modelo.VenStatus.ToString();
                    txtWint.Text = modelo.VenWinthor.ToString();
                    txtCart.Text = modelo.VenCartao.ToString();
                    txtVenCod.ReadOnly = true;
                    BLLItensVenda bllitens = new BLLItensVenda(cx);
                    dgvProdutos.DataSource = bllitens.Localizar(Convert.ToInt32(txtVenCod.Text));
                    this.AtualizaDGVProdutosVenda();
                    txtVlrPed.Focus();
                    //txtWint_Leave(sender, e);

                }
                
            }
            catch
            {

            }
        }

        private void txtWint_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (!txtWint.Text.Contains(","))
                {
                    e.KeyChar = ',';
                }
                else e.Handled = true;
            }
        }

        private void txtWint_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCart.Focus();
            }

        }

        private void txtWint_Leave(object sender, EventArgs e)
        {
            if (txtWint.Text.Contains(",") == false)
            {
                txtWint.Text += ",00";
            }
            else
            {
                if (txtWint.Text.IndexOf(",") == txtWint.Text.Length - 1)
                {
                    txtWint.Text += "00";
                }
            }
            try
            {
                Double d = Math.Round(Convert.ToDouble(txtWint.Text),2);
            }
            catch
            {
                txtWint.Text = "0,00";
            }


            Double TotalDinheiro = Math.Round(Convert.ToDouble(txtWint.Text) + Convert.ToDouble(txtVlrPed.Text) - Convert.ToDouble(txtCart.Text),2);
            this.totalVenda = Math.Round(Convert.ToDouble(txtWint.Text) + Convert.ToDouble(txtVlrPed.Text),2);
            txtTot.Text = this.totalVenda.ToString();
            txtTotal.Text = TotalDinheiro.ToString();
            if (txtStatus.Text.Contains("PENDENTE") == true)
            {
                btnGrava.Visible = true;

            }

        }

        private void txtCart_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGrava.Focus();
            }
            if (e.KeyCode == Keys.F5)
            {
                btnCancela_Click(sender, e);
            }
        }

        private void txtCart_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (!txtCart.Text.Contains(","))
                {
                    e.KeyChar = ',';
                }
                else e.Handled = true;
            }
        }

        private void txtCart_Leave(object sender, EventArgs e)
        {
            if (txtCart.Text.Contains(",") == false)
            {
                txtCart.Text += ",00";
            }
            else
            {
                if (txtCart.Text.IndexOf(",") == txtCart.Text.Length - 1)
                {
                    txtCart.Text += "00";
                }
            }
            try
            {
                Double d = Math.Round(Convert.ToDouble(txtCart.Text),2);
            }
            catch
            {
                txtCart.Text = "0,00";
            }
            Double TotalDinheiro = Math.Round(Convert.ToDouble(txtWint.Text) + Convert.ToDouble(txtVlrPed.Text) - Convert.ToDouble(txtCart.Text),2);
            txtTotal.Text = TotalDinheiro.ToString();

        }

        private void txtVlrPed_Leave(object sender, EventArgs e)
        {
            if (txtVlrPed.Text.Contains(",") == false)
            {
                txtVlrPed.Text += ",00";
            }
            else
            {
                if (txtVlrPed.Text.IndexOf(",") == txtVlrPed.Text.Length - 1)
                {
                    txtVlrPed.Text += "00";
                }
            }
            try
            {
                Double d = Math.Round(Convert.ToDouble(txtVlrPed.Text), 2);
            }
            catch
            {
                txtVlrPed.Text = "0,00";
            }
            if (txtStatus.Text.Contains("PENDENTE") == false)
            {
                txtWint.ReadOnly = true;
                txtCart.ReadOnly = true;
                btImprimir.Visible = true;
                btnGrava.Visible = false;
                btImprimir.Focus();
                txtWint_Leave(sender, e);
                txtCart_Leave(sender, e);
            }
        }

        private void txtTotal_Leave(object sender, EventArgs e)
        {
            if (txtTotal.Text.Contains(",") == false)
            {
                txtTotal.Text += ",00";
            }
            else
            {
                if (txtTotal.Text.IndexOf(",") == txtTotal.Text.Length - 1)
                {
                    txtTotal.Text += "00";
                }
            }
            try
            {
                Double d = Math.Round(Convert.ToDouble(txtTotal.Text), 2);
            }
            catch
            {
                txtTotal.Text = "0,00";
            }

        }

        private void txtTot_Leave(object sender, EventArgs e)
        {
            if (txtTot.Text.Contains(",") == false)
            {
                txtTot.Text += ",00";
            }
            else
            {
                if (txtTot.Text.IndexOf(",") == txtTot.Text.Length - 1)
                {
                    txtTot.Text += "00";
                }
            }
            try
            {
                Double d = Math.Round(Convert.ToDouble(txtTot.Text), 2);
            }
            catch
            {
                txtTot.Text = "0,00";
            }

        }

      
        public void operacao(int op)
        {
            if(op == 1)
            {
                txtVenCod.ReadOnly = true;
                btnLocaliza.Visible = false;
                txtNomeCli.ReadOnly = false;
                txtNomeAtend.ReadOnly = false;
                txtNomeCli.CharacterCasing = CharacterCasing.Upper;
                txtNomeAtend.CharacterCasing = CharacterCasing.Upper;
                txtStatus.Text = "PENDENTE";
                btImprimir.Visible = true;
                txtNomeCli.Focus();
                this.opp = 1;
            }
            if ( op == 0)
            {
                txtVenCod.Visible = true;
                txtVenCod.Focus();
                btnLocaliza.Visible = true;
                txtWint.ReadOnly = false;
                txtNomeCli.ReadOnly = true;
                txtNomeAtend.ReadOnly = true;
                btImprimir.Visible = false;
                this.opp = 0;
            }
        }

        private void txtNomeCli_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtNomeAtend.Focus();
            }
        }

        private void btImprimir_Click(object sender, EventArgs e)
        {
            
            string doc = "PEDIDO.TXT";
            imprimerecibo();
            spoolrec(doc);
            spoolrec(doc);
            if (dgvProdutos.RowCount > 0)
            {
                doc = "VENDA.TXT";
                GravarVenda();
                spoolrec(doc);
            }
        }

        public void GravarVenda()
        {
            StreamWriter STW_Arquivo;
            STW_Arquivo = new StreamWriter("VENDA.txt", false);
            STW_Arquivo.WriteLine("");
            STW_Arquivo.WriteLine("                 MAPA DE SEPARAÇÃO        ");
            STW_Arquivo.WriteLine("");
            STW_Arquivo.WriteLine("Código...: " + txtVenCod.Text);
            STW_Arquivo.WriteLine("Cliente..: " + txtNomeCli.Text);
            STW_Arquivo.WriteLine("Total....: R$ " + txtVlrPed.Text.ToString());
            STW_Arquivo.WriteLine("Hora.....: " +DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
            STW_Arquivo.WriteLine("Caixa....: "+ User.Trim());
            STW_Arquivo.WriteLine("");
            STW_Arquivo.WriteLine("      PRODUTOS        ");
            STW_Arquivo.WriteLine("");
            for (int i = 0; i < dgvProdutos.RowCount;i++)
            {
                STW_Arquivo.WriteLine(dgvProdutos.Rows[i].Cells[5].Value.ToString().Trim());
                STW_Arquivo.WriteLine(" Quant.: " + dgvProdutos.Rows[i].Cells[1].Value.ToString() +"        Vlr Unit: R$ " + dgvProdutos.Rows[i].Cells[2].Value.ToString());
                STW_Arquivo.WriteLine("");
            }
            STW_Arquivo.WriteLine("");
            STW_Arquivo.WriteLine("");
            STW_Arquivo.WriteLine("");
            STW_Arquivo.WriteLine("COMPROVANTE SEM VALOR FISCAL");
            STW_Arquivo.Close();
        }
        public void GravarFechamento(string caixa, string pedido, string winthor, string dinheiro, string cartao, string total,string abertura)
        {
            StreamWriter STW_Arquivo;
            STW_Arquivo = new StreamWriter("FECHAMENTO.txt", false);
            STW_Arquivo.WriteLine("");
            STW_Arquivo.WriteLine("                FECHAMENTO DE CAIXA       ");
            STW_Arquivo.WriteLine("");
            STW_Arquivo.WriteLine("");
            STW_Arquivo.WriteLine("Total.......: R$ " + pedido);
            STW_Arquivo.WriteLine("");
            STW_Arquivo.WriteLine("------------------------------------------------");
            STW_Arquivo.WriteLine("");
            STW_Arquivo.WriteLine("Abertura....: " + abertura);
            STW_Arquivo.WriteLine("Fechamento..: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
            STW_Arquivo.WriteLine("Caixa.......: " + User.Trim());
            STW_Arquivo.WriteLine("Cód Caixa...: " + caixa );
            STW_Arquivo.WriteLine("");
            STW_Arquivo.WriteLine("");
            STW_Arquivo.Close();
        }
        public void GravarTED(int via, string nomecliente, string total)
        {
            StreamWriter STW_Arquivo;
            STW_Arquivo = new StreamWriter("FECHTED.log", false);
            STW_Arquivo.WriteLine("");
            STW_Arquivo.WriteLine("              COMPROVANTE DE TED - VIA:" + via);
            STW_Arquivo.WriteLine("");
            STW_Arquivo.WriteLine("Cliente.....:");
            STW_Arquivo.WriteLine(" " + cliente);
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



        private void txtVlrPed_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtWint.Focus();
            }
        }
        public void VendaCaixa()

        {
         
            try
            {
                ModeloCaixa modelo = new ModeloCaixa();
                modelo.CaxId = IdCaixa;
                modelo.CaxVenda = codigov;
                modelo.CaxNome = Properties.Settings.Default.Usuario;
                modelo.CaxPedido = Convert.ToDouble(txtVlrPed.Text);
                modelo.CaxCartao = Convert.ToDouble(txtCart.Text);
                modelo.CaxWinthor = Convert.ToDouble(txtWint.Text);
                modelo.CaxDinheiro = Convert.ToDouble(txtTotal.Text);
                modelo.CaxTotal = Convert.ToDouble(txtTot.Text);
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCaixa bll = new BLLCaixa(cx);
                bll.Incluir(modelo);
                
            }
            catch
            {
             
            }

        }
        private void txtNomeAtend_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtWint.Focus();
            }
        }

        private void abrirCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloCaixaStatus modelo = new ModeloCaixaStatus();
                modelo.CaxsTurno = 1;
                modelo.CaxsAbertura = DateTime.Now;
                modelo.CaxsStatus = 0;
                modelo.CaxsNome = User;
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCaixaStatus bll = new BLLCaixaStatus(cx);
                bll.Abrir(modelo);
                IdCaixa = modelo.CaxsCod;
                MessageBox.Show("Caixa Aberto código:" + IdCaixa.ToString(), "Aviso!");
                StreamWriter STW_Caixa;
                STW_Caixa= new StreamWriter("CAIXA", false);
                STW_Caixa.WriteLine (IdCaixa);
                STW_Caixa.Close();
                btnLocaliza.Enabled = true;
                txtVenCod.Enabled = true;
            }
            catch
            {
                MessageBox.Show(" Erro Já existe caixa aberto para essa operadora.\n \n Deseja fechar o caixa anterior ?","Atenção", 
                                 MessageBoxButtons.YesNo , MessageBoxIcon.Error);
            }

        }

        private void fecharCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string caixa = ""; string pedido = ""; string winthor = ""; string dinheiro = ""; string cartao = ""; string total = ""; string abertura = "";
            ModeloCaixaStatus modelo = new ModeloCaixaStatus();
            modelo.CaxsCod = IdCaixa;
            modelo.CaxsFechamento = DateTime.Now;
            modelo.CaxsStatus = 1;
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCaixaStatus bll = new BLLCaixaStatus(cx);
            bll.Fechar(modelo);
            BLLCaixa bllc = new BLLCaixa(cx);
            ModeloCaixa mcaixa = bllc.CarregaModeloCaixa(modelo.CaxsCod);
            caixa = mcaixa.CaxId.ToString();
            pedido = mcaixa.CaxPedido.ToString();
            winthor = mcaixa.CaxWinthor.ToString();
            dinheiro = mcaixa.CaxDinheiro.ToString();
            cartao = mcaixa.CaxCartao.ToString();
            total = mcaixa.CaxTotal.ToString();
            abertura = mcaixa.CaxAbertura.ToString();
            GravarFechamento(caixa, pedido, winthor, dinheiro, cartao, total, abertura);
            spoolrec("FECHAMENTO.txt");
            File.Move("CAIXA", "CAIXA_" + DateTime.Now.ToString("ddMMyyyy_HHmm"));

            this.Close();
        }

        private void consultarTEDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLctoTED frm = new frmLctoTED(Caixa,NomeW,1);
            frm.Show();
        }

        private void txtVenCod_KeyDown(object sender, KeyEventArgs e)
        {
            if(txtVenCod.Text != "" && e.KeyCode == Keys.Enter )
            {
                txtVenCod_Leave(sender, e);
                txtWint.Focus();
            }
        }
    

        private void btnTED_Click(object sender, EventArgs e)
        {

            frmLctoTED frm = new frmLctoTED( Caixa, NomeW, 1);
            frm.Show();

        }

        private void frmMovimentacaoVenda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                btnCancela_Click(sender, e);
            }
            if (e.KeyCode == Keys.F2)
            {
                btnLocaliza_Click(sender, e);
            }
            if (e.KeyCode == Keys.F10)
            {
                btnTED_Click(sender, e);
            }
        }
    }
}
