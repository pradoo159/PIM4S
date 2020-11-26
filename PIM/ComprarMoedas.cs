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
    public partial class ComprarMoedas : Form
    {

        Thread nt;

        public ComprarMoedas()
        {
            InitializeComponent();
        }
        private void formHome()
        {
            Application.Run(new HomeBroker());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomeBroker homeBroker = new HomeBroker();
            nt = new Thread(formHome);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
            this.Close();
        }
    }
}
