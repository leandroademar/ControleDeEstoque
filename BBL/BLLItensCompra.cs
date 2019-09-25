using System;
using DAL;
using Modelo;
using System.Data;

namespace BLL
{
    public class BLLItensCompra
    {
        private DALConexao conexao;
        public BLLItensCompra(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloItensCompra modelo)
        {
            if (modelo.VenCod <= 0)
            {
                throw new Exception("O código da venda é obrigatório");
            }
            if (modelo.ProDesc == "")
            {
                throw new Exception("Verifique o código e nome do produto.");
            }
            if (modelo.itcCod <= 0)
            {
                throw new Exception("O código do item da venda é obrigatório");
            }


            if (modelo.ProCod <= 0)
            {
                throw new Exception("O código do produto é obrigatório");
            }
            DALItensCompra DALobj = new DALItensCompra(conexao);
            DALobj.Incluir(modelo);
        }
        public void Alterar(ModeloItensCompra modelo)
        {
            if (modelo.VenCod <= 0)
            {
                throw new Exception("O código da compra é obrigatório");
            }
            if (modelo.itcCod <= 0)
            {
                throw new Exception("O código do item da compra é obrigatório");
            }

            if (modelo.itcQtde <= 0)
            {
                throw new Exception("A quantidade deve ser maior do que zero");
            }

            if (modelo.itcValor <= 0)
            {
                throw new Exception("O valor do item deve ser maior do que zero");
            }

            if (modelo.ProCod <= 0)
            {
                throw new Exception("O código do produto é obrigatório");
            }
            DALItensCompra DALobj = new DALItensCompra(conexao);
            DALobj.Alterar(modelo);
        }
        public void Excluir(ModeloItensCompra modelo)
        {
            if (modelo.VenCod <= 0)
            {
                throw new Exception("O código da compra é obrigatório");
            }

            if (modelo.itcCod <= 0)
            {
                throw new Exception("O código do item da compra é obrigatório");
            }

            if (modelo.ProCod <= 0)
            {
                throw new Exception("O código do produto é obrigatório");
            }
            DALItensCompra DALobj = new DALItensCompra(conexao);
            DALobj.Excluir(modelo);

        }
        public DataTable Localizar(int comcod)
        {
            DALItensCompra DALobj = new DALItensCompra(conexao);
            return DALobj.Localizar(comcod);
        }

        public ModeloItensCompra CarregaModeloItensCompra(int itcCod, int VenCod, int ProCod)
        {
            DALItensCompra DALobj = new DALItensCompra(conexao);
            return DALobj.CarregaModeloitenscompra(itcCod, VenCod, ProCod);
        }
    }
}
