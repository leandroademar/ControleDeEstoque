using System;

namespace Modelo
{
    public class ModeloItensVenda
    {
        private int itv_cod;
        public int ItvCod
        {
            get { return this.itv_cod; }
            set { this.itv_cod = value; }
        }

        private double itv_qtde;
        public double ItvQtde
        {
            get { return this.itv_qtde; }
            set { this.itv_qtde = value; }
        }

        private double itv_valor;
        public double ItvValor
        {
            get { return this.itv_valor; }
            set { this.itv_valor = value; }
        }

        private int ven_cod;
        public int VenCod
        {
            get { return this.ven_cod; }
            set { this.ven_cod = value; }
        }

        private int pro_cod;
        public int ProCod
        {
            get { return this.pro_cod; }
            set { this.pro_cod = value; }
        }
        private String pro_desc;
        public String ProDesc
        {
            get { return this.pro_desc; }
            set { this.pro_desc = value; }
        }
    }
}
