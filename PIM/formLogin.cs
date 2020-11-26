﻿using System;
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
    public partial class formLogin : Form
    {
        Thread nt;
        public Point mouseLocation;


        public formLogin()
        {
            InitializeComponent();
        }

        private void tbaccountBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbaccountBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbloginDataSet);

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

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            String usuario = txtLogin.Text;
            String senha = txtSenha.Text;

            // Config da conexão
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-76HMS08\\SQLEXPRESS;Initial Catalog=dbpim;Persist Security Info=True;User ID=sa;Password=leo123");
            con.Open();


            // QUERY PARA CONSULTAR OS DADOS
            String query = "Select * from tblogin Where usuario = '" + txtLogin.Text.Trim() + "' and senha = '" + txtSenha.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dtbl = new DataTable();
            _ = sda.Fill(dtbl);

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

        private void limparLogin(object sender, MouseEventArgs e)
        {
            txtLogin.Clear();
        }

        private void limparSenha(object sender, MouseEventArgs e)
        {
            txtSenha.Clear();
        }

        private void limparSenhaTab(object sender, EventArgs e)
        {
            txtSenha.Clear();
        }

        private void esconderSenha(object sender, EventArgs e)
        {
            txtSenha.UseSystemPasswordChar = true;
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
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-76HMS08\\SQLEXPRESS;Initial Catalog=dbpim;Persist Security Info=True;User ID=sa;Password=leo123");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into tblogin(usuario, senha) values ('" + txtLogin.Text + "', '" + txtSenha.Text + "')", con);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                MessageBox.Show("sucesso");
            }
            else
            {
                MessageBox.Show("Erro");
            }
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

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnConfirmar.PerformClick();
            }
        }
    }
}
