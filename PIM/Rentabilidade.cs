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
    public partial class Rentabilidade : Form
    {

        Thread nt;

        public Rentabilidade()
        {
            InitializeComponent();
        }
        private void formCarteiraInvestimento()
        {
            Application.Run(new carteiraInvestimento());
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            carteiraInvestimento carteira = new carteiraInvestimento();
            nt = new Thread(formCarteiraInvestimento);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
            this.Close();
        }
    }
}
