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
using System.Diagnostics;

namespace PIM
{
    public partial class formLogin : Form
    {
        Thread nt;
        public Point mouseLocation;
        private bool pessoaFisica;


        public formLogin()
        {
            InitializeComponent();
            pfLoginControl1.BringToFront();
            cadastroSelecionado(btnPF);
            pessoaFisica = true;
        }
        private void formLogin_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dbloginDataSet.tbaccount'. Você pode movê-la ou removê-la conforme necessário.
            //this.tbaccountTableAdapter.Fill(this.dbloginDataSet.tbaccount);

        }

        private void novoForm()
        {
            Application.Run(new formHome());
        }

        private void novoFormCadastro()
        {
            Application.Run(new formCadastro());
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            
            // Config da conexão
            SqlConnection con = new SqlConnection("Data Source=ALFREDO-PC\\SQLEXPRESS;Initial Catalog=BDPIMEXPRESS;User ID=sa;Password=admin123");

            String query;
            // QUERY PARA CONSULTAR OS DADOS
            if (pessoaFisica)
            {
                query = "Select * from Login_pessoaFisica Where CPF = '" +pfLoginControl1.txtCPF.Text.Trim()+ "' and Login = '" + pfLoginControl1.txtLogin.Text.Trim() + "' and Senha = '" + pfLoginControl1.txtSenha.Text.Trim() + "'";
            } else
            {
                query = "Select * from Login_pessoaJuridica where cnpj = '" + pjLoginControl1.txtCNPJ.Text.Trim() + "' and Login = '" + pjLoginControl1.txtLogin.Text.Trim() + "' and Senha = '" + pjLoginControl1.txtSenha.Text.Trim() + "'";
            }
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            // LÓGICA DE LOGIN
            if (dtbl.Rows.Count == 1)
            {
                formHome home = new formHome();
                nt = new Thread(novoForm);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
                this.Close();
            }
            else
            {
                MessageBox.Show("Credenciais inválidas");
            }
              
        }

        private void AlteraTextButton(object sender, EventArgs e)
        {
            btnCadastrar.ForeColor = Color.Black;

        }

        private void VoltaTextButton(object sender, EventArgs e)
        {
            btnCadastrar.ForeColor = Color.White;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            formCadastro cadastro = new formCadastro();
            nt = new Thread(novoFormCadastro);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
            this.Close();
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
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnConfirmar.PerformClick();
            }
        }


        private void btnPJ_MouseClick(object sender, MouseEventArgs e)
        {
            pjLoginControl1.BringToFront();
            cadastroSelecionado(btnPJ);
            pessoaFisica = false;
            removerSelecao(btnPF);
        }

        private void btnPF_MouseClick(object sender, MouseEventArgs e)
        {
            pfLoginControl1.BringToFront();
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

    }
}
