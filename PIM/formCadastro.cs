using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PIM
{
    public partial class formCadastro : Form
    {
        Thread nt;
        public Point mouseLocation;
        private bool pessoaFisica;

        public formCadastro()
        {
            InitializeComponent();
            pfCadastroControl1.BringToFront();
            cadastroSelecionado(btnPF);
            pessoaFisica = true;
        }

        private void novoFormLogin()
        {
            Application.Run(new formLogin());
        }


        private void formLogin_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dbloginDataSet.tbaccount'. Você pode movê-la ou removê-la conforme necessário.
            //this.tbaccountTableAdapter.Fill(this.dbloginDataSet.tbaccount);

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelWinCustom_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void panelWinCustom_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            VoltarParaLogin();
        }

        private void VoltarParaLogin()
        {
            formLogin login = new formLogin();
            nt = new Thread(novoFormLogin);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
            this.Close();
        }

        private void pfCadastroControl1_Load(object sender, EventArgs e)
        {

        }

        private void btnPJ_MouseClick(object sender, MouseEventArgs e)
        {
            pjCadastroControl1.BringToFront();
            cadastroSelecionado(btnPJ);
            pessoaFisica = false;
            removerSelecao(btnPF);
        }

        private void btnPF_MouseClick(object sender, MouseEventArgs e)
        {
            pfCadastroControl1.BringToFront();
            cadastroSelecionado(btnPF);
            pessoaFisica = true;
            removerSelecao(btnPJ);
        }

        static void cadastroSelecionado(Button botao)
        {
            botao.ForeColor = Color.White;
            botao.BackColor = Color.FromArgb(66, 195, 207);
            botao.FlatAppearance.BorderColor = Color.FromArgb(66, 195, 207);
        }

        static void removerSelecao(Button botao)
        {
            botao.ForeColor = Color.FromArgb(66, 195, 207);
            botao.BackColor = Color.Transparent;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Auxiliar.conexaoBD);
            con.Open();
            SqlCommand cmd;
            if (pessoaFisica)
            {
                cmd = new SqlCommand("insert into Pessoa_fisica(Nome_Usuario, CPF, email_PF, Telefone, Data_nasc, Login, senha) values ('" + pfCadastroControl1.txtNome.Text + "', '" + pfCadastroControl1.txtCPF.Text + "', " +
                    "'" + pfCadastroControl1.txtEmail.Text + "', '" + pfCadastroControl1.txtTelefone.Text + "', '" + pfCadastroControl1.txtDataNasc.Text + "', '" + pfCadastroControl1.txtUsusario.Text + "', '" + pfCadastroControl1.txtSenha.Text + "')", con);
            }
            else
            {
                cmd = new SqlCommand("insert into Pessoa_juridica(Nome_Usuario, CNPJ, email_PJ, Telefone, Data_nasc, login, senha) values ('" + pjCadastroControl1.txtNome.Text + "', '" + pjCadastroControl1.txtCNPJ.Text + "', " +
                    "'" + pjCadastroControl1.txtEmail.Text + "', '" + pjCadastroControl1.txtTelefone.Text + "', '" + pjCadastroControl1.txtDataNasc.Text + "', '" + pjCadastroControl1.txtUsusario.Text + "', '" + pjCadastroControl1.txtSenha.Text + "')", con);
            }
            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i != 0)
                {
                    MessageBox.Show("sucesso");
                    VoltarParaLogin();
                }
                else
                {
                    MessageBox.Show("Erro");
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Erro ao realizar o cadastro.");
            }
        }
    }
}
