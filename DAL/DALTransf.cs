using System;
using System.Data;
using System.Data.SqlClient;
using Modelo;

namespace DAL
{
    public class DALTransf
    {
        private DALConexao conexao;
        private string stringDeConexao;

        public DALTransf(DALConexao cx)
        {
            this.conexao = cx;
        }

        public DALTransf(string stringDeConexao)
        {
            this.stringDeConexao = stringDeConexao;
        }

        public void Incluir(ModeloTransf modelo)
        {
            String comando1 = "";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            comando1 = comando1 + "INSERT INTO TABTRANSF  (NOMEBANCO,NOMECLIENTE,DATADEP,HORA,USUARIO,VALOR,HORAAUTORIZACAO) " + "\n";
            comando1 = comando1 + "VALUES (@NOMEBANCO,@NOMECLIENTE,@DATADEP,@HORA,@USUARIO,@VALOR,GETDATE())";
            cmd.CommandText = comando1;
            cmd.Parameters.AddWithValue("@NOMEBANCO", modelo.NomeBanco);
            cmd.Parameters.AddWithValue("@NOMECLIENTE", modelo.NomeCliente);
            cmd.Parameters.AddWithValue("@DATADEP", modelo.DtTransf);
            cmd.Parameters.AddWithValue("@HORA", modelo.Hora);
            cmd.Parameters.AddWithValue("@USUARIO", modelo.Usuario);
            cmd.Parameters.AddWithValue("@VALOR", modelo.Valor);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public void Alterar(ModeloTransf modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            String comando2 = "";
            comando2 = comando2 + "UPDATE TABTRANSF SET " + "\n";
            comando2 = comando2 + "HORALIBERACAO = GETDATE(), " + "\n";
            comando2 = comando2 + "NUMCAIXA = @NUMCAIXA, " + "\n";
            comando2 = comando2 + "TURNO = @TURNO, " + "\n";
            comando2 = comando2 + "CODFUNC = @CODFUNC," + "\n";
            comando2 = comando2 + "NOMECAIXA = @NOMECAIXA";
            cmd.Parameters.AddWithValue("@NUMCAIXA", modelo.NumCaixa);
            cmd.Parameters.AddWithValue("@NOMECAIXA", modelo.Usuario);
            cmd.Parameters.AddWithValue("@TURNO", modelo.Turno);
            cmd.Parameters.AddWithValue("@CODFUNC", modelo.CodFunc);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public DataTable LocalizarCaixas(int turno, int seg, int dia, string datamovimento)
        {
            String comando2 = "";
            comando2 = comando2 + "SELECT [NUMTRANS] " + "\n";
            comando2 = comando2 + "      ,[VLROUTROS] " + "\n";
            comando2 = comando2 + "  FROM [TABFECHA] " + "\n";
            comando2 = comando2 + "  WHERE DTCAIXA = '" + datamovimento + "' " + "\n";
            if (seg != 0)
            {
                comando2 = comando2 + "  AND NUMCAIXA IN ('10','11','12') " + "\n";

            }
            else
            {
                comando2 = comando2 + "  AND NUMCAIXA NOT IN ('10','11','12') " + "\n";

            }
            if (dia == 0)
            {
                comando2 = comando2 + "  AND TURNO = " + turno;
            }

            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter
            (comando2, conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
    }
}
