using System;
using DAL;
using Modelo;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLTotal
    {
        private DALConexao conexao;
        public BLLTotal(DALConexao cx)
        {
            this.conexao = cx;
        }

        public ModeloTotal CarregaTotal(int numcaixa, int turno, string data, int codfunc)
        {
            DALTABTotais DALobj = new DALTABTotais(conexao);
            return DALobj.CarregaTotal(numcaixa,turno,data,codfunc);
        }
    }
}
