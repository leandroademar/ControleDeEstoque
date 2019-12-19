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
        public ModeloTABCaixa(int _numtrans, int _numcaixa, int _codcaixa, String _nomecaixa, DateTime _dtcaixa, double _vlrdin, double _vlrdep, double _vlrdeb, double _vlrtran, double _vlrcheq, double _vlrvend, double _vlrcred, int _turno, double _vlrcctks, double _vlrcdtks, double _vlroutros, double _vlrmoedas)
        {
            this.NumTrans = _numtrans;
            this.NumCaixa = _numcaixa;
            this.CodCaixa = _codcaixa;
            this.NomeCaixa = _nomecaixa;
            this.DtCaixa = _dtcaixa;
            this.VlrDin = _vlrdin;
            this.VlrDep = _vlrdep;
            this.VlrDeb = _vlrdeb;
            this.VlrTran = _vlrtran;
            this.VlrCheq = _vlrcheq;
            this.VlrVend = _vlrvend;
            this.VlrCred = _vlrcred;
            this.Turno = _turno;
            this.VlrCctks = _vlrcctks;
            this.VlrCdtks = _vlrcdtks;
            this.VlrOutros = _vlroutros;
            this.VlrMoedas = _vlrmoedas;


        }

        private int numtrans;
        public int NumTrans
        {
            get { return this.numtrans; }
            set { this.numtrans = value; }
        }

        private int numcaixa;
        public int NumCaixa
        {
            get { return this.numcaixa; }
            set { this.numcaixa = value; }
        }
        private int codcaixa;
        public int CodCaixa
        {
            get { return this.codcaixa; }
            set { this.codcaixa = value; }
        }

        private string nomecaixa;
        public string NomeCaixa
        {
            get { return this.nomecaixa; }
            set { this.nomecaixa = value; }
        }

        private double vlrdin;
        public double VlrDin
        {
            get { return this.vlrdin; }
            set { this.vlrdin = value; }
        }

        private double vlrdep;
        public double VlrDep
        {
            get { return this.vlrdep; }
            set { this.vlrdep = value; }
        }
        private double vlrdeb;
        public double VlrDeb
        {
            get { return this.vlrdeb; }
            set { this.vlrdeb = value; }
        }
        private double vlrtran;
        public double VlrTran
        {
            get { return this.vlrtran; }
            set { this.vlrtran = value; }
        }
        private double vlrcheq;
        public double VlrCheq
        {
            get { return this.vlrcheq; }
            set { this.vlrcheq = value; }
        }
        private double vlrvend;
        public double VlrVend
        {
            get { return this.vlrvend; }
            set { this.vlrvend = value; }
        }
        private double vlrcred;
        public double VlrCred
        {
            get { return this.vlrcred; }
            set { this.vlrcred = value; }
        }
        private int turno;
        public int Turno
        {
            get { return this.turno; }
            set { this.turno = value; }
        }
        private double vlrcctks;
        public double VlrCctks
        {
            get { return this.vlrcctks; }
            set { this.vlrcctks = value; }
        }
        private double vlrcdtks;
        public double VlrCdtks
        {
            get { return this.vlrcdtks; }
            set { this.vlrcdtks = value; }
        }
        private double vlroutros;
        public double VlrOutros
        {
            get { return this.vlroutros; }
            set { this.vlroutros = value; }
        }
        private double vlrmoedas;
        public double VlrMoedas
        {
            get { return this.vlrmoedas; }
            set { this.vlrmoedas = value; }
        }
        private DateTime dtcaixa;
        public DateTime DtCaixa
        {
            get { return this.dtcaixa; }
            set { this.dtcaixa = value; }
        }

    }

   
}
