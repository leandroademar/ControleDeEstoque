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
        public void IncluirRet(ModeloTransf modelo)
        {

            DALTransf DALobj = new DALTransf(conexao);
            DALobj.IncluirRet(modelo);
        }
        public void Alterar(ModeloTransf modelo)
        {

            DALTransf DALobj = new DALTransf(conexao);
            DALobj.Alterar(modelo);
        }
        public DataTable LocalizarTED(int turno, int seg, int caixa)
        {
            DALTransf DALobj = new DALTransf(conexao);
            return DALobj.LocalizarTED(turno,seg,caixa);
        }
        public DataTable LocalizardgvTED(int caixa, int turno, int codfunc)
        {
            DALTransf DALobj = new DALTransf(conexao);
            return DALobj.LocalizaTedDgv(caixa, turno, codfunc);
        }
        public DataTable LocalizarAvulso(int caixa, int turno, int codfunc)
        {
            DALTransf DALobj = new DALTransf(conexao);
            return DALobj.LocalizaAvulso(caixa, turno, codfunc);
        }
    }
}
