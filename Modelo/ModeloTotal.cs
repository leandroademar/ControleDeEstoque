using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloTotal
    {
        public ModeloTotal()
        {
            this.Turno = 0;
            this.NumCaixa = 0;
            this.CodCaixa = 0;
            this.DataMov = "";
            this.VlrEnt = 0.00;
            this.VlrRed = 0.00;
            this.VlrTks = 0.00;
            this.VlrSai = 0.00;
            this.VlrTed = 0.00;
            this.VlrTotal = 0.00;

        }
        public ModeloTotal(int _turno, int _numcaixa, int _codcaixa,string _dtmov,double _vlrent, double _vlrred, double _vlrtks, double _vlrsai, double _vlrted,double _vlrtotal)
        {
            this.Turno = _turno;
            this.NumCaixa = _numcaixa;
            this.CodCaixa = _codcaixa;
            this.DataMov = _dtmov;
            this.VlrEnt = _vlrent;
            this.VlrRed = _vlrred;
            this.VlrTks = _vlrtks;
            this.VlrSai = _vlrsai;
            this.VlrTed = _vlrted;
            this.VlrTotal = _vlrtotal;

        }

        private int turno;
        public int Turno
        {
            get { return this.turno; }
            set { this.turno = value; }
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
        private string dtmov;
        public string DataMov
        {
            get { return this.dtmov; }
            set { this.dtmov = value; }
        }
        private double vlrent;
        public double VlrEnt
        {
            get { return this.vlrent; }
            set { this.vlrent = value; }
        }
        private double vlrred;
        public double VlrRed
        {
            get { return this.vlrred; }
            set { this.vlrred = value; }
        }
        private double vlrtks;
        public double VlrTks
        {
            get { return this.vlrtks; }
            set { this.vlrtks = value; }
        }
        private double vlrsai;
        public double VlrSai
        {
            get { return this.vlrsai; }
            set { this.vlrsai = value; }
        }
        private double vlrted;
        public double VlrTed
        {
            get { return this.vlrted; }
            set { this.vlrted = value; }
        }
        private double vlrtotal;
        public double VlrTotal
        {
            get { return this.vlrtotal; }
            set { this.vlrtotal = value; }
        }
    }
}
