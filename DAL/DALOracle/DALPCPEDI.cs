using System;
using Modelo;
using Oracle.DataAccess.Client;
using System.Data;

namespace DAL
{
    public class DALPCPEDI
    {
        public DALTABConexao conexao;
        public DALPCPEDI(DALTABConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloPCPEDI modelo)
        {
            String comando1 = "";
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conexao.ObjetoConexao;
            comando1 = comando1 + "INSERT INTO PCPEDI " + "\n";
            comando1 = comando1 + "      (CODPROD, " + "\n";
            comando1 = comando1 + "       QT, " + "\n";
            comando1 = comando1 + "       PVENDA, " + "\n";
            comando1 = comando1 + "       NUMPED, " + "\n";
            comando1 = comando1 + "       DATA, " + "\n";
            if (modelo.codcli != null) { comando1 = comando1 + "	CODCLI, " + "\n"; }
            if (modelo.codusur != null) { comando1 = comando1 + "	CODUSUR, " + "\n"; }
            if (modelo.numcar != null) { comando1 = comando1 + "	NUMCAR, " + "\n"; }
            if (modelo.posicao != null) { comando1 = comando1 + "	POSICAO, " + "\n"; }
            if (modelo.st != null) { comando1 = comando1 + "	ST, " + "\n"; }
            if (modelo.vlcustoreal != null) { comando1 = comando1 + "	VLCUSTOREAL, " + "\n"; }
            if (modelo.vlcustofin != null) { comando1 = comando1 + "	VLCUSTOFIN, " + "\n"; }
            if (modelo.ptabela != null) { comando1 = comando1 + "	PTABELA, " + "\n"; }
            if (modelo.percom != null) { comando1 = comando1 + "	PERCOM, " + "\n"; }
            if (modelo.perdesc != null) { comando1 = comando1 + "	PERDESC, " + "\n"; }
            if (modelo.qtfalta != null) { comando1 = comando1 + "	QTFALTA, " + "\n"; }
            if (modelo.numseq != null) { comando1 = comando1 + "	NUMSEQ, " + "\n"; }
            if (modelo.vldesccustocmv != null) { comando1 = comando1 + "	VLDESCCUSTOCMV, " + "\n"; }
            if (modelo.vlcustocont != null) { comando1 = comando1 + "	VLCUSTOCONT, " + "\n"; }
            if (modelo.vlcustorep != null) { comando1 = comando1 + "	VLCUSTOREP, " + "\n"; }
            if (modelo.vldescsuframa != null) { comando1 = comando1 + "	VLDESCSUFRAMA, " + "\n"; }
            if (modelo.codst != null) { comando1 = comando1 + "	CODST, " + "\n"; }
            if (modelo.vldescfin != null) { comando1 = comando1 + "	VLDESCFIN, " + "\n"; }
            if (modelo.pvendabase != null) { comando1 = comando1 + "	PVENDABASE, " + "\n"; }
            if (modelo.vlipi != null) { comando1 = comando1 + "	VLIPI, " + "\n"; }
            if (modelo.percipi != null) { comando1 = comando1 + "	PERCIPI, " + "\n"; }
            if (modelo.poriginal != null) { comando1 = comando1 + "	PORIGINAL, " + "\n"; }
            if (modelo.iva != null) { comando1 = comando1 + "	IVA, " + "\n"; }
            if (modelo.pauta != null) { comando1 = comando1 + "	PAUTA, " + "\n"; }
            if (modelo.aliqicms1 != null) { comando1 = comando1 + "	ALIQICMS1, " + "\n"; }
            if (modelo.aliqicms2 != null) { comando1 = comando1 + "	ALIQICMS2, " + "\n"; }
            if (modelo.stclientegnre != null) { comando1 = comando1 + "	STCLIENTEGNRE, " + "\n"; }
            if (modelo.percbasered != null) { comando1 = comando1 + "	PERCBASERED, " + "\n"; }
            if (modelo.percbaseredst != null) { comando1 = comando1 + "	PERCBASEREDST, " + "\n"; }
            if (modelo.percbaseredstfonte != null) { comando1 = comando1 + "	PERCBASEREDSTFONTE, " + "\n"; }
            if (modelo.perfretecmv != null) { comando1 = comando1 + "	PERFRETECMV, " + "\n"; }
            if (modelo.custofinest != null) { comando1 = comando1 + "	CUSTOFINEST, " + "\n"; }
            if (modelo.perciss != null) { comando1 = comando1 + "	PERCISS, " + "\n"; }
            if (modelo.vliss != null) { comando1 = comando1 + "	VLISS, " + "\n"; }
            if (modelo.complemento != null) { comando1 = comando1 + "	COMPLEMENTO, " + "\n"; }
            if (modelo.pbaserca != null) { comando1 = comando1 + "	PBASERCA, " + "\n"; }
            if (modelo.vlverbacmv != null) { comando1 = comando1 + "	VLVERBACMV, " + "\n"; }
            if (modelo.numverbarebcmv != null) { comando1 = comando1 + "	NUMVERBAREBCMV, " + "\n"; }
            if (modelo.brinde != null) { comando1 = comando1 + "	BRINDE, " + "\n"; }
            if (modelo.baseicst != null) { comando1 = comando1 + "	BASEICST, " + "\n"; }
            if (modelo.qtcx != null) { comando1 = comando1 + "	QTCX, " + "\n"; }
            if (modelo.qtpecas != null) { comando1 = comando1 + "	QTPECAS, " + "\n"; }
            if (modelo.letracomiss != null) { comando1 = comando1 + "	LETRACOMISS, " + "\n"; }
            if (modelo.codauxiliar != null) { comando1 = comando1 + "	CODAUXILIAR, " + "\n"; }
            if (modelo.txvenda != null) { comando1 = comando1 + "	TXVENDA, " + "\n"; }
            if (modelo.codicmtab != null) { comando1 = comando1 + "	CODICMTAB, " + "\n"; }
            if (modelo.perdesccusto != null) { comando1 = comando1 + "	PERDESCCUSTO, " + "\n"; }
            if (modelo.codfilialretira != null) { comando1 = comando1 + "	CODFILIALRETIRA, " + "\n"; }
            if (modelo.eancodprod != null) { comando1 = comando1 + "	EANCODPROD, " + "\n"; }
            if (modelo.vldescicmisencao != null) { comando1 = comando1 + "	VLDESCICMISENCAO, " + "\n"; }
            if (modelo.perdescisentoicms != null) { comando1 = comando1 + "	PERDESCISENTOICMS, " + "\n"; }
            if (modelo.vlverbacmvcli != null) { comando1 = comando1 + "	VLVERBACMVCLI, " + "\n"; }
            if (modelo.pvenda1 != null) { comando1 = comando1 + "	PVENDA1, " + "\n"; }
            if (modelo.tipoentrega != null) { comando1 = comando1 + "	TIPOENTREGA, " + "\n"; }
            if (modelo.geragnreCnpjcliente != null) { comando1 = comando1 + "	GERAGNRE_CNPJCLIENTE, " + "\n"; }
            if (modelo.percdifaliquotas != null) { comando1 = comando1 + "	PERCDIFALIQUOTAS, " + "\n"; }
            if (modelo.basedifaliquotas != null) { comando1 = comando1 + "	BASEDIFALIQUOTAS, " + "\n"; }
            if (modelo.vldifaliquotas != null) { comando1 = comando1 + "	VLDIFALIQUOTAS, " + "\n"; }
            if (modelo.perdescpolitica != null) { comando1 = comando1 + "	PERDESCPOLITICA, " + "\n"; }
            if (modelo.pvendaanterior != null) { comando1 = comando1 + "	PVENDAANTERIOR, " + "\n"; }
            if (modelo.proddescricaocontrato != null) { comando1 = comando1 + "	PRODDESCRICAOCONTRATO, " + "\n"; }
            if (modelo.politicaprioritaria != null) { comando1 = comando1 + "	POLITICAPRIORITARIA, " + "\n"; }
            if (modelo.truncaritem != null) { comando1 = comando1 + "	TRUNCARITEM, " + "\n"; }
            if (modelo.qtunitemb != null) { comando1 = comando1 + "	QTUNITEMB, " + "\n"; }
            if (modelo.qtunitemb != null) { comando1 = comando1 + "	ROTINALANC, " + "\n"; }
            if (modelo.qtunitcx != null) { comando1 = comando1 + "	QTUNITCX, " + "\n"; }
            if (modelo.percdescpis != null) { comando1 = comando1 + "	PERCDESCPIS, " + "\n"; }
            if (modelo.vldescreducaopis != null) { comando1 = comando1 + "	VLDESCREDUCAOPIS, " + "\n"; }
            if (modelo.percdesccofins != null) { comando1 = comando1 + "	PERCDESCCOFINS, " + "\n"; }
            if (modelo.vldescreducaocofins != null) { comando1 = comando1 + "	VLDESCREDUCAOCOFINS, " + "\n"; }
            if (modelo.percom2 != null) { comando1 = comando1 + "	PERCOM2, " + "\n"; }
            if (modelo.percom3 != null) { comando1 = comando1 + "	PERCOM3, " + "\n"; }
            if (modelo.percom4 != null) { comando1 = comando1 + "	PERCOM4, " + "\n"; }
            if (modelo.coddesconto != null) { comando1 = comando1 + "	CODDESCONTO, " + "\n"; }
            if (modelo.vldescpissuframa != null) { comando1 = comando1 + "	VLDESCPISSUFRAMA, " + "\n"; }
            if (modelo.vlredpvendasimplesna != null) { comando1 = comando1 + "	VLREDPVENDASIMPLESNA, " + "\n"; }
            if (modelo.vlredcmvsimplesnac != null) { comando1 = comando1 + "	VLREDCMVSIMPLESNAC, " + "\n"; }
            if (modelo.codcontrato != null) { comando1 = comando1 + "	CODCONTRATO, " + "\n"; }
            if (modelo.vlrepasse != null) { comando1 = comando1 + "	VLREPASSE, " + "\n"; }
            if (modelo.perbonific != null) { comando1 = comando1 + "	PERBONIFIC, " + "\n"; }
            if (modelo.vlbonific != null) { comando1 = comando1 + "	VLBONIFIC, " + "\n"; }
            if (modelo.perdesccom != null) { comando1 = comando1 + "	PERDESCCOM, " + "\n"; }
            if (modelo.vldesccom != null) { comando1 = comando1 + "	VLDESCCOM, " + "\n"; }
            if (modelo.vloutros != null) { comando1 = comando1 + "	VLOUTROS, " + "\n"; }
            if (modelo.descprecofab != null) { comando1 = comando1 + "	DESCPRECOFAB, " + "\n"; }
            if (modelo.precomaxconsum != null) { comando1 = comando1 + "	PRECOMAXCONSUM, " + "\n"; }
            if (modelo.qtlitragem != null) { comando1 = comando1 + "	QTLITRAGEM, " + "\n"; }
            if (modelo.rotinalancbrinde != null) { comando1 = comando1 + "	ROTINALANCBRINDE, " + "\n"; }
            if (modelo.percdescabatimento != null) { comando1 = comando1 + "	PERCDESCABATIMENTO, " + "\n"; }
            if (modelo.vldescabatimento != null) { comando1 = comando1 + "	VLDESCABATIMENTO, " + "\n"; }
            if (modelo.pbonific != null) { comando1 = comando1 + "	PBONIFIC, " + "\n"; }
            if (modelo.bonific != null) { comando1 = comando1 + "	BONIFIC, " + "\n"; }
            if (modelo.numitemped != null) { comando1 = comando1 + "	NUMITEMPED, " + "\n"; }
            if (modelo.perdescpauta != null) { comando1 = comando1 + "	PERDESCPAUTA, " + "\n"; }
            if (modelo.origemst != null) { comando1 = comando1 + "	ORIGEMST, " + "\n"; }
            if (modelo.codformula != null) { comando1 = comando1 + "	CODFORMULA, " + "\n"; }
            if (modelo.codbase != null) { comando1 = comando1 + "	CODBASE, " + "\n"; }
            if (modelo.siglaqualidade != null) { comando1 = comando1 + "	SIGLAQUALIDADE, " + "\n"; }
            if (modelo.alternativo != null) { comando1 = comando1 + "	ALTERNATIVO, " + "\n"; }
            if (modelo.volumedesejado != null) { comando1 = comando1 + "	VOLUMEDESEJADO, " + "\n"; }
            if (modelo.qtdiasentregaitem != null) { comando1 = comando1 + "	QTDIASENTREGAITEM, " + "\n"; }
            if (modelo.numerorecopi != null) { comando1 = comando1 + "	NUMERORECOPI, " + "\n"; }
            if (modelo.usaunidademaster != null) { comando1 = comando1 + "	USAUNIDADEMASTER, " + "\n"; }
            if (modelo.codcombo != null) { comando1 = comando1 + "	CODCOMBO, " + "\n"; }
            if (modelo.numseqitemcontrato != null) { comando1 = comando1 + "	NUMSEQITEMCONTRATO, " + "\n"; }
            if (modelo.percredaliqipi != null) { comando1 = comando1 + "	PERCREDALIQIPI, " + "\n"; }
            if (modelo.numseqcestabasica != null) { comando1 = comando1 + "	NUMSEQCESTABASICA, " + "\n"; }
            if (modelo.codprodcesta != null) { comando1 = comando1 + "	CODPRODCESTA, " + "\n"; }
            if (modelo.coddescontobaserca != null) { comando1 = comando1 + "	CODDESCONTOBASERCA, " + "\n"; }
            if (modelo.aliqfcp != null) { comando1 = comando1 + "	ALIQFCP, " + "\n"; }
            if (modelo.aliqinternadest != null) { comando1 = comando1 + "	ALIQINTERNADEST, " + "\n"; }
            if (modelo.vlfcppart != null) { comando1 = comando1 + "	VLFCPPART, " + "\n"; }
            if (modelo.vlicmspartdest != null) { comando1 = comando1 + "	VLICMSPARTDEST, " + "\n"; }
            if (modelo.vlicmspart != null) { comando1 = comando1 + "	VLICMSPART, " + "\n"; }
            if (modelo.percprovpart != null) { comando1 = comando1 + "	PERCPROVPART, " + "\n"; }
            if (modelo.vlicmsdifaliqpart != null) { comando1 = comando1 + "	VLICMSDIFALIQPART, " + "\n"; }
            if (modelo.percbaseredpart != null) { comando1 = comando1 + "	PERCBASEREDPART, " + "\n"; }
            if (modelo.vlicmspartrem != null) { comando1 = comando1 + "	VLICMSPARTREM, " + "\n"; }
            if (modelo.aliqinterorigpart != null) { comando1 = comando1 + "	ALIQINTERORIGPART, " + "\n"; }
            if (modelo.vlbasepartdest != null) { comando1 = comando1 + "	VLBASEPARTDEST, " + "\n"; }
            if (modelo.vlipiptabela != null) { comando1 = comando1 + "	VLIPIPTABELA, " + "\n"; }
            if (modelo.vlipipbaserca != null) { comando1 = comando1 + "	VLIPIPBASERCA, " + "\n"; }
            if (modelo.stptabela != null) { comando1 = comando1 + "	STPTABELA, " + "\n"; }
            if (modelo.stpbaserca != null) { comando1 = comando1 + "	STPBASERCA, " + "\n"; }
            if (modelo.vlicmspartptabela != null) { comando1 = comando1 + "	VLICMSPARTPTABELA, " + "\n"; }
            if (modelo.vlicmspartpbaserca != null) { comando1 = comando1 + "	VLICMSPARTPBASERCA, " + "\n"; }
            if (modelo.unidade != null) { comando1 = comando1 + "	UNIDADE, " + "\n"; }
            if (modelo.coddescontosimulador != null) { comando1 = comando1 + "	CODDESCONTOSIMULADOR, " + "\n"; }
            if (modelo.codfigvendatriangular != null) { comando1 = comando1 + "	CODFIGVENDATRIANGULAR, " + "\n"; }
            if (modelo.codfiscal != null) { comando1 = comando1 + "	CODFISCAL, " + "\n"; }
            if (modelo.sittribut != null) { comando1 = comando1 + "	SITTRIBUT, " + "\n"; }
            if (modelo.ptabelafabricazfm != null) { comando1 = comando1 + "	PTABELAFABRICAZFM, " + "\n"; }
            if (modelo.origmerctrib != null) { comando1 = comando1 + "	ORIGMERCTRIB, " + "\n"; }
            if (modelo.vldesccarcaca != null) { comando1 = comando1 + "	VLDESCCARCACA, " + "\n"; }
            if (modelo.log1 != null) { comando1 = comando1 + "	LOG1, " + "\n"; }
            if (modelo.log2 != null) { comando1 = comando1 + "	LOG2, " + "\n"; }
            if (modelo.log3 != null) { comando1 = comando1 + "	LOG3, " + "\n"; }
            comando1 = comando1 + "       DEVOLUCAOCARCACA " + "\n";
            comando1 = comando1 + "    ) " + "\n";
            comando1 = comando1 + "    VALUES " + "\n";
            comando1 = comando1 + "      (:CODPROD, " + "\n";
            comando1 = comando1 + "       :QT, " + "\n";
            comando1 = comando1 + "       :PVENDA, " + "\n";
            comando1 = comando1 + "       :NUMPED, " + "\n";
            comando1 = comando1 + "       :DATA, " + "\n";
            if (modelo.codcli != null) { comando1 = comando1 + ":CODCLI," + "\n"; }
            if (modelo.codusur != null) { comando1 = comando1 + ":CODUSUR," + "\n"; }
            if (modelo.numcar != null) { comando1 = comando1 + ":NUMCAR," + "\n"; }
            if (modelo.posicao != null) { comando1 = comando1 + ":POSICAO," + "\n"; }
            if (modelo.st != null) { comando1 = comando1 + ":ST," + "\n"; }
            if (modelo.vlcustoreal != null) { comando1 = comando1 + ":VLCUSTOREAL," + "\n"; }
            if (modelo.vlcustofin != null) { comando1 = comando1 + ":VLCUSTOFIN," + "\n"; }
            if (modelo.ptabela != null) { comando1 = comando1 + ":PTABELA," + "\n"; }
            if (modelo.percom != null) { comando1 = comando1 + ":PERCOM," + "\n"; }
            if (modelo.perdesc != null) { comando1 = comando1 + ":PERDESC," + "\n"; }
            if (modelo.qtfalta != null) { comando1 = comando1 + ":QTFALTA," + "\n"; }
            if (modelo.numseq != null) { comando1 = comando1 + ":NUMSEQ," + "\n"; }
            if (modelo.vldesccustocmv != null) { comando1 = comando1 + ":VLDESCCUSTOCMV," + "\n"; }
            if (modelo.vlcustocont != null) { comando1 = comando1 + ":VLCUSTOCONT," + "\n"; }
            if (modelo.vlcustorep != null) { comando1 = comando1 + ":VLCUSTOREP," + "\n"; }
            if (modelo.vldescsuframa != null) { comando1 = comando1 + ":VLDESCSUFRAMA," + "\n"; }
            if (modelo.codst != null) { comando1 = comando1 + ":CODST," + "\n"; }
            if (modelo.vldescfin != null) { comando1 = comando1 + ":VLDESCFIN," + "\n"; }
            if (modelo.pvendabase != null) { comando1 = comando1 + ":PVENDABASE," + "\n"; }
            if (modelo.vlipi != null) { comando1 = comando1 + ":VLIPI," + "\n"; }
            if (modelo.percipi != null) { comando1 = comando1 + ":PERCIPI," + "\n"; }
            if (modelo.poriginal != null) { comando1 = comando1 + ":PORIGINAL," + "\n"; }
            if (modelo.iva != null) { comando1 = comando1 + ":IVA," + "\n"; }
            if (modelo.pauta != null) { comando1 = comando1 + ":PAUTA," + "\n"; }
            if (modelo.aliqicms1 != null) { comando1 = comando1 + ":ALIQICMS1," + "\n"; }
            if (modelo.aliqicms2 != null) { comando1 = comando1 + ":ALIQICMS2," + "\n"; }
            if (modelo.stclientegnre != null) { comando1 = comando1 + ":STCLIENTEGNRE," + "\n"; }
            if (modelo.percbasered != null) { comando1 = comando1 + ":PERCBASERED," + "\n"; }
            if (modelo.percbaseredst != null) { comando1 = comando1 + ":PERCBASEREDST," + "\n"; }
            if (modelo.percbaseredstfonte != null) { comando1 = comando1 + ":PERCBASEREDSTFONTE," + "\n"; }
            if (modelo.perfretecmv != null) { comando1 = comando1 + ":PERFRETECMV," + "\n"; }
            if (modelo.custofinest != null) { comando1 = comando1 + ":CUSTOFINEST," + "\n"; }
            if (modelo.perciss != null) { comando1 = comando1 + ":PERCISS," + "\n"; }
            if (modelo.vliss != null) { comando1 = comando1 + ":VLISS," + "\n"; }
            if (modelo.complemento != null) { comando1 = comando1 + ":COMPLEMENTO," + "\n"; }
            if (modelo.pbaserca != null) { comando1 = comando1 + ":PBASERCA," + "\n"; }
            if (modelo.vlverbacmv != null) { comando1 = comando1 + ":VLVERBACMV," + "\n"; }
            if (modelo.numverbarebcmv != null) { comando1 = comando1 + ":NUMVERBAREBCMV," + "\n"; }
            if (modelo.brinde != null) { comando1 = comando1 + ":BRINDE," + "\n"; }
            if (modelo.baseicst != null) { comando1 = comando1 + ":BASEICST," + "\n"; }
            if (modelo.qtcx != null) { comando1 = comando1 + ":QTCX," + "\n"; }
            if (modelo.qtpecas != null) { comando1 = comando1 + ":QTPECAS," + "\n"; }
            if (modelo.letracomiss != null) { comando1 = comando1 + ":LETRACOMISS," + "\n"; }
            if (modelo.codauxiliar != null) { comando1 = comando1 + ":CODAUXILIAR," + "\n"; }
            if (modelo.txvenda != null) { comando1 = comando1 + ":TXVENDA," + "\n"; }
            if (modelo.codicmtab != null) { comando1 = comando1 + ":CODICMTAB," + "\n"; }
            if (modelo.perdesccusto != null) { comando1 = comando1 + ":PERDESCCUSTO," + "\n"; }
            if (modelo.codfilialretira != null) { comando1 = comando1 + ":CODFILIALRETIRA," + "\n"; }
            if (modelo.eancodprod != null) { comando1 = comando1 + ":EANCODPROD," + "\n"; }
            if (modelo.vldescicmisencao != null) { comando1 = comando1 + ":VLDESCICMISENCAO," + "\n"; }
            if (modelo.perdescisentoicms != null) { comando1 = comando1 + ":PERDESCISENTOICMS," + "\n"; }
            if (modelo.vlverbacmvcli != null) { comando1 = comando1 + ":VLVERBACMVCLI," + "\n"; }
            if (modelo.pvenda1 != null) { comando1 = comando1 + ":PVENDA1," + "\n"; }
            if (modelo.tipoentrega != null) { comando1 = comando1 + ":TIPOENTREGA," + "\n"; }
            if (modelo.geragnreCnpjcliente != null) { comando1 = comando1 + ":GERAGNRECNPJCLIENTE," + "\n"; }
            if (modelo.percdifaliquotas != null) { comando1 = comando1 + ":PERCDIFALIQUOTAS," + "\n"; }
            if (modelo.basedifaliquotas != null) { comando1 = comando1 + ":BASEDIFALIQUOTAS," + "\n"; }
            if (modelo.vldifaliquotas != null) { comando1 = comando1 + ":VLDIFALIQUOTAS," + "\n"; }
            if (modelo.perdescpolitica != null) { comando1 = comando1 + ":PERDESCPOLITICA," + "\n"; }
            if (modelo.pvendaanterior != null) { comando1 = comando1 + ":PVENDAANTERIOR," + "\n"; }
            if (modelo.proddescricaocontrato != null) { comando1 = comando1 + ":PRODDESCRICAOCONTRATO," + "\n"; }
            if (modelo.politicaprioritaria != null) { comando1 = comando1 + ":POLITICAPRIORITARIA," + "\n"; }
            if (modelo.truncaritem != null) { comando1 = comando1 + ":TRUNCARITEM," + "\n"; }
            if (modelo.qtunitemb != null) { comando1 = comando1 + ":QTUNITEMB," + "\n"; }
            comando1 = comando1 + "316, " + "\n";
           // if (modelo.qtunitemb != null) { comando1 = comando1 + ":ROTINALANC," + "\n"; }
            if (modelo.qtunitcx != null) { comando1 = comando1 + ":QTUNITCX," + "\n"; }
            if (modelo.percdescpis != null) { comando1 = comando1 + ":PERCDESCPIS," + "\n"; }
            if (modelo.vldescreducaopis != null) { comando1 = comando1 + ":VLDESCREDUCAOPIS," + "\n"; }
            if (modelo.percdesccofins != null) { comando1 = comando1 + ":PERCDESCCOFINS," + "\n"; }
            if (modelo.vldescreducaocofins != null) { comando1 = comando1 + ":VLDESCREDUCAOCOFINS," + "\n"; }
            if (modelo.percom2 != null) { comando1 = comando1 + ":PERCOM2," + "\n"; }
            if (modelo.percom3 != null) { comando1 = comando1 + ":PERCOM3," + "\n"; }
            if (modelo.percom4 != null) { comando1 = comando1 + ":PERCOM4," + "\n"; }
            if (modelo.coddesconto != null) { comando1 = comando1 + ":CODDESCONTO," + "\n"; }
            if (modelo.vldescpissuframa != null) { comando1 = comando1 + ":VLDESCPISSUFRAMA," + "\n"; }
            if (modelo.vlredpvendasimplesna != null) { comando1 = comando1 + ":VLREDPVENDASIMPLESNA," + "\n"; }
            if (modelo.vlredcmvsimplesnac != null) { comando1 = comando1 + ":VLREDCMVSIMPLESNAC," + "\n"; }
            if (modelo.codcontrato != null) { comando1 = comando1 + ":CODCONTRATO," + "\n"; }
            if (modelo.vlrepasse != null) { comando1 = comando1 + ":VLREPASSE," + "\n"; }
            if (modelo.perbonific != null) { comando1 = comando1 + ":PERBONIFIC," + "\n"; }
            if (modelo.vlbonific != null) { comando1 = comando1 + ":VLBONIFIC," + "\n"; }
            if (modelo.perdesccom != null) { comando1 = comando1 + ":PERDESCCOM," + "\n"; }
            if (modelo.vldesccom != null) { comando1 = comando1 + ":VLDESCCOM," + "\n"; }
            if (modelo.vloutros != null) { comando1 = comando1 + ":VLOUTROS," + "\n"; }
            if (modelo.descprecofab != null) { comando1 = comando1 + ":DESCPRECOFAB," + "\n"; }
            if (modelo.precomaxconsum != null) { comando1 = comando1 + ":PRECOMAXCONSUM," + "\n"; }
            if (modelo.qtlitragem != null) { comando1 = comando1 + ":QTLITRAGEM," + "\n"; }
            if (modelo.rotinalancbrinde != null) { comando1 = comando1 + ":ROTINALANCBRINDE," + "\n"; }
            if (modelo.percdescabatimento != null) { comando1 = comando1 + ":PERCDESCABATIMENTO," + "\n"; }
            if (modelo.vldescabatimento != null) { comando1 = comando1 + ":VLDESCABATIMENTO," + "\n"; }
            if (modelo.pbonific != null) { comando1 = comando1 + ":PBONIFIC," + "\n"; }
            if (modelo.bonific != null) { comando1 = comando1 + ":BONIFIC," + "\n"; }
            if (modelo.numitemped != null) { comando1 = comando1 + ":NUMITEMPED," + "\n"; }
            if (modelo.perdescpauta != null) { comando1 = comando1 + ":PERDESCPAUTA," + "\n"; }
            if (modelo.origemst != null) { comando1 = comando1 + ":ORIGEMST," + "\n"; }
            if (modelo.codformula != null) { comando1 = comando1 + ":CODFORMULA," + "\n"; }
            if (modelo.codbase != null) { comando1 = comando1 + ":CODBASE," + "\n"; }
            if (modelo.siglaqualidade != null) { comando1 = comando1 + ":SIGLAQUALIDADE," + "\n"; }
            if (modelo.alternativo != null) { comando1 = comando1 + ":ALTERNATIVO," + "\n"; }
            if (modelo.volumedesejado != null) { comando1 = comando1 + ":VOLUMEDESEJADO," + "\n"; }
            if (modelo.qtdiasentregaitem != null) { comando1 = comando1 + ":QTDIASENTREGAITEM," + "\n"; }
            if (modelo.numerorecopi != null) { comando1 = comando1 + ":NUMERORECOPI," + "\n"; }
            if (modelo.usaunidademaster != null) { comando1 = comando1 + ":USAUNIDADEMASTER," + "\n"; }
            if (modelo.codcombo != null) { comando1 = comando1 + ":CODCOMBO," + "\n"; }
            if (modelo.numseqitemcontrato != null) { comando1 = comando1 + ":NUMSEQITEMCONTRATO," + "\n"; }
            if (modelo.percredaliqipi != null) { comando1 = comando1 + ":PERCREDALIQIPI," + "\n"; }
            if (modelo.numseqcestabasica != null) { comando1 = comando1 + ":NUMSEQCESTABASICA," + "\n"; }
            if (modelo.codprodcesta != null) { comando1 = comando1 + ":CODPRODCESTA," + "\n"; }
            if (modelo.coddescontobaserca != null) { comando1 = comando1 + ":CODDESCONTOBASERCA," + "\n"; }
            if (modelo.aliqfcp != null) { comando1 = comando1 + ":ALIQFCP," + "\n"; }
            if (modelo.aliqinternadest != null) { comando1 = comando1 + ":ALIQINTERNADEST," + "\n"; }
            if (modelo.vlfcppart != null) { comando1 = comando1 + ":VLFCPPART," + "\n"; }
            if (modelo.vlicmspartdest != null) { comando1 = comando1 + ":VLICMSPARTDEST," + "\n"; }
            if (modelo.vlicmspart != null) { comando1 = comando1 + ":VLICMSPART," + "\n"; }
            if (modelo.percprovpart != null) { comando1 = comando1 + ":PERCPROVPART," + "\n"; }
            if (modelo.vlicmsdifaliqpart != null) { comando1 = comando1 + ":VLICMSDIFALIQPART," + "\n"; }
            if (modelo.percbaseredpart != null) { comando1 = comando1 + ":PERCBASEREDPART," + "\n"; }
            if (modelo.vlicmspartrem != null) { comando1 = comando1 + ":VLICMSPARTREM," + "\n"; }
            if (modelo.aliqinterorigpart != null) { comando1 = comando1 + ":ALIQINTERORIGPART," + "\n"; }
            if (modelo.vlbasepartdest != null) { comando1 = comando1 + ":VLBASEPARTDEST," + "\n"; }
            if (modelo.vlipiptabela != null) { comando1 = comando1 + ":VLIPIPTABELA," + "\n"; }
            if (modelo.vlipipbaserca != null) { comando1 = comando1 + ":VLIPIPBASERCA," + "\n"; }
            if (modelo.stptabela != null) { comando1 = comando1 + ":STPTABELA," + "\n"; }
            if (modelo.stpbaserca != null) { comando1 = comando1 + ":STPBASERCA," + "\n"; }
            if (modelo.vlicmspartptabela != null) { comando1 = comando1 + ":VLICMSPARTPTABELA," + "\n"; }
            if (modelo.vlicmspartpbaserca != null) { comando1 = comando1 + ":VLICMSPARTPBASERCA," + "\n"; }
            if (modelo.unidade != null) { comando1 = comando1 + ":UNIDADE," + "\n"; }
            if (modelo.coddescontosimulador != null) { comando1 = comando1 + ":CODDESCONTOSIMULADOR," + "\n"; }
            if (modelo.codfigvendatriangular != null) { comando1 = comando1 + ":CODFIGVENDATRIANGULAR," + "\n"; }
            if (modelo.codfiscal != null) { comando1 = comando1 + ":CODFISCAL," + "\n"; }
            if (modelo.sittribut != null) { comando1 = comando1 + ":SITTRIBUT," + "\n"; }
            if (modelo.ptabelafabricazfm != null) { comando1 = comando1 + ":PTABELAFABRICAZFM," + "\n"; }
            if (modelo.origmerctrib != null) { comando1 = comando1 + ":ORIGMERCTRIB," + "\n"; }
            if (modelo.vldesccarcaca != null) { comando1 = comando1 + ":VLDESCCARCACA," + "\n"; }
            if (modelo.log1 != null) { comando1 = comando1 + ":LOG1," + "\n"; }
            if (modelo.log2 != null) { comando1 = comando1 + ":LOG2," + "\n"; }
            if (modelo.log3 != null) { comando1 = comando1 + ":LOG3," + "\n"; }
            comando1 = comando1 + "       :DEVOLUCAOCARCACA " + "\n";
            comando1 = comando1 + "       )";
            cmd.CommandText = comando1;
            cmd.Parameters.Add(new OracleParameter(":CODPROD", modelo.codprod));
            cmd.Parameters.Add(new OracleParameter(":QT", modelo.qt));
            cmd.Parameters.Add(new OracleParameter(":PVENDA", modelo.pvenda));
            cmd.Parameters.Add(new OracleParameter(":NUMPED", modelo.numped));
            cmd.Parameters.Add(new OracleParameter(":DATA", modelo.data));
            cmd.Parameters.Add(new OracleParameter(":CODCLI", modelo.codcli));
            cmd.Parameters.Add(new OracleParameter(":CODUSUR", modelo.codusur));
            cmd.Parameters.Add(new OracleParameter(":NUMCAR", modelo.numcar));
            cmd.Parameters.Add(new OracleParameter(":POSICAO", modelo.posicao));
            cmd.Parameters.Add(new OracleParameter(":ST", modelo.st));
            cmd.Parameters.Add(new OracleParameter(":VLCUSTOREAL", modelo.vlcustoreal));
            cmd.Parameters.Add(new OracleParameter(":VLCUSTOFIN", modelo.vlcustofin));
            cmd.Parameters.Add(new OracleParameter(":PTABELA", modelo.ptabela));
            cmd.Parameters.Add(new OracleParameter(":PERCOM", modelo.percom));
            cmd.Parameters.Add(new OracleParameter(":PERDESC", modelo.perdesc));
            cmd.Parameters.Add(new OracleParameter(":QTFALTA", modelo.qtfalta));
            cmd.Parameters.Add(new OracleParameter(":NUMSEQ", modelo.numseq));
            cmd.Parameters.Add(new OracleParameter(":VLDESCCUSTOCMV", modelo.vldesccustocmv));
            cmd.Parameters.Add(new OracleParameter(":VLCUSTOCONT", modelo.vlcustocont));
            cmd.Parameters.Add(new OracleParameter(":VLCUSTOREP", modelo.vlcustorep));
            cmd.Parameters.Add(new OracleParameter(":VLDESCSUFRAMA", modelo.vldescsuframa));
            cmd.Parameters.Add(new OracleParameter(":CODST", modelo.codst));
            cmd.Parameters.Add(new OracleParameter(":VLDESCFIN", modelo.vldescfin));
            cmd.Parameters.Add(new OracleParameter(":PVENDABASE", modelo.pvendabase));
            cmd.Parameters.Add(new OracleParameter(":VLIPI", modelo.vlipi));
            cmd.Parameters.Add(new OracleParameter(":PERCIPI", modelo.percipi));
            cmd.Parameters.Add(new OracleParameter(":PORIGINAL", modelo.poriginal));
            cmd.Parameters.Add(new OracleParameter(":IVA", modelo.iva));
            cmd.Parameters.Add(new OracleParameter(":PAUTA", modelo.pauta));
            cmd.Parameters.Add(new OracleParameter(":ALIQICMS1", modelo.aliqicms1));
            cmd.Parameters.Add(new OracleParameter(":ALIQICMS2", modelo.aliqicms2));
            cmd.Parameters.Add(new OracleParameter(":STCLIENTEGNRE", modelo.stclientegnre));
            cmd.Parameters.Add(new OracleParameter(":PERCBASERED", modelo.percbasered));
            cmd.Parameters.Add(new OracleParameter(":PERCBASEREDST", modelo.percbaseredst));
            cmd.Parameters.Add(new OracleParameter(":PERCBASEREDSTFONTE", modelo.percbaseredstfonte));
            cmd.Parameters.Add(new OracleParameter(":PERFRETECMV", modelo.perfretecmv));
            cmd.Parameters.Add(new OracleParameter(":CUSTOFINEST", modelo.custofinest));
            cmd.Parameters.Add(new OracleParameter(":PERCISS", modelo.perciss));
            cmd.Parameters.Add(new OracleParameter(":VLISS", modelo.vliss));
            cmd.Parameters.Add(new OracleParameter(":COMPLEMENTO", modelo.complemento));
            cmd.Parameters.Add(new OracleParameter(":PBASERCA", modelo.pbaserca));
            cmd.Parameters.Add(new OracleParameter(":VLVERBACMV", modelo.vlverbacmv));
            cmd.Parameters.Add(new OracleParameter(":NUMVERBAREBCMV", modelo.numverbarebcmv));
            cmd.Parameters.Add(new OracleParameter(":BRINDE", modelo.brinde));
            cmd.Parameters.Add(new OracleParameter(":BASEICST", modelo.baseicst));
            cmd.Parameters.Add(new OracleParameter(":QTCX", modelo.qtcx));
            cmd.Parameters.Add(new OracleParameter(":QTPECAS", modelo.qtpecas));
            cmd.Parameters.Add(new OracleParameter(":LETRACOMISS", modelo.letracomiss));
            cmd.Parameters.Add(new OracleParameter(":CODAUXILIAR", modelo.codauxiliar));
            cmd.Parameters.Add(new OracleParameter(":TXVENDA", modelo.txvenda));
            cmd.Parameters.Add(new OracleParameter(":CODICMTAB", modelo.codicmtab));
            cmd.Parameters.Add(new OracleParameter(":PERDESCCUSTO", modelo.perdesccusto));
            cmd.Parameters.Add(new OracleParameter(":CODFILIALRETIRA", modelo.codfilialretira));
            cmd.Parameters.Add(new OracleParameter(":EANCODPROD", modelo.eancodprod));
            cmd.Parameters.Add(new OracleParameter(":VLDESCICMISENCAO", modelo.vldescicmisencao));
            cmd.Parameters.Add(new OracleParameter(":PERDESCISENTOICMS", modelo.perdescisentoicms));
            cmd.Parameters.Add(new OracleParameter(":VLVERBACMVCLI", modelo.vlverbacmvcli));
            cmd.Parameters.Add(new OracleParameter(":PVENDA1", modelo.pvenda1));
            cmd.Parameters.Add(new OracleParameter(":TIPOENTREGA", modelo.tipoentrega));
            cmd.Parameters.Add(new OracleParameter(":GERAGNRECNPJCLIENTE", modelo.geragnreCnpjcliente));
            cmd.Parameters.Add(new OracleParameter(":PERCDIFALIQUOTAS", modelo.percdifaliquotas));
            cmd.Parameters.Add(new OracleParameter(":BASEDIFALIQUOTAS", modelo.basedifaliquotas));
            cmd.Parameters.Add(new OracleParameter(":VLDIFALIQUOTAS", modelo.vldifaliquotas));
            cmd.Parameters.Add(new OracleParameter(":PERDESCPOLITICA", modelo.perdescpolitica));
            cmd.Parameters.Add(new OracleParameter(":PVENDAANTERIOR", modelo.pvendaanterior));
            cmd.Parameters.Add(new OracleParameter(":PRODDESCRICAOCONTRATO", modelo.proddescricaocontrato));
            cmd.Parameters.Add(new OracleParameter(":POLITICAPRIORITARIA", modelo.politicaprioritaria));
            cmd.Parameters.Add(new OracleParameter(":TRUNCARITEM", modelo.truncaritem));
            cmd.Parameters.Add(new OracleParameter(":QTUNITEMB", modelo.qtunitemb));
            cmd.Parameters.Add(new OracleParameter(":QTUNITCX", modelo.qtunitcx));
            cmd.Parameters.Add(new OracleParameter(":PERCDESCPIS", modelo.percdescpis));
            cmd.Parameters.Add(new OracleParameter(":VLDESCREDUCAOPIS", modelo.vldescreducaopis));
            cmd.Parameters.Add(new OracleParameter(":PERCDESCCOFINS", modelo.percdesccofins));
            cmd.Parameters.Add(new OracleParameter(":VLDESCREDUCAOCOFINS", modelo.vldescreducaocofins));
            cmd.Parameters.Add(new OracleParameter(":PERCOM2", modelo.percom2));
            cmd.Parameters.Add(new OracleParameter(":PERCOM3", modelo.percom3));
            cmd.Parameters.Add(new OracleParameter(":PERCOM4", modelo.percom4));
            cmd.Parameters.Add(new OracleParameter(":CODDESCONTO", modelo.coddesconto));
            cmd.Parameters.Add(new OracleParameter(":VLDESCPISSUFRAMA", modelo.vldescpissuframa));
            cmd.Parameters.Add(new OracleParameter(":VLREDPVENDASIMPLESNA", modelo.vlredpvendasimplesna));
            cmd.Parameters.Add(new OracleParameter(":VLREDCMVSIMPLESNAC", modelo.vlredcmvsimplesnac));
            cmd.Parameters.Add(new OracleParameter(":CODCONTRATO", modelo.codcontrato));
            cmd.Parameters.Add(new OracleParameter(":VLREPASSE", modelo.vlrepasse));
            cmd.Parameters.Add(new OracleParameter(":PERBONIFIC", modelo.perbonific));
            cmd.Parameters.Add(new OracleParameter(":VLBONIFIC", modelo.vlbonific));
            cmd.Parameters.Add(new OracleParameter(":PERDESCCOM", modelo.perdesccom));
            cmd.Parameters.Add(new OracleParameter(":VLDESCCOM", modelo.vldesccom));
            cmd.Parameters.Add(new OracleParameter(":VLOUTROS", modelo.vloutros));
            cmd.Parameters.Add(new OracleParameter(":DESCPRECOFAB", modelo.descprecofab));
            cmd.Parameters.Add(new OracleParameter(":PRECOMAXCONSUM", modelo.precomaxconsum));
            cmd.Parameters.Add(new OracleParameter(":QTLITRAGEM", modelo.qtlitragem));
            cmd.Parameters.Add(new OracleParameter(":ROTINALANCBRINDE", modelo.rotinalancbrinde));
            cmd.Parameters.Add(new OracleParameter(":PERCDESCABATIMENTO", modelo.percdescabatimento));
            cmd.Parameters.Add(new OracleParameter(":VLDESCABATIMENTO", modelo.vldescabatimento));
            cmd.Parameters.Add(new OracleParameter(":PBONIFIC", modelo.pbonific));
            cmd.Parameters.Add(new OracleParameter(":BONIFIC", modelo.bonific));
            cmd.Parameters.Add(new OracleParameter(":NUMITEMPED", modelo.numitemped));
            cmd.Parameters.Add(new OracleParameter(":PERDESCPAUTA", modelo.perdescpauta));
            cmd.Parameters.Add(new OracleParameter(":ORIGEMST", modelo.origemst));
            cmd.Parameters.Add(new OracleParameter(":CODFORMULA", modelo.codformula));
            cmd.Parameters.Add(new OracleParameter(":CODBASE", modelo.codbase));
            cmd.Parameters.Add(new OracleParameter(":SIGLAQUALIDADE", modelo.siglaqualidade));
            cmd.Parameters.Add(new OracleParameter(":ALTERNATIVO", modelo.alternativo));
            cmd.Parameters.Add(new OracleParameter(":VOLUMEDESEJADO", modelo.volumedesejado));
            cmd.Parameters.Add(new OracleParameter(":QTDIASENTREGAITEM", modelo.qtdiasentregaitem));
            cmd.Parameters.Add(new OracleParameter(":NUMERORECOPI", modelo.numerorecopi));
            cmd.Parameters.Add(new OracleParameter(":USAUNIDADEMASTER", modelo.usaunidademaster));
            cmd.Parameters.Add(new OracleParameter(":CODCOMBO", modelo.codcombo));
            cmd.Parameters.Add(new OracleParameter(":NUMSEQITEMCONTRATO", modelo.numseqitemcontrato));
            cmd.Parameters.Add(new OracleParameter(":PERCREDALIQIPI", modelo.percredaliqipi));
            cmd.Parameters.Add(new OracleParameter(":NUMSEQCESTABASICA", modelo.numseqcestabasica));
            cmd.Parameters.Add(new OracleParameter(":CODPRODCESTA", modelo.codprodcesta));
            cmd.Parameters.Add(new OracleParameter(":CODDESCONTOBASERCA", modelo.coddescontobaserca));
            cmd.Parameters.Add(new OracleParameter(":ALIQFCP", modelo.aliqfcp));
            cmd.Parameters.Add(new OracleParameter(":ALIQINTERNADEST", modelo.aliqinternadest));
            cmd.Parameters.Add(new OracleParameter(":VLFCPPART", modelo.vlfcppart));
            cmd.Parameters.Add(new OracleParameter(":VLICMSPARTDEST", modelo.vlicmspartdest));
            cmd.Parameters.Add(new OracleParameter(":VLICMSPART", modelo.vlicmspart));
            cmd.Parameters.Add(new OracleParameter(":PERCPROVPART", modelo.percprovpart));
            cmd.Parameters.Add(new OracleParameter(":VLICMSDIFALIQPART", modelo.vlicmsdifaliqpart));
            cmd.Parameters.Add(new OracleParameter(":PERCBASEREDPART", modelo.percbaseredpart));
            cmd.Parameters.Add(new OracleParameter(":VLICMSPARTREM", modelo.vlicmspartrem));
            cmd.Parameters.Add(new OracleParameter(":ALIQINTERORIGPART", modelo.aliqinterorigpart));
            cmd.Parameters.Add(new OracleParameter(":VLBASEPARTDEST", modelo.vlbasepartdest));
            cmd.Parameters.Add(new OracleParameter(":VLIPIPTABELA", modelo.vlipiptabela));
            cmd.Parameters.Add(new OracleParameter(":VLIPIPBASERCA", modelo.vlipipbaserca));
            cmd.Parameters.Add(new OracleParameter(":STPTABELA", modelo.stptabela));
            cmd.Parameters.Add(new OracleParameter(":STPBASERCA", modelo.stpbaserca));
            cmd.Parameters.Add(new OracleParameter(":VLICMSPARTPTABELA", modelo.vlicmspartptabela));
            cmd.Parameters.Add(new OracleParameter(":VLICMSPARTPBASERCA", modelo.vlicmspartpbaserca));
            cmd.Parameters.Add(new OracleParameter(":UNIDADE", modelo.unidade));
            cmd.Parameters.Add(new OracleParameter(":CODDESCONTOSIMULADOR", modelo.coddescontosimulador));
            cmd.Parameters.Add(new OracleParameter(":CODFIGVENDATRIANGULAR", modelo.codfigvendatriangular));
            cmd.Parameters.Add(new OracleParameter(":CODFISCAL", modelo.codfiscal));
            cmd.Parameters.Add(new OracleParameter(":SITTRIBUT", modelo.sittribut));
            cmd.Parameters.Add(new OracleParameter(":PTABELAFABRICAZFM", modelo.ptabelafabricazfm));
            cmd.Parameters.Add(new OracleParameter(":ORIGMERCTRIB", modelo.origmerctrib));
            cmd.Parameters.Add(new OracleParameter(":VLDESCCARCACA", modelo.vldesccarcaca));
            cmd.Parameters.Add(new OracleParameter(":LOG1", modelo.log1));
            cmd.Parameters.Add(new OracleParameter(":LOG2", modelo.log2));
            cmd.Parameters.Add(new OracleParameter(":LOG3", modelo.log3));
            cmd.Parameters.Add(new OracleParameter(":DEVOLUCAOCARCACA", modelo.devolucaocarcaca));
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            //conexao.TerminarTransacao();
            conexao.Desconectar();
        }
        public void IncluirQT (ModeloPCPEDI modelo)
        {
            String comando1 = "";

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conexao.ObjetoConexao;
            comando1 = comando1 + "INSERT INTO TABPED " + "\n";
            comando1 = comando1 + "    (NUMPED, NUMPEDORI,CODPROD " + "\n";
            comando1 = comando1 + "     ,CODAUXILIAR, QT,QTUNITEMB) " + "\n";
            comando1 = comando1 + "    VALUES " + "\n";
            comando1 = comando1 + "    (:NUMPED,:NUMPEDORI, :CODPROD,:CODAUXILIAR,:QT " + "\n";
            comando1 = comando1 + "     ,:QTUNITEMB)";
            cmd.CommandText = comando1;
            cmd.Parameters.Add(new OracleParameter(":NUMPED", modelo.numped));
            cmd.Parameters.Add(new OracleParameter(":NUMPEDORI", modelo.oldnumped));
            cmd.Parameters.Add(new OracleParameter(":CODPROD", modelo.codprod));
            cmd.Parameters.Add(new OracleParameter(":CODAUXILIAR", modelo.codauxiliar));
            cmd.Parameters.Add(new OracleParameter(":QT", modelo.qt));
            cmd.Parameters.Add(new OracleParameter(":QTUNITEMB", modelo.qtunitemb));
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            //conexao.TerminarTransacao();
            conexao.Desconectar();

        }
        public void IncluirDUP(ModeloPCPEDI modelo)
        {
            String comando1 = "";

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conexao.ObjetoConexao;
            comando1 = comando1 + "INSERT INTO TABDUP " + "\n";
            comando1 = comando1 + "    (NUMPED,DATA,CODPROD,CODAUXILIAR,QT,QTUNITEMB,PVENDA) " + "\n";
            comando1 = comando1 + "    VALUES " + "\n";
            comando1 = comando1 + "    (:NUMPED, TO_DATE(SYSDATE, 'DD/MM/YYYY'),:CODPROD,:CODAUXILIAR,:QT,:QTUNITEMB,:PVENDA) " + "\n";
            cmd.CommandText = comando1;
            cmd.Parameters.Add(new OracleParameter(":NUMPED", modelo.numped));
            cmd.Parameters.Add(new OracleParameter(":CODPROD", modelo.codprod));
            cmd.Parameters.Add(new OracleParameter(":CODAUXILIAR", modelo.codauxiliar));
            cmd.Parameters.Add(new OracleParameter(":QT", modelo.qt));
            cmd.Parameters.Add(new OracleParameter(":QTUNITEMB", modelo.qtunitemb));
            cmd.Parameters.Add(new OracleParameter(":PVENDA", modelo.pvenda));
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            //conexao.TerminarTransacao();
            conexao.Desconectar();

        }
        public void AlterarQT(ModeloPCPEDI modelo)
        {
            String comando2 = " UPDATE PCPEDI SET QT = :QT WHERE NUMPED = :NUMPED AND CODPROD = :CODPROD AND NUMSEQ = :NUMSEQ AND QT > 0";

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = comando2;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add(new OracleParameter(":QT", modelo.qtrest));
            cmd.Parameters.Add(new OracleParameter(":NUMPED", modelo.oldnumped));
            cmd.Parameters.Add(new OracleParameter(":CODPROD", modelo.codprod));
            cmd.Parameters.Add(new OracleParameter(":NUMSEQ", modelo.numseqori));
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();

        }
        public void AlterarQTORI(ModeloPCPEDI modelo)
        {
            String comando2 = " UPDATE PCPEDI SET QT = :QT WHERE NUMPED = :NUMPED AND CODPROD = :CODPROD ";

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = comando2;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add(new OracleParameter(":QT", modelo.qt));
            cmd.Parameters.Add(new OracleParameter(":NUMPED", modelo.numped));
            cmd.Parameters.Add(new OracleParameter(":CODPROD", modelo.codprod));
            conexao.Conectar();
            cmd.ExecuteNonQuery();
          //  conexao.TerminarTransacao();
            conexao.Desconectar();

        }
       
