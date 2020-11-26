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
    public partial class ComprarBitcoins : Form
    {

        Thread nt;

        public ComprarBitcoins()
        {
            InitializeComponent();
        }
        private void formComprarMoedas()
        {
            Application.Run(new ComprarMoedas());
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ComprarMoedas ComprarMoedas = new ComprarMoedas();
            nt = new Thread(formComprarMoedas);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
            this.Close();
        }
    }
}
