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
                //modelo.DataMov = registro["DTCAIXA"].ToString();
                modelo.VlrEnt = Convert.ToDouble(registro["ENTRADAS"]);
                modelo.VlrSai = Convert.ToDouble(registro["SAIDAS"]);
                modelo.VlrTotal = Convert.ToDouble(registro["TOTAL"]);
            }
            conexao.Desconectar();
            registro.Close();
            return modelo;
        }
    }
}