        public ModeloPCPEDI CarregaModeloPCPEDI(long codigo)
        {
            String comando3 = "";
            comando3 = comando3 + "SELECT  PI.*, 1 as QTUNITCX2," + "\n";
            comando3 = comando3 + "(SELECT CODAUXILIAR FROM (SELECT * FROM PCEMBALAGEM ORDER BY PVENDA,QTUNIT) PE WHERE PE.PVENDA > 0 AND PE.QTUNIT = 1 AND PE.CODPROD = PI.CODPROD AND NVL(PE.EXCLUIDO,'N') = 'N' AND NVL(PE.ENVIAFRENTECAIXA,'N') = 'S' AND PE.CODFUNCINATIVO IS NULL AND ROWNUM = 1) AS CODAUX2," + "\n";
            comando3 = comando3 + " NVL((SELECT PP.ACEITAVENDAFRACAO FROM PCPRODUT PP WHERE PP.CODPROD = PI.CODPROD AND ROWNUM = 1),'N') AS FRACAO FROM PCPEDI PI WHERE NUMPED = :NUMPED AND QT > 0 AND ROWNUM = 1";
            ModeloPCPEDI modelo = new ModeloPCPEDI();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = comando3;
            cmd.Parameters.Add(new OracleParameter(":NUMPED", codigo));
            conexao.Conectar();
            OracleDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                if (registro["CODPROD"] != DBNull.Value) { modelo.codprod = Convert.ToInt32(registro["CODPROD"]); }
                if (registro["QT"] != DBNull.Value) { modelo.qt = Convert.ToDecimal(registro["QT"]); }
                if (registro["PVENDA"] != DBNull.Value) { modelo.pvenda = Convert.ToDecimal(registro["PVENDA"]); }
                if (registro["NUMPED"] != DBNull.Value) { modelo.numped = Convert.ToInt64(registro["NUMPED"]); }
                if (registro["DATA"] != DBNull.Value) { modelo.data = Convert.ToDateTime(registro["DATA"]); }
                if (registro["CODCLI"] != DBNull.Value) { modelo.codcli = Convert.ToInt32(registro["CODCLI"]); }
                if (registro["CODUSUR"] != DBNull.Value) { modelo.codusur = Convert.ToInt16(registro["CODUSUR"]); }
                if (registro["NUMCAR"] != DBNull.Value) { modelo.numcar = Convert.ToInt32(registro["NUMCAR"]); }
                if (registro["POSICAO"] != DBNull.Value) { modelo.posicao = Convert.ToString(registro["POSICAO"]); }
                if (registro["ST"] != DBNull.Value) { modelo.st = Convert.ToDecimal(registro["ST"]); }
                if (registro["VLCUSTOREAL"] != DBNull.Value) { modelo.vlcustoreal = Convert.ToDecimal(registro["VLCUSTOREAL"]); }
                if (registro["VLCUSTOFIN"] != DBNull.Value) { modelo.vlcustofin = Convert.ToDecimal(registro["VLCUSTOFIN"]); }
                if (registro["PTABELA"] != DBNull.Value) { modelo.ptabela = Convert.ToDecimal(registro["PTABELA"]); }
                if (registro["PERCOM"] != DBNull.Value) { modelo.percom = Convert.ToDouble(registro["PERCOM"]); }
                if (registro["PERDESC"] != DBNull.Value) { modelo.perdesc = Convert.ToDecimal(registro["PERDESC"]); }
                if (registro["QTFALTA"] != DBNull.Value) { modelo.qtfalta = Convert.ToDecimal(registro["QTFALTA"]); }
                if (registro["NUMSEQ"] != DBNull.Value) { modelo.numseq = Convert.ToDecimal(registro["NUMSEQ"]); }
                if (registro["VLDESCCUSTOCMV"] != DBNull.Value) { modelo.vldesccustocmv = Convert.ToDouble(registro["VLDESCCUSTOCMV"]); }
                if (registro["VLCUSTOCONT"] != DBNull.Value) { modelo.vlcustocont = Convert.ToDecimal(registro["VLCUSTOCONT"]); }
                if (registro["VLCUSTOREP"] != DBNull.Value) { modelo.vlcustorep = Convert.ToDecimal(registro["VLCUSTOREP"]); }
                if (registro["VLDESCSUFRAMA"] != DBNull.Value) { modelo.vldescsuframa = Convert.ToDecimal(registro["VLDESCSUFRAMA"]); }
                if (registro["CODST"] != DBNull.Value) { modelo.codst = Convert.ToInt16(registro["CODST"]); }
                if (registro["VLDESCFIN"] != DBNull.Value) { modelo.vldescfin = Convert.ToDecimal(registro["VLDESCFIN"]); }
                if (registro["PVENDABASE"] != DBNull.Value) { modelo.pvendabase = Convert.ToDecimal(registro["PVENDABASE"]); }
                if (registro["VLIPI"] != DBNull.Value) { modelo.vlipi = Convert.ToDecimal(registro["VLIPI"]); }
                if (registro["PERCIPI"] != DBNull.Value) { modelo.percipi = Convert.ToDouble(registro["PERCIPI"]); }
                if (registro["PORIGINAL"] != DBNull.Value) { modelo.poriginal = Convert.ToDecimal(registro["PORIGINAL"]); }
                if (registro["IVA"] != DBNull.Value) { modelo.iva = Convert.ToDouble(registro["IVA"]); }
                if (registro["PAUTA"] != DBNull.Value) { modelo.pauta = Convert.ToDouble(registro["PAUTA"]); }
                if (registro["ALIQICMS1"] != DBNull.Value) { modelo.aliqicms1 = Convert.ToDouble(registro["ALIQICMS1"]); }
                if (registro["ALIQICMS2"] != DBNull.Value) { modelo.aliqicms2 = Convert.ToDouble(registro["ALIQICMS2"]); }
                if (registro["STCLIENTEGNRE"] != DBNull.Value) { modelo.stclientegnre = Convert.ToDecimal(registro["STCLIENTEGNRE"]); }
                if (registro["PERCBASERED"] != DBNull.Value) { modelo.percbasered = Convert.ToDouble(registro["PERCBASERED"]); }
                if (registro["PERCBASEREDST"] != DBNull.Value) { modelo.percbaseredst = Convert.ToDouble(registro["PERCBASEREDST"]); }
                if (registro["PERCBASEREDSTFONTE"] != DBNull.Value) { modelo.percbaseredstfonte = Convert.ToDouble(registro["PERCBASEREDSTFONTE"]); }
                if (registro["PERFRETECMV"] != DBNull.Value) { modelo.perfretecmv = Convert.ToDouble(registro["PERFRETECMV"]); }
                if (registro["CUSTOFINEST"] != DBNull.Value) { modelo.custofinest = Convert.ToDecimal(registro["CUSTOFINEST"]); }
                if (registro["PERCISS"] != DBNull.Value) { modelo.perciss = Convert.ToDouble(registro["PERCISS"]); }
                if (registro["VLISS"] != DBNull.Value) { modelo.vliss = Convert.ToDecimal(registro["VLISS"]); }
                if (registro["COMPLEMENTO"] != DBNull.Value) { modelo.complemento = Convert.ToString(registro["COMPLEMENTO"]); }
                if (registro["PBASERCA"] != DBNull.Value) { modelo.pbaserca = Convert.ToDecimal(registro["PBASERCA"]); }
                if (registro["VLVERBACMV"] != DBNull.Value) { modelo.vlverbacmv = Convert.ToDecimal(registro["VLVERBACMV"]); }
                if (registro["NUMVERBAREBCMV"] != DBNull.Value) { modelo.numverbarebcmv = Convert.ToInt32(registro["NUMVERBAREBCMV"]); }
                if (registro["BRINDE"] != DBNull.Value) { modelo.brinde = Convert.ToString(registro["BRINDE"]); }
                if (registro["BASEICST"] != DBNull.Value) { modelo.baseicst = Convert.ToDecimal(registro["BASEICST"]); }
                if (registro["QTCX"] != DBNull.Value) { modelo.qtcx = Convert.ToDouble(registro["QTCX"]); }
                if (registro["QTPECAS"] != DBNull.Value) { modelo.qtpecas = Convert.ToDouble(registro["QTPECAS"]); }
                if (registro["LETRACOMISS"] != DBNull.Value) { modelo.letracomiss = Convert.ToString(registro["LETRACOMISS"]); }
                if (registro["CODAUXILIAR"] != DBNull.Value) { modelo.codauxiliar = Convert.ToDecimal(registro["CODAUXILIAR"]); }
                if (registro["CODAUX2"] != DBNull.Value) { modelo.codauxiliarunit = Convert.ToDecimal(registro["CODAUX2"]); }
                if (registro["TXVENDA"] != DBNull.Value) { modelo.txvenda = Convert.ToDouble(registro["TXVENDA"]); }
                if (registro["CODICMTAB"] != DBNull.Value) { modelo.codicmtab = Convert.ToDouble(registro["CODICMTAB"]); }
                if (registro["PERDESCCUSTO"] != DBNull.Value) { modelo.perdesccusto = Convert.ToDouble(registro["PERDESCCUSTO"]); }
                if (registro["CODFILIALRETIRA"] != DBNull.Value) { modelo.codfilialretira = Convert.ToString(registro["CODFILIALRETIRA"]); }
                if (registro["EANCODPROD"] != DBNull.Value) { modelo.eancodprod = Convert.ToInt64(registro["EANCODPROD"]); }
                if (registro["VLDESCICMISENCAO"] != DBNull.Value) { modelo.vldescicmisencao = Convert.ToDecimal(registro["VLDESCICMISENCAO"]); }
                if (registro["PERDESCISENTOICMS"] != DBNull.Value) { modelo.perdescisentoicms = Convert.ToSingle(registro["PERDESCISENTOICMS"]); }
                if (registro["VLVERBACMVCLI"] != DBNull.Value) { modelo.vlverbacmvcli = Convert.ToDecimal(registro["VLVERBACMVCLI"]); }
                if (registro["PVENDA1"] != DBNull.Value) { modelo.pvenda1 = Convert.ToDecimal(registro["PVENDA1"]); }
                if (registro["TIPOENTREGA"] != DBNull.Value) { modelo.tipoentrega = Convert.ToString(registro["TIPOENTREGA"]); }
                if (registro["GERAGNRE_CNPJCLIENTE"] != DBNull.Value) { modelo.geragnreCnpjcliente = Convert.ToString(registro["GERAGNRE_CNPJCLIENTE"]); }
                if (registro["PERCDIFALIQUOTAS"] != DBNull.Value) { modelo.percdifaliquotas = Convert.ToDouble(registro["PERCDIFALIQUOTAS"]); }
                if (registro["BASEDIFALIQUOTAS"] != DBNull.Value) { modelo.basedifaliquotas = Convert.ToDecimal(registro["BASEDIFALIQUOTAS"]); }
                if (registro["VLDIFALIQUOTAS"] != DBNull.Value) { modelo.vldifaliquotas = Convert.ToDecimal(registro["VLDIFALIQUOTAS"]); }
                if (registro["PERDESCPOLITICA"] != DBNull.Value) { modelo.perdescpolitica = Convert.ToDouble(registro["PERDESCPOLITICA"]); }
                if (registro["PVENDAANTERIOR"] != DBNull.Value) { modelo.pvendaanterior = Convert.ToDecimal(registro["PVENDAANTERIOR"]); }
                if (registro["PRODDESCRICAOCONTRATO"] != DBNull.Value) { modelo.proddescricaocontrato = Convert.ToString(registro["PRODDESCRICAOCONTRATO"]); }
                if (registro["POLITICAPRIORITARIA"] != DBNull.Value) { modelo.politicaprioritaria = Convert.ToString(registro["POLITICAPRIORITARIA"]); }
                if (registro["TRUNCARITEM"] != DBNull.Value) { modelo.truncaritem = Convert.ToString(registro["TRUNCARITEM"]); }
                if (registro["QTUNITEMB"] != DBNull.Value) { modelo.qtunitemb = Convert.ToDecimal(registro["QTUNITEMB"]); }
                if (registro["ROTINALANC"] != DBNull.Value) { modelo.rotinalanc = Convert.ToInt32(registro["ROTINALANC"]); }
                if (registro["QTUNITCX"] != DBNull.Value) { modelo.qtunitcx = Convert.ToDouble(registro["QTUNITCX"]); }
                if (registro["QTUNITCX2"] != DBNull.Value) { modelo.qtunitcxunit = Convert.ToDouble(registro["QTUNITCX2"]); }
                if (registro["PERCDESCPIS"] != DBNull.Value) { modelo.percdescpis = Convert.ToDouble(registro["PERCDESCPIS"]); }
                if (registro["VLDESCREDUCAOPIS"] != DBNull.Value) { modelo.vldescreducaopis = Convert.ToDecimal(registro["VLDESCREDUCAOPIS"]); }
                if (registro["PERCDESCCOFINS"] != DBNull.Value) { modelo.percdesccofins = Convert.ToDouble(registro["PERCDESCCOFINS"]); }
                if (registro["VLDESCREDUCAOCOFINS"] != DBNull.Value) { modelo.vldescreducaocofins = Convert.ToDecimal(registro["VLDESCREDUCAOCOFINS"]); }
                if (registro["PERCOM2"] != DBNull.Value) { modelo.percom2 = Convert.ToDouble(registro["PERCOM2"]); }
                if (registro["PERCOM3"] != DBNull.Value) { modelo.percom3 = Convert.ToDouble(registro["PERCOM3"]); }
                if (registro["PERCOM4"] != DBNull.Value) { modelo.percom4 = Convert.ToDouble(registro["PERCOM4"]); }
                if (registro["CODDESCONTO"] != DBNull.Value) { modelo.coddesconto = Convert.ToInt32(registro["CODDESCONTO"]); }
                if (registro["VLDESCPISSUFRAMA"] != DBNull.Value) { modelo.vldescpissuframa = Convert.ToDecimal(registro["VLDESCPISSUFRAMA"]); }
                if (registro["VLREDPVENDASIMPLESNA"] != DBNull.Value) { modelo.vlredpvendasimplesna = Convert.ToDecimal(registro["VLREDPVENDASIMPLESNA"]); }
                if (registro["VLREDCMVSIMPLESNAC"] != DBNull.Value) { modelo.vlredcmvsimplesnac = Convert.ToDecimal(registro["VLREDCMVSIMPLESNAC"]); }
                if (registro["CODCONTRATO"] != DBNull.Value) { modelo.codcontrato = Convert.ToInt32(registro["CODCONTRATO"]); }
                if (registro["VLREPASSE"] != DBNull.Value) { modelo.vlrepasse = Convert.ToDecimal(registro["VLREPASSE"]); }
                if (registro["PERBONIFIC"] != DBNull.Value) { modelo.perbonific = Convert.ToDouble(registro["PERBONIFIC"]); }
                if (registro["VLBONIFIC"] != DBNull.Value) { modelo.vlbonific = Convert.ToDecimal(registro["VLBONIFIC"]); }
                if (registro["PERDESCCOM"] != DBNull.Value) { modelo.perdesccom = Convert.ToDouble(registro["PERDESCCOM"]); }
                if (registro["VLDESCCOM"] != DBNull.Value) { modelo.vldesccom = Convert.ToDecimal(registro["VLDESCCOM"]); }
                if (registro["VLOUTROS"] != DBNull.Value) { modelo.vloutros = Convert.ToDecimal(registro["VLOUTROS"]); }
                if (registro["DESCPRECOFAB"] != DBNull.Value) { modelo.descprecofab = Convert.ToDecimal(registro["DESCPRECOFAB"]); }
                if (registro["PRECOMAXCONSUM"] != DBNull.Value) { modelo.precomaxconsum = Convert.ToDecimal(registro["PRECOMAXCONSUM"]); }
                if (registro["QTLITRAGEM"] != DBNull.Value) { modelo.qtlitragem = Convert.ToDecimal(registro["QTLITRAGEM"]); }
                if (registro["ROTINALANCBRINDE"] != DBNull.Value) { modelo.rotinalancbrinde = Convert.ToInt32(registro["ROTINALANCBRINDE"]); }
                if (registro["PERCDESCABATIMENTO"] != DBNull.Value) { modelo.percdescabatimento = Convert.ToDecimal(registro["PERCDESCABATIMENTO"]); }
                if (registro["VLDESCABATIMENTO"] != DBNull.Value) { modelo.vldescabatimento = Convert.ToDecimal(registro["VLDESCABATIMENTO"]); }
                if (registro["PBONIFIC"] != DBNull.Value) { modelo.pbonific = Convert.ToDecimal(registro["PBONIFIC"]); }
                if (registro["BONIFIC"] != DBNull.Value) { modelo.bonific = Convert.ToString(registro["BONIFIC"]); }
                if (registro["NUMITEMPED"] != DBNull.Value) { modelo.numitemped = Convert.ToInt32(registro["NUMITEMPED"]); }
                if (registro["PERDESCPAUTA"] != DBNull.Value) { modelo.perdescpauta = Convert.ToDecimal(registro["PERDESCPAUTA"]); }
                if (registro["ORIGEMST"] != DBNull.Value) { modelo.origemst = Convert.ToString(registro["ORIGEMST"]); }
                if (registro["CODFORMULA"] != DBNull.Value) { modelo.codformula = Convert.ToString(registro["CODFORMULA"]); }
                if (registro["CODBASE"] != DBNull.Value) { modelo.codbase = Convert.ToString(registro["CODBASE"]); }
                if (registro["SIGLAQUALIDADE"] != DBNull.Value) { modelo.siglaqualidade = Convert.ToString(registro["SIGLAQUALIDADE"]); }
                if (registro["ALTERNATIVO"] != DBNull.Value) { modelo.alternativo = Convert.ToString(registro["ALTERNATIVO"]); }
                if (registro["VOLUMEDESEJADO"] != DBNull.Value) { modelo.volumedesejado = Convert.ToDouble(registro["VOLUMEDESEJADO"]); }
                if (registro["QTDIASENTREGAITEM"] != DBNull.Value) { modelo.qtdiasentregaitem = Convert.ToInt16(registro["QTDIASENTREGAITEM"]); }
                if (registro["NUMERORECOPI"] != DBNull.Value) { modelo.numerorecopi = Convert.ToString(registro["NUMERORECOPI"]); }
                if (registro["USAUNIDADEMASTER"] != DBNull.Value) { modelo.usaunidademaster = Convert.ToString(registro["USAUNIDADEMASTER"]); }
                if (registro["CODCOMBO"] != DBNull.Value) { modelo.codcombo = Convert.ToInt64(registro["CODCOMBO"]); }
                if (registro["NUMSEQITEMCONTRATO"] != DBNull.Value) { modelo.numseqitemcontrato = Convert.ToInt32(registro["NUMSEQITEMCONTRATO"]); }
                if (registro["PERCREDALIQIPI"] != DBNull.Value) { modelo.percredaliqipi = Convert.ToDecimal(registro["PERCREDALIQIPI"]); }
                if (registro["NUMSEQCESTABASICA"] != DBNull.Value) { modelo.numseqcestabasica = Convert.ToInt32(registro["NUMSEQCESTABASICA"]); }
                if (registro["CODPRODCESTA"] != DBNull.Value) { modelo.codprodcesta = Convert.ToInt32(registro["CODPRODCESTA"]); }
                if (registro["CODDESCONTOBASERCA"] != DBNull.Value) { modelo.coddescontobaserca = Convert.ToInt32(registro["CODDESCONTOBASERCA"]); }
                if (registro["ALIQFCP"] != DBNull.Value) { modelo.aliqfcp = Convert.ToDecimal(registro["ALIQFCP"]); }
                if (registro["ALIQINTERNADEST"] != DBNull.Value) { modelo.aliqinternadest = Convert.ToDecimal(registro["ALIQINTERNADEST"]); }
                if (registro["VLFCPPART"] != DBNull.Value) { modelo.vlfcppart = Convert.ToDecimal(registro["VLFCPPART"]); }
                if (registro["VLICMSPARTDEST"] != DBNull.Value) { modelo.vlicmspartdest = Convert.ToDecimal(registro["VLICMSPARTDEST"]); }
                if (registro["VLICMSPART"] != DBNull.Value) { modelo.vlicmspart = Convert.ToDecimal(registro["VLICMSPART"]); }
                if (registro["PERCPROVPART"] != DBNull.Value) { modelo.percprovpart = Convert.ToSingle(registro["PERCPROVPART"]); }
                if (registro["VLICMSDIFALIQPART"] != DBNull.Value) { modelo.vlicmsdifaliqpart = Convert.ToDecimal(registro["VLICMSDIFALIQPART"]); }
                if (registro["PERCBASEREDPART"] != DBNull.Value) { modelo.percbaseredpart = Convert.ToSingle(registro["PERCBASEREDPART"]); }
                if (registro["VLICMSPARTREM"] != DBNull.Value) { modelo.vlicmspartrem = Convert.ToDecimal(registro["VLICMSPARTREM"]); }
                if (registro["ALIQINTERORIGPART"] != DBNull.Value) { modelo.aliqinterorigpart = Convert.ToDecimal(registro["ALIQINTERORIGPART"]); }
                if (registro["VLBASEPARTDEST"] != DBNull.Value) { modelo.vlbasepartdest = Convert.ToDecimal(registro["VLBASEPARTDEST"]); }
                if (registro["VLIPIPTABELA"] != DBNull.Value) { modelo.vlipiptabela = Convert.ToDecimal(registro["VLIPIPTABELA"]); }
                if (registro["VLIPIPBASERCA"] != DBNull.Value) { modelo.vlipipbaserca = Convert.ToDecimal(registro["VLIPIPBASERCA"]); }
                if (registro["STPTABELA"] != DBNull.Value) { modelo.stptabela = Convert.ToDecimal(registro["STPTABELA"]); }
                if (registro["STPBASERCA"] != DBNull.Value) { modelo.stpbaserca = Convert.ToDecimal(registro["STPBASERCA"]); }
                if (registro["VLICMSPARTPTABELA"] != DBNull.Value) { modelo.vlicmspartptabela = Convert.ToDecimal(registro["VLICMSPARTPTABELA"]); }
                if (registro["VLICMSPARTPBASERCA"] != DBNull.Value) { modelo.vlicmspartpbaserca = Convert.ToDecimal(registro["VLICMSPARTPBASERCA"]); }
                if (registro["UNIDADE"] != DBNull.Value) { modelo.unidade = Convert.ToString(registro["UNIDADE"]); }
                if (registro["CODDESCONTOSIMULADOR"] != DBNull.Value) { modelo.coddescontosimulador = Convert.ToInt32(registro["CODDESCONTOSIMULADOR"]); }
                if (registro["CODFIGVENDATRIANGULAR"] != DBNull.Value) { modelo.codfigvendatriangular = Convert.ToInt16(registro["CODFIGVENDATRIANGULAR"]); }
                if (registro["CODFISCAL"] != DBNull.Value) { modelo.codfiscal = Convert.ToInt32(registro["CODFISCAL"]); }
                if (registro["SITTRIBUT"] != DBNull.Value) { modelo.sittribut = Convert.ToString(registro["SITTRIBUT"]); }
                if (registro["PTABELAFABRICAZFM"] != DBNull.Value) { modelo.ptabelafabricazfm = Convert.ToDecimal(registro["PTABELAFABRICAZFM"]); }
                if (registro["ORIGMERCTRIB"] != DBNull.Value) { modelo.origmerctrib = Convert.ToString(registro["ORIGMERCTRIB"]); }
                if (registro["VLDESCCARCACA"] != DBNull.Value) { modelo.vldesccarcaca = Convert.ToDecimal(registro["VLDESCCARCACA"]); }
                if (registro["DEVOLUCAOCARCACA"] != DBNull.Value) { modelo.devolucaocarcaca = Convert.ToString(registro["DEVOLUCAOCARCACA"]); }
                if (registro["FRACAO"] != DBNull.Value) { modelo.fracao = Convert.ToString(registro["FRACAO"]); }

            }
            conexao.Desconectar();
            return modelo;

        }
        public DataTable Localizar(long codigovenda)
        {
            DataTable tabela = new DataTable();
            OracleDataAdapter da = new OracleDataAdapter("Select codprod,codauxiliar,qt,qtunitemb,pvenda from PCPEDI where NUMPED =" + codigovenda.ToString() + " AND QT > 0 ", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
    }
}
