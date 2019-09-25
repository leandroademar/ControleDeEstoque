using System;

namespace Modelo
{
    public class ModeloCaixaStatus
    {
        public ModeloCaixaStatus()
        {
            this.CaxsTurno = 0;
            this.CaxsNome = "";
            this.CaxsAbertura = DateTime.Now;
            this.CaxsStatus = 0;
        }

        public ModeloCaixaStatus(int caxscod,int caxsturno, string caxsnome, DateTime caxsabertura, DateTime caxsfechamento, int caxsstatus)
        {
            this.CaxsCod = caxscod;
            this.CaxsTurno = caxsturno;
            this.CaxsNome = caxsnome;
            this.CaxsAbertura = caxsabertura;
            this.CaxsFechamento = caxsfechamento;
            this.CaxsStatus = caxsstatus;
        }

        private int caxs_cod;
        public int CaxsCod
        {
            get { return this.caxs_cod; }
            set { this.caxs_cod = value; }
        }

        private int caxs_turno;
        public int CaxsTurno
        {
            get { return this.caxs_turno; }
            set { this.caxs_turno = value; }
        }

        private String caxs_nome;
        public String CaxsNome
        {
            get { return this.caxs_nome; }
            set { this.caxs_nome = value; }
        }
        private DateTime caxs_abertura;
        public DateTime CaxsAbertura
        {
            get { return this.caxs_abertura; }
            set { this.caxs_abertura = value; }
        }
        private DateTime caxs_fechamento;
        public DateTime CaxsFechamento
        {
            get { return this.caxs_fechamento; }
            set { this.caxs_fechamento = value; }
        }
        private int caxs_status;
        public int CaxsStatus
        {
            get { return this.caxs_status; }
            set { this.caxs_status = value; }
        }
    }
}
