using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IACC2020
{
    public partial class CatProductos : Form
    {
        public CatProductos()
        {
            InitializeComponent();
            string prueba = "Cambio para verificar repositorio";
        }
        ConsultasSQL sql = new ConsultasSQL();
        private void GridCatPrdouctos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = GridCatPrdouctos.Rows[e.RowIndex];
            IDCatPro.Text = Convert.ToString(fila.Cells[0].Value);
            NomCatPro.Text = Convert.ToString(fila.Cells[1].Value);

        }
        private void CatProductos_Load(object sender, EventArgs e)
        {
            GridCatPrdouctos.DataSource = sql.MostrarCatProductos();
        }
        private bool ValidarCampos()
        {
            bool no_error = true;

            if (NomCatPro.Text == string.Empty)
            {
                errorCatPro.Clear();
                errorCatPro.SetError(NomCatPro, "Debe ingresar un nombre");
                no_error = false;

            }
            return no_error;
            
        }

        private void LimCatPro_Click(object sender, EventArgs e)
        {
            {
                LimCatFomrs();
            }
        }
        public void LimCatFomrs()
        {
            IDCatPro.Clear();
            NomCatPro.Clear();
            errorCatPro.Clear();
            
        }

        private void AgregarCatPro_Click(object sender, EventArgs e)
        {
            int Nid;
            string IdNuevo;
            NewIDCatPro.Text = Convert.ToString(sql.ObtidnewCatPro());
            Nid = Convert.ToInt32(NewIDCatPro.Text);
            if (NewIDCatPro.Text == Convert.ToString(Nid))

            {
                IdNuevo = Convert.ToString(Nid + 1);

                IDCatPro.Text = IdNuevo;

            }          
            if (ValidarCampos() && (sql.ExisteCatPro(NomCatPro.Text) && (sql.InsertCatPro(IDCatPro.Text, NomCatPro.Text))))
            {

                MessageBox.Show("Datos ingresado Correctamente", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GridCatPrdouctos.DataSource = sql.MostrarCatProductos();

                LimCatFomrs();

            }
            else
            {
                MessageBox.Show("No se han podido insertar los datos", "Por favor verificar los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimCatFomrs();
            }
        }

        private void ModCatPro_Click(object sender, EventArgs e)
        {
            {
                GridCatPrdouctos.DataSource = sql.MostrarCatProductos();
                if ((sql.ActualizarCatPro(IDCatPro.Text, NomCatPro.Text)) && (ValidarCampos()))
                {
                    errorCatPro.Clear();
                    MessageBox.Show("Datos actualizados correctamente", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimCatFomrs();
                    GridCatPrdouctos.DataSource = sql.MostrarCatProductos();
                }
                else MessageBox.Show("No se han podido actualizar los datos", "Error al cambiar los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void ElimCatPro_Click(object sender, EventArgs e)
        {
            GridCatPrdouctos.DataSource = sql.MostrarCatProductos();
            if (sql.EliminarCatPro(IDCatPro.Text))
            {
                MessageBox.Show("Datos eliminados", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                LimCatFomrs();
                GridCatPrdouctos.DataSource = sql.MostrarCatProductos();
            }
            else MessageBox.Show("No se han podido eliminar los datos");
        }
    }
}
