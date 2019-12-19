using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Modelo;
using System.Data;

namespace BLL
{
    public class BLLVenda
    {
        private DALConexao conexao;
        public BLLVenda(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloVenda modelo)
        {
            //if (modelo.ComData != DateTime.Now)
            //{
            //    throw new Exception("A data da compra não corresponde a data atual");
            //}

           

            if (modelo.CliCod <= 0)
            {
                throw new Exception("O código do cliente deve ser informado");
            }
            if (modelo.VenNome == "")
            {
                throw new Exception("O nome do cliente precisa ser informado");
            }

            if (modelo.VendasMista == 0 && modelo.VenWinthor == 0 )
            {
                throw new Exception("Identifique os valores de Vendas Winthor");
            }
            if(string.IsNullOrEmpty(modelo.VenWinthor.ToString()))
            {
                throw new Exception("Identifique os valores de Vendas Winthor");

            }

            DALVenda DALobj = new DALVenda(conexao);
            DALobj.Incluir(modelo);
        }
        public void IncluirW(ModeloVenda modelo)
        {
            if (modelo.VenWinthor <= 0)
            {
                throw new Exception("O valor da venda deve ser maior que zero");
            }
            DALVenda DALobj = new DALVenda(conexao);
            DALobj.IncluirW(modelo);
        }


        public void Alterar(ModeloVenda modelo)
        {
            if (modelo.VenCod <= 0)
            {
                throw new Exception("O código da compra dever ser maior do que zero");
            }          

            DALVenda DALobj = new DALVenda(conexao);
            DALobj.Alterar(modelo);
        }
        public void AlterarS(ModeloVenda modelo)
        {
            if (modelo.VenCod <= 0)
            {
                throw new Exception("O código da compra dever ser maior do que zero");
            }

            DALVenda DALobj = new DALVenda(conexao);
            DALobj.AlterarS(modelo);
        }
        public void AlterarSf(ModeloVenda modelo)
        {
            if (modelo.VenCod <= 0)
            {
                throw new Exception("O código da compra dever ser maior do que zero");
            }

            DALVenda DALobj = new DALVenda(conexao);
            DALobj.AlterarSf(modelo);
        }

        public void Excluir(int codigo)
        {

            DALVenda DALobj = new DALVenda(conexao);
            DALobj.Excluir(codigo);
        }
        public DataTable Localizar(int codigo)
        {
            DALVenda DALobj = new DALVenda(conexao);
            return DALobj.Localizar(codigo);
        }
        public DataTable LocalizarP(String nome)
        {
            DALVenda DALobj = new DALVenda(conexao);
            return DALobj.LocalizarP(nome);
        }
        public DataTable LocalizarFatura(String nome)
        {
            DALVenda DALobj = new DALVenda(conexao);
            return DALobj.LocalizarFatura(nome);
        }
        public DataTable LocalizarFatura()
        {
            DALVenda DALobj = new DALVenda(conexao);
            return DALobj.LocalizarFatura();
        }
        public DataTable LocalizarSepara(string nome)
        {
            DALVenda DALobj = new DALVenda(conexao);
            return DALobj.LocalizarSepara(nome);
        }
        public DataTable LocalizarSeparados(string nome)
        {
            DALVenda DALobj = new DALVenda(conexao);
            return DALobj.LocalizarSeparados(nome);
        }
        public DataTable LocalizarFinalizados(string nome)
        {
            DALVenda DALobj = new DALVenda(conexao);
            return DALobj.LocalizarFinalizados(nome);
        }
        public DataTable Localizar()
        {
            DALVenda DALobj = new DALVenda(conexao);
            return DALobj.Localizar();
        }
        public DataTable Localizar(DateTime dtinicial, DateTime dtfinal)
        {
            DALVenda DALobj = new DALVenda(conexao);
            return DALobj.Localizar(dtinicial, dtfinal);
        }
        public ModeloVenda CarregaModeloVenda(int codigo)
        {
            DALVenda DALobj = new DALVenda(conexao);
            return DALobj.CarregaModeloVenda(codigo);
        }
        public ModeloVenda CarregaModeloFatura(int codigo)
        {
            DALVenda DALobj = new DALVenda(conexao);
            return DALobj.CarregaModeloFatura(codigo);
        }

    }
}
