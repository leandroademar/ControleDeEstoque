using System;

namespace Modelo
{
    public class ModeloUnidadeDeMedida
    {
        //umed_cod
        //umed_nome

        public ModeloUnidadeDeMedida()
        {
            this.UmedCod = 0;
            this.UmedSigla = "";
            this.UmedNome = "";
        }

        public ModeloUnidadeDeMedida(int cod, String sigla,String nome)
        {
            this.UmedCod = cod;
            this.UmedSigla = sigla;
            this.UmedNome = nome;
        }

        private int umed_cod;
        public int UmedCod
        {
            get
            {
                return this.umed_cod;
            }
            set
            {
                this.umed_cod = value;
            }
        }
        private String umed_sigla;
        public String UmedSigla
        {
            get { return this.umed_sigla; }
            set { this.umed_sigla = value; }
        }
        private String umed_nome;
        public String UmedNome
        {
            get { return this.umed_nome; }
            set { this.umed_nome = value; }
        }
    }
}
