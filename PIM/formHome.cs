using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM
{
    public partial class formHome : Form
    {
        public formHome()
        {
            InitializeComponent();
        }

        private void formHome_Load(object sender, EventArgs e)
        {

        }

        private void btnHomeBroker_Click(object sender, EventArgs e)
        {
            homeBroker homeBroker = new homeBroker();
            homeBroker.Show();
        }

        private void btnCarteira_Click(object sender, EventArgs e)
        {
            carteiraInvestimento carteira = new carteiraInvestimento();
            carteira.Show();
        }

        private void btnControle_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
