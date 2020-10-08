using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IACC2020
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ConsultasSQL sql = new ConsultasSQL();
        private void Form1_Load(object sender, EventArgs e)
        {
            tbprov.DataSource = sql.MostrarDatosPrv();
           
            Idprv.Enabled = false;
            Idprv.ReadOnly = true;
            newid.Visible = false;
            nombreprov.Text = string.Empty;
            dirprov.Text = string.Empty;
            rutprov.Text = string.Empty;
            buscarprov.Text = string.Empty;


        }
        private void Tbprov_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = tbprov.Rows[e.RowIndex];
            Idprv.Text = Convert.ToString(fila.Cells[0].Value);
            nombreprov.Text = Convert.ToString(fila.Cells[1].Value);
            dirprov.Text = Convert.ToString(fila.Cells[2].Value);
            rutprov.Text = Convert.ToString(fila.Cells[3].Value);

        }
        private bool ValidarCampos()
        {
            bool no_error = true;

            if (nombreprov.Text == string.Empty)
            {
                errorprv.Clear();
                errorprv.SetError(nombreprov, "Debe ingresar un nombre");
                no_error = false;
                
            }
            else if (dirprov.Text == string.Empty)
            {
                errorprv.Clear();
                errorprv.SetError(dirprov, "Debe ingresar una dirección");
                no_error = false;
               
            }
            else if (rutprov.Text == string.Empty)
            {
                errorprv.Clear();
                errorprv.SetError(rutprov, "Debe ingresar un rut");
                no_error = false;
                
            }

            return no_error;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int Nidprv;
            string IdNuevo;
            newid.Text = Convert.ToString(sql.ObtidnewPrv());
            Nidprv = Convert.ToInt32(newid.Text);
            if (newid.Text == Convert.ToString(Nidprv))

            {
                IdNuevo = Convert.ToString(Nidprv + 1);

                Idprv.Text = IdNuevo;
               
            }
            //if (ValidarCampos()==true &&(sql.ExistePrV(nombreprov.Text, dirprov.Text, rutprov.Text) == false))
            //{
            //else if (sql.ExistePrV(nombreprov.Text, dirprov.Text, rutprov.Text) == (sql.InsertPrv(Idprv.Text, nombreprov.Text, dirprov.Text, rutprov.Text)))
            //{
            if (ValidarCampos() && (sql.ExistePrV(nombreprov.Text, dirprov.Text, rutprov.Text) && (sql.InsertPrv(Idprv.Text, nombreprov.Text, dirprov.Text, rutprov.Text))))
            {

                MessageBox.Show("Datos ingresado Correctamente", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbprov.DataSource = sql.MostrarDatosPrv();

                LimPrv();

            }
            //}
            else
            {
                MessageBox.Show("No se han podido insertar los datos", "Por favor verificar los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimPrv();
            }

            //}
            //else
            //{
            //MessageBox.Show("No se puede agregar el proveedor", "El Proveedor ya existe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}

        }


        private void Mdprov_Click(object sender, EventArgs e)
        {
            tbprov.DataSource = sql.MostrarDatosPrv();
            if ((sql.Actualizar(Idprv.Text, nombreprov.Text, dirprov.Text, rutprov.Text)) && (ValidarCampos()))
            {
                errorprv.Clear();
                MessageBox.Show("Datos actualizados correctamente", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimPrv();
                tbprov.DataSource = sql.MostrarDatosPrv();
            }
            else MessageBox.Show("No se han podido actualizar los datos", "Error al cambiar los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void Eliprv_Click(object sender, EventArgs e)
        {
            tbprov.DataSource = sql.MostrarDatosPrv();
            if (sql.Eliminar(Idprv.Text))
            {
                MessageBox.Show("Datos eliminados", "Validación", MessageBoxButtons.OK,MessageBoxIcon.Stop);
                LimPrv();
                tbprov.DataSource = sql.MostrarDatosPrv();
            }
            else MessageBox.Show("No se han podido eliminar los datos");
        }

        private void Buscarprov_TextChanged(object sender, EventArgs e)
        {
            {
                if (buscarprov.Text != "") tbprov.DataSource = sql.BuscardatosPrv(buscarprov.Text);
                else tbprov.DataSource = sql.MostrarDatosPrv();
            }
        }

        private void Limprv_Click(object sender, EventArgs e)
        {
            LimPrv();
        }
        public void LimPrv()
        {
            Idprv.Clear();
            nombreprov.Clear();
            dirprov.Clear();
            rutprov.Clear();
            errorprv.Clear();
        }

        private void Idprv_TextChanged(object sender, EventArgs e)
        {
            //Idprv.Enabled = false;
            //Idprv.ReadOnly = true;
        }

    }
}
