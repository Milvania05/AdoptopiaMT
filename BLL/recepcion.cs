using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dal;

namespace BLL
{
    public class recepcion
    {
        public int id_recepcion { get; set; }
        public string especie { get; set; }
        public string direccion { get; set; }
        public string persona_entrega { get; set; }
        public DateTime fecha_hora_recepcion { get; set; }
        public string raza { get; set; }
        public int genero { get; set; }
        public string salud_animal { get; set; }
        public int id_mascota { get; set; }

        Dal.Conexion conexion = new Dal.Conexion();
        public bool Insert()
        {
            return conexion.EjecutarDB(string.Concat(string.Format("INSERT INTO RECEPCION(ESPECIE,DIRECCION,PERSONA_ENTREGA,FECHA_HORA_RECEPCION,RAZA,GENERO,SALUD_ANIMAL,ID_MASCOTA)VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}',", especie, direccion, persona_entrega, fecha_hora_recepcion.ToString("MM/dd/yyyy"), raza, genero, salud_animal), string.Format("'{0}')", id_mascota)));
        }
        public bool Update()
        {
            return conexion.EjecutarDB(string.Concat(string.Format("UPDATE RECEPCION SET ESPECIE='{0}',DIRECCION='{1}',PERSONA_ENTREGA='{2}',FECHA_HORA_RECEPCION='{3}',RAZA='{4}',GENERO='{5}',SALUD_ANIMAL='{6}',", especie, direccion, persona_entrega, fecha_hora_recepcion.ToString("MM/dd/yyyy"), raza, genero, salud_animal), string.Format("ID_MASCOTA='{0}' WHERE ID_RECEPCION='{1}'", id_mascota, id_recepcion)));
        }
        public bool Delete()
        {
            return conexion.EjecutarDB(string.Format("DELETE RECEPCION WHERE ID_RECEPCION='{0}'", id_recepcion));
        }
        public bool search()
        {
            bool retorno = false;
            DataTable dt = new DataTable();
            dt = conexion.BuscarDb(string.Format("select * from recepcion where persona_entrega='{0}'", persona_entrega));
            if (dt.Rows.Count > 0)
            {
                retorno = true;
                id_recepcion = (int)dt.Rows[0]["id_recepcion"];
                especie = dt.Rows[0]["especie"].ToString();
                direccion = dt.Rows[0]["direccion"].ToString();
                persona_entrega = dt.Rows[0]["persona_entrega"].ToString();
                fecha_hora_recepcion = DateTime.Parse(dt.Rows[0]["fecha_hora_recepcion"].ToString());
                raza = dt.Rows[0]["raza"].ToString();
                genero = (int)dt.Rows[0]["genero"];
                salud_animal = dt.Rows[0]["salud_animal"].ToString();
                id_mascota = (int)dt.Rows[0]["id_mascota"];
            }
            return retorno;
        }
        public DataTable Listar(string campo, string condicion)
        {
            return conexion.BuscarDb(string.Format("select {0} from recepcion where {1}",campo,condicion));
        }
        //milva
    }
}
