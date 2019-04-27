using BLL;
using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmMovimentacaoPedido : GUI.frmModeloDeFormularioDeCadastro
    {
        public double totalVenda = 0;//Variavel Global
        public double totalPedidosW = 0;
        public int coditem = 0;
        public string usuario = "";
        public string User = "";
        public int perfil = 0;
        public frmMovimentacaoPedido()
        {
            
            //frmPrincipal frm = new frmPrincipal(usuario, perfil);
            User = Properties.Settings.Default.Usuario;
            InitializeComponent();
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alteraBotoes(2);
            txtCod.Clear();
            txtCodCli_Leave(sender, e);
            txtObs.Focus();
        }

        private void tbpCliente_Click(object sender, EventArgs e)
        {

        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            try
            {
                frmConsultaVenda f = new frmConsultaVenda();
                f.ShowDialog();


                if (f.codigo != 0)
                {

                    txtCod.Text = f.codigo.ToString();

                    
                }


                f.Dispose();
            }
            catch { }

        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.alteraBotoes(2);
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            //DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            //cx.Conectar();
            //cx.IniciarTransacao();
            try
            {
               
                
                ModeloVenda modeloVenda = new ModeloVenda();
                //modeloVenda.VenCod = Convert.ToInt32(txtCod.Text);
                modeloVenda.CliCod = Convert.ToInt32(txtCodCli.Text);
                modeloVenda.VenStatus = "PENDENTE";
                modeloVenda.VenTotal = this.totalVenda;
                modeloVenda.VenAtend = txtAtendente.Text;
                modeloVenda.VenNome = txtObs.Text.Trim();
                modeloVenda.VenCartao = 0;
                if (chkZero.Checked == true)
                {
                    modeloVenda.VendasMista = 1;
                }else
                    modeloVenda.VendasMista = 0;

                modeloVenda.VenWinthor = Math.Round(Convert.ToDouble(txtTotalWint.Text.ToString()),2);
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLVenda bll = new BLLVenda(cx);
                ModeloItensVenda mitens = new ModeloItensVenda();
                BLLItensVenda bitens = new BLLItensVenda(cx);

                if(this.operacao == "inserir")
                {
                    bll.Incluir(modeloVenda);
                    for (int i = 0; i < dgvItens.RowCount; i++)
                    {
                        mitens.ItvCod = i + 1;
                        mitens.VenCod = modeloVenda.VenCod;
                        mitens.ProCod = Convert.ToInt32(dgvItens.Rows[i].Cells[0].Value);
                        mitens.ProDesc = dgvItens.Rows[i].Cells[1].Value.ToString();
                        mitens.ItvQtde = Math.Round(Convert.ToDouble(dgvItens.Rows[i].Cells[2].Value),2);
                        mitens.ItvValor = Math.Round(Convert.ToDouble(dgvItens.Rows[i].Cells[3].Value),2);
                        DALConexao cxp = new DALConexao(DadosDaConexao.StringDeConexao);
                        BLLProduto bllp = new BLLProduto(cx);
                        ModeloProduto modelop = bllp.CarregaModeloProduto(Convert.ToInt32(dgvItens.Rows[i].Cells[0].Value));
                        modelop.ProQtde = modelop.ProQtde - mitens.ItvQtde;
                        bllp.Alterar(modelop);
                        bitens.Incluir(mitens);
                        tbpPedido.SelectedTab = tbpCliente;
                    }

                   
                }
                MessageBox.Show("Pedido de Venda: \n " + modeloVenda.VenCod.ToString()+" - "+ modeloVenda.VenNome.ToString() +
                    " \n Valor Pedido: R$ "+ modeloVenda.VenTotal.ToString() + 
                    "  \n Valor Winthor: R$ "+ modeloVenda.VenWinthor.ToString() +
                    "  \n Valor Total: R$ " + (modeloVenda.VenTotal + modeloVenda.VenWinthor).ToString() +
                    " \n ", "Informação do Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbpCliente.Focus();
                this.LimpaTela();
                this.alteraBotoes(1);
                


            }
            

            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            this.LimpaTela();
            tbpCliente.Focus();
            tbpPedido.SelectedTab = tbpCliente;


        }
        public void LimpaTela()
        {
            txtCod.Clear();
            txtCodCli.Text = "1";
            txtDescCli.Clear();
            txtAtendente.Clear();
            txtObs.Clear();
            txtCodProd.Clear();
            txtDescProd.Clear();
            txtQuantidade.Clear();
            txtVlrUnit.Clear();
            txtTotal.Clear();
            txtTotalWint.Clear();
            totalVenda = 0;
            chkZero.Checked = false;
            dgvItens.Rows.Clear();
            dgvPedWint.Rows.Clear();
            totalPedidosW = 0;
            coditem = 0;

        }

        private void btnLocalCli_Click(object sender, EventArgs e)
        {

            frmConsultaCliente f = new frmConsultaCliente();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                txtCodCli.Text = f.codigo.ToString();
                txtCodCli_Leave(sender, e);
                //chamada do método do txtForCod
            }
        }
        private void txtCodCli_Leave (object sender, EventArgs e)
        {
            try
            {
                txtAtendente.Text = User;
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                ModeloCliente modelo = bll.CarregaModeloCliente(Convert.ToInt32(txtCodCli.Text));
                txtDescCli.Text = modelo.CliNome;
                if (modelo.CliCod != 1)
                {
                    txtObs.Text = modelo.CliNome;
                }
            }
            catch
            {
                txtCodCli.Clear();
                txtDescCli.Clear();
                
            }
        }

        private void txtCodProd_Leave(object sender, EventArgs e)
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProduto bll = new BLLProduto(cx);
                ModeloProduto modelo = bll.CarregaModeloProduto(Convert.ToInt32(txtCodProd.Text));
                txtDescProd.Text = modelo.ProDescricao;
                txtVlrUnit.Text = modelo.ProValorVenda.ToString();
                txtQuantidade.Text = "1";
            }
            catch
            {
                txtDescProd.Clear();
                txtVlrUnit.Clear();
                txtQuantidade.Clear();
                txtCodProd.Clear();
                txtCodProd.Focus();
            }
        }

        private void txtCodProd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                frmConsultaProduto f = new frmConsultaProduto(2);
                f.ShowDialog();
                if (f.codigo != 0)
                {
                    txtCodProd.Text = f.codigo.ToString();
                    txtCodProd_Leave(sender, e);
                    //chamada do método do txtForCod
                }
            }
        }
        private void VerificaEstoque(int ProCod)
        {
            Double Qtde = 0;

            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProduto bll = new BLLProduto(cx);
                ModeloProduto modelo = bll.CarregaModeloProduto(ProCod);
                Qtde = modelo.ProQtde;
                for (int i = 0; i < dgvItens.RowCount;i++)
                {
                    if(Convert.ToInt32(dgvItens.Rows[i].Cells[0].Value)== ProCod)
                    {
                        Qtde = Qtde - Convert.ToInt32(dgvItens.Rows[i].Cells[2].Value);
                    }
                }
            }
            catch { }
           // return Qtde;
        }
        
        private void txtQuantidade_KeyDown(object sender, KeyEventArgs e)
        {
            Double Qtd = 0;
            try
            {

                if ((txtCodProd.Text != "") && (txtQuantidade.Text != "") && (txtVlrUnit.Text != "") && e.KeyCode == Keys.Enter)
                {
                   if(txtDescProd == null)
                   {
                        MessageBox.Show("Produto Sem Descrição", "Atenção Com o Produto");
                   }
             //       Qtd = VerificaEstoque(Convert.ToInt32(txtCodProd.Text));

                    Double TotalLocal = Math.Round(Convert.ToDouble(txtQuantidade.Text) * Convert.ToDouble(txtVlrUnit.Text), 2);//metodo para calcular o total do produto
                    this.totalVenda = this.totalVenda + TotalLocal;//metodo para somar o total da compra
                    String[] i = new String[] { txtCodProd.Text, txtDescProd.Text, txtQuantidade.Text, txtVlrUnit.Text, TotalLocal.ToString() };//criado vetor de string
                    this.dgvItens.Rows.Add(i);//adicionando o string dentro da datagrid
                    dgvItens.FirstDisplayedScrollingRowIndex = dgvItens.RowCount - 1;
                    txtCodProd.Clear();//limpar o campo
                    txtDescProd.Clear();
                    txtQuantidade.Clear();//limpar o campo
                    txtVlrUnit.Clear();//limpar o campo
                    txtCodProd.Focus();
                    txtTotal.Text = this.totalVenda.ToString();//atualizar o total da compra               
                }

                if (e.KeyCode == Keys.Escape)
                {
                    txtDescProd.Clear();
                    txtVlrUnit.Clear();
                    txtQuantidade.Clear();
                    txtCodProd.Clear();
                    txtCodProd.Focus();
                }
            }
            catch { }
        }

        private void dgvItens_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtCodProd.Text = dgvItens.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtDescProd.Text = dgvItens.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtQuantidade.Text = dgvItens.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtVlrUnit.Text = dgvItens.Rows[e.RowIndex].Cells[3].Value.ToString();
                Double valor = Math.Round(Convert.ToDouble(dgvItens.Rows[e.RowIndex].Cells[4].Value),2);
                this.totalVenda = this.totalVenda - valor;
                dgvItens.Rows.RemoveAt(e.RowIndex);
                txtTotal.Text = this.totalVenda.ToString();
            }
        }

        private void txtObs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter | e.KeyCode == Keys.Tab)
            {
                //tbpPedido.SelectedTab = tbpItens;
                txtVlrWint.Focus();
            }
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (!txtQuantidade.Text.Contains(","))
                {
                    e.KeyChar = ',';
                }
                else e.Handled = true;
            }
        }

        private void txtCodCli_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
            
        }

        private void txtCodProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }

        }

        private void txtQuantidade_Leave(object sender, EventArgs e)
        {
            if (txtQuantidade.Text.Contains(",") == false)
            {
                txtQuantidade.Text += ",00";
            }
            else
            {
                if (txtQuantidade.Text.IndexOf(",") == txtQuantidade.Text.Length - 1)
                {
                    txtTotal.Text += "00";
                }
            }
            try
            {
                Double d = Math.Round(Convert.ToDouble(txtQuantidade.Text), 2);
            }
            catch
            {
                txtQuantidade.Text = "0,00";
            }

        }

        private void txtVlrWint_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter && (txtVlrWint.Text != ""))
            {
                
                Double VlrWint = Math.Round(Convert.ToDouble(txtVlrWint.Text), 2);//metodo para calcular o total do produto
                coditem = coditem + 1;
                totalPedidosW = totalPedidosW + VlrWint;//metodo para somar o total da compra
                String[] i = new String[] { coditem.ToString(), txtVlrWint.Text};//criado vetor de string
                this.dgvPedWint.Rows.Add(i);//adicionando o string dentro da datagrid
                dgvPedWint.FirstDisplayedScrollingRowIndex = dgvPedWint.RowCount - 1;
                txtVlrWint.Clear();//limpar o campo
                txtVlrWint.Focus();
                txtTotalWint.Text = totalPedidosW.ToString();//atualizar o total da compra   
                txtTotalWint_Leave(sender, e);
            }

        }

        private void txtVlrWint_Leave(object sender, EventArgs e)
        {
            if (txtVlrWint.Text.Contains(",") == false)
            {
                txtVlrWint.Text += ",00";
            }
            else
            {
                if (txtVlrWint.Text.IndexOf(",") == txtVlrWint.Text.Length - 1)
                {
                    txtVlrWint.Text += "00";
                }
            }
            try
            {
                Double d = Math.Round(Convert.ToDouble(txtVlrWint.Text), 2);
            }
            catch
            {
                txtVlrWint.Text = "0,00";
            }
        }

      
        private void txtTotalWint_Leave(object sender, EventArgs e)
        {
            if (txtTotalWint.Text.Contains(",") == false)
            {
                txtTotalWint.Text += ",00";
            }
            else
            {
                if (txtTotalWint.Text.IndexOf(",") == txtTotalWint.Text.Length - 1)
                {
                    txtTotalWint.Text += "00";
                }
            }
            try
            {
                Double d = Math.Round(Convert.ToDouble(txtTotalWint.Text), 2);
            }
            catch
            {
                txtTotalWint.Text = "0,00";
            }
        }

        private void dgvPedWint_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtVlrWint.Text = dgvPedWint.Rows[e.RowIndex].Cells[1].Value.ToString();
                Double valorW = Math.Round(Convert.ToDouble(dgvPedWint.Rows[e.RowIndex].Cells[1].Value), 2);
                coditem = coditem - 1;
                this.totalPedidosW = this.totalPedidosW - valorW;
                dgvPedWint.Rows.RemoveAt(e.RowIndex);
                txtTotalWint.Text = this.totalPedidosW.ToString();
                txtTotalWint_Leave(sender, e);
                txtVlrWint.Focus();
            }
        }

        private void txtVlrWint_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (!txtVlrWint.Text.Contains(","))
                {
                    e.KeyChar = ',';
                }
                else e.Handled = true;
            }
        }

        private void frmMovimentacaoPedido_KeyDown(object sender, KeyEventArgs e)
        {
          
            if(e.KeyCode == Keys.F4)
            {
                tbpPedido.SelectedTab = tbpItens;
                txtCodProd.Focus();
            }
            if (e.KeyCode == Keys.F2)
            {
                tbpPedido.SelectedTab = tbpCliente;
                txtObs.Focus();
            }
        }
        
        private void txtCod_Leave(object sender, EventArgs e)
        {
          
        }
    }
}
