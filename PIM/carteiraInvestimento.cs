﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;

namespace PIM
{
    public partial class carteiraInvestimento : Form
    {

        Thread nt;
        private float valorSaldo = 0f;

        public carteiraInvestimento()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-MAO1FRB\\SQLEXPRESS;Initial Catalog=BDPIMEXPRESS;User ID=sa;Password=admin123");
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar no banco", ex);
            }

            SqlCommand cmd;

            if (Auxiliar.CPF != "")
            {
                cmd = new SqlCommand("select * from Carteira_Investimento where CPF='" + Auxiliar.CPF + "'", con);
            }
            else
            {
                cmd = new SqlCommand("select * from Carteira_Investimento where CNPJ='" + Auxiliar.CNPJ + "'", con);
            }

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {

                dr.Read();
                try
                {
                    valorSaldo = float.Parse(dr["Saldo"].ToString());
                }
                catch (System.FormatException fmtE)
                {
                    txtSaldoConta.Text = "R$0,00";
                }
            }

            txtSaldoConta.Text = "R$" + valorSaldo + ",00";

            con.Close();
        }
        private void formRentabilidade()
        {
            Application.Run(new Rentabilidade());
        }

        private void formHome()
        {
            Application.Run(new formHome());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRentabilidade_Click(object sender, EventArgs e)
        {
            Rentabilidade rentabilidade = new Rentabilidade();
            nt = new Thread(formRentabilidade);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
            this.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            formHome home = new formHome();
            nt = new Thread(formHome);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
            this.Close();
        }
    }
}
