﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DadosDaConexao
    {
        public static String servidor = @"DESKTOP-G8VSENE";
        public static String banco = "nControle";
        public static String usuario = "sa";
        public static String senha = "Adm@123";
        public static String caixa = "10";

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
