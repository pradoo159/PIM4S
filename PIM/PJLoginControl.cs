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
    public partial class PJLoginControl : UserControl
    {
        public PJLoginControl()
        {
            InitializeComponent();
        }

        private void txtCNPJ_Enter(object sender, EventArgs e)
        {
            if (txtCNPJ.Text == "CNPJ")
            {
                removerTexto(txtCNPJ);
            }
        }

        private void txtCNPJ_Leave(object sender, EventArgs e)
        {
            if (txtCNPJ.Text == "")
            {
                txtCNPJ.Text = "CNPJ";
            }
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtLogin.Text == "Usuário")
            {
                removerTexto(txtLogin);
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtLogin.Text == "")
            {
                txtLogin.Text = "Usuário";
            }
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            if (txtSenha.Text == "Senha")
            {
                removerTexto(txtSenha);
                txtSenha.UseSystemPasswordChar = true;
            }
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if (txtSenha.Text == "")
            {
                txtSenha.UseSystemPasswordChar = false;
                txtSenha.Text = "Senha";
            }
        }

        static void removerTexto(TextBox textBox)
        {
            textBox.Text = "";
        }
    }
}
