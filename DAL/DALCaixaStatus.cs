using Modelo;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DALCaixaStatus
    {
        private DALConexao conexao;
        public DALCaixaStatus(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Abrir(ModeloCaixaStatus modelo)
        {
           
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "insert into caixastatus (caxs_turno,caxs_nome,caxs_abertura,caxs_status) values (@turno," +
                                   "@nome,@abertura,@status); select @@IDENTITY;";
                cmd.Parameters.AddWithValue("@turno", modelo.CaxsTurno);
                cmd.Parameters.AddWithValue("@nome", modelo.CaxsNome);
                cmd.Parameters.AddWithValue("@abertura", modelo.CaxsAbertura);
                cmd.Parameters.AddWithValue("@status", modelo.CaxsStatus);
                conexao.Conectar();
                modelo.CaxsCod = Convert.ToInt32(cmd.ExecuteScalar());
                conexao.Desconectar();

        }
        public void Fechar(ModeloCaixaStatus modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update caixastatus set caxs_fechamento = @fechamento, caxs_status = @status where caxs_cod = @codigo ";
            cmd.Parameters.AddWithValue("@fechamento", modelo.CaxsFechamento);
            cmd.Parameters.AddWithValue("@status", modelo.CaxsStatus);
            cmd.Parameters.AddWithValue("@codigo", modelo.CaxsCod);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public void FecharC(ModeloCaixaStatus modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update caixastatus set  caxs_status = 9 where caxs_cod = @codigo ";
            cmd.Parameters.AddWithValue("@codigo", modelo.CaxsCod);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select cax_nome,cax_id,sum(cax_pedido)pedido,sum(cax_winthor)winthor,sum(cax_dinheiro)dinheiro,sum(cax_cartao)cartao,sum(cax_total)total,"+
                                                    "(select caxs_abertura from caixastatus where caxs_cod = cax_id)hora_abertura,"+
                                                  " (select caxs_fechamento from caixastatus where caxs_cod = cax_id)hora_fechamento from caixa where  cax_id = " +
                                                  valor + " group by cax_nome, cax_id ", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloCaixaStatus CarregaModeloCaisaStatus(int codigo)
        {
            ModeloCaixaStatus modelo = new ModeloCaixaStatus();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from caixastatus where caxs_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.CaxsCod = Convert.ToInt32(registro["caxs_cod"]);
                modelo.CaxsTurno = Convert.ToInt32(registro["caxs_cod"]);
                modelo.CaxsNome = Convert.ToString(registro["caxs_nome"]);
            }
            conexao.Desconectar();
            return modelo;
        }
    }
}
