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
            if (!String.IsNullOrWhiteSpace(modelo.NomeCaixa.ToString()) && modelo.NumCaixa != 0)
            {
                DALTABCaixa DALobj = new DALTABCaixa(conexao);
                DALobj.Incluir(modelo);
            }
            
        }
        public void IncluirTBC(ModeloTABCaixa modelo)
        {

            DALTABCaixa DALobj = new DALTABCaixa(conexao);
            DALobj.InsertTBC(modelo);
           

        }
        public void Alterar(ModeloTABCaixa modelo)
        {
            DALTABCaixa DALobj = new DALTABCaixa(conexao);
            DALobj.Alterar(modelo);
        }

        public DataTable LocalizarCaixas(int turno,int seg,int dia, string dtmovimento)
        {
            DALTABCaixa DALobj = new DALTABCaixa(conexao);
            return DALobj.LocalizarCaixas(turno,seg,dia, dtmovimento);
        }
        public DataTable Buscar(int seg, string dtmovimento,string nome)
        {
            DALTABCaixa DALobj = new DALTABCaixa(conexao);
            return DALobj.Buscar(seg,  dtmovimento,nome);
        }
    }
}
