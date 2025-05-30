using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dal;

namespace BLL
{
    public class donacion
    {
        public int id_donacion { get; set; }
        public string producto { get; set; }
        public string monto { get; set; }
        public string metodo_pago { get; set; }
        public DateTime fecha_donacion { get; set; }
        public int id_clientes { get; set; }

        Dal.Conexion conexion = new Dal.Conexion();
        public bool Insert()
        {
            return conexion.EjecutarDB(string.Format("INSERT INTO DONACION(PRODUCTO,MONTO,METODO_PAGO,FECHA_DONACION,ID_CLIENTES)VALUES('{0}','{1}','{2}','{3}','{4}')", producto, monto, metodo_pago, fecha_donacion.ToString("MM/dd/yyyy"), id_clientes));
        }
        public bool Update()
        {
            return conexion.EjecutarDB(string.Format("UPDATE DONACION SET PRODUCTO='{0}',MONTO='{1}',METODO_PAGO='{2}',FECHA_DONACION='{3}',ID_CLIENTES='{4}' WHERE ID_DONACION='{5}'", producto, monto, metodo_pago, fecha_donacion.ToString("MM/dd/yyyy"), id_clientes, id_donacion));
        }
        public bool Delete()
        {
            return conexion.EjecutarDB(string.Format("DELETE DONACION WHERE ID_DONACION='{0}'", id_donacion));
        }
        public bool search()
        {
            bool retorno = false;
            DataTable dt = new DataTable();
            dt = conexion.BuscarDb(string.Format("select * from donacion where producto='{0}'", producto));
            if (dt.Rows.Count > 0)
            {
                retorno= true;
                id_donacion = (int)dt.Rows[0]["id_donacion"];
                producto = dt.Rows[0]["producto"].ToString();
                monto = dt.Rows[0]["monto"].ToString();
                metodo_pago = dt.Rows[0]["metodo_pago"].ToString();
                fecha_donacion = DateTime.Parse(dt.Rows[0]["fecha_donacion"].ToString());
                id_clientes = (int)dt.Rows[0]["id_clientes"];
            }
            return retorno;
        }
        public DataTable Listar(string campo, string condicion)
        {
            return conexion.BuscarDb(string.Format("select {0} from donacion where {1}", campo, condicion));
        }
    }
}
