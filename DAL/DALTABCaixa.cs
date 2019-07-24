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

        public DataTable LocalizarCaixas(int turno,int seg,int dia, string datamovimento)
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

        public  DataTable Buscar(int seg,string dtmovimento)
        {
            String comando3 = "";
            comando3 = comando3 + "SELECT NUMTRANS " + "\n";
            comando3 = comando3 + "      , NUMCHECKOUT " + "\n";
            comando3 = comando3 + "      , CODFUNCCHECKOUT " + "\n";
            comando3 = comando3 + "      , NOME " + "\n";
            comando3 = comando3 + "      , TURNO " + "\n";
            comando3 = comando3 + "      , DTCAIXA " + "\n";
            comando3 = comando3 + "      , DTCONFERENCIA " + "\n";
            comando3 = comando3 + "  FROM  TABCAIXA " + "\n";
            comando3 = comando3 + "  WHERE TURNO IS NULL " + "\n";
            if(seg != 0)
            {
                comando3 = comando3 + "AND NUMCHECKOUT IN (10,11,12)";

            }
            else
            {
                comando3 = comando3 + "AND NUMCHECKOUT NOT IN (10,11,12)";

            }

            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter
            (comando3, conexao.StringConexao);
            da.Fill(tabela);
            return tabela;

        }
        public void InsertTBC(ModeloTABCaixa modelo)
        {
           
            string comando4 = " INSERT INTO TABCAIXA (NUMCHECKOUT,CODFUNCCHECKOUT,NOME)  EXEC T_TABCAIXA @SEG,@DATA,'',''";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = comando4;
            cmd.Parameters.AddWithValue("@SEG", modelo.Turno);
            cmd.Parameters.AddWithValue("@DTCAIXA", modelo.DtCaixa);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
            
            
        }
       
        public void Alterar (ModeloTABCaixa modelo)
        {
         
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            String comando3 = "";
            comando3 = comando3 + "UPDATE  TABFECHA SET " + "\n";
            comando3 = comando3 + "      VLRDIN = @VLRDIN, " + "\n";
            comando3 = comando3 + "      VLRDEP = @VLRDEP, " + "\n";
            comando3 = comando3 + "      VLRDEB = @VLRDEB, " + "\n";
            comando3 = comando3 + "      VLRTRAN = @VLRTRAN, " + "\n";
            comando3 = comando3 + "      VLRCHEQ = @VLRCHEQ, " + "\n";
            comando3 = comando3 + "      VLRVEND = @VLRVEND, " + "\n";
            comando3 = comando3 + "      VLRCRED = @VLRCRED, " + "\n";
            comando3 = comando3 + "      VLRCCTKS = @VLRCCTKS, " + "\n";
            comando3 = comando3 + "      VLRCDTKS = @VLRCDTKS, " + "\n";
            comando3 = comando3 + "      VLRMOEDA = @VLRMOEDA, " + "\n";
            comando3 = comando3 + "      VLROUTROS = @VLROUTROS " + "\n";
            comando3 = comando3 + " " + "\n";
            comando3 = comando3 + "  WHERE NUMTRANS = @NUMTRANS";
            cmd.CommandText = comando3;
            cmd.Parameters.AddWithValue("@NUMTRANS", modelo.NumTrans);
            cmd.Parameters.AddWithValue("@VLRDIN", modelo.VlrDin);
            cmd.Parameters.AddWithValue("@VLRDEP", modelo.VlrDep);
            cmd.Parameters.AddWithValue("@VLRDEB", modelo.VlrDeb);
            cmd.Parameters.AddWithValue("@VLRTRAN", modelo.VlrTran);
            cmd.Parameters.AddWithValue("@VLRCHEQ", modelo.VlrCheq);
            cmd.Parameters.AddWithValue("@VLRVEND", modelo.VlrVend);
            cmd.Parameters.AddWithValue("@VLRCCTKS", modelo.VlrCctks);
            cmd.Parameters.AddWithValue("@VLRCDTKS", modelo.VlrCdtks);
            cmd.Parameters.AddWithValue("@VLRMOEDA", modelo.VlrMoedas);
            cmd.Parameters.AddWithValue("@VLROUTROS", modelo.VlrOutros);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

    }
}
