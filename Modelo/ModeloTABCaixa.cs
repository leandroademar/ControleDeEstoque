using System;

namespace Modelo
{
    public class ModeloTABCaixa
    {
        public ModeloTABCaixa()
        {
            this.NumTrans = 0;
            this.NumCaixa = 0;
            this.CodCaixa = 0;
            this.NomeCaixa = "";
            this.VlrDin = 0.00;
            this.VlrDep = 0.00;
            this.VlrDeb = 0.00;
            this.VlrTran = 0.00;
            this.VlrCheq = 0.00;
            this.VlrVend = 0.00;
            this.VlrCred = 0.00;
            this.Turno = 1;
            this.VlrCctks = 0.00;
            this.VlrCdtks = 0.00;
            this.VlrMoedas = 0.00;
            this.VlrOutros = 0.00;


        }
        public ModeloTABCaixa(int numtrans, int _numcaixa, int codcaixa, String nomecaixa,DateTime dtcaixa, double vlrdin, double vlrdep, double vlrdeb, double vlrtran, double vlrcheq, double vlrvend, double vlrcred, int turno, double vlrcctks, double vlrcdtks, double vlroutros, double vlrmoedas)
        {
            this.NumTrans = numtrans;
            this.NumCaixa = _numcaixa;
            this.CodCaixa = codcaixa;
            this.NomeCaixa = nomecaixa;
            this.DtCaixa = dtcaixa;
            this.VlrDin = vlrdin;
            this.VlrDep = vlrdep;
            this.VlrDeb = vlrdeb;
            this.VlrTran = vlrtran;
            this.VlrCheq = vlrcheq;
            this.VlrVend = vlrvend;
            this.VlrCred = vlrcred;
            this.Turno = turno;
            this.VlrCctks = vlrcctks;
            this.VlrCdtks = vlrcdtks;
            this.VlrOutros = vlroutros;
            this.VlrMoedas = vlrmoedas;


        }

        private int numtrans;
        public int NumTrans
        {
            get { return this.NumTrans; }
            set { this.numtrans = value; }
        }

        private int _numcaixa;
        public int NumCaixa
        {
            get { return this.NumCaixa; }
            set { this._numcaixa = value; }
        }
        private int codcaixa;
        public int CodCaixa
        {
            get { return this.CodCaixa; }
            set { this.codcaixa = value; }
        }
        private string nomecaixa;
        public string NomeCaixa
        {
            get { return this.NomeCaixa; }
            set { this.nomecaixa = value; }
        }
        private double vlrdin;
        public double VlrDin
        {
            get { return this.VlrDin; }
            set { this.vlrdin = value; }
        }
        private double vlrdep;
        public double VlrDep
        {
            get { return this.VlrDep; }
            set { this.vlrdep = value; }
        }
        private double vlrdeb;
        public double VlrDeb
        {
            get { return this.VlrDeb; }
            set { this.vlrdeb = value; }
        }
        private double vlrtran;
        public double VlrTran
        {
            get { return this.VlrTran; }
            set { this.vlrtran = value; }
        }
        private double vlrcheq;
        public double VlrCheq
        {
            get { return this.VlrCheq; }
            set { this.vlrcheq = value; }
        }
        private double vlrvend;
        public double VlrVend
        {
            get { return this.VlrVend; }
            set { this.vlrvend = value; }
        }
        private double vlrcred;
        public double VlrCred
        {
            get { return this.VlrCred; }
            set { this.vlrcred = value; }
        }
        private int turno;
        public int Turno
        {
            get { return this.Turno; }
            set { this.turno = value; }
        }
        private double vlrcctks;
        public double VlrCctks
        {
            get { return this.VlrCctks; }
            set { this.vlrcctks = value; }
        }
        private double vlrcdtks;
        public double VlrCdtks
        {
            get { return this.VlrCdtks; }
            set { this.vlrcdtks = value; }
        }
        private double vlroutros;
        public double VlrOutros
        {
            get { return this.VlrOutros; }
            set { this.vlroutros = value; }
        }
        private double vlrmoedas;
        public double VlrMoedas
        {
            get { return this.VlrMoedas; }
            set { this.vlrmoedas = value; }
        }
        private DateTime dtcaixa;
        public DateTime DtCaixa
        {
            get { return this.DtCaixa; }
            set { this.dtcaixa = value; }
        }

    }

   
}
