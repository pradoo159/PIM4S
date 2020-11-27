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
using System.Data.Common;

namespace PIM
{
    public partial class InvestimentosHomeBroker : Form
    {

        Thread nt;
        float valorInvestimento = 0f;

        private void novoForm()
        {
            Application.Run(new HomeBroker());
        }

        public InvestimentosHomeBroker()
        {
            InitializeComponent();
            // Config da conexão
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
                cmd = new SqlCommand("select SUM(Valor_investimento) from Home_Broker_Cliente where CPF='" + Auxiliar.CPF + "'", con);
            }
            else
            {
                cmd = new SqlCommand("select SUM(Valor_investimento) from Home_Broker_Cliente where CNPJ='" + Auxiliar.CNPJ + "'", con);
            }

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {

                dr.Read();
                try
                {
                    valorInvestimento = float.Parse(dr[""].ToString());
                }
                catch (System.FormatException fmtE)
                {
                    txtValorInvestido.Text = "R$0,00";
                }
            }

            txtValorInvestido.Text = "R$" + valorInvestimento + ",00";

            con.Close();
        }


        private void investirBitcoin()
        {
            Application.Run(new InvestimentoBitcoin());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InvestimentoBitcoin bitcoin = new InvestimentoBitcoin();
            nt = new Thread(investirBitcoin);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
            this.Close();
        }

        private void Voltar()
        {
            HomeBroker homeBroker = new HomeBroker();
            nt = new Thread(novoForm);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
            this.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Voltar();
        }
    }
}
