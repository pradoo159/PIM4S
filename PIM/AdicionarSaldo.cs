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
    public partial class AdicionarSaldo : Form
    {
        float valorAdicionado;
        Thread nt;

        public AdicionarSaldo()
        {
            InitializeComponent();
            valorAdicionado = 0f;
            valores.Text = "Valor: " + valorTotal();
        }

        private void formCarteiraInvestimento()
        {
            Application.Run(new carteiraInvestimento());
        }  

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            // Config da conexão
            SqlConnection con = new SqlConnection(Auxiliar.conexaoBD);
            con.Open();
            SqlCommand cmd;
              
            cmd = new SqlCommand("insert into Carteira_Investimento(Saldo, Tipo_Moeda, CPF) values('" + valorAdicionado + "', 'Real', '" + Auxiliar.CPF + "')",con);


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


        }
        private String valorTotal()
        {
            return "R$" + valorAdicionado + ",00";
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Voltar();
        }

        private void Voltar()
        {
            carteiraInvestimento carteira = new carteiraInvestimento();
            nt = new Thread(formCarteiraInvestimento);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
            this.Close();
        }

        private void addUm_Click(object sender, EventArgs e)
        {
            valorAdicionado += 1f;
            valores.Text = "Valor: " + valorTotal();
        }

        private void rmUm_Click(object sender, EventArgs e)
        {
            if (valorAdicionado > 0f)
            {
                valorAdicionado -= 1f;
                valores.Text = "Valor: " + valorTotal();
            }
        }

        private void rmMil_Click(object sender, EventArgs e)
        {
            if (valorAdicionado > 999f)
            {
                valorAdicionado -= 1000f;
                valores.Text = "Valor: " + valorTotal();
            }
        }

        private void valores_Click(object sender, EventArgs e)
        {

        }

        private void addUm_Click_1(object sender, EventArgs e)
        {
            valorAdicionado += 1f;
            valores.Text = "Valor: " + valorTotal();
        }

        private void addDez_Click(object sender, EventArgs e)
        {
            valorAdicionado += 10f;
            valores.Text = "Valor: " + valorTotal();
        }

        private void addCem_Click(object sender, EventArgs e)
        {
            valorAdicionado += 100f;
            valores.Text = "Valor: " + valorTotal();
        }

        private void addMil_Click(object sender, EventArgs e)
        {
            valorAdicionado += 1000f;
            valores.Text = "Valor: " + valorTotal();
        }
    }
}
