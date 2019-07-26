using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLTransf
    {
        private DALConexao conexao;
        public BLLTransf(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloTransf modelo)
        {

            DALTransf DALobj = new DALTransf(conexao);
            DALobj.Incluir(modelo);
        }
        public void Alterar(ModeloTransf modelo)
        {

            DALTransf DALobj = new DALTransf(conexao);
            DALobj.Incluir(modelo);
        }
    }
}
