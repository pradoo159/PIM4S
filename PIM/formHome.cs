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

namespace PIM
{
    public partial class formHome : Form
    {

        Thread nt;

        public formHome()
        {
            InitializeComponent();
        }
        private void formHomeBroker()
        {
            Application.Run(new HomeBroker());
        }
        private void formCarteiraInvestimento()
        {
            Application.Run(new carteiraInvestimento());
        }
        private void formControle()
        {
            Application.Run(new ControleLiquidacao());
        }

        private void formHome_Load(object sender, EventArgs e)
        {

        }

        private void btnHomeBroker_Click(object sender, EventArgs e)
        {
            HomeBroker homeBroker = new HomeBroker();
            nt = new Thread(formHomeBroker);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
            this.Close();
        }

        private void btnCarteira_Click(object sender, EventArgs e)
        {
            carteiraInvestimento carteira = new carteiraInvestimento();
            nt = new Thread(formCarteiraInvestimento);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
            this.Close();
        }

        private void btnControle_Click(object sender, EventArgs e)
        {
            ControleLiquidacao controle = new ControleLiquidacao();
            nt = new Thread(formControle);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
            this.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
