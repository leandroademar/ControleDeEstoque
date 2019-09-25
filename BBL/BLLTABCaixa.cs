using DAL;
using Modelo;
using System;
using System.Data;
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
        public void Deleta(ModeloTABCaixa modelo)
        {
            DALTABCaixa DALobj = new DALTABCaixa(conexao);
            DALobj.DelCaixa(modelo);
        }
        public void DeletaT(ModeloTABCaixa modelo)
        {
            DALTABCaixa DALobj = new DALTABCaixa(conexao);
            DALobj.DelCaixaT(modelo);
        }
        public void AlterarTBC(ModeloTABCaixa modelo)
        {
            DALTABCaixa DALobj = new DALTABCaixa(conexao);
            DALobj.AlterarTBC(modelo);
        }

        public DataTable LocalizarCaixas(int seg, string dtmovimento)
        {
            DALTABCaixa DALobj = new DALTABCaixa(conexao);
            return DALobj.LocalizarCaixas(seg, dtmovimento);
        }
        public DataTable Buscar(int seg, string dtmovimento,string nome)
        {
            DALTABCaixa DALobj = new DALTABCaixa(conexao);
            return DALobj.Buscar(seg,  dtmovimento,nome);
        }
    }
}
