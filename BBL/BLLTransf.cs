﻿using DAL;
using Modelo;
using System.Data;

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
        public void Deleta(ModeloTransf modelo)
        {

            DALTransf DALobj = new DALTransf(conexao);
            DALobj.AlterarDel(modelo);
        }
        public DataTable LocalizarTED( int seg, int caixa)
        {
            DALTransf DALobj = new DALTransf(conexao);
            return DALobj.LocalizarTED(seg,caixa);
        }
        public DataTable LocalizarAv( int seg, int caixa)
        {
            DALTransf DALobj = new DALTransf(conexao);
            return DALobj.LocalizarTED( seg, caixa);
        }
        public DataTable LocalizardgvTED(int caixa, int turno, int codfunc,string datamov)
        {
            DALTransf DALobj = new DALTransf(conexao);
            return DALobj.LocalizaTedDgv(caixa, turno, codfunc,datamov);
        }
        public DataTable LocalizarAvulso(int caixa, int turno, int codfunc, string datamov)
        {
            DALTransf DALobj = new DALTransf(conexao);
            return DALobj.LocalizaAvulso(caixa, codfunc,datamov);
        }
    }
}
