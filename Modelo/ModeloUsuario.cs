using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloUsuario
    {
        public ModeloUsuario()
        {
            this.CodUser = 0;
            this.NomeUser = "";
            this.SenhaUser = "";
            this.PerfilUser = 0;

        }

        public ModeloUsuario(int coduser, String nomeuser, string senhauser,int perfiluser)
        {
            this.CodUser = coduser;
            this.NomeUser = nomeuser;
            this.SenhaUser = senhauser;
            this.PerfilUser = perfiluser;
        }

        private int cod_user;
        public int CodUser
        {
            get { return this.cod_user; }
            set { this.cod_user = value; }
        }
        private String nome_user;
        public String NomeUser
        {
            get { return this.nome_user; }
            set { this.nome_user = value; }
        }
        private String senha_user;
        public String SenhaUser
        {
            get { return this.senha_user; }
            set { this.senha_user = value; }
        }
        private int perfil_user;
        public int PerfilUser
        {
            get { return this.perfil_user; }
            set { this.perfil_user = value; }
        }
    }
}
