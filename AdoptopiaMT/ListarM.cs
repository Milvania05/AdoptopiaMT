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
    public partial class ListarM : Form
    {
        public ListarM()
        {
            InitializeComponent();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            cbBuscar.SelectedIndex = -1;
            txtCriterio.Clear();
            dtDatos.DataSource = new DataTable();
            dtDatos.Show();
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            BLL.clientes clientes = new BLL.clientes();
            DataTable dt = new DataTable();
            dt = clientes.Listar("nombre,apellido,telefono,direccion,cedula,correo,fecha_nacimiento", string.Format("{0} like '%{1}%'", cbBuscar.SelectedItem.ToString(), txtCriterio.Text));
            if (dt.Rows.Count > -1)
            {
                dtDatos.DataSource = dt;
                dtDatos.Show();
            }
            else MessageBox.Show("No se encontro la informacion :(", "PET ADOPTION");

        }
    }
}
