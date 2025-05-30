using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace AdoptopiaMT
{
    public partial class ListarR : Form
    {
        public ListarR()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cbBuscar.SelectedIndex = -1;
            txtCriterio.Clear();
            dtDatos.DataSource = new DataTable();
            dtDatos.Show();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            BLL.recepcion recepcion = new BLL.recepcion();
            DataTable dt = new DataTable();
            dt = recepcion.Listar("especie,direccion,persona_entrega,fecha_hora_recepcion,raza,salud_animal", string.Format("{0} like '%{1}%'", cbBuscar.SelectedItem.ToString(), txtCriterio.Text));
            if (dt.Rows.Count > -1)
            {
                dtDatos.DataSource = dt;
                dtDatos.Show();
            }
            else MessageBox.Show("No se encontro la informacion :(", "PET ADOPTION");
        }
    }
}
