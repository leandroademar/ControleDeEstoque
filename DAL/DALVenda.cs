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
    public class DALVenda
    {
        private DALConexao conexao;
        public DALVenda(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloVenda modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObjetoTransacao;
            cmd.CommandText = "insert into venda (cli_cod,ven_status,ven_atendente,ven_nome,ven_total,ven_winthor) " +
            "values (@cli_cod,@ven_status,@ven_atendente,@ven_nome,@ven_total,@ven_winthor);select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@cli_cod", modelo.CliCod);
            cmd.Parameters.AddWithValue("@ven_total", modelo.VenTotal);
            cmd.Parameters.AddWithValue("@ven_nome", modelo.VenNome);
            cmd.Parameters.AddWithValue("@ven_status", modelo.VenStatus);
            cmd.Parameters.AddWithValue("@ven_atendente", modelo.VenAtend);
            cmd.Parameters.AddWithValue("@ven_winthor", modelo.VenWinthor);
            conexao.Conectar();
            modelo.VenCod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }
        public void IncluirW(ModeloVenda modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObjetoTransacao;
            cmd.CommandText = "insert into venda (cli_cod,ven_status,ven_atendente,ven_nome,ven_total,ven_dtpag,ven_caixa,ven_winthor,ven_cartao,ven_dinheiro,ven_totalgeral) " +
            "values (@cli_cod,@ven_status,@ven_atendente,@ven_nome,@ven_total,current_timestamp,@ven_caixa,@ven_winthor,@ven_cartao,@ven_dinheiro,@ven_totalgeral);select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@cli_cod", modelo.CliCod);
            cmd.Parameters.AddWithValue("@ven_total", modelo.VenTotal);
            cmd.Parameters.AddWithValue("@ven_nome", modelo.VenNome);
            cmd.Parameters.AddWithValue("@ven_status", modelo.VenStatus);
            cmd.Parameters.AddWithValue("@ven_atendente", modelo.VenAtend);
            cmd.Parameters.AddWithValue("@ven_winthor", modelo.VenWinthor);
            cmd.Parameters.AddWithValue("@ven_cartao", modelo.VenCartao);
            cmd.Parameters.AddWithValue("@ven_caixa", modelo.VenCaixa);
            cmd.Parameters.AddWithValue("@ven_dinheiro", modelo.VenDinheiro);
            cmd.Parameters.AddWithValue("@ven_totalgeral", modelo.VenTotalgeral);
            conexao.Conectar();
            modelo.VenCod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }
        public void Alterar(ModeloVenda modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObjetoTransacao;
            cmd.CommandText = "update venda set ven_dtpag=current_timestamp, ven_status=@ven_status," +
            " ven_caixa = @ven_caixa, ven_winthor = @ven_winthor,ven_cartao = " +
            "@ven_cartao,ven_dinheiro = @ven_dinheiro,ven_totalgeral = @ven_totalgeral "+
            " where ven_cod = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", modelo.VenCod);
            //para dados primitivos
            cmd.Parameters.AddWithValue("@ven_status", modelo.VenStatus);
            cmd.Parameters.AddWithValue("@for_cod", modelo.CliCod);
            cmd.Parameters.AddWithValue("@ven_caixa", modelo.VenCaixa);
            cmd.Parameters.AddWithValue("@ven_winthor", modelo.VenWinthor);
            cmd.Parameters.AddWithValue("@ven_cartao", modelo.VenCartao);
            cmd.Parameters.AddWithValue("@ven_dinheiro", modelo.VenDinheiro);
            cmd.Parameters.AddWithValue("@ven_totalgeral", modelo.VenTotalgeral);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public void AlterarS(ModeloVenda modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObjetoTransacao;
            cmd.CommandText = "update venda set equi_cod = @equi_cod, equi_nome = @equi_nome, ven_dtinisep = @ven_dtinisep,ven_valorsepara = @ven_valorsepara, ven_statussepara = 1 where ven_cod = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", modelo.VenCod);
            //para dados primitivos
            cmd.Parameters.AddWithValue("@equi_cod", modelo.CodEquipe);
            cmd.Parameters.AddWithValue("@equi_nome", modelo.NomeEquipe);
            cmd.Parameters.AddWithValue("@ven_valorsepara", modelo.ValorSepara);
            cmd.Parameters.AddWithValue("@ven_dtinisep", modelo.DataIni);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public void AlterarSf(ModeloVenda modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObjetoTransacao;
            cmd.CommandText = "update venda set  ven_dtfimsep = @ven_dtfimsep, ven_statussepara = 2 where ven_cod = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", modelo.VenCod);
            //para dados primitivos
            cmd.Parameters.AddWithValue("@ven_dtfimsep", modelo.DataFim);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObjetoTransacao;
            cmd.CommandText = "delete from compra where com_cod = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        //localizar pelo código do fornecedor
        public DataTable Localizar(int codigo)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select v.ven_cod, v.ven_nome,v.ven_total,v.ven_data, v.ven_atendente " +
            "from venda v inner join cliente c on c.cli_cod = v.cli_cod where ven_status = 'PENDENTE' and "+
                " v.cli_cod = " + codigo.ToString(), conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarP(String nome)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select v.ven_cod, v.ven_nome,(v.ven_total+v.ven_winthor) as ven_total,v.ven_data, v.ven_atendente " +
            "from venda v inner join cliente c on c.cli_cod = v.cli_cod where" +
                "  ven_data >= GETDATE() - 8 and ven_status = 'PENDENTE' and  v.ven_nome  like '%" + nome + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable Localizar()
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select v.ven_cod, v.ven_nome,(v.ven_total+v.ven_winthor) as ven_total,v.ven_data, v.ven_atendente " +
            "from venda v inner join cliente c on c.cli_cod = v.cli_cod where" +
                " ven_data >= GETDATE() - 8 AND ven_status = 'PENDENTE' ", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public DataTable LocalizarFatura()
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select v.ven_cod, v.ven_nome,v.ven_total,v.ven_data, v.ven_atendente " +
            "from venda v inner join cliente c on c.cli_cod = v.cli_cod where" +
                " ven_status <> 'PENDENTE' ", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public DataTable LocalizarFatura(String nome)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select v.ven_cod, v.ven_nome,v.ven_total,v.ven_data, v.ven_atendente " +
            "from venda v inner join cliente c on c.cli_cod = v.cli_cod where" +
                " ven_status <> 'PENDENTE' and  v.ven_nome  like '%" + nome + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public DataTable LocalizarSepara(String nome)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select v.ven_cod, v.ven_nome,v.ven_totalgeral,v.ven_dtpag, v.equi_nome " +
            "from venda v inner join cliente c on c.cli_cod = v.cli_cod where" +
                " ven_status <> 'PENDENTE' and v.ven_statussepara = 0 and  v.ven_nome  like '%" + nome + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public DataTable LocalizarSeparados(String nome)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select v.ven_cod, v.ven_nome,v.ven_totalgeral,v.ven_dtinisep,v.ven_dtfimsep, v.equi_nome " +
            "from venda v inner join cliente c on c.cli_cod = v.cli_cod where" +
                " v.ven_statussepara <> 0 and v.ven_dtfimsep is null and  v.ven_nome like '%" + nome + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public DataTable LocalizarFinalizados(String nome)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select v.ven_cod, v.ven_nome,v.ven_totalgeral,v.ven_dtinisep,v.ven_dtfimsep, v.equi_nome " +
            "from venda v inner join cliente c on c.cli_cod = v.cli_cod where" +
                " v.ven_statussepara <> 0 and convert(date,v.ven_data,121) = convert(date,current_timestamp,121) and v.ven_dtfimsep is not null and v.ven_nome  like '%" + nome + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable Localizar(DateTime dtinicial, DateTime dtfinal)
        {

            DataTable tabela = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "Select v.ven_cod,v.ven_data,v.ven_total,v.ven_status, c.cli_cod, v.ven_nome, v.ven_atendente " +
            "from venda v inner join cliente c on c.cli_cod = v.cli_cod where v.ven_data BETWEEN @dtinicial and @dtfinal";
            cmd.Parameters.Add("@dtinicial", System.Data.SqlDbType.DateTime);
            cmd.Parameters["@dtinicial"].Value = dtinicial;
            cmd.Parameters.Add("@dtfinal", System.Data.SqlDbType.DateTime);
            cmd.Parameters["@dtfinal"].Value = dtfinal;
            //conexao.Conectar();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabela);
            //conexao.Desconectar();
            return tabela;
        }

        public DataTable LocalizarSeparadas(string dtinicial, string dtfinal)
        {

            DataTable tabela = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select *  from RELSEPARADAS WHERE ven_dtfimsep BETWEEN @dtinicial and @dtfinal";
            cmd.Parameters.AddWithValue("@dtinicial", dtinicial);
            cmd.Parameters.AddWithValue("@dtfinal", dtfinal);

            // cmd.Parameters.Add("@dtinicial", System.Data.SqlDbType.DateTime);
            // cmd.Parameters["@dtinicial"].Value = dtinicial;
            // cmd.Parameters.Add("@dtfinal", System.Data.SqlDbType.DateTime);
            // cmd.Parameters["@dtfinal"].Value = dtfinal;
            //conexao.Conectar();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabela);
            //conexao.Desconectar();
            return tabela;
        }

        public ModeloVenda CarregaModeloVenda(int codigo)
        {
            ModeloVenda modelo = new ModeloVenda();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from venda where ven_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {

                registro.Read();
                modelo.VenCod = Convert.ToInt32(registro["ven_cod"]);
                modelo.VenData = Convert.ToDateTime(registro["ven_data"]);
                modelo.VenTotal = Convert.ToDouble(registro["ven_total"]);
                modelo.VenStatus = Convert.ToString(registro["ven_status"]);
                modelo.CliCod = Convert.ToInt32(registro["cli_cod"]);
                modelo.VenAtend = Convert.ToString(registro["ven_atendente"]);
                modelo.VenNome = Convert.ToString(registro["ven_nome"]);
                modelo.VenCartao = Convert.ToDouble(registro["ven_cartao"]);
                modelo.VenWinthor = Convert.ToDouble(registro["ven_winthor"]);


            }
            conexao.Desconectar();
            registro.Close();
            return modelo;
        }

        public ModeloVenda CarregaModeloFatura(int codigo)
        {
                ModeloVenda modelof = new ModeloVenda();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "select ven_cod,ven_data,ven_total,ven_status,cli_cod,ven_atendente,ven_nome," +
                "isnull(equi_cod,'')equi_cod,isnull(equi_nome,'')equi_nome,isnull(ven_dtinisep,' ')ven_dtinisep,isnull(ven_dtfimsep,' ')ven_dtfimsep,"+
                "isnull(ven_totalgeral,0)ven_totalgeral,ven_valorsepara,ven_statussepara from venda where ven_cod = @codigo";
                cmd.Parameters.AddWithValue("@codigo", codigo);
                conexao.Conectar();
                SqlDataReader registro = cmd.ExecuteReader();
                if (registro.HasRows)
                {

                    registro.Read();
                    modelof.VenCod = Convert.ToInt32(registro["ven_cod"]);
                    modelof.VenData = Convert.ToDateTime(registro["ven_data"]);
                    modelof.VenTotal = Convert.ToDouble(registro["ven_total"]);
                    modelof.VenTotalgeral = Convert.ToDouble(registro["ven_totalgeral"]);
                    modelof.VenStatus = Convert.ToString(registro["ven_status"]);
                    modelof.CliCod = Convert.ToInt32(registro["cli_cod"]);
                    modelof.VenAtend = Convert.ToString(registro["ven_atendente"]);
                    modelof.VenNome = Convert.ToString(registro["ven_nome"]);
                    modelof.CodEquipe = Convert.ToInt32(registro["equi_cod"]);
                    modelof.NomeEquipe = Convert.ToString(registro["equi_nome"]);
                    modelof.DataIni = Convert.ToDateTime(registro["ven_dtinisep"]);
                    modelof.DataFim = Convert.ToDateTime(registro["ven_dtfimsep"]);
                    modelof.ValorSepara = Convert.ToDouble(registro["ven_valorsepara"]);
                    modelof.StatusSepara = Convert.ToInt32(registro["ven_statussepara"]);

            }   

            conexao.Desconectar();
            registro.Close();
            return modelof;
        }
        
    }
}
