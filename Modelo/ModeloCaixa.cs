using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloCaixa
    {
        public ModeloCaixa()
        {
            this.CaxId = 0;
            this.CaxTurno = 0;
            this.CaxNome = "";
            this.CaxVenda = 0;
            this.CaxDinheiro = 0.00;
            this.CaxCartao = 0.00;
            this.CaxPedido = 0.00;
            this.CaxWinthor = 0.00;
            this.CaxTotal = 0.00;
            this.CaxStatus = "";
            
        }

        public ModeloCaixa(int caxid, int caixaturno, String nome, int caxvenda, double caxdinheiro, double caxcartao, double caixapedido,double caixawinthor, double caixatotal, DateTime caxabertura, DateTime caxfechamento, string caxstatus)
        {
            this.CaxId = caxid;
            this.CaxTurno = caixaturno;
            this.CaxVenda = caxvenda;
            this.CaxNome = nome;
            this.CaxDinheiro = caxdinheiro;
            this.CaxCartao = caxcartao;
            this.CaxPedido = caixapedido;
            this.CaxWinthor = caixawinthor;
            this.CaxTotal = caixatotal;
            this.CaxAbertura = caxabertura;
            this.CaxFechamento = caxfechamento;
            this.CaxStatus = caxstatus;
            
            
        }

        private int cax_id;
        public int CaxId
        {
            get { return this.cax_id; }
            set { this.cax_id = value; }
        }
        private int cax_turno;
        public int CaxTurno
        {
            get { return this.cax_turno; }
            set { this.cax_turno = value; }
        }

        private String cax_nome;
        public String CaxNome
        {
            get { return this.cax_nome; }
            set { this.cax_nome = value; }
        }
        private int cax_venda;
        public int CaxVenda
        {
            get { return this.cax_venda; }
            set { this.cax_venda = value; }
        }
        private Double cax_dinheiro;
        public Double CaxDinheiro
        {
            get { return this.cax_dinheiro; }
            set { this.cax_dinheiro = value; }

        }
        private Double cax_cartao;
        public Double CaxCartao
        {
            get { return this.cax_cartao; }
            set { this.cax_cartao = value; }

        }
        private Double cax_pedido;
        public Double CaxPedido
        {
            get { return this.cax_pedido; }
            set { this.cax_pedido = value; }

        }
        private Double cax_winthor;
        public Double CaxWinthor
        {
            get { return this.cax_winthor; }
            set { this.cax_winthor = value; }

        }

        private Double cax_total;
        public Double CaxTotal
        {
            get { return this.cax_total; }
            set { this.cax_total = value; }

        }
        private DateTime cax_abertura;
        public DateTime CaxAbertura
        {
            get { return this.cax_abertura; }
            set { this.cax_abertura = value; }

        }
        private DateTime cax_fechamento;
        public DateTime CaxFechamento
        {
            get { return this.cax_fechamento; }
            set { this.cax_fechamento = value; }

        }
        private String cax_status;
        public String CaxStatus
        {
            get { return this.cax_status; }
            set { this.cax_status = value; }

        }
    }
}
