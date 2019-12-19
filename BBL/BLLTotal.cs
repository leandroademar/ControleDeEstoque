﻿using DAL;
using Modelo;

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
        public ModeloTotal CarregaTotalGeral( string data)
        {
            DALTABTotais DALobj = new DALTABTotais(conexao);
            return DALobj.CarregaTotalGeral( data);
        }
    }
}