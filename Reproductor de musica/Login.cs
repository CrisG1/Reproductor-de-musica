using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reproductor_de_musica
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "" || txtPass.Text == "") { MessageBox.Show("Le faltan campos por llenar", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
            if (AccionesComunes.ConsultaLogin($"Select * from usuarios where user = '{txtUser.Text}' and pass = '{AccionesComunes.Encripta(txtPass.Text)}'") == 1)
            {
                Form1 frm = new Form1();
                frm.Show();
            }
            MessageBox.Show("No existe usuario o contraseña incorrecta");
        }

        private void lblCrear_Click(object sender, EventArgs e)
        {
            CreateAccount ct = new CreateAccount();
            ct.ShowDialog();
        }
    }
}
