using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM
{
    public partial class PFCadastroControl : UserControl
    {
        public PFCadastroControl()
        {
            InitializeComponent();
        }

        private void txtNome_Enter(object sender, EventArgs e)
        {
            removerTexto(txtNome);
        }

        private void txtDataNasc_Enter(object sender, EventArgs e)
        {
            removerTexto(txtDataNasc);
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            removerTexto(txtEmail);
        }

        private void txtCPF_Enter(object sender, EventArgs e)
        {
            removerTexto(txtCPF);
        }

        private void txtTelefone_Enter(object sender, EventArgs e)
        {
            removerTexto(txtTelefone);
        }

        private void txtLogin_Enter(object sender, EventArgs e)
        {
            removerTexto(txtUsusario);
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            removerTexto(txtSenha);
            txtSenha.UseSystemPasswordChar = true;
        }


        static void removerTexto(TextBox textBox)
        {
            textBox.Clear();
        }
    }
}
