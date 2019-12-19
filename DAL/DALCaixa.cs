using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALCaixa
    {
        private DALConexao conexao;
        public DALCaixa(DALConexao cx)
        {
            this.conexao = cx;
        }
        
        public void Incluir(ModeloCaixa modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = " insert into caixa(cax_id, cax_turno, cax_nome, cax_venda, cax_dinheiro, cax_pedido, cax_winthor,"+
                                " cax_cartao, cax_total) values (@id,@turno,@nome,@venda,@dinheiro,@pedido,@winthor,@cartao,@total) ";
            cmd.Parameters.AddWithValue("@id",modelo.CaxId);
            cmd.Parameters.AddWithValue("@venda", modelo.CaxVenda);
            cmd.Parameters.AddWithValue("@turno", modelo.CaxTurno);
            cmd.Parameters.AddWithValue("@nome", modelo.CaxNome);
            cmd.Parameters.AddWithValue("@dinheiro", modelo.CaxDinheiro);
            cmd.Parameters.AddWithValue("@pedido", modelo.CaxPedido);
            cmd.Parameters.AddWithValue("@winthor", modelo.CaxWinthor);
            cmd.Parameters.AddWithValue("@cartao", modelo.CaxCartao);
            cmd.Parameters.AddWithValue("@total", modelo.CaxTotal);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select cax_nome,cax_id,sum(cax_pedido)pedido,sum(cax_winthor)winthor,sum(cax_dinheiro)dinheiro,sum(cax_cartao)cartao,sum(cax_total)total," +
                                              "(select caxs_abertura from caixastatus where caxs_cod = cax_id)hora_abertura," +
                                            " (select caxs_fechamento from caixastatus where caxs_cod = cax_id)hora_fechamento from caixa where  cax_id = " +
                                            valor + " group by cax_nome, cax_id ", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public DataTable LocalizarCaixa(String valor, string dtinicial)
        {
            DataTable tabela = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = ("select cax_nome,cax_id,sum(cax_pedido)pedido,sum(cax_winthor)winthor,sum(cax_dinheiro)dinheiro,sum(cax_cartao)cartao,sum(cax_total)total," +
                                              "(select caxs_abertura from caixastatus where caxs_cod = cax_id)hora_abertura," +
                                            " (select caxs_fechamento from caixastatus where caxs_cod = cax_id)hora_fechamento from caixa where  cax_nome " +
                                            "like '%"+valor+ "%' and (select convert(date,caxs_abertura,121) from caixastatus where caxs_cod = cax_id) " +
                                            " = convert(date,'" + dtinicial + "',121) and (select caxs_fechamento from caixastatus where caxs_cod = cax_id) " +
                                            "is null group by cax_nome, cax_id ");
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabela);
            return tabela;
        }
        public DataTable LocalizarCaixaF(String valor, string dtinicial)
        {
            DataTable tabela = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = ("select cax_nome,cax_id,sum(cax_pedido)pedido,sum(cax_winthor)winthor,sum(cax_dinheiro)dinheiro,sum(cax_cartao)cartao,sum(cax_total)total," +
                                              "(select caxs_abertura from caixastatus where caxs_cod = cax_id)hora_abertura," +
                                            " (select caxs_fechamento from caixastatus where caxs_cod = cax_id)hora_fechamento from caixa where  cax_nome " +
                                            "like '%" + valor + "%' and (select convert(date,caxs_abertura,121) from caixastatus where caxs_cod = cax_id) " +
                                            " = convert(date,'"+dtinicial+"',121) and (select caxs_fechamento from caixastatus where caxs_cod = cax_id) " +
                                            "is not null and (select caxs_status from caixastatus where caxs_cod = cax_id) <> 9  group by cax_nome, cax_id ");
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabela);
            return tabela;
        }
        public ModeloCaixa CarregaModeloCaixa(int codigo)
        {
            ModeloCaixa modelo = new ModeloCaixa();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select cax_nome,cax_id,sum(cax_pedido)pedido,sum(cax_winthor)winthor,sum(cax_dinheiro)dinheiro,sum(cax_cartao)cartao,sum(cax_total)total," +
                                              "(select caxs_abertura from caixastatus where caxs_cod = cax_id)hora_abertura " +
                                            "  from caixa where  cax_id = @codigo group by cax_nome, cax_id ";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.CaxNome = Convert.ToString(registro["cax_nome"]);
                modelo.CaxId = Convert.ToInt32(registro["cax_id"]);
                modelo.CaxPedido = Convert.ToDouble(registro["pedido"]);
                modelo.CaxWinthor = Convert.ToDouble(registro["winthor"]);
                modelo.CaxDinheiro = Convert.ToDouble(registro["dinheiro"]);
                modelo.CaxCartao = Convert.ToDouble(registro["cartao"]);
                modelo.CaxTotal = Convert.ToDouble(registro["total"]);
                modelo.CaxAbertura = Convert.ToDateTime(registro["hora_abertura"]);
            }
            conexao.Desconectar();
            registro.Close();
            return modelo;
        }
        public ModeloCaixa CarregaTesouraria()
        {
            ModeloCaixa modelo = new ModeloCaixa();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select cax_nome,cax_id,sum(cax_pedido)pedido,sum(cax_winthor)winthor,sum(cax_dinheiro)dinheiro,sum(cax_cartao)cartao,sum(cax_total)total," +
                                              "(select caxs_abertura from caixastatus where caxs_cod = cax_id)hora_abertura " +
                                            "  from caixa group by cax_nome, cax_id ";
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.CaxNome = Convert.ToString(registro["cax_nome"]);
                modelo.CaxId = Convert.ToInt32(registro["cax_id"]);
                modelo.CaxPedido = Convert.ToDouble(registro["pedido"]);
                modelo.CaxWinthor = Convert.ToDouble(registro["winthor"]);
                modelo.CaxDinheiro = Convert.ToDouble(registro["dinheiro"]);
                modelo.CaxCartao = Convert.ToDouble(registro["cartao"]);
                modelo.CaxTotal = Convert.ToDouble(registro["total"]);
                modelo.CaxAbertura = Convert.ToDateTime(registro["hora_abertura"]);
            }
            conexao.Desconectar();
            registro.Close();
            return modelo;

        }
    }
}
