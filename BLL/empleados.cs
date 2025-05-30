using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dal;

namespace BLL
{
    public class empleados
    {
        public int id_empleados { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string telefono { get; set; }
        public string cedula { get; set; }
        public string direccion { get; set; }
        public string correo { get; set; }
        public string cargo { get; set; }
        public DateTime fecha_nacimiento { get; set; }
        public bool activo { get; set; }

        Dal.Conexion conexion = new Dal.Conexion();
        public bool Insert()
        {
            return conexion.EjecutarDB(string.Concat(string.Format("INSERT INTO EMPLEADOS(NOMBRE,APELLIDO,TELEFONO,CEDULA,DIRECCION,CORREO,CARGO,FECHA_NACIMIENTO,ACTIVO)VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}',", nombre, apellido, telefono, cedula, direccion, correo, cargo), string.Format("'{0}','{1}')", fecha_nacimiento.ToString("MM/dd/yyyy"), activo)));
        }
        public bool Update()
        {
            return conexion.EjecutarDB(string.Concat(string.Format("UPDATE EMPLEADOS SET NOMBRE='{0}',APELLIDO='{1}',TELEFONO='{2}',CEDULA='{3}',DIRECCION='{4}',CORREO='{5}',CARGO='{6}',", nombre, apellido, telefono, cedula, direccion, correo, cargo), string.Format("FECHA_NACIMIENTO='{0}',ACTIVO='{1}' WHERE ID_EMPLEADOS='{2}'", fecha_nacimiento.ToString("MM/dd/yyyy"), activo, id_empleados)));
        }
        public bool Delete()
        {
            return conexion.EjecutarDB(string.Format("DELETE EMPLEADOS WHERE ID_EMPLEADOS='{0}'", id_empleados));
        }
        public bool search()
        {
            bool retorno = false;
            DataTable dt = new DataTable();
            dt = conexion.BuscarDb(string.Format("select * from empleados where cedula='{0}'", cedula));
            if (dt.Rows.Count > 0)
            {
                retorno= true;
                id_empleados = (int)dt.Rows[0]["id_empleados"];
                nombre = dt.Rows[0]["nombre"].ToString();
                apellido = dt.Rows[0]["apellido"].ToString();
                telefono = dt.Rows[0]["telefono"].ToString();
                cedula = dt.Rows[0]["cedula"].ToString();
                direccion = dt.Rows[0]["direccion"].ToString();
                correo = dt.Rows[0]["correo"].ToString();
                cargo = dt.Rows[0]["cargo"].ToString();
                fecha_nacimiento = DateTime.Parse(dt.Rows[0]["fecha_nacimiento"].ToString());
                activo = (bool)dt.Rows[0]["activo"];
            }
            return retorno;
        }
        public DataTable Listar(string campo, string condicion)
        {
            return conexion.BuscarDb(string.Format("select {0} from empleados where {1}", campo, condicion));
        }
    }
}
