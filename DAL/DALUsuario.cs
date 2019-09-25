using Modelo;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DALUsuario
    {
        private DALConexao conexao;
        public DALUsuario(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloUsuario modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into usuarios(usu_nome,usu_senha,per_cod) values (@nome,@senha,@perfil); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@nome", modelo.NomeUser);
            cmd.Parameters.AddWithValue("@senha", modelo.SenhaUser);
            cmd.Parameters.AddWithValue("@perfil", modelo.PerfilUser);
            conexao.Conectar();
            modelo.CodUser = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }
        public void Alterar(ModeloUsuario modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update usuarios set usu_nome = @nome, usu_senha = @senha, per_cod = @perfil where usu_cod = @codigo;";
            cmd.Parameters.AddWithValue("@nome", modelo.NomeUser);
            cmd.Parameters.AddWithValue("@codigo", modelo.CodUser);
            cmd.Parameters.AddWithValue("@senha", modelo.SenhaUser);
            cmd.Parameters.AddWithValue("@perfil", modelo.PerfilUser);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }


        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from usuarios where usu_nome like '%" +
                valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloUsuario CarregaModeloUsuario(string nome, string senha)
        {
            ModeloUsuario modelo = new ModeloUsuario();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from usuarios where usu_nome = @nome and usu_senha = @senha;";
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@senha", senha);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.CodUser = Convert.ToInt32(registro["usu_cod"]);
                modelo.NomeUser = Convert.ToString(registro["usu_nome"]);
                modelo.SenhaUser = Convert.ToString(registro["usu_senha"]);
                modelo.PerfilUser = Convert.ToInt32(registro["per_cod"]);
                modelo.PerfilTed = Convert.ToInt32(registro["per_ted"]);
                modelo.Matricula = Convert.ToInt32(registro["usu_caixa"]);
                modelo.NomeWint = Convert.ToString(registro["cax_nome"]);

            }
            conexao.Desconectar();
            return modelo;
        }
        public ModeloUsuario CarregaModeloUsuarioC(int codigo)
        {
            ModeloUsuario modelo = new ModeloUsuario();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from usuarios where usu_cod = @codigo ;";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.CodUser = Convert.ToInt32(registro["usu_cod"]);
                modelo.NomeUser = Convert.ToString(registro["usu_nome"]);
                modelo.SenhaUser = Convert.ToString(registro["usu_senha"]);
                modelo.PerfilUser = Convert.ToInt32(registro["per_cod"]);
                modelo.PerfilTed = Convert.ToInt32(registro["per_ted"]);

            }
            conexao.Desconectar();
            return modelo;
        }
    }
}
