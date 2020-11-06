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
    public partial class formLogin : Form
    {
        Thread nt;


        public formLogin()
        {
            InitializeComponent();
        }

        private void tbaccountBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbaccountBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbloginDataSet);

        }

        private void formLogin_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dbloginDataSet.tbaccount'. Você pode movê-la ou removê-la conforme necessário.
            //this.tbaccountTableAdapter.Fill(this.dbloginDataSet.tbaccount);

        }

        private void novoForm()
        {
            Application.Run(new formHome()); 
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            String usuario = txtLogin.Text;
            String senha = txtSenha.Text;

            //query 
            if(Convert.ToBoolean(this.tbaccountTableAdapter.FillByLogin(this.dbloginDataSet.tbaccount, usuario, senha)))
            {
                formHome home = new formHome();
                this.WindowState = FormWindowState.Minimized;
                nt = new Thread(novoForm);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }


    }
}
