using System;

namespace Modelo
{
    public class ModeloEquipe
    {
        public ModeloEquipe()
        {
            this.CodEquipe = 0;
            this.NomeEquipe = "";
        }

        public ModeloEquipe(int CodEquipe, String nome)
        {
            this.CodEquipe = CodEquipe;
            this.NomeEquipe = nome;
        }

        private int cod_equipe;
        public int CodEquipe
        {
            get { return this.cod_equipe; }
            set { this.cod_equipe = value; }
        }
        private String nome_equipe;
        public String NomeEquipe
        {
            get { return this.nome_equipe; }
            set { this.nome_equipe = value; }
        }
    }
}
