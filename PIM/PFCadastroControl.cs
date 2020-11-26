using System;
using System.Windows.Forms;

namespace PIM
{
    public partial class PFCadastroControl : UserControl
    {

        private String phNome = "Nome Completo";
        private String phEmail = "Email";
        private String phTelefone = "Telefone";
        private String phUsuario = "Usuário";
        private String phSenha = "Senha";
        private String phCPF = "CPF (apenas números)";
        private String phDataNasc = "Data de nascimento";


        public PFCadastroControl()
        {
            InitializeComponent();
        }

        private void txtNome_Enter(object sender, EventArgs e)
        {
            if (txtNome.Text == phNome)
            {
                removerTexto(txtNome);
            }
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                txtNome.Text = phNome;
            }
        }

        private void txtDataNasc_Enter(object sender, EventArgs e)
        {
            if (txtDataNasc.Text == phDataNasc)
                removerTexto(txtDataNasc);
        }

        private void txtDataNasc_Leave(object sender, EventArgs e)
        {
            if (txtDataNasc.Text == "")
            {
                txtDataNasc.Text = phDataNasc;
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == phEmail)
                removerTexto(txtEmail);
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = phEmail;
            }
        }

        private void txtCPF_Enter(object sender, EventArgs e)
        {
            if (txtCPF.Text == phCPF)
                removerTexto(txtCPF);
        }

        private void txtCPF_Leave(object sender, EventArgs e)
        {
            if (txtCPF.Text == "")
            {
                txtCPF.Text = phCPF;
            }
        }

        private void txtTelefone_Enter(object sender, EventArgs e)
        {
            if (txtTelefone.Text == phTelefone)
                removerTexto(txtTelefone);
        }

        private void txtTelefone_Leave(object sender, EventArgs e)
        {
            if (txtTelefone.Text == "")
            {
                txtTelefone.Text = phTelefone;
            }
        }

        private void txtLogin_Enter(object sender, EventArgs e)
        {
            if (txtUsusario.Text == phUsuario)
                removerTexto(txtUsusario);
        }

        private void txtLogin_Leave(object sender, EventArgs e)
        {
            if (txtUsusario.Text == "")
            {
                txtUsusario.Text = phUsuario;
            }
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            if (txtSenha.Text == phSenha)
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
                txtSenha.Text = phSenha;
            }
        }


        static void removerTexto(TextBox textBox)
        {
            textBox.Clear();
        }
    }
}
