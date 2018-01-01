// Treinamento C# (Microsoft Visual Studio .NET)
// MTM Sistemas Ltda  
// Consultoria em C# e MS SQL Server para Desenvolvimento e Migração de Sistemas
// 041-3232.6416

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Ferramentas
{
    public class clsArquivoTxt
    {
        string datapagamento = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        public void FU_Gravar(string txtID, string txtCliente, string txtCarta,string txtDinheiro,string txtValor)
        {
            File.Delete("PEDIDO.TXT");
            StreamWriter STW_Arquivo;
            STW_Arquivo = new StreamWriter("PEDIDO.txt",false);
            STW_Arquivo.WriteLine("     SUPERMERCADO TABAJARA      ");
            STW_Arquivo.WriteLine("");
            STW_Arquivo.WriteLine("R Nossa Senhora da Glória, 695");
            STW_Arquivo.WriteLine("Cidade Nova Aracaju/SE");
            STW_Arquivo.WriteLine("");
            STW_Arquivo.WriteLine("     COMPROVANTE DE PAGAMENTO    ");
            STW_Arquivo.WriteLine("Código..: " + txtID.Trim());
            STW_Arquivo.WriteLine("Cliente.: " + txtCliente.Trim());
            STW_Arquivo.WriteLine("");
            STW_Arquivo.WriteLine("");
            STW_Arquivo.WriteLine("Total...: R$ " + txtValor.Trim());
            STW_Arquivo.WriteLine("");
            STW_Arquivo.WriteLine("Hora....: " + datapagamento.Trim());
            STW_Arquivo.WriteLine("");
            STW_Arquivo.WriteLine("");
            STW_Arquivo.WriteLine("");
            STW_Arquivo.WriteLine("_________________________________");
            STW_Arquivo.WriteLine("            Atendente");
            STW_Arquivo.WriteLine("");            
            STW_Arquivo.WriteLine("OBS: A MERCADORIA COMPRADA SERA");
            STW_Arquivo.WriteLine("ENTREGUE MEDIANTE APRESENTAÇÃO ");
            STW_Arquivo.WriteLine("DESTE DOCUMENTO.");
            STW_Arquivo.WriteLine("");
            STW_Arquivo.WriteLine("COMPROVANTE SEM VALOR FISCAL");
            STW_Arquivo.Close();
        }

        
    }
}
