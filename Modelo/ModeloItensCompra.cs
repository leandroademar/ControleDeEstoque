using System;

namespace Modelo
{
    public class ModeloItensCompra
    {
        private int itc_cod;
        public int itcCod
        {
            get { return this.itc_cod; }
            set { this.itc_cod = value; }
        }

        private double itc_qtde;
        public double itcQtde
        {
            get { return this.itc_qtde; }
            set { this.itc_qtde = value; }
        }

        private double itc_valor;
        public double itcValor
        {
            get { return this.itc_valor; }
            set { this.itc_valor = value; }
        }
        private double itc_valorcompra;
        public double itcValorCompra
        {
            get { return this.itc_valorcompra; }
            set { this.itc_valorcompra = value; }
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
