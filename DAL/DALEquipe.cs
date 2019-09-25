using System;
using Modelo;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DALEquipe
    {
        private DALConexao conexao;
        public DALEquipe(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloEquipe modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into equipe(equi_nome) values (@nome); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@nome", modelo.NomeEquipe);
            conexao.Conectar();
            modelo.CodEquipe = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }
        public void Alterar(ModeloEquipe modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update equipe set equi_nome = @nome where equi_cod = @codigo;";
            cmd.Parameters.AddWithValue("@nome", modelo.NomeEquipe);
            cmd.Parameters.AddWithValue("@codigo", modelo.CodEquipe);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from equipe where equi_cod = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from equipe where equi_nome like '%" +
                valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloEquipe CarregaModeloEquipe(int codigo)
        {
            ModeloEquipe modelo = new ModeloEquipe();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from equipe where equi_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.CodEquipe = Convert.ToInt32(registro["equi_cod"]);
                modelo.NomeEquipe = Convert.ToString(registro["equi_nome"]);
            }
            conexao.Desconectar();
            return modelo;
        }
    }
}
