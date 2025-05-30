using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dal;

namespace BLL
{
    public class adopcion
    {
        public int id_adopcion { get; set; }
        public DateTime fecha_adopcion { get; set; }
        public string estado_seguimiento { get; set; }
        public string costo_cuidado_inicial { get; set; }
        public int id_clientes { get; set; }
        public int id_mascota { get; set; }

        Dal.Conexion conexion = new Dal.Conexion();
        public bool Insert()
        {
            return conexion.EjecutarDB(string.Format("INSERT INTO ADOPCION(FECHA_ADOPCION,ESTADO_SEGUIMIENTO,COSTO_CUIDADO_INICIAL,ID_CLIENTES,ID_MASCOTA) VALUES ('{0}','{1}','{2}','{3}','{4}')", fecha_adopcion.ToString("MM/dd/yyyy"), estado_seguimiento, costo_cuidado_inicial, id_clientes, id_mascota));
        }
        public bool Update()
        {
            return conexion.EjecutarDB(string.Format("UPDATE ADOPCION SET FECHA_ADOPCION='{0}',ESTADO_SEGUIMIENTO='{1}',COSTO_CUIDADO_INICIAL='{2}',ID_CLIENTES='{3}',ID_MASCOTA='{4}' WHERE ID_ADOPCION='{5}'", fecha_adopcion.ToString("MM/dd/yyyy"), estado_seguimiento, costo_cuidado_inicial, id_clientes, id_mascota, id_adopcion));
        }
        public bool Delete()
        {
            return conexion.EjecutarDB(string.Format("DELETE ADOPCION WHERE ID_ADOPCION='{0}'", id_adopcion));
        }
        public bool Search()
        {
            bool retorno = false;
            DataTable dt = new DataTable();
            dt = conexion.BuscarDb(string.Format("select * from adopcion where costo_cuidado_inicial='{0}'", costo_cuidado_inicial));
            if (dt.Rows.Count > 0)
            {
                retorno= true;
                id_adopcion = (int)dt.Rows[0]["id_adopcion"];
                fecha_adopcion = DateTime.Parse(dt.Rows[0]["fecha_adopcion"].ToString());
                estado_seguimiento = dt.Rows[0]["estado_seguimiento"].ToString();
                costo_cuidado_inicial = dt.Rows[0]["costo_cuidado_inicial"].ToString();
                id_clientes = (int)dt.Rows[0]["id_clientes"];
                id_mascota = (int)dt.Rows[0]["id_mascota"];
            }
            return retorno;
        }
        public DataTable Listar(string campo, string condicion)
        {
            return conexion.BuscarDb(string.Format("select {0} from adopcion where {1}",campo,condicion));
        }
    }
}