using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace PIM
{
    public partial class carteiraInvestimento : Form
    {

        Thread nt;

        public carteiraInvestimento()
        {
            InitializeComponent();
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
