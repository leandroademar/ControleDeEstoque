using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Chamar o login antes de iniciar a aplicação
            Login fLogin = new Login();
            fLogin.ShowDialog();

            //Só inicia se receber True na propriedade "Logado"
            if (fLogin.Logado)
            {
                Application.Run(new frmPrincipal(fLogin.Usuario,fLogin.Perfil,fLogin.PerfilTed));
            }

        }
    }
}
