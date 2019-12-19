using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DALItensCompra
    {

        private DALConexao conexao;
        public DALItensCompra(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloItensCompra modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObjetoTransacao;
            cmd.CommandText = "insert into itenscompra(itc_cod,itc_qtde,itc_valor,com_cod,pro_cod) values (@itc_cod,@itc_qtde,@itc_valor,@com_cod,@pro_cod);";
            cmd.Parameters.AddWithValue("@itc_cod", modelo.itcCod);
            cmd.Parameters.AddWithValue("@itc_qtde", modelo.itcQtde);
            cmd.Parameters.AddWithValue("@itc_valor", modelo.itcValor);
            cmd.Parameters.AddWithValue("@com_cod", modelo.VenCod);
            cmd.Parameters.AddWithValue("@pro_cod", modelo.ProCod);
            cmd.ExecuteNonQuery();
        }
        public void Alterar(ModeloItensCompra modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObjetoTransacao;

            cmd.CommandText = "update itenscompra set itc_qtde = @itc_qtde, itc_valor= @itc_valor " +
                               "where itc_cod = @itc_cod and com_cod = @com_cod and pro_cod = @pro_cod;";
            cmd.Parameters.AddWithValue("@itc_cod", modelo.itcCod);
            cmd.Parameters.AddWithValue("@itc_qtde", modelo.itcQtde);
            cmd.Parameters.AddWithValue("@itc_valor", modelo.itcValor);
            cmd.Parameters.AddWithValue("@com_cod", modelo.VenCod);
            cmd.Parameters.AddWithValue("@pro_cod", modelo.ProCod);
            cmd.ExecuteNonQuery();
        }
        public void Excluir(ModeloItensCompra modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObjetoTransacao;
            cmd.CommandText = "delete from itensvenda " +
                "where itc_cod = @itc_cod and com_cod = @com_cod and pro_cod = @pro_cod;";
            cmd.Parameters.AddWithValue("@itc_cod", modelo.itcCod);
            cmd.Parameters.AddWithValue("@com_cod", modelo.VenCod);
            cmd.Parameters.AddWithValue("@pro_cod", modelo.ProCod);
            cmd.ExecuteNonQuery();
        }

        public DataTable Localizar(int vencod)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from itensvenda where com_cod =" +
                vencod.ToString(), conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloItensCompra CarregaModeloitenscompra(int itcCod, int VenCod, int ProCod)
        {
            ModeloItensCompra modelo = new ModeloItensCompra();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from itensvenda where itc_cod = @itc_cod and com_cod = @com_cod and pro_cod = @pro_cod;";
            cmd.Parameters.AddWithValue("@itc_cod", itcCod);
            cmd.Parameters.AddWithValue("@com_cod", VenCod);
            cmd.Parameters.AddWithValue("@pro_cod", ProCod);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.itcCod = itcCod;
                modelo.ProCod = ProCod;
                modelo.VenCod = VenCod;
                modelo.itcQtde = Convert.ToDouble(registro["itc_qtde"]);
                modelo.itcQtde = Convert.ToDouble(registro["itc_valor"]);
            }
            conexao.Desconectar();
            registro.Close();
            return modelo;
        }
    }
}
