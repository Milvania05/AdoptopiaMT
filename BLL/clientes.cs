using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dal;

namespace BLL
{
    public class clientes
    {
        public int id_cliente { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }
        public string cedula { get; set; }
        public string correo { get; set; }
        public DateTime fecha_nacimiento { get; set; }
        public bool activo { get; set; }

        Dal.Conexion conexion = new Dal.Conexion();
        public bool Insert()
        {
            return conexion.EjecutarDB(string.Concat(string.Format("INSERT INTO CLIENTES(NOMBRE,APELLIDO,TELEFONO,DIRECCION,CEDULA,CORREO,FECHA_NACIMIENTO,ACTIVO) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}',", nombre, apellido, telefono, direccion, cedula, correo, fecha_nacimiento.ToString("MM/dd/yyyy")), string.Format("'{0}')", activo)));
        }
        public bool Update()
        {
            return conexion.EjecutarDB(string.Concat(string.Format("UPDATE CLIENTES SET NOMBRE='{0}',APELLIDO='{1}',TELEFONO='{2}',DIRECCION='{3}',CEDULA='{4}',CORREO='{5}',FECHA_NACIMIENTO='{6}',", nombre, apellido, telefono, direccion, cedula, correo, fecha_nacimiento.ToString("MM/dd/yyyy")), string.Format("ACTIVO='{0}' WHERE ID_CLIENTE='{1}'", activo, id_cliente)));
        }
        public bool Delete()
        {
            return conexion.EjecutarDB(string.Format("DELETE CLIENTES WHERE ID_CLIENTE='{0}'", id_cliente));
        }
        public bool search()
        {
            bool retorno = false;
            DataTable dt = new DataTable();
            dt = conexion.BuscarDb(string.Format("select * from clientes where cedula='{0}'", cedula));
            if (dt.Rows.Count > 0)
            {
                retorno= true;
                id_cliente = (int)dt.Rows[0]["id_cliente"];
                nombre = dt.Rows[0]["nombre"].ToString();
                apellido = dt.Rows[0]["apellido"].ToString();
                telefono = dt.Rows[0]["telefono"].ToString();
                direccion = dt.Rows[0]["direccion"].ToString();
                cedula = dt.Rows[0]["cedula"].ToString();
                correo = dt.Rows[0]["correo"].ToString();
                fecha_nacimiento = DateTime.Parse(dt.Rows[0]["fecha_nacimiento"].ToString());
                activo = (bool)dt.Rows[0]["activo"];
            }
            return retorno;
        }
        public DataTable Listar(string campo, string condicion)
        {
            return conexion.BuscarDb(string.Format("select {0} from clientes where {1}",campo,condicion));
        }
    }
}
