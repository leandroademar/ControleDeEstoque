using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmCadastroTED : GUI.frmModeloDeFormularioDeCadastro
    {
        public frmCadastroTED()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alteraBotoes(2);
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {

        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.alteraBotoes(2);
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {

        }
    }
}
