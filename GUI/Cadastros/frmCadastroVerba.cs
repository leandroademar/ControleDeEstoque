using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI.Cadastros
{
    public partial class frmCadastroVerba : GUI.frmModeloDeFormularioDeCadastro
    {
        public frmCadastroVerba()
        {
            InitializeComponent();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                
                this.alteraBotoes(1);
                MessageBox.Show("Cadastro alterado");

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btInserir_Click(object sender, EventArgs e)
        {

        }
    }
}
