using DAL;
using BLL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BLL
{
    public class BLLEquipe
    {

        private DALConexao conexao;
        public BLLEquipe(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloEquipe modelo)
        {
            if (modelo.NomeEquipe.Trim().Length == 0)
            {
                throw new Exception("O nome da equipe é obrigatório");
            }
            //modelo.NomeEquipe = modelo.NomeEquipe.ToUpper();

            DALEquipe DALobj = new DALEquipe(conexao);
            DALobj.Incluir(modelo);
        }
        public void Alterar(ModeloEquipe modelo)
        {
            if (modelo.CodEquipe <= 0)
            {
                throw new Exception("O código da equipe é obrigatório");
            }
            if (modelo.NomeEquipe.Trim().Length == 0)
            {
                throw new Exception("O nome da equipe é obrigatório");
            }
            //modelo.NomeEquipe = modelo.NomeEquipe.ToUpper();

            DALEquipe DALobj = new DALEquipe(conexao);
            DALobj.Alterar(modelo);
        }
        public void Excluir(int codigo)
        {
            DALEquipe DALobj = new DALEquipe(conexao);
            DALobj.Excluir(codigo);
        }
        public DataTable Localizar(String valor)
        {
            DALEquipe DALobj = new DALEquipe(conexao);
            return DALobj.Localizar(valor);
        }
        public ModeloEquipe CarregaModeloEquipe(int codigo)
        {
            DALEquipe DALobj = new DALEquipe(conexao);
            return DALobj.CarregaModeloEquipe(codigo);
        }
    }
}
