using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLCaixa
    {
        private DALConexao conexao;
        public BLLCaixa(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloCaixa modelo)
        {

            DALCaixa DALobj = new DALCaixa(conexao);
            DALobj.Incluir(modelo);
        }
        public DataTable Localizar(String valor)
        {
            DALCaixa DALobj = new DALCaixa(conexao);
            return DALobj.Localizar(valor);
        }
        public DataTable LocalizarCaixas(String valor, string dtinicial)
        {
            DALCaixa DALobj = new DALCaixa(conexao);
            return DALobj.LocalizarCaixa(valor,dtinicial);
        }
        public DataTable LocalizarCaixasF(String valor, string dtinicial)
        {
            DALCaixa DALobj = new DALCaixa(conexao);
            return DALobj.LocalizarCaixaF(valor, dtinicial);
        }
        public ModeloCaixa CarregaModeloCaixa(int codigo)
        {
            DALCaixa DALobj = new DALCaixa(conexao);
            return DALobj.CarregaModeloCaixa(codigo);
        }

    }
}
