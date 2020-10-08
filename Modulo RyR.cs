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
using System.IO;

namespace IACC2020
{
    public partial class Modulo_RyR : Form
    {
        public Modulo_RyR()
        {
            InitializeComponent();
        }
        
        private void RespaldarDB_Click(object sender, EventArgs e)
        {
            bool desea_respaldar = true;

            //poner cursor de reloj
            Cursor.Current = Cursors.WaitCursor;

            if (Directory.Exists(@"c:\ Respaldo"))
            {
                if (File.Exists(@"c:\ Respaldo\resp.bak"))
                {
                    if (MessageBox.Show(@"Ya habia un respaldo anteriormente ¿desea remplazarlo?", "Respaldo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        File.Delete(@"c:\ Respaldo\resp.bak");
                    }
                    else
                        desea_respaldar = false;
                }
            }
            else
                Directory.CreateDirectory(@"c:\ Respaldo");

            if (desea_respaldar)
            {
                //comando para conectar BD-----------
                SqlConnection connect;
                string con = "Data Source=DESKTOP-A779MQ8;Initial Catalog=supermercado;Integrated Security=True";
                connect = new SqlConnection(con);
                connect.Open();
                //-------------------------------------------------------------------------

                //comando para respaldar base de datos
                SqlCommand command;
                command = new SqlCommand(@"backup database supermercado to disk ='c:\ Respaldo\resp.bak' with init,stats=10", connect);
                command.ExecuteNonQuery();
                //-------------------------------------------------------------------------

                connect.Close();

                MessageBox.Show("El Respaldo de la base de datos fue realizado satisfactoriamente", "Respaldo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void RestaurarBD_Click(object sender, EventArgs e)
        {
            //poner cursor de reloj
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                if (File.Exists(@"c:\ Respaldo\resp.bak"))
                {
                    if (MessageBox.Show("¿Está seguro de restaurar?", "Restauracion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //Comando conexion BD-----------
                        SqlConnection connect;
                        string con = "Data Source=DESKTOP-A779MQ8;Initial Catalog=supermercado;Integrated Security=True";
                        connect = new SqlConnection(con);
                        connect.Open();
                        //--------------------------------------------------------------------------

                        //esto puede ser un método aparte para ejecutar comandos SQL----------------
                        SqlCommand command;
                        command = new SqlCommand("use master", connect);
                        command.ExecuteNonQuery();
                        command = new SqlCommand(@"restore database supermercado from disk = 'c:\ Respaldo\resp.bak'", connect);
                        command.ExecuteNonQuery();
                        //--------------------------------------------------------------------------
                        connect.Close();

                        MessageBox.Show("Se ha restaurado la base de datos", "Restauración", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                    MessageBox.Show(@"No haz hecho ningun respaldo anteriormente (o no está en la ruta correcta)", "Restauracion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

        }
    }
}
