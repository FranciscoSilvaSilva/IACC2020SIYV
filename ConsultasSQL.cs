using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace IACC2020
{
    class ConsultasSQL
    {
        private SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-A779MQ8;Initial Catalog=supermercado;Integrated Security=True");
        private DataSet ds;


        // Sql Proveedor
        public DataTable MostrarDatosPrv()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT P.Id_proveedor'ID', P.Nombre, P.Direccion, P.Rut FROM Proveedor P", conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tbprov");
            conexion.Close();
            return ds.Tables["tbprov"];

        }

        public DataTable BuscardatosPrv(string nombre)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("select * from Proveedor where Nombre like '%{0}%'", nombre), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tbprov");
            conexion.Close();
            return ds.Tables["tbprov"];
        }
        public bool InsertPrv(string Id, string Nombre, string Direccion, string Rut)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("insert into Proveedor values ({0}, '{1}', '{2}', '{3}')", new string[] { Id, Nombre, Direccion, Rut }), conexion);
            int filasafectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasafectadas > 0) return true;
            else return false;

        }
        public bool Eliminar(string id)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("delete from Proveedor where Id_proveedor = {0}", id), conexion);
            int filasafectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasafectadas > 0) return true;
            else return false;
        }

        public bool Actualizar(string id, string nombre, string direccion, string rut)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("update Proveedor set Nombre = '{0}', Direccion = '{1}', Rut = '{2}' where Id_proveedor = {3}", new string[] { nombre, direccion, rut, id }), conexion);
            int filasafectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasafectadas > 0) return true;
            else return false;
        }

        public int ObtidnewPrv()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("select Id_Proveedor from Proveedor where Id_Proveedor = (select MAX(Id_Proveedor) from Proveedor)", conexion);
            int MaxId = Convert.ToInt32(cmd.ExecuteScalar());
            conexion.Close();
            return MaxId;
        }

        public bool ExistePrV(string nombre, string direccion, string rut)
        {
            string nbr;
            string dir;
            string rt;
            bool valida = true;
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("Select Nombre From Proveedor where Nombre = '{0}'", new string[] { nombre }), conexion);
            SqlCommand cmd1 = new SqlCommand(string.Format("Select Direccion From Proveedor where Direccion ='{0}'", new string[] { direccion }), conexion);
            SqlCommand cmd2 = new SqlCommand(string.Format("Select Rut From Proveedor where Rut = '{0}'", new string[] { rut }), conexion);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                nbr = rd["Nombre"].ToString();
                if (string.Equals(nbr, nombre))
                {
                    return valida = false;
                }
                return valida = false;
            }
            rd.Close();
            SqlDataReader rd1 = cmd1.ExecuteReader();
            if (rd1.Read())
            {
                dir = rd1["Direccion"].ToString();
                if (string.Equals(dir, direccion))
                {
                    rd1.Close();
                }
                return valida = false;
            }
            rd1.Close();
            SqlDataReader rd2 = cmd2.ExecuteReader();
            if (rd2.Read())
            {
                rt = rd2["Rut"].ToString();
                if (string.Equals(rt, rut))
                {
                    rd2.Close();
                }
                return valida = false;
            }
            rd2.Close();
            conexion.Close();
            return valida;
            //string valida = Convert.ToString(cmd.ExecuteScalar());

            // string loguser = Convert.ToString(cmd.Parameters(usuario)); 
            //conexion.Close();
            //if (valida != string.Empty) return true;
            //else return false;



            //Int32 valida = Convert.ToInt32(cmd.ExecuteScalar());
            //conexion.Close();
            //if (valida == 0) return true;
            //else return false;


            ////int count = Convert.ToInt32(cmd.ExecuteScalar());
            ////if (count == 0)
            ////{
            ////    conexion.Close();
            ////    return false;
            ////}
            ////else
            ////{
            ////    conexion.Close();
            ////    return true;
            ////}


        }
        //Bitacora
        public bool BitacoraSesion(string id, string iduser, string fecha)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("insert into Bitacora(Id_bitacora,Fk_IdUsuario,Fecha) values ({0},{1},CONVERT(smalldatetime,'{2}'))", new string[] { id, iduser, fecha }), conexion);
            int filasafectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasafectadas > 0) return true;
            else return false;

        }
        public int ObtenerIdUsuario(string nombre)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("select Id_usuarios from Usuarios where Nombre = '{0}'", new string[] { nombre }), conexion);
            int Id = Convert.ToInt32(cmd.ExecuteScalar());
            conexion.Close();
            return Id;


        }
        public int ObtidnewBit()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("select Id_bitacora from Bitacora where Id_bitacora = (select MAX(Id_bitacora) from Bitacora)", conexion);
            int MaxId = Convert.ToInt32(cmd.ExecuteScalar());
            conexion.Close();
            return MaxId;
        }


        // Sql Login

        public bool LoginUsuario(string usuario, string contraseña)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("Select Nombre From Usuarios where Nombre = '{0}' and Contraseña = '{1}'", new string[] { usuario, contraseña }), conexion);
            string user = Convert.ToString(cmd.ExecuteScalar());

            // string loguser = Convert.ToString(cmd.Parameters(usuario)); 
            conexion.Close();
            if (user != string.Empty) return true;
            else return false;
        }
        public bool CerrarSesión(string fecha, string id)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("update Bitacora set FechaSalida = CONVERT(smalldatetime,'{0}') where Id_bitacora = {1}", new string[] { fecha, id }), conexion);
            int filasafectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasafectadas > 0) return true;
            else return false;
        }

        // Mantencion Usuarios

        public DataTable MostrarUser()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT U.Id_usuarios'ID', U.Nombre, U.Contraseña, T.Nombre_tipo'Tipo de usuario' FROM Usuarios U, [Tipos de usuario] T WHERE U.Fk_tipo = T.Id_tipo_usuario", conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tbuser");
            conexion.Close();
            return ds.Tables["tbuser"];

        }
        public DataTable BuscardatosUser(string nombre)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("select * from Usuarios where Nombre like '%{0}%'", nombre), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tbuser");
            conexion.Close();
            return ds.Tables["tbuser"];
        }
        public bool InsertUser(string Id, string Nombre, string Contraseña, int Tipo)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("insert into usuarios values ({0}, '{1}', '{2}', {3})", new string[] { Id, Nombre, Contraseña, Convert.ToString(Tipo) }), conexion);
            int filasafectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasafectadas > 0) return true;
            else return false;

        }
        public bool ElimUser(string id)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("delete from Usuarios where Id_usuarios = {0}", id), conexion);
            int filasafectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasafectadas > 0) return true;
            else return false;
        }

        public bool ActualizarUser(string id, string nombre, string Contraseña, int tipo)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("update Usuarios set Nombre = '{0}', Contraseña = '{1}', Fk_tipo = '{2}' where Id_usuarios = {3}", new string[] { nombre, Contraseña, Convert.ToString(tipo), id }), conexion);
            int filasafectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasafectadas > 0) return true;
            else return false;
        }
        public int ObtidnewUser()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("select Id_usuarios from Usuarios where Id_usuarios = (select MAX(Id_usuarios) from Usuarios)", conexion);
            int MaxId = Convert.ToInt32(cmd.ExecuteScalar());
            conexion.Close();
            return MaxId;
        }

        public bool ExisteUser(string nombre)
        {
            string nbr;
            bool valida = true;
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("Select Nombre From Usuarios where Nombre = '{0}'", new string[] { nombre }), conexion);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                nbr = rd["Nombre"].ToString();
                if (string.Equals(nbr, nombre))
                {
                    return valida = false;
                }
                return valida = false;
            }
            rd.Close();
            conexion.Close();
            return valida;

        }
        // Categoría Productos
        public DataTable MostrarCatProductos()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT C.Id_Catproducto'ID', C.Nombre FROM[Categoria Producto] C", conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "GridCatPrdouctos");
            conexion.Close();
            return ds.Tables["GridCatPrdouctos"];

        }

        /*public DataTable BuscarCatProductos(string nombre)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("select * from Proveedor where Nombre like '%{0}%'", nombre), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tbprov");
            conexion.Close();
            return ds.Tables["tbprov"];
        }*/
        public bool InsertCatPro(string Id, string Nombre)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("insert into [Categoria Producto] values ({0}, '{1}')", new string[] { Id, Nombre }), conexion);
            int filasafectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasafectadas > 0) return true;
            else return false;

        }
        public bool EliminarCatPro(string id)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("delete from [Categoria Producto] where Id_Catproducto = {0}", id), conexion);
            int filasafectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasafectadas > 0) return true;
            else return false;
        }

        public bool ActualizarCatPro(string id, string nombre)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("update [Categoria Producto] set Nombre = '{0}' where Id_Catproducto = {1}", new string[] { nombre, id }), conexion);
            int filasafectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasafectadas > 0) return true;
            else return false;
        }

        public int ObtidnewCatPro()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("select Id_Catproducto from [Categoria Producto] where Id_Catproducto = (select MAX(Id_Catproducto) from [Categoria Producto])", conexion);
            int MaxId = Convert.ToInt32(cmd.ExecuteScalar());
            conexion.Close();
            return MaxId;
        }

        public bool ExisteCatPro(string nombre)
        {
            string nbr;

            bool valida = true;
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("Select Nombre From [Categoria Producto] where Nombre = '{0}'", new string[] { nombre }), conexion);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                nbr = rd["Nombre"].ToString();
                if (string.Equals(nbr, nombre))
                {
                    return valida = false;
                }
                return valida = false;
            }
            rd.Close();
            conexion.Close();
            return valida;
        }
        // Productos
        public DataTable MostrarDatosProductos()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT P.Id_Producto'ID', P.Nombre, P.Estado, P.Stock, P.Precio, P.Descripcion, P.Fecha_Vecimiento'Fecha Vencimiento', C.Nombre'Categoría Producto', R.Nombre'Proveedor' FROM Producto P, [Categoria Producto] C, Proveedor R WHERE P.Fk_Categoria = C.Id_Catproducto And P.Fk_Proveedor = R.Id_proveedor", conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "GridPro");
            conexion.Close();
            return ds.Tables["GridPro"];

        }
        public DataTable BuscardatosPro(string nombre)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("select * from Producto where Nombre like '%{0}%'", nombre), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "GridPro");
            conexion.Close();
            return ds.Tables["GridPro"];
        }

        public DataTable BuscardatosProducto(string nombre)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("select * from Producto where Nombre like '%{0}%'", nombre), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "GridPro");
            conexion.Close();
            return ds.Tables["GridPro"];
        }
        public bool InsertProducto(string Id, string Nombre, string estado, string stock, string precio, string descripcion,string fechaV, string cat, string prov)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("insert into Producto values ({0}, '{1}', {2}, {3}, {4}, '{5}', '{6}', {7}, {8})", new string[] { Id, Nombre, estado, stock,precio,descripcion,fechaV,cat,prov }), conexion);
            int filasafectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasafectadas > 0) return true;
            else return false;

        }
        public bool EliminarProducto(string id)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("delete from Producto where Id_Producto = {0}", id), conexion);
            int filasafectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasafectadas > 0) return true;
            else return false;
        }

        public bool ActualizarProducto(string Id, string Nombre, string estado, string stock, string precio, string descripcion, string fechaV, string cat, string prov)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("update Producto set Nombre = '{0}', Estado = {1}, Stock = {2}, Precio ={3}, Descripcion = '{4}', Fecha_Vecimiento = '{5}' ,Fk_Categoria = {6}, Fk_Proveedor = {7} where Id_Producto = {8}", new string[] { Nombre, estado,stock,precio, descripcion,fechaV , cat,prov, Id }), conexion);
            int filasafectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasafectadas > 0) return true;
            else return false;
        }

        public int ObtidnewProducto()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("select Id_Producto from Producto where Id_Producto = (select MAX(Id_Producto) from Producto)", conexion);
            int MaxId = Convert.ToInt32(cmd.ExecuteScalar());
            conexion.Close();
            return MaxId;
        }
        public  DataTable CategoriaProductos()
        {
           conexion.Open();
                using (var da = new SqlDataAdapter())
                {
                    using (var cmd = conexion.CreateCommand())
                    {
                        cmd.CommandText = "SELECT Id_Catproducto, Nombre FROM [Categoria Producto]";
                        da.SelectCommand = cmd;
                        var dt = new DataTable();
                        da.Fill(dt);
                        conexion.Close();
                    return dt;
                    }
                }           
        }
        public DataTable MostrarPrvProductos()
        {
            conexion.Open();
            using (var da = new SqlDataAdapter())
            {
                using (var cmd = conexion.CreateCommand())
                {
                    cmd.CommandText = "SELECT Id_proveedor, Nombre FROM Proveedor";
                    da.SelectCommand = cmd;
                    var dt2 = new DataTable();
                    da.Fill(dt2);
                    conexion.Close();
                    return dt2;
                }
            }
        }
        // Limites
        public DataTable MostrarLimites()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT L.Id_Limites'ID límite', P.Id_Producto'ID Producto', P.Nombre, P.Estado, P.Stock, P.Fecha_Vecimiento'Fecha Vencimiento', L.Cantidad'Límite' FROM Producto P, Limites L WHERE L.Fk_Producto = p.Id_Producto", conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "GridLim");
            conexion.Close();
            return ds.Tables["GridLim"];

        }
        public DataTable MostrarSinLimites()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("Select P.Id_Producto'ID', P.Nombre, P.Estado, P.Stock, P.Fecha_Vecimiento'Fecha de vencimiento' from Producto P where not exists (select 1 from Limites L where L.Fk_Producto = P.Id_Producto)", conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "GridNewLIm");
            conexion.Close();
            return ds.Tables["GridNewLim"];

        }
        public bool InsertLimite(string Id, string idPro, string cantidad)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("insert into Limites values ({0}, {1}, {2})", new string[] { Id, idPro, cantidad}), conexion);
            int filasafectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasafectadas > 0) return true;
            else return false;

        }
        public int ObtidnewLimite()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("select Id_Limites from Limites where Id_Limites = (select MAX(Id_Limites) from Limites)", conexion);
            int MaxId = Convert.ToInt32(cmd.ExecuteScalar());
            conexion.Close();
            return MaxId;
        }
        public bool ActualizarLimite(string idPro, string cantidad, string Id)
        { 
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("update Limites set Fk_Producto = {0},Cantidad = {1}  where Id_Limites = {2}", new string[] { idPro,cantidad, Id }), conexion);
            int filasafectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasafectadas > 0) return true;
            else return false;
        }
        public bool EliminarLimite(string id)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("delete from Limites where Id_Limites = {0}", id), conexion);
            int filasafectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasafectadas > 0) return true;
            else return false;
        }

    }
}

