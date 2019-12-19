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
            this.Matricula = 0;

            this.NomeUser = "";

            this.NomeWint = "";

            this.SenhaUser = "";
            this.PerfilUser = 0;

        }

        public ModeloUsuario(int coduser, int matricula, String nomeuser, String nomewint, string senhauser,int perfiluser,int perfilted)
        {
            this.CodUser = coduser;
            this.Matricula = matricula;

            this.NomeUser = nomeuser;
            this.NomeWint = nomewint;

            this.SenhaUser = senhauser;
            this.PerfilUser = perfiluser;
            this.PerfilTed = perfilted;
        }

        private int cod_user;
        public int CodUser
        {
            get { return this.cod_user; }
            set { this.cod_user = value; }
        }
        private int cod_mat;
        public int Matricula
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
        private String nome_wint;
        public String NomeWint
        {
            get { return this.nome_wint; }
            set { this.nome_wint = value; }
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
        private int perfil_ted;
        public int PerfilTed
        {
            get { return this.perfil_ted; }
            set { this.perfil_ted = value; }
        }
    }
}
