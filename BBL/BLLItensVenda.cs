using System;
using DAL;
using Modelo;
using System.Data;

namespace BLL
{
    public class BLLItensVenda
    {
        private DALConexao conexao;
        public BLLItensVenda(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloItensVenda modelo)
        {
            if (modelo.VenCod <= 0)
            {
                throw new Exception("O código da venda é obrigatório");
            }
            if (modelo.ProDesc == "")
            {
                throw new Exception("Verifique o código e nome do produto.");
            }
            if (modelo.ItvCod <= 0)
            {
                throw new Exception("O código do item da venda é obrigatório");
            }

            if (modelo.ItvQtde <= 0)
            {
                throw new Exception("A quantidade deve ser verificada: "+modelo.ProDesc.ToString());
            }

            if (modelo.ItvValor <= 0)
            {
                throw new Exception("O valor do item deve ser maior do que zero");
            }

            if (modelo.ProCod <= 0)
            {
                throw new Exception("O código do produto é obrigatório");
            }
            DALItensVenda DALobj = new DALItensVenda(conexao);
            DALobj.Incluir(modelo);
        }
        public void Alterar(ModeloItensVenda modelo)
        {
            if (modelo.VenCod <= 0)
            {
                throw new Exception("O código da compra é obrigatório");
            }
            if (modelo.ItvCod <= 0)
            {
                throw new Exception("O código do item da compra é obrigatório");
            }

            if (modelo.ItvQtde <= 0)
            {
                throw new Exception("A quantidade deve ser maior do que zero");
            }

            if (modelo.ItvValor <= 0)
            {
                throw new Exception("O valor do item deve ser maior do que zero");
            }

            if (modelo.ProCod <= 0)
            {
                throw new Exception("O código do produto é obrigatório");
            }
            DALItensVenda DALobj = new DALItensVenda(conexao);
            DALobj.Alterar(modelo);
        }
        public void Excluir(ModeloItensVenda modelo)
        {
            if (modelo.VenCod <= 0)
            {
                throw new Exception("O código da compra é obrigatório");
            }

            if (modelo.ItvCod <= 0)
            {
                throw new Exception("O código do item da compra é obrigatório");
            }

            if (modelo.ProCod <= 0)
            {
                throw new Exception("O código do produto é obrigatório");
            }
            DALItensVenda DALobj = new DALItensVenda(conexao);
            DALobj.Excluir(modelo);

        }
        public DataTable Localizar(int comcod)
        {
            DALItensVenda DALobj = new DALItensVenda(conexao);
            return DALobj.Localizar(comcod);
        }

        public ModeloItensVenda CarregaModeloItensCompra(int ItvCod, int ComCod, int ProCod)
        {
            DALItensVenda DALobj = new DALItensVenda(conexao);
            return DALobj.CarregaModeloitensvenda(ItvCod, ComCod, ProCod);
        }
    }
}
