using Modelo;
using System.Data;
using Oracle.DataAccess.Client;
using System;


namespace DAL
{
    public class DALPCVENDACONSUM
    {
        private DALTABConexao conexao;
        public DALPCVENDACONSUM(DALTABConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloPCVENDACONSUM modelo)
        {
            String comando1 = "";
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conexao.ObjetoConexao;

            comando1 = comando1 + "INSERT INTO pcvendaconsum " + "\n";
            comando1 = comando1 + "                ( numped " + "\n";
            comando1 = comando1 + "                 ,cliente " + "\n";
            comando1 = comando1 + "                 ,cgcent " + "\n";
            comando1 = comando1 + "                 ,enderent " + "\n";
            comando1 = comando1 + "                 ,bairroent " + "\n";
            comando1 = comando1 + "                 ,telent " + "\n";
            comando1 = comando1 + "                 ,municent " + "\n";
            comando1 = comando1 + "                 ,estent " + "\n";
            comando1 = comando1 + "                 ,cepent " + "\n";
            comando1 = comando1 + "                 ,ieent " + "\n";
            comando1 = comando1 + "                 ,nomecontato " + "\n";
            comando1 = comando1 + "                 ,telefonecontato " + "\n";
            comando1 = comando1 + "                 ,obscontato " + "\n";
            comando1 = comando1 + "                 ,email " + "\n";
            comando1 = comando1 + "                 ,codcidade " + "\n";
            comando1 = comando1 + "                 ,numeroent " + "\n";
            comando1 = comando1 + "                ) " + "\n";
            comando1 = comando1 + "         VALUES ( :numped " + "\n";
            comando1 = comando1 + "                 ,:cliente " + "\n";
            comando1 = comando1 + "                 ,:cgcent " + "\n";
            comando1 = comando1 + "                 ,:enderent " + "\n";
            comando1 = comando1 + "                 ,:bairroent " + "\n";
            comando1 = comando1 + "                 ,:telent " + "\n";
            comando1 = comando1 + "                 ,:municent " + "\n";
            comando1 = comando1 + "                 ,:estent " + "\n";
            comando1 = comando1 + "                 ,:cepent " + "\n";
            comando1 = comando1 + "                 ,:ieent " + "\n";
            comando1 = comando1 + "                 ,:nomecontato " + "\n";
            comando1 = comando1 + "                 ,:telefonecontato " + "\n";
            comando1 = comando1 + "                 ,:obscontato " + "\n";
            comando1 = comando1 + "                 ,:email " + "\n";
            comando1 = comando1 + "                 ,:codcidade " + "\n";
            comando1 = comando1 + "                 ,:numeroent " + "\n";
            comando1 = comando1 + "                )";
            cmd.CommandText = comando1;
            cmd.Parameters.Add(new OracleParameter(":numped", modelo.numped));
            cmd.Parameters.Add(new OracleParameter(":cliente", modelo.cliente));
            cmd.Parameters.Add(new OracleParameter(":cgcent", modelo.cgcent));
            cmd.Parameters.Add(new OracleParameter(":enderent", modelo.enderent));
            cmd.Parameters.Add(new OracleParameter(":bairroent", modelo.bairroent));
            cmd.Parameters.Add(new OracleParameter(":telent", modelo.telent));
            cmd.Parameters.Add(new OracleParameter(":municent", modelo.municent));
            cmd.Parameters.Add(new OracleParameter(":estent", modelo.estent));
            cmd.Parameters.Add(new OracleParameter(":cepent", modelo.cepent));
            cmd.Parameters.Add(new OracleParameter(":ieent", modelo.ieent));
            cmd.Parameters.Add(new OracleParameter(":nomecontato", modelo.nomecontato));
            cmd.Parameters.Add(new OracleParameter(":telefonecontato", modelo.telefonecontato));
            cmd.Parameters.Add(new OracleParameter(":obscontato", modelo.obscontato));
            cmd.Parameters.Add(new OracleParameter(":email", modelo.email));
            cmd.Parameters.Add(new OracleParameter(":codcidade", modelo.codcidade));
            cmd.Parameters.Add(new OracleParameter(":numeroent", modelo.numeroent));
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public ModeloPCVENDACONSUM CarregaPCVENDACONSUM (long codigo)
        {
            String comando2 = "SELECT * FROM PCVENDACONSUM WHERE NUMPED = :codigo ";

            ModeloPCVENDACONSUM modelo = new ModeloPCVENDACONSUM();
            OracleCommand cmd = new OracleCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = comando2;
            cmd.Parameters.Add(new OracleParameter(":codigo", codigo));
            conexao.Conectar();
            OracleDataReader registro = cmd.ExecuteReader();
            if(registro.HasRows)
            {
                registro.Read();
                modelo.numped = Convert.ToInt64(registro["NUMPED"]);
                modelo.cliente = Convert.ToString(registro["CLIENTE"]);
                modelo.cgcent = Convert.ToString(registro["CGCENT"]);
                modelo.enderent = Convert.ToString(registro["ENDERENT"]);
                modelo.bairroent = Convert.ToString(registro["BAIRROENT"]);
                modelo.telent = Convert.ToString(registro["TELENT"]);
                modelo.municent = Convert.ToString(registro["MUNICENT"]);
                modelo.estent = Convert.ToString(registro["ESTENT"]);
                modelo.cepent = Convert.ToString(registro["CEPENT"]);
                modelo.ieent = Convert.ToString(registro["IEENT"]);
                modelo.nomecontato = Convert.ToString(registro["NOMECONTATO"]);
                modelo.telefonecontato = Convert.ToString(registro["TELEFONECONTATO"]);
                modelo.obscontato = Convert.ToString(registro["OBSCONTATO"]);
                modelo.email = Convert.ToString(registro["EMAIL"]);
                modelo.codcidade = Convert.ToInt32(registro["CODCIDADE"]);
                modelo.numeroent = Convert.ToString(registro["NUMEROENT"]);

            }
            conexao.Desconectar();
            return modelo;
        }
        
        
    }
}
