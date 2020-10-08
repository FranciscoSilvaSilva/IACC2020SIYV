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
    public partial class GestionProductos : Form
    {
        public GestionProductos()
        {
            InitializeComponent();
        }
        ConsultasSQL sql = new ConsultasSQL();

        private void GestionProductos_Load(object sender, EventArgs e)
        {
            GridPro.DataSource = sql.MostrarDatosProductos();

            DataTable dt = sql.CategoriaProductos();
            CboxCatPro.DataSource = dt;
            CboxCatPro.ValueMember = "Id_Catproducto";
            CboxCatPro.DisplayMember = "Nombre";

            DataTable dt2 = sql.MostrarPrvProductos();
            CBoxPrvPro.DataSource = dt2;
            CBoxPrvPro.ValueMember = "Id_proveedor";
            CBoxPrvPro.DisplayMember = "Nombre";

            CboxCatPro.SelectedIndex = -1;
            CBoxPrvPro.SelectedIndex = -1;
        }

        private void GridPro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = GridPro.Rows[e.RowIndex];
            IDPro.Text = Convert.ToString(fila.Cells[0].Value);
            NomPro.Text = Convert.ToString(fila.Cells[1].Value);
            if (Convert.ToInt32(fila.Cells[2].Value) == 1)
            {
                RdDisponible.Checked = Convert.ToBoolean(fila.Cells[3].Value);
            }
            else
            {
                RdNoDisponible.Checked = Convert.ToBoolean(fila.Cells[3].Value);
            }
            StockPro.Text = Convert.ToString(fila.Cells[3].Value);
            PrecioPro.Text = Convert.ToString(fila.Cells[4].Value);
            DesPro.Text = Convert.ToString(fila.Cells[5].Value);
            VenFecha.Text = Convert.ToString(fila.Cells[6].Value);
            CboxCatPro.Text = Convert.ToString(fila.Cells[7].Value);
            CBoxPrvPro.Text = Convert.ToString(fila.Cells[8].Value);
            
;        }
        public void LimTextPro()
        {
            IDPro.Clear();
            NomPro.Clear();
            StockPro.Clear();
            PrecioPro.Clear();
            DesPro.Clear();
            CboxCatPro.SelectedIndex = -1;
            CBoxPrvPro.SelectedIndex = -1;
            errorPro.Clear();
            Calendario.SetDate(DateTime.Now);
        }
        private bool ValidarCampos()
        {
            bool no_error = true;

            if (NomPro.Text == string.Empty)
            {
                errorPro.Clear();
                errorPro.SetError(NomPro, "Debe ingresar un nombre de Nombre de producto");
                no_error = false;

            }
            else if (StockPro.Text == string.Empty)
            {
                errorPro.Clear();
                errorPro.SetError(StockPro, "Debe ingresar stock");
                no_error = false;

            }
            else if (PrecioPro.Text == string.Empty)
            {
                errorPro.Clear();
                errorPro.SetError(PrecioPro, "Debe ingresar un precio para el producto");
                no_error = false;

            }
            return no_error;
        }

        private void CboxCatPro_SelectedIndexChanged(object sender, EventArgs e)
        {
            //sql.ObtenerCategoria();
        }

        private void AgregarPro_Click(object sender, EventArgs e)
        {

            int Nid;
            string IdNuevo;
            IDnew.Text = Convert.ToString(sql.ObtidnewProducto());
            Nid = Convert.ToInt32(IDnew.Text);

            if (IDnew.Text == Convert.ToString(Nid))

            {
                IdNuevo = Convert.ToString(Nid + 1);

                IDnew.Text = IdNuevo;

            }
            int tipo = 1; ;
            if (RdDisponible.Checked)
            {
                tipo = 1;

            }
            else if (RdNoDisponible.Checked)
            {
                tipo = 0;
            }
            if (ValidarCampos() && sql.InsertProducto(IDnew.Text,NomPro.Text, Convert.ToString(tipo), StockPro.Text, PrecioPro.Text, DesPro.Text,VenFecha.Text, Convert.ToString(CboxCatPro.SelectedValue), Convert.ToString(CBoxPrvPro.SelectedValue)) )
            {

                MessageBox.Show("Datos ingresado Correctamente", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GridPro.DataSource = sql.MostrarDatosProductos();
                LimTextPro();
            }

            else
            {
                MessageBox.Show("No se han podido insertar los datos", "Por favor verificar los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void ModPro_Click(object sender, EventArgs e)
        {
            int tipo = 1; ;
            if (RdDisponible.Checked)
            {
                tipo = 1;

            }
            else if (RdNoDisponible.Checked)
            {
                tipo = 0;
            }
            GridPro.DataSource = sql.MostrarDatosProductos();
            if ((sql.ActualizarProducto(IDPro.Text, NomPro.Text,Convert.ToString(tipo), StockPro.Text, PrecioPro.Text, DesPro.Text,VenFecha.Text, Convert.ToString(CboxCatPro.SelectedValue), Convert.ToString(CBoxPrvPro.SelectedValue))) && (ValidarCampos()))
            {
                errorPro.Clear();
                MessageBox.Show("Datos actualizados correctamente", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimTextPro();
                GridPro.DataSource = sql.MostrarDatosProductos();
            }
            else MessageBox.Show("No se han podido actualizar los datos", "Error al cambiar los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void ElimPro_Click(object sender, EventArgs e)
        {
            GridPro.DataSource = sql.MostrarDatosProductos();
            if (sql.EliminarProducto(IDPro.Text))
            {
                MessageBox.Show("Datos eliminados", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                LimTextPro();
                GridPro.DataSource = sql.MostrarDatosProductos();
            }
            else MessageBox.Show("No se han podido eliminar los datos");
        }

        private void LimPro_Click(object sender, EventArgs e)
        {
            LimTextPro();
        }

        public void Calendario_DateChanged(object sender, DateRangeEventArgs e)
        {
            VenFecha.Text = Calendario.SelectionRange.End.ToShortDateString();
        }

        private void BusPro_TextChanged(object sender, EventArgs e)
        {
            {
                if (BusPro.Text != "") GridPro.DataSource = sql.BuscardatosPro(BusPro.Text);
                else GridPro.DataSource = sql.MostrarDatosProductos();
            }
        }
    }
}
