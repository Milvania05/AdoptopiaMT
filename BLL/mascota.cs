using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dal;

namespace BLL
{
    public class mascota
    {
        public int Id_mascota { get; set; }
        public string nombre { get; set; }
        public string raza { get; set; }
        public DateTime fecha_nacimiento { get; set; }
        public string historial_clinico { get; set; }
        public string descripcion { get; set; }
        public string tamano { get; set; }
        public int Genero { get; set; }
        public string especie { get; set; }
        public bool estado_adopcion { get; set; }

        Dal.Conexion conexion = new Dal.Conexion();
        public bool Insert()
        {
            return conexion.EjecutarDB(string.Concat(string.Format("INSERT INTO MASCOTA(NOMBRE,RAZA,FECHA_NACIMIENTO,HISTORIAL_CLINICO,DESCRIPCION,TAMANO,GENERO,ESPECIE,ESTADO_ADOPCION)VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}',", nombre, raza, fecha_nacimiento.ToString("MM/dd/yyyy"), historial_clinico, descripcion, tamano, Genero), string.Format("'{0}','{1}')", especie, estado_adopcion)));
        }
        public bool Update()
        {
            return conexion.EjecutarDB(string.Concat(string.Format("UPDATE MASCOTA SET NOMBRE='{0}',RAZA='{1}',FECHA_NACIMIENTO='{2}',HISTORIAL_CLINICO='{3}',DESCRIPCION='{4}',TAMANO='{5}',GENERO='{6}',", nombre, raza, fecha_nacimiento.ToString("MM/dd/yyyy"), historial_clinico, descripcion, tamano, Genero), string.Format("ESPECIE='{0}',ESTADO_ADOPCION='{1}' WHERE ID_MASCOTA='{2}'", especie, estado_adopcion, Id_mascota)));
        }
        public bool Delete()
        {
            return conexion.EjecutarDB(string.Format("DELETE MASCOTA WHERE ID_MASCOTA='{0}'", Id_mascota));
        }
        public bool search()
        {
            bool retorno = false;
            DataTable dt = new DataTable();
            dt = conexion.BuscarDb(string.Format("select * from mascota where nombre='{0}'", nombre));
            if (dt.Rows.Count > 0)
            {
                retorno = true;
                Id_mascota = (int)dt.Rows[0]["Id_mascota"];
                nombre = dt.Rows[0]["nombre"].ToString();
                raza = dt.Rows[0]["raza"].ToString();
                fecha_nacimiento = DateTime.Parse(dt.Rows[0]["fecha_nacimiento"].ToString());
                historial_clinico = dt.Rows[0]["historial_clinico"].ToString();
                descripcion = dt.Rows[0]["descripcion"].ToString();
                tamano = dt.Rows[0]["tamano"].ToString();
                Genero = (int)dt.Rows[0]["Genero"];
                especie = dt.Rows[0]["especie"].ToString();
                estado_adopcion = (bool)dt.Rows[0]["estado_adopcion"];
            }
            return retorno;
        }
        public DataTable Listar(string campo, string condicion)
        {
            return conexion.BuscarDb(string.Format("select {0} from mascota where {1}",campo,condicion));
        }
    }
}
