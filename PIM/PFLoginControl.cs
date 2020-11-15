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
    public partial class PFLoginControl : UserControl
    {
        public PFLoginControl()
        {
            InitializeComponent();
        }

        static void removerTexto(TextBox textBox)
        {
            textBox.Text = "";
        }

        private void txtCPF_Click(object sender, EventArgs e)
        {
            removerTexto(txtCPF);
        }

        private void txtLogin_Click(object sender, EventArgs e)
        {
            removerTexto(txtLogin);
        }

        private void txtSenha_Click(object sender, EventArgs e)
        {
            removerTexto(txtSenha);
            txtSenha.UseSystemPasswordChar = true;
        }
    }
}
