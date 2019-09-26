using DAL;
using Modelo;
using System;
using System.Data;

namespace BLL
{
    public class BLLVerba
    {
        private DALConexao conexao;
        public BLLVerba(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void IncluirVerba(ModeloVerba modelo)
        {

            DALVerba DALobj = new DALVerba(conexao);
            DALobj.IncluirVerba(modelo);
        }

        public void IncluirVerbaDep(ModeloVerba modelo)
        {

            DALVerba DALobj = new DALVerba(conexao);
            DALobj.IncluirVerbaDep(modelo);
        }
        public void AtualizaSaldo(ModeloVerba modelo)
        {

            DALVerba DALobj = new DALVerba(conexao);
            DALobj.AtualizaSaldo(modelo);
        }

        public void Deleta(ModeloVerba modelo)
        {

            DALVerba DALobj = new DALVerba(conexao);
            DALobj.AlterarDel(modelo);
        }
        public void Excluir(ModeloVerba modelo)
        {

            DALVerba DALobj = new DALVerba(conexao);
            DALobj.Excluir(modelo);
        }

        public DataTable Localizar(String valor)
        {
            DALVerba DALobj = new DALVerba(conexao);
            return DALobj.Localizar(valor);
        }

        public DataTable LocalizarDep(int valor)
        {
            DALVerba DALobj = new DALVerba(conexao);
            return DALobj.LocalizarDep(valor);
        }
        public ModeloVerba CarregaModeloVerba(int codigo)
        {
            DALVerba DALobj = new DALVerba(conexao);
            return DALobj.CarregaVerba(codigo);
        }

    }
}
