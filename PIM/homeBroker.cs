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
    public partial class HomeBroker : Form
    {

        Thread nt;

        public HomeBroker()
        {
            InitializeComponent();
        }
        private void formHome()
        {
            Application.Run(new formHome());
        }
        private void formMoedas()
        {
            Application.Run(new ComprarMoedas());
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            formHome home = new formHome();
            nt = new Thread(formHome);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ComprarMoedas ComprarMoedas = new ComprarMoedas();
            nt = new Thread(formMoedas);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
            this.Close();
        }
    }
}
