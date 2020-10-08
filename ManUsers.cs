using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;


namespace IACC2020
{
    public partial class ManUsers : Form
    {
        public ManUsers()
        {
            InitializeComponent();
        }
        ConsultasSQL sql = new ConsultasSQL();
        
        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ManUsers_Load(object sender, EventArgs e)
        {
            tbuser.DataSource = sql.MostrarUser();
            IDuser.Enabled = false;
            IDuser.ReadOnly = true;
            newID.Visible = false;

        }
        public void LimUser()
        {
            IDuser.Clear();
            NomUser.Clear();
            PassUser.Clear();
            errorUser.Clear();
        }


        private void Tbuser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = tbuser.Rows[e.RowIndex];
            IDuser.Text = Convert.ToString(fila.Cells[0].Value);
            NomUser.Text = Convert.ToString(fila.Cells[1].Value);
            PassUser.Text = Convert.ToString(fila.Cells[2].Value);
            
            if (Convert.ToInt32(fila.Cells[3].Selected) == 1)
            {
                selectAdm.Checked = Convert.ToBoolean(fila.Cells[3].Value);
            }
            else
            {
                selecVende.Checked = Convert.ToBoolean(fila.Cells[3].Selected);
            }
            
        }
        private bool ValidarCampos()
        {
            bool no_error = true;

            if (NomUser.Text == string.Empty)
            {
                errorUser.Clear();
                errorUser.SetError(NomUser, "Debe ingresar un nombre de usuario");
                no_error = false;

            }
            else if (PassUser.Text == string.Empty)
            {
                errorUser.Clear();
                errorUser.SetError(PassUser, "Debe ingresar una contraseña");
                no_error = false;

            }

            return no_error;
        }
        
        private void BtAgregar_Click(object sender, EventArgs e)
        {
            int NidUsr;
            string IdNuevo;
            newID.Text = Convert.ToString(sql.ObtidnewUser());
            NidUsr = Convert.ToInt32(newID.Text);

            if (newID.Text == Convert.ToString(NidUsr))

            {
                IdNuevo = Convert.ToString(NidUsr + 1);

                IDuser.Text = IdNuevo;

            }
            int tipo = 0; ;
            if (selectAdm.Checked)
            {
                tipo = 1;

            }
            else if (selecVende.Checked)
            {
                tipo = 2;
            }
            //string pass = "";
            //if (btAgregar.Capture==true)
            //{ pass = PassUser.Text;
            //    Seguridad.Cifrar(pass);
            //} 
            
            if (ValidarCampos() && sql.ExisteUser(NomUser.Text) && sql.InsertUser(IDuser.Text, NomUser.Text, PassUser.Text=Seguridad.Cifrar(PassUser.Text), tipo))
            {

                MessageBox.Show("Datos ingresado Correctamente", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbuser.DataSource = sql.MostrarUser();
                LimUser();
            }
          
            else
            {
                MessageBox.Show("No se han podido insertar los datos", "Por favor verificar los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

        }

        private void BtMod_Click(object sender, EventArgs e)
        {
            int tipo = 0; ;
            if (selectAdm.Checked)
            {
                tipo = 1;

            }
            else if (selecVende.Checked)
            {
                tipo = 2;
            }
            tbuser.DataSource = sql.MostrarUser();
            if ((sql.ActualizarUser(IDuser.Text, NomUser.Text, PassUser.Text=Seguridad.Cifrar(PassUser.Text), tipo)) && (ValidarCampos()))
            {
                errorUser.Clear();
                MessageBox.Show("Datos actualizados correctamente", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimUser();
                tbuser.DataSource = sql.MostrarUser();
            }
            else MessageBox.Show("No se han podido actualizar los datos", "Error al cambiar los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void BtEli_Click(object sender, EventArgs e)
        {
            tbuser.DataSource = sql.MostrarUser();
            if (sql.ElimUser(IDuser.Text))
            {
                MessageBox.Show("Datos eliminados", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                LimUser();
                tbuser.DataSource = sql.MostrarUser();
            }
            else MessageBox.Show("No se han podido eliminar los datos");
        }

        private void LimDatosUser_Click(object sender, EventArgs e)
        {
            LimUser();
        }

        private void BuscarUser_TextChanged(object sender, EventArgs e)
        {
            {
                if (BuscarUser.Text != "") tbuser.DataSource = sql.BuscardatosUser(BuscarUser.Text);
                else tbuser.DataSource = sql.MostrarUser();
            }
        }
    }
}

