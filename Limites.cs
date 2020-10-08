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
    public partial class Limites : Form
    {
        public Limites()
        {
            InitializeComponent();
        }
        ConsultasSQL sql = new ConsultasSQL();
        private void Limites_Load(object sender, EventArgs e)
        {
            GridLim.DataSource = sql.MostrarLimites();
        }

        private void GridLim_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = GridLim.Rows[e.RowIndex];
            IDLimite.Text = Convert.ToString(fila.Cells[0].Value);
            IDProducto.Text = Convert.ToString(fila.Cells[1].Value);
            LimiteMod.Text = Convert.ToString(fila.Cells[6].Value);
        }
        public void Limpiar()
        {
            IDLimite.Clear();
            IDProducto.Clear();
            LimiteMod.Clear();
            errorlimite.Clear();
        }
        private bool ValidarCampos()
        {
            bool no_error = true;

            if (LimiteMod.Text == string.Empty)
            {
                errorlimite.Clear();
                errorlimite.SetError(LimiteMod, "Debe ingresar una cantidad");
                no_error = false;

            }
            return no_error;
        }

            private void AgrLim_Click(object sender, EventArgs e)
        {
            Nuevo_Lim LimNew = new Nuevo_Lim();
            LimNew.Show();
        }

        private void ModLim_Click(object sender, EventArgs e)
        {
            if(ValidarCampos() && (sql.ActualizarLimite(IDProducto.Text, LimiteMod.Text, IDLimite.Text)))
            {
                errorlimite.Clear();
                MessageBox.Show("Límites actualizados correctamente", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
                GridLim.DataSource = sql.MostrarLimites();
            }
            else MessageBox.Show("No se han podido actualizar los límites", "Error al cambiar los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void ElimLim_Click(object sender, EventArgs e)
        {
            GridLim.DataSource = sql.MostrarLimites();
            if (sql.EliminarLimite(IDLimite.Text))
            {
                MessageBox.Show("Datos eliminados", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Limpiar();
                GridLim.DataSource = sql.MostrarLimites();
            }
            else MessageBox.Show("No se han podido eliminar los datos");
        }
    }
}
