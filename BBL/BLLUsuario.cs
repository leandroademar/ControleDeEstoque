using System;
using DAL;
using Modelo;
using System.Data;

namespace BLL
{
    public class BLLUsuario
    {
        private DALConexao conexao;
        public BLLUsuario(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloUsuario modelo)
        {
            if (modelo.NomeUser.Trim().Length == 0)
            {
                throw new Exception("O nome do usuario é obrigatório");
            }
            if (modelo.SenhaUser.Trim().Length == 0)
            {
                throw new Exception("A senha do usuario é obrigatório");
            }

            DALUsuario DALobj = new DALUsuario(conexao);
            DALobj.Incluir(modelo);
        }
        public void Alterar (ModeloUsuario modelo)
        {
            DALUsuario DALobj = new DALUsuario(conexao);
            DALobj.Alterar(modelo);
        }
        public DataTable Localizar(String valor)
        {
            DALUsuario DALobj = new DALUsuario(conexao);
            return DALobj.Localizar(valor);
        }
        public ModeloUsuario CarregaModeloUsuario(string nome, string senha)
        {
            DALUsuario DALobj = new DALUsuario(conexao);
            return DALobj.CarregaModeloUsuario(nome,senha);
        }
        public ModeloUsuario CarregaModeloUsuarioC(int codigo)
        {
            DALUsuario DALobj = new DALUsuario(conexao);
            return DALobj.CarregaModeloUsuarioC(codigo);
        }
    }
}
