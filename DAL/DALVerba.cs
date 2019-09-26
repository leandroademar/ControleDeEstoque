using Modelo;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DALVerba
    {
        private DALConexao conexao;
        public DALVerba(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void IncluirVerba(ModeloVerba modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            String cSql = "";
            cSql = cSql + "INSERT INTO TABVERBA( " + "\n";
            cSql = cSql + "      CODFORNEC " + "\n";
            cSql = cSql + "      ,NOMEFORNECEDOR " + "\n";
            cSql = cSql + "      ,OBS " + "\n";
            cSql = cSql + "      ,VALORMERCADO " + "\n";
            cSql = cSql + "      ,VALORDESCONTO " + "\n";
            cSql = cSql + "      ,QUANTIDADE " + "\n";
            cSql = cSql + "      ,DESCRICAOPROD " + "\n";
            cSql = cSql + "      ,DATA " + "\n";
            cSql = cSql + "      ,SALDO) " + "\n";
            cSql = cSql + "  VALUES (@CODFORNEC " + "\n";
            cSql = cSql + "      ,@NOMEFORNECEDOR " + "\n";
            cSql = cSql + "      ,@OBS " + "\n";
            cSql = cSql + "      ,@VALORMERCADO " + "\n";
            cSql = cSql + "      ,@VALORDESCONTO " + "\n";
            cSql = cSql + "      ,@QUANTIDADE " + "\n";
            cSql = cSql + "      ,@DESCRICAOPROD " + "\n";
            cSql = cSql + "      ,CURRENT_TIMESTAMP " + "\n";
            cSql = cSql + "      ,@SALDO)";
            cmd.CommandText = cSql;
            cmd.Parameters.AddWithValue("@CODFORNEC", modelo.CodFornec);
            cmd.Parameters.AddWithValue("@NOMEFORNECEDOR", modelo.NomeFornec);
            cmd.Parameters.AddWithValue("@OBS", modelo.Obs);
            cmd.Parameters.AddWithValue("@VALORMERCADO", modelo.ValorMercado);
            cmd.Parameters.AddWithValue("@VALORDESCONTO", modelo.ValorDesconto);
            cmd.Parameters.AddWithValue("@QUANTIDADE", modelo.Quantidade);
            cmd.Parameters.AddWithValue("@DESCRICAOPROD", modelo.DescProd);
            cmd.Parameters.AddWithValue("@SALDO", modelo.ValorDesconto);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void IncluirVerbaDep(ModeloVerba modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            String cSql1 = "";
            cSql1 = cSql1 + "INSERT INTO TABDETVERBA ([IDVERBA],[DATA],[DATADEP],[VALOR]) " + "\n";
            cSql1 = cSql1 + "VALUES (@IDVERBA,CURRENT_TIMESTAMP,@DATADEP,@VALOR)";
            cmd.CommandText = cSql1;
            cmd.Parameters.AddWithValue("@IDVERBA", modelo.IdTran);
            cmd.Parameters.AddWithValue("@VALOR", modelo.ValorMercado);
            cmd.Parameters.AddWithValue("@DATADEP", modelo.DataDep);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void AtualizaSaldo(ModeloVerba modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            String cSql2 = "";
            cSql2 = cSql2 + " UPDATE TABVERBA SET SALDO = VALORDESCONTO - (SELECT SUM(VALOR) FROM TABDETVERBA WHERE IDVERBA = @IDTRAN)" + "\n";
            cSql2 = cSql2 + " WHERE IDTRAN = @IDTRAN";
            cmd.CommandText = cSql2;
            cmd.Parameters.AddWithValue("@IDTRAN", modelo.IdTran);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(" SELECT * FROM TABVERBA WHERE NOMEFORNECEDOR LIKE '%"+valor+"%' ", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloVerba CarregaVerba(int codigo)
        {
            ModeloVerba modelo = new ModeloVerba();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            String cSql2 = "";
            cSql2 = cSql2 + "SELECT IDTRAN " + "\n";
            cSql2 = cSql2 + "      ,CODFORNEC " + "\n";
            cSql2 = cSql2 + "      ,NOMEFORNECEDOR " + "\n";
            cSql2 = cSql2 + "      ,OBS " + "\n";
            cSql2 = cSql2 + "      ,VALORMERCADO " + "\n";
            cSql2 = cSql2 + "      ,VALORDESCONTO " + "\n";
            cSql2 = cSql2 + "      ,QUANTIDADE " + "\n";
            cSql2 = cSql2 + "      ,CODPROD " + "\n";
            cSql2 = cSql2 + "      ,DESCRICAOPROD " + "\n";
            cSql2 = cSql2 + "      ,DATA " + "\n";
            cSql2 = cSql2 + "      ,DATAQUITACAO " + "\n";
            cSql2 = cSql2 + "      ,SALDO " + "\n";
            cSql2 = cSql2 + "  FROM TABVERBA " + "\n";
            cSql2 = cSql2 + "WHERE IDTRAN = @CODIGO";
            cmd.CommandText = cSql2;
            cmd.Parameters.AddWithValue("@CODIGO", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.IdTran = Convert.ToInt32(registro["IDTRAN"]);
                modelo.CodFornec = Convert.ToInt32(registro["CODFORNEC"]);
                modelo.NomeFornec = Convert.ToString(registro["NOMEFORNECEDOR"]);
                modelo.Obs = Convert.ToString(registro["OBS"]);
                modelo.ValorMercado = Convert.ToDouble(registro["VALORMERCADO"]);
                modelo.ValorDesconto = Convert.ToDouble(registro["VALORDESCONTO"]);
                modelo.Saldo = Convert.ToDouble(registro["SALDO"]);
                modelo.Quantidade = Convert.ToDouble(registro["QUANTIDADE"]);
                modelo.DescProd = Convert.ToString(registro["DESCRICAOPROD"]);
            }
            conexao.Desconectar();
            registro.Close();
            return modelo;
        }

    }
}
