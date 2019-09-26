using System;

namespace Modelo
{
    public class ModeloVerba
    {
        public ModeloVerba()
        {
            this.IdTran = 0;
            this.CodFornec = 0;
            this.NomeFornec = "";
            this.Obs = "";
            this.ValorMercado = 0.00;
            this.ValorDesconto = 0.00;
            this.Quantidade = 0.00;
            this.CodProd = 0;
            this.DescProd = "";


        }

        public ModeloVerba(int _idtran, int _codfornec, String _nomefornec, string _obs,double _valormercado,double _valordesconto, double _quantidade, int _codprod, string _descprod,double _saldo,String _datadep)
        {
            this.IdTran = _idtran;
            this.CodFornec = _codfornec;
            this.NomeFornec = _nomefornec;
            this.Obs = _obs;
            this.ValorMercado = _valormercado;
            this.ValorDesconto = _valordesconto;
            this.Quantidade = _quantidade;
            this.Saldo = _saldo;
            this.CodProd = _codprod;
            this.DescProd = _descprod;
            this.DataDep = _datadep;




        }

        private int _idtran;
        public int IdTran
        {
            get { return this._idtran; }
            set { this._idtran = value; }
        }
        private int _codfornec;
        public int CodFornec
        {
            get { return this._codfornec; }
            set { this._codfornec = value; }
        }
        private string _nomefornec;
        public string NomeFornec
        {
            get { return this._nomefornec; }
            set { this._nomefornec = value; }
        }
        private string _obs;
        public string Obs
        {
            get { return this._obs; }
            set { this._obs = value; }
        }
        private Double _valormercado;
        public Double ValorMercado
        {
            get { return this._valormercado; }
            set { this._valormercado = value; }
        }
        private Double _valordesconto;
        public Double ValorDesconto
        {
            get { return this._valordesconto; }
            set { this._valordesconto = value; }
        }
        private Double _quantidade;
        public Double Quantidade
        {
            get { return this._quantidade; }
            set { this._quantidade = value; }
        }
        private Double _saldo;
        public Double Saldo
        {
            get { return this._saldo; }
            set { this._saldo = value; }
        }
        private int _codprod;
        public int CodProd
        {
            get { return this._codprod; }
            set { this._codprod = value; }
        }
        private String _desprod;
        public String DescProd
        {
            get { return this._desprod; }
            set { this._desprod = value; }
        }
        private String _datadep;
        public String DataDep
        {
            get { return this._datadep; }
            set { this._datadep = value; }
        }
    }
}
