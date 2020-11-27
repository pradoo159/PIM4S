using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace PIM
{
    public partial class InvestimentoBitcoin : Form
    {
        Thread nt;
        float valorInvestido;
        public InvestimentoBitcoin()
        {
            InitializeComponent();
            valorInvestido = 0f;
            txtValor.Text = "Valor: " + valorTotal();
        }

        private void novoForm()
        {
            Application.Run(new InvestimentosHomeBroker());
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            // Config da conexão
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-MAO1FRB\\SQLEXPRESS;Initial Catalog=BDPIMEXPRESS;User ID=sa;Password=admin123");
            con.Open();
            SqlCommand cmd;
            SqlCommand cmd2;

            if (Auxiliar.CPF != "")
            {
                SqlCommand saldoSQL = new SqlCommand("Select Saldo from Carteira_Investimento WHERE CPF = '" + Auxiliar.CPF + "'", con);
                float saldo = float.Parse(saldoSQL.ExecuteScalar().ToString());
                if (saldo < valorInvestido)
                {
                    MessageBox.Show("Saldo insuficiente");
                    return;
                }
                else
                {
                    cmd = new SqlCommand("INSERT INTO Home_Broker_Cliente(CPF, Valor_investimento) VALUES ('" + Auxiliar.CPF + "', " + valorInvestido + ")", con);
                    cmd2 = new SqlCommand("UPDATE Carteira_Investimento SET Saldo = Saldo - '" + valorInvestido + "' WHERE CPF = '" + Auxiliar.CPF + "'", con);

                }
            }
            else
            {
                SqlCommand saldoSQL = new SqlCommand("Select Saldo from Carteira_Investimento WHERE CPF = '" + Auxiliar.CPF + "'", con);
                float saldo = float.Parse(saldoSQL.ExecuteScalar().ToString());
                if (saldo < valorInvestido)
                {
                    MessageBox.Show("Saldo insuficiente");
                    return;
                }
                else
                {
                    cmd = new SqlCommand("INSERT INTO Home_Broker_Cliente(CNPJ, Valor_investimento) VALUES ('" + Auxiliar.CNPJ + "', " + valorInvestido + ")", con);
                    cmd2 = new SqlCommand("UPDATE Carteira_Investimento SET Saldo = Saldo - '" + valorInvestido + "' WHERE CNPJ = '" + Auxiliar.CNPJ + "'", con);
                }
            }


            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                MessageBox.Show("Sucesso");
                Voltar();
            }
            else
            {
                MessageBox.Show("Erro");
            }

            int i2 = cmd2.ExecuteNonQuery();
            if (i2 != 0)
            {
                MessageBox.Show("Sucesso");
                Voltar();
            }
            else
            {
                MessageBox.Show("Erro");
            }

        }

        private void addUm_Click(object sender, EventArgs e)
        {
            valorInvestido += 1f;
            txtValor.Text = "Valor: " + valorTotal();
        }

        private void addDez_Click(object sender, EventArgs e)
        {
            valorInvestido += 10f;
            txtValor.Text = "Valor: " + valorTotal();
        }

        private void addCem_Click(object sender, EventArgs e)
        {
            valorInvestido += 100f;
            txtValor.Text = "Valor: " + valorTotal();
        }

        private void addMil_Click(object sender, EventArgs e)
        {
            valorInvestido += 1000f;
            txtValor.Text = "Valor: " + valorTotal();

        }

        private void rmUm_Click(object sender, EventArgs e)
        {
            if (valorInvestido > 0f)
            {
                valorInvestido -= 1f;
                txtValor.Text = "Valor: " + valorTotal();
            }


        }

        private void rmDez_Click(object sender, EventArgs e)
        {
            if (valorInvestido > 9f)
            {
                valorInvestido -= 10f;
                txtValor.Text = "Valor: " + valorTotal();
            }
        }

        private void rmCem_Click(object sender, EventArgs e)
        {
            if (valorInvestido > 99f)
            {
                valorInvestido -= 100f;
                txtValor.Text = "Valor: " + valorTotal();
            }
        }

        private void rmMil_Click(object sender, EventArgs e)
        {
            if (valorInvestido > 999f)
            {
                valorInvestido -= 1000f;
                txtValor.Text = "Valor: " + valorTotal();
            }
        }

        private String valorTotal()
        {
            return "R$" + valorInvestido + ",00";
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Voltar();
        }

        private void Voltar()
        {
            InvestimentosHomeBroker bitcoin = new InvestimentosHomeBroker();
            nt = new Thread(novoForm);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
            this.Close();
        }
    }
}
