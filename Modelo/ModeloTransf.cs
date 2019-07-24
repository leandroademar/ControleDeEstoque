using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloTransf
    {
        public ModeloTransf()
        {
            this.NumTrans = 0;
            this.NomeBanco = "";
            this.NomeCliente = "";
            this.Hora = "";
            this.Usuario = "";
            this.UsuarioAut = "";
            this.Valor = 0.00;
            this.NumCaixa = 1;
            this.Turno = 1;
            this.CodFunc = 1;





        }
        public ModeloTransf(int _numtrans, string _nomebanco,string _nomecliente, DateTime _dttransf,string _hora, DateTime _horaautorizacao, string _usuario,string _usuarioaut, double _valor,int _numcaixa, int _turno, int _codfunc)
        {
            this.NumTrans = _numtrans;
            this.NomeBanco = _nomebanco;
            this.NomeCliente = _nomecliente;
            this.DtTransf = _dttransf;
            this.Hora = _hora;
            this.HoraAutorizacao = _horaautorizacao;
            this.Usuario = _usuario;
            this.UsuarioAut = _usuarioaut;
            this.Valor = _valor;
            this.NumCaixa = _numcaixa;
            this.Turno = _turno;
            this.CodFunc = _codfunc;
        }

        private int numtrans;
        public int NumTrans
        {
            get { return this.numtrans; }
            set { this.numtrans = value; }
        }
        private string nomebanco;
        public string NomeBanco
        {
            get { return this.nomebanco; }
            set { this.nomebanco = value; }
        }
        private string nomecliente;
        public string NomeCliente
        {
            get { return this.nomecliente; }
            set { this.nomecliente = value; }
        }

        private DateTime dttransf;
        public DateTime DtTransf
        {
            get { return this.dttransf; }
            set { this.dttransf = value; }
        }
        private string hora;
        public string Hora
        {
            get { return this.hora; }
            set { this.hora = value; }
        }
        private DateTime horaautorizacao;
        public DateTime HoraAutorizacao
        {
            get { return this.horaautorizacao; }
            set { this.horaautorizacao = value; }
        }
        private string usuario;
        public string Usuario
        {
            get { return this.usuario; }
            set { this.usuario = value; }
        }
        private string usuarioaut;
        public string UsuarioAut
        {
            get { return this.usuarioaut; }
            set { this.usuarioaut = value; }
        }
        private double valor;
        public double Valor
        {
            get { return this.valor; }
            set { this.valor = value; }
        }
        private int numcaixa;
        public int NumCaixa
        {
            get { return this.numcaixa; }
            set { this.numcaixa = value; }
        }
        private int turno;
        public int Turno
        {
            get { return this.turno; }
            set { this.turno = value; }
        }
        private int codfunc;
        public int CodFunc
        {
            get { return this.codfunc; }
            set { this.codfunc = value; }
        }

    }
}
