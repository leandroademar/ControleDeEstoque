using Modelo;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DALTABCaixa
    {
        private DALConexao conexao;
        public DALTABCaixa(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloTABCaixa modelo)
        {
            String comando1 = "";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            comando1 = comando1 + "INSERT INTO TABFECHA ( " + "\n";
            comando1 = comando1 + "NUMCAIXA, " + "\n";
            comando1 = comando1 + "CODCAIXA, " + "\n";
            comando1 = comando1 + "NOMECAIXA, " + "\n";
            comando1 = comando1 + "DTCAIXA, " + "\n";
            comando1 = comando1 + "TURNO " + "\n";
            comando1 = comando1 + ") " + "\n";
            comando1 = comando1 + "VALUES( " + "\n";
            comando1 = comando1 + "@NUMCAIXA, " + "\n";
            comando1 = comando1 + "@CODCAIXA, " + "\n";
            comando1 = comando1 + "@NOMECAIXA, " + "\n";
            comando1 = comando1 + "@DTCAIXA, " + "\n";
            comando1 = comando1 + "@TURNO " + "\n";
            comando1 = comando1 + ");";
            cmd.CommandText = comando1;
            cmd.Parameters.AddWithValue("@NUMCAIXA", modelo.NumCaixa);
            cmd.Parameters.AddWithValue("@CODCAIXA", modelo.CodCaixa);
            cmd.Parameters.AddWithValue("@NOMECAIXA", modelo.NomeCaixa);
            cmd.Parameters.AddWithValue("@DTCAIXA", modelo.DtCaixa);
            cmd.Parameters.AddWithValue("@TURNO", modelo.Turno);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable LocalizarCaixas(int seg, string datamovimento)
        {
            String comando2 = "";
            comando2 = comando2 + "SELECT [NUMTRANS] " + "\n";
            comando2 = comando2 + "      ,[NUMCAIXA] " + "\n";
            comando2 = comando2 + "      ,[CODCAIXA] " + "\n";
            comando2 = comando2 + "      ,[NOMECAIXA] " + "\n";
            comando2 = comando2 + "      ,[DTCAIXA] " + "\n";
            comando2 = comando2 + "      ,[VLRDIN] " + "\n";
            comando2 = comando2 + "      ,[VLRDEP] " + "\n";
            comando2 = comando2 + "      ,[VLRDEB] " + "\n";
            comando2 = comando2 + "      ,[VLRTRAN] " + "\n";
            comando2 = comando2 + "      ,[VLRCHEQ] " + "\n";
            comando2 = comando2 + "      ,[VLRVEND] " + "\n";
            comando2 = comando2 + "      ,[VLRCRED] " + "\n";
            comando2 = comando2 + "      ,[TURNO] " + "\n";
            comando2 = comando2 + "      ,[VLRCCTKS] " + "\n";
            comando2 = comando2 + "      ,[VLRCDTKS] " + "\n";
            comando2 = comando2 + "      ,[VLRMOEDA] " + "\n";
            comando2 = comando2 + "      ,[VLROUTROS] " + "\n";
            comando2 = comando2 + "  FROM [TABFECHA] " + "\n";
            comando2 = comando2 + "  WHERE DTCAIXA = '"+datamovimento+"' " + "\n";
            if(seg != 0)
            {
                comando2 = comando2 + "  AND NUMCAIXA IN ('10','11','12') " + "\n";

            }
            else
            {
                comando2 = comando2 + "  AND NUMCAIXA NOT IN ('10','11','12') " + "\n";

            }
            

            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter
            (comando2, conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public  DataTable Buscar(int seg,string dtmovimento,string nome)
        {
            String comando3 = "  ";
            comando3 = comando3 + "SELECT NUMCHECKOUT " + "\n";
            comando3 = comando3 + "      , CODFUNCCHECKOUT " + "\n";
            comando3 = comando3 + "      , NOME " + "\n";
            comando3 = comando3 + "  FROM  TABCAIXA " + "\n";
            comando3 = comando3 + "  WHERE DTCAIXA = '"+dtmovimento+"' AND TURNO IS NULL " + "\n";
            if(seg != 0)
            {
                comando3 = comando3 + "AND NUMCHECKOUT IN (10,11,12)";

            }
            else
            {
                comando3 = comando3 + "AND NUMCHECKOUT NOT IN (10,11,12)";

            }
            comando3 = comando3 + " AND NOME LIKE '%"+nome+"%'";

            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter
            (comando3, conexao.StringConexao);
            da.Fill(tabela);
            return tabela;

        }
        public void InsertTBC(ModeloTABCaixa modelo)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "  EXEC SINC_TABAJARA; "; 
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
            
            
        }
       
        public void Alterar (ModeloTABCaixa modelo)
        {
         
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            String comando3 = " UPDATE  TABFECHA SET TURNO = @TURNO, VLRDIN = @VLRDIN, VLRDEP = @VLRDEP, VLRDEB = @VLRDEB, VLRTRAN = @VLRTRAN, VLRCHEQ = @VLRCHEQ, VLRVEND = @VLRVEND, VLRCRED = @VLRCRED, " + "\n";
            comando3 = comando3 + " VLRCCTKS = @VLRCCTKS, VLRCDTKS = @VLRCDTKS, VLRMOEDA = @VLRMOEDA, VLROUTROS = @VLROUTROS  WHERE NUMTRANS = @NUMTRANS;";
            cmd.CommandText = comando3;
            cmd.Parameters.AddWithValue("@TURNO", modelo.Turno);
            cmd.Parameters.AddWithValue("@NUMTRANS", modelo.NumTrans);
            cmd.Parameters.AddWithValue("@VLRDIN", modelo.VlrDin);
            cmd.Parameters.AddWithValue("@VLRDEP", modelo.VlrDep);
            cmd.Parameters.AddWithValue("@VLRDEB", modelo.VlrDeb);
            cmd.Parameters.AddWithValue("@VLRTRAN", modelo.VlrTran);
            cmd.Parameters.AddWithValue("@VLRCHEQ", modelo.VlrCheq);
            cmd.Parameters.AddWithValue("@VLRCRED", modelo.VlrCred);
            cmd.Parameters.AddWithValue("@VLRVEND", modelo.VlrVend);
            cmd.Parameters.AddWithValue("@VLRCCTKS", modelo.VlrCctks);
            cmd.Parameters.AddWithValue("@VLRCDTKS", modelo.VlrCdtks);
            cmd.Parameters.AddWithValue("@VLRMOEDA", modelo.VlrMoedas);
            cmd.Parameters.AddWithValue("@VLROUTROS", modelo.VlrOutros);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public void AlterarTBC (ModeloTABCaixa modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            String comando4 = " UPDATE TABCAIXA SET TURNO = @TURNO WHERE DTCAIXA = @DTCAIXA AND NUMCHECKOUT = @NUMCAIXA AND CODFUNCCHECKOUT = @CODCAIXA;";
            cmd.CommandText = comando4;
            cmd.Parameters.AddWithValue("@TURNO", modelo.Turno);
            cmd.Parameters.AddWithValue("@DTCAIXA", modelo.DtCaixa);
            cmd.Parameters.AddWithValue("@NUMCAIXA", modelo.NumCaixa);
            cmd.Parameters.AddWithValue("@CODCAIXA", modelo.CodCaixa);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();

        }


        public void DelCaixa(ModeloTABCaixa modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            String comando5 = "";
            comando5 = comando5 + " DELETE FROM TABFECHA WHERE NUMTRANS = @NUMTRANS;";

            cmd.CommandText = comando5;
            cmd.Parameters.AddWithValue("@NUMTRANS", modelo.NumTrans);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public void DelCaixaT(ModeloTABCaixa modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            String comando5 = "";
            comando5 = comando5 + " DELETE FROM TABCAIXA WHERE NUMCHECKOUT = @NUMCAIXA AND CODFUNCCHECKOUT = @CODFUNC AND TURNO = @TURNO AND CONVERT(nvarchar(30), DTCAIXA, 103) = @DATA;;";

            cmd.CommandText = comando5;
            cmd.Parameters.AddWithValue("@NUMCAIXA", modelo.NumCaixa);
            cmd.Parameters.AddWithValue("@CODFUNC", modelo.CodCaixa);
            cmd.Parameters.AddWithValue("@TURNO", modelo.Turno);
            cmd.Parameters.AddWithValue("@DATA", modelo.DtCaixast);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

    }
}
