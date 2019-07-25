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
    public partial class frmSuprirEstoque : GUI.frmModeloDeFormularioDeCadastro
    {
        public double totalCompra;
        public frmSuprirEstoque()
        {
            InitializeComponent();
        }

        private void txtCodProd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                frmConsultaProduto f = new frmConsultaProduto(0);
                f.ShowDialog();
                if (f.codigo != 0)
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLProduto bll = new BLLProduto(cx);
                    ModeloProduto modelo = bll.CarregaModeloProduto(f.codigo);
                    txtCodProd.Text = modelo.CatCod.ToString();
                    //colocar os dados na tela
                    txtCodProd.Text = modelo.ProCod.ToString();
                    txtDescProd.Text = modelo.ProDescricao;
                    txtVlrCompra.Text = modelo.ProValorPago.ToString();
                    txtVlrUnit.Text = modelo.ProValorVenda.ToString();


                }
                f.Dispose();
            }
        }
        public void LimpaTela()
        {
            txtCodProd.Clear();
            txtDescProd.Clear();
            txtQuantidade.Clear();
            txtVlrUnit.Clear();
            txtTotal.Clear();
            txtVlrCompra.Clear();
            dgvItens.Rows.Clear();

        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alteraBotoes(2);
            txtCodProd.Focus();
        }

        private void txtVlrCompra_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            this.LimpaTela();
        }

        private void pnDados_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            cx.IniciarTransacao();

            try
            {


                ModeloCompra modelocompra = new ModeloCompra();
                //modeloVenda.VenCod = Convert.ToInt32(txtCod.Text);
                modelocompra.ComNFiscal = 1;
                modelocompra.ForCod = 1;
                modelocompra.ComNParcelas = 1;
                modelocompra.ComStatus = 1;
                modelocompra.ComTotal = this.totalCompra;
                modelocompra.TpaCod = 1;
            
              
                

                BLLCompra bll = new BLLCompra(cx);
                ModeloItensCompra mitens = new ModeloItensCompra();
                BLLItensCompra bitens = new BLLItensCompra(cx);

                if (this.operacao == "inserir")
                {
                    bll.Incluir(modelocompra);
                    for (int i = 0; i < dgvItens.RowCount; i++)
                    {
                        mitens.itcCod = i + 1;
                        mitens.VenCod = modelocompra.ComCod;
                        mitens.ProCod = Convert.ToInt32(dgvItens.Rows[i].Cells[0].Value);
                        mitens.ProDesc = dgvItens.Rows[i].Cells[1].Value.ToString();
                        mitens.itcQtde = Math.Round(Convert.ToDouble(dgvItens.Rows[i].Cells[2].Value), 2);
                        mitens.itcValorCompra = Math.Round(Convert.ToDouble(dgvItens.Rows[i].Cells[3].Value), 2);
                        mitens.itcValor = Math.Round(Convert.ToDouble(dgvItens.Rows[i].Cells[4].Value), 2);
                        DALConexao cxp = new DALConexao(DadosDaConexao.StringDeConexao);
                        BLLProduto bllp = new BLLProduto(cx);
                        ModeloProduto modelop = bllp.CarregaModeloProduto(Convert.ToInt32(dgvItens.Rows[i].Cells[0].Value));
                        modelop.ProQtde = modelop.ProQtde + mitens.itcQtde;
                        modelop.ProValorVenda = mitens.itcValor;
                        modelop.ProValorPago = mitens.itcValorCompra;
                        bllp.Alterar(modelop);
                        bitens.Incluir(mitens);
                    }
                }
                MessageBox.Show("Entrada de Mercadoria", "Informação da entrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.LimpaTela();
                this.alteraBotoes(1);
                cx.TerminarTransacao();
                cx.Desconectar();

            }


            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                cx.CancelarTransacao();
                cx.Desconectar();
            }
        }

        private void txtVlrUnit_KeyDown(object sender, KeyEventArgs e)
        {
            Double Qtd = 0;
            try
            {

                if ((txtCodProd.Text != "") && (txtQuantidade.Text != "") && (txtVlrUnit.Text != "") && e.KeyCode == Keys.Enter)
                {
                    if (txtDescProd == null)
                    {
                        MessageBox.Show("Produto Sem Descrição", "Atenção Com o Produto");
                    }
                    //       Qtd = VerificaEstoque(Convert.ToInt32(txtCodProd.Text));

                    Double TotalLocal = Math.Round(Convert.ToDouble(txtQuantidade.Text) * Convert.ToDouble(txtVlrUnit.Text), 2);//metodo para calcular o total do produto
                    this.totalCompra = this.totalCompra + TotalLocal;//metodo para somar o total da compra
                    String[] i = new String[] { txtCodProd.Text, txtDescProd.Text, txtQuantidade.Text, txtVlrCompra.Text, txtVlrUnit.Text, TotalLocal.ToString() };//criado vetor de string
                    this.dgvItens.Rows.Add(i);//adicionando o string dentro da datagrid
                    dgvItens.FirstDisplayedScrollingRowIndex = dgvItens.RowCount - 1;
                    txtCodProd.Clear();//limpar o campo
                    txtDescProd.Clear();
                    txtQuantidade.Clear();//limpar o campo
                    txtVlrUnit.Clear();//limpar o campo
                    txtVlrCompra.Clear();
                    txtCodProd.Focus();
                    txtTotal.Text = this.totalCompra.ToString();//atualizar o total da compra               
                }

                if (e.KeyCode == Keys.Escape)
                {
                    txtDescProd.Clear();
                    txtVlrUnit.Clear();
                    txtVlrCompra.Clear();
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
                txtVlrCompra.Text = dgvItens.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtVlrUnit.Text = dgvItens.Rows[e.RowIndex].Cells[4].Value.ToString();
                Double valor = Math.Round(Convert.ToDouble(dgvItens.Rows[e.RowIndex].Cells[5].Value), 2);
                this.totalCompra = this.totalCompra - valor;
                dgvItens.Rows.RemoveAt(e.RowIndex);
                txtTotal.Text = this.totalCompra.ToString();
            }
        }
    }
}
