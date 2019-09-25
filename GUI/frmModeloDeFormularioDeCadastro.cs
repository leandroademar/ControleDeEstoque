using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmModeloDeFormularioDeCadastro : Form
    {
        public String operacao;
        public frmModeloDeFormularioDeCadastro()
        {
            InitializeComponent();
        }
        public void tipoLetra(int op)
        {
            if (op == 1)
            {
                foreach (Object txtBox in this.Controls)
                {
                    if (txtBox is TextBox)
                    {
                        //((TextBox)txtBox).Text = ((TextBox)txtBox).Text.ToUpper();
                        ((TextBox)txtBox).CharacterCasing = CharacterCasing.Upper;

                    }
                }
            }
        }
        public void alteraBotoes(int op)
        {
            // op = operaçoes que serao feitas com os botoes
            // 1  = Preparar os botoes para inserir e localizar
            // 2  = preparar os para inserir/alterar um registro
            // 3  = preparar a tela para excluir ou alterar

            pnDados.Enabled = false;
            btInserir.Enabled = false;
            btAlterar.Enabled = false;
            btLocalizar.Enabled = false;
            btExcluir.Enabled = false;
            btCancelar.Enabled = false;
            btSalvar.Enabled = false;

            if (op == 1)
            {
                btInserir.Enabled = true;
                btLocalizar.Enabled = true;
            }
            if (op == 2)
            {
                pnDados.Enabled = true;
                btSalvar.Enabled = true;
                btCancelar.Enabled = true;
            }
            if (op == 3)
            {
                btAlterar.Enabled = true;
                btExcluir.Enabled = true;
                btCancelar.Enabled = true;
            }
        }

        private void frmModeloDeFormularioDeCadastro_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.alteraBotoes(1);
            this.tipoLetra(1);
            //Letras Maiusculas
            foreach (Object txtBox in this.Controls)
            {
                if (txtBox is TextBox)
                {
                    //((TextBox)txtBox).Text = ((TextBox)txtBox).Text.ToUpper();
                    ((TextBox)txtBox).CharacterCasing = CharacterCasing.Upper;

                }
            }

        }

        private void frmModeloDeFormularioDeCadastro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
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

        }

        private void btExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btSalvar_Click(object sender, EventArgs e)
        {

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
