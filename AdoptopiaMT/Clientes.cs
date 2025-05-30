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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }
        void limpiar()
        {
            BtnActualizar.Enabled = false;
            BtnEliminar.Enabled = false;
            idclientes = 0;
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            txtCedula.Clear();
            txtCorreo.Clear();
            dtpfecha_nacimiento.Value = DateTime.Now;
            cbActivo.Checked = true;
        }
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        BLL.clientes c = new BLL.clientes();
        static int idclientes = 0;
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            c.nombre= txtNombre.Text;
            c.apellido= txtApellido.Text;
            c.telefono= txtTelefono.Text;
            c.direccion= txtDireccion.Text;
            c.cedula= txtCedula.Text;
            c.correo= txtCorreo.Text;
            c.fecha_nacimiento = dtpfecha_nacimiento.Value;
            c.activo= cbActivo.Checked;
            if (c.Insert())
            {
                MessageBox.Show("SE GUARDO CORRECTAMENTE :)", "PET ADOPTION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
            }
            else MessageBox.Show("NO SE GUARDO EL CLIENTE :(", "PET ADOPTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            c.id_cliente = idclientes;
            c.nombre = txtNombre.Text;
            c.apellido = txtApellido.Text;
            c.telefono = txtTelefono.Text.Trim();
            c.direccion = txtDireccion.Text;
            c.cedula = txtCedula.Text.Trim();
            c.correo = txtCorreo.Text;
            c.fecha_nacimiento = dtpfecha_nacimiento.Value;
            c.activo = cbActivo.Checked;
            if (c.Update())
            {
                MessageBox.Show("SE ACTUALIZO CORRECTAMENTE :)", "PET ADOPTION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
            }
            else MessageBox.Show("NO SE ACTUALIZO EL CLIENTE :(", "PET ADOPTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            c.id_cliente=idclientes;
            if (c.Delete())
            {
                MessageBox.Show("SE ELIMINO CORRECTAMENTE :)", "PET ADOPTION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                limpiar() ;
            }
            else MessageBox.Show("NO SE ELIMINO CORRECTAMENTE", "PET ADOPTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            c.cedula=txtCedula.Text;
            if (c.search())
            {
                idclientes = c.id_cliente;
                txtNombre.Text = c.nombre;
                txtApellido.Text = c.apellido;
                txtTelefono.Text = c.telefono;
                txtDireccion.Text = c.direccion;
                txtCedula.Text = c.cedula;
                txtCorreo.Text = c.correo;
                dtpfecha_nacimiento.Value = c.fecha_nacimiento;
                cbActivo.Checked = c.activo;
                BtnActualizar.Enabled = true;
                BtnEliminar.Enabled = true;
            }
            else MessageBox.Show("NO SE ENCONTRO EL CLIENTE :(", "PET ADOPTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            ListarM listar = new ListarM();
            listar.Show();
        }
    }
}
