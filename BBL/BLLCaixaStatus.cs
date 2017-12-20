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
    public class BLLCaixaStatus
    {
        private DALConexao conexao;
        public BLLCaixaStatus(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Abrir(ModeloCaixaStatus modelo)
        {
            if (modelo.CaxsCod != 0)
            {
                throw new Exception("Já existe caixa aberto para operadora");
            }

            DALCaixaStatus DALobj = new DALCaixaStatus(conexao);
            DALobj.Abrir(modelo);
        }
        public DataTable Localizar(String valor)
        {
            DALCaixaStatus DALobj = new DALCaixaStatus(conexao);
            return DALobj.Localizar(valor);
        }
        public void Fechar(ModeloCaixaStatus modelo)
        {
            DALCaixaStatus DALobj = new DALCaixaStatus(conexao);
            DALobj.Fechar(modelo);
        }
        public void FecharC(ModeloCaixaStatus modelo)
        {
            DALCaixaStatus DALobj = new DALCaixaStatus(conexao);
            DALobj.FecharC(modelo);
        }
        public ModeloCaixaStatus CarregaModeloCategoria(int codigo)
        {
            DALCaixaStatus DALobj = new DALCaixaStatus(conexao);
            return DALobj.CarregaModeloCaisaStatus(codigo);
        }
    }
}
