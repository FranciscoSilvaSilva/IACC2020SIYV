using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;

namespace IACC2020
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        ConsultasSQL sql = new ConsultasSQL();
        public void Label3_Click(object sender, EventArgs e)
        {
           //string iduser;
           //iduser =Convert.ToString(sql.ObtenerIdUsuario(lgnusuario.Text));
//            public string idbit = idinterno; 
        }
        private void Lgningresar_Click(object sender, EventArgs e)
        {

            int Nidbit;
            string IdNuevo;
            lbidbit.Text = Convert.ToString(sql.ObtidnewBit());
            Nidbit = Convert.ToInt32(lbidbit.Text);
            if (lbidbit.Text == Convert.ToString(Nidbit))

            {
                IdNuevo = Convert.ToString(Nidbit + 1);

                lbidbit.Text = IdNuevo;

            }
            label3.Text = Convert.ToString(sql.ObtenerIdUsuario(lgnusuario.Text));

            if (sql.LoginUsuario(lgnusuario.Text, (Seguridad.Cifrar(lgncontraseña.Text))))

            {
                MessageBox.Show(
                "Bienvenido " + lgnusuario.Text + " ", "Acceso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                sql.BitacoraSesion(lbidbit.Text,label3.Text, lbfecha.Text);
                this.Hide();
                Principal inicio = new Principal();
                inicio.Show();
            }
            else
            {
                MessageBox.Show(
                "Los datos no son Corectos !!! ",

                "Acceso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            //lbhora.Text = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss"); 
            lbfecha.Text = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss");
        }

        
    }
}
    

