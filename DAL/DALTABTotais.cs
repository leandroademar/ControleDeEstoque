using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace DAL
{
    public class DALTABTotais
    {
        private DALConexao conexao;
        private string stringDeConexao;

        public DALTABTotais(DALConexao cx)
        {
            this.conexao = cx;
        }

        public DALTABTotais(string stringDeConexao)
        {
            this.stringDeConexao = stringDeConexao;
        }

        public ModeloTotal CarregaTotal(int numcaixa, int turno, string data, int codfunc)
        {
            
                ModeloTotal modelo = new ModeloTotal();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;

                cmd.CommandText = "" +
                    " SELECT NUMCAIXA,TURNO,CODCAIXA, ENTRADAS, TED, SAIDAS, TOTAL  FROM VWTOTAL_CAIXA WHERE " +
                    "DTCAIXA = @datamov AND NUMCAIXA = @numcaixa AND TURNO = @turno AND CODCAIXA = @codcaixa ;";
                cmd.Parameters.AddWithValue("@numcaixa", numcaixa);
                cmd.Parameters.AddWithValue("@datamov", data);
                cmd.Parameters.AddWithValue("@codcaixa", codfunc);
                cmd.Parameters.AddWithValue("@turno", turno);

                conexao.Conectar();
                SqlDataReader registro = cmd.ExecuteReader();
                if (registro.HasRows)
                {
                    registro.Read();
                    modelo.NumCaixa = Convert.ToInt32(registro["NUMCAIXA"]);
                    modelo.Turno = Convert.ToInt32(registro["TURNO"]);
                    modelo.CodCaixa = Convert.ToInt32(registro["CODCAIXA"]);
                    modelo.VlrEnt = Convert.ToDouble(registro["ENTRADAS"]);
                    modelo.VlrSai = Convert.ToDouble(registro["SAIDAS"]);
                    modelo.VlrTotal = Convert.ToDouble(registro["TOTAL"]);
                }
                conexao.Desconectar();
                registro.Close();
                return modelo;

            }
            
      
        public ModeloTotal CarregaTotalGeral( string data)
        {
            ModeloTotal modelo = new ModeloTotal();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Parameters.AddWithValue("@DTCAIXA", data);
            String comando1 = "";
            comando1 = comando1 + "SELECT CONVERT(nvarchar(30), TF.DTCAIXA, 103) DTCAIXA, " + "\n";
            comando1 = comando1 + "ROUND(SUM(VLRDIN+VLRDEP+VLRDEB+VLRTRAN+VLRCHEQ+VLRCRED+VLRCCTKS+VLRCDTKS+VLROUTROS+VLRMOEDA),2)AS  ENTRADAS, " + "\n";
            comando1 = comando1 + "ISNULL((SELECT SUM(TED) FROM VWTRANSFENT TE WHERE CONVERT(nvarchar(30), TF.DTCAIXA, 103) = TE.DATADEP GROUP BY TE.DATADEP),0) TED, " + "\n";
            comando1 = comando1 + "ROUND(SUM(VLRDEB+VLRCRED),2) AS REDE,ROUND(SUM(VLRCCTKS+VLRCDTKS),2) AS TKS," + "\n";
            comando1 = comando1 + "ISNULL((SELECT SUM(SAIDAS) FROM VWTRANSF TE WHERE CONVERT(nvarchar(30), TF.DTCAIXA, 103) = TE.DATADEP GROUP BY TE.DATADEP),0) SAIDAS, " + "\n";
            comando1 = comando1 + "ROUND(SUM(VLRDIN+VLRDEP+VLRDEB+VLRTRAN+VLRCHEQ+VLRCRED+VLRCCTKS+VLRCDTKS+VLROUTROS+VLRMOEDA),2) - " + "\n";
            comando1 = comando1 + "ISNULL((SELECT SUM(SAIDAS) FROM VWTRANSF TE WHERE  CONVERT(nvarchar(30), TF.DTCAIXA, 103) = TE.DATADEP GROUP BY TE.DATADEP),0) AS TOTAL " + "\n";
            comando1 = comando1 + "FROM TABFECHA TF " + "\n";
            comando1 = comando1 + "WHERE CONVERT(nvarchar(30), TF.DTCAIXA, 103) = @DTCAIXA " + "\n";
            comando1 = comando1 + "GROUP BY DTCAIXA";
            cmd.CommandText = comando1;

            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.VlrEnt = Convert.ToDouble(registro["ENTRADAS"]);
                modelo.VlrRed = Convert.ToDouble(registro["REDE"]);
                modelo.VlrTks = Convert.ToDouble(registro["TKS"]);
                modelo.VlrSai = Convert.ToDouble(registro["SAIDAS"]);
                modelo.VlrTed = Convert.ToDouble(registro["TED"]);
                modelo.VlrTotal = Convert.ToDouble(registro["TOTAL"]);
            }
            conexao.Desconectar();
            registro.Close();
            return modelo;
        }
    }
}
