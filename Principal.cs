using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace IACC2020
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }
        ConsultasSQL sql = new ConsultasSQL();
        private void GestionarProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Form1 proveedor = new Form1();
            proveedor.Show();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
        private void Timer1_Tick_1(object sender, EventArgs e)
        {
            //lbhora.Text = DateTime.Now.ToString("hh:mm:ss");
            lbfecha.Text = DateTime.Now.ToString("dd - MM - yyyy hh: mm:ss");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //int Nidbit;
            //string IdNuevo;
            lbiD.Text = Convert.ToString(sql.ObtidnewBit());
            //Nidbit = Convert.ToInt32(lbiD.Text);

            sql.CerrarSesión(lbfecha.Text, lbiD.Text);
            this.Close();
            Login sesionnew = new Login();
            sesionnew.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Process.Start("C:/Manual_de_uso.pdf");
        }

        private void ProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void GestionarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManUsers GestionUser = new ManUsers();
            GestionUser.Show();
        }

        private void RespaldoYRestauraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modulo_RyR ryr = new Modulo_RyR();
            ryr.Show();
        }

        private void GestionarCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
           CatProductos CatPro = new CatProductos();
            CatPro.Show();
        }

        private void GestionarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionProductos GesPro = new GestionProductos();
            GesPro.Show();
        }

        private void RegistarBajaVencimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void LímitesParaReponerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Limites Limforms = new Limites();
            Limforms.Show();
        }
    }
    
}
