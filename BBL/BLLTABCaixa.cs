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
    public class BLLTABCaixa
    {
        private DALConexao conexao;
        public BLLTABCaixa(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloTABCaixa modelo)
        {

            DALTABCaixa DALobj = new DALTABCaixa(conexao);
            DALobj.Incluir(modelo);
        }

        public DataTable LocalizarCaixas(int turno,int seg,int dia, string dtmovimento)
        {
            DALTABCaixa DALobj = new DALTABCaixa(conexao);
            return DALobj.LocalizarCaixas(turno,seg,dia, dtmovimento);
        }
        public DataTable Buscar(int seg, string dtmovimento)
        {
            DALTABCaixa DALobj = new DALTABCaixa(conexao);
            return DALobj.Buscar(seg,  dtmovimento);
        }
    }
}
