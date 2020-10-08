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
    public partial class Nuevo_Lim : Form
    {
        public Nuevo_Lim()
        {
            InitializeComponent();
        }
        ConsultasSQL sql = new ConsultasSQL();
        private void Nuevo_Lim_Load(object sender, EventArgs e)
        {
            GridNewLIm.DataSource = sql.MostrarSinLimites();
        }

        private void GridNewLIm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = GridNewLIm.Rows[e.RowIndex];
            IDProLim.Text = Convert.ToString(fila.Cells[0].Value);
        }
        private bool ValidarCampos()
        {
            bool no_error = true;

            if (LimNuevo.Text == string.Empty)
            {
                errorNewLim.Clear();
                errorNewLim.SetError(LimNuevo, "Debe ingresar una cantidad");
                no_error = false;

            }
            return no_error;
        }
        public void LimTexbox()
        {
            IDLim.Clear();
            IDProLim.Clear();
            LimNuevo.Clear();
            errorNewLim.Clear();
        }

        private void LimNuevo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void GuardarLimNew_Click(object sender, EventArgs e)
        {
            int NidUsr;
            string IdNuevo;
            NewIDLim.Text = Convert.ToString(sql.ObtidnewLimite());
            NidUsr = Convert.ToInt32(NewIDLim.Text);

            if (NewIDLim.Text == Convert.ToString(NidUsr))

            {
                IdNuevo = Convert.ToString(NidUsr + 1);

                NewIDLim.Text = IdNuevo;

            }
            if (ValidarCampos() && sql.InsertLimite(NewIDLim.Text, IDProLim.Text, LimNuevo.Text))
            {

                MessageBox.Show("Límite ingresado Correctamente", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GridNewLIm.DataSource = sql.MostrarSinLimites();
                LimTexbox();
            }

            else
            {
                MessageBox.Show("No se han podido insertar el límite", "Por favor verificar los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void IDProLim_TextChanged(object sender, EventArgs e)
        {

        }

        private void IDProLim_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void LimNuevo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
