using System;

namespace DAL
{
    public class DadosDaConexao
    {
        public static String servidor = @"10.1.1.247";
        public static String banco = "nControle";
        public static String usuario = "sa";
        public static String senha = "Adm@123";
        public static String caixa = "1";

        public static String StringDeConexao
        {
            get 
            {
                return @"Data Source="+servidor+";Initial Catalog="+banco+";User ID="+usuario+";Password="+senha;
            }
        }
    }
    public class DadosDaConexaoTAB
    {
        public static String servidor = "WINT";
        public static String usuario = "TABAJARA";
        public static String senha = "SU9FTA3A";
        public static String StringDeConexao
        {
            get
            {
                return @"Data Source=" + servidor + "; User ID=" + usuario + ";Password=" + senha + ";Unicode = True";
            }
        }
    }
}
