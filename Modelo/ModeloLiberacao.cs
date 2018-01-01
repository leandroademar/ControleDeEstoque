using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloLiberacao
    {
        public ModeloLiberacao()
       
            {
                this.VenCod = 0;
                this.VenData = DateTime.Now;
                this.VenNFiscal = 0;
                this.VenTotal = 0;
                this.VenNParcelas = 0;
                this.VenStatus = "PENDENTE";
                this.CliCod = 0;
                this.TpaCod = 0;
                this.VenNome = "";
                this.VenAtend = "";
                this.VenCaixa = "";
                this.VenDinheiro = 0;
                this.VenWinthor = 0;
                this.VenTotalgeral = 0;
            }

            public ModeloLiberacao(int venCod, DateTime data, int nFiscal, double total,
                int nParcelas, String status, int cliCod, int tpaCod, String vennome, String venatend, String vencaixa, Double venwinthor, Double vendinheiro, Double ventotalgeral)
            {
                this.VenCod = venCod;
                this.VenData = data;
                this.VenNFiscal = nFiscal;
                this.VenTotal = total;
                this.VenNParcelas = nParcelas;
                this.VenStatus = status;
                this.CliCod = cliCod;
                this.TpaCod = tpaCod;
                this.VenNome = vennome;
                this.VenAtend = venatend;
                this.VenCaixa = vencaixa;
                this.VenWinthor = venwinthor;
                this.VenDinheiro = vendinheiro;
                this.VenTotalgeral = ventotalgeral;
            }
        private int _ven_cod;
        public int VenCod
        {
            get
            {
                return this._ven_cod;
            }
            set
            {
                this._ven_cod = value;
            }
        }

        private DateTime _ven_data;
        public DateTime VenData
        {
            get { return this._ven_data; }
            set { this._ven_data = value; }
        }

        private int _ven_nfiscal;
        public int VenNFiscal
        {
            get { return this._ven_nfiscal; }
            set { this._ven_nfiscal = value; }
        }

        private Double _ven_total;
        public Double VenTotal
        {
            get { return this._ven_total; }
            set { this._ven_total = value; }
        }

        private int _ven_nparcelas;
        public int VenNParcelas
        {
            get { return this._ven_nparcelas; }
            set { this._ven_nparcelas = value; }
        }

        private String _ven_status;
        public String VenStatus
        {
            get { return this._ven_status; }
            set { this._ven_status = value; }

        }

        private int _cli_cod;
        public int CliCod
        {
            get { return this._cli_cod; }
            set { this._cli_cod = value; }
        }

        private int _tpa_cod;
        public int TpaCod
        {
            get { return this._tpa_cod; }
            set { this._tpa_cod = value; }
        }
        private string _ven_nome;
        public String VenNome
        {
            get { return this._ven_nome; }
            set { this._ven_nome = value; }
        }
        private string _ven_atend;
        public String VenAtend
        {
            get { return this._ven_atend; }
            set { this._ven_atend = value; }
        }
        private String _ven_caixa;
        public String VenCaixa
        {
            get { return this._ven_caixa; }
            set { this._ven_caixa = value; }
        }
        private Double _ven_winthor;
        public Double VenWinthor
        {
            get { return this._ven_winthor; }
            set { this._ven_winthor = value; }
        }
        private Double _ven_cartao;
        public Double VenCartao
        {
            get { return this._ven_cartao; }
            set { this._ven_cartao = value; }
        }
        private Double _ven_dinheiro;
        public Double VenDinheiro
        {
            get { return this._ven_dinheiro; }
            set { this._ven_dinheiro = value; }
        }
        private Double _ven_totalgeral;
        public Double VenTotalgeral
        {
            get { return this._ven_totalgeral; }
            set { this._ven_totalgeral = value; }
        }
    }
}

