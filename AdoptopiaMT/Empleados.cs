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
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
        }
        void limpiar()
        {
            BtnActualizar.Enabled = false;
            BtnEliminar.Enabled = false;
            idempleados = 0;
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtCedula.Clear();
            txtDireccion.Clear();
            txtCorreo.Clear();
            txtcargo.Clear();
            dtpFecha.Value = DateTime.Now;
            cbActivo.Checked = true;
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        BLL.empleados empleados = new BLL.empleados();
        static int idempleados = 0;

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            empleados.nombre = txtNombre.Text;
            empleados.apellido = txtApellido.Text;
            empleados.telefono = txtTelefono.Text.Trim();
            empleados.cedula = txtCedula.Text.Trim();
            empleados.direccion = txtDireccion.Text;
            empleados.correo = txtCorreo.Text;
            empleados.cargo = txtcargo.Text;
            empleados.fecha_nacimiento = dtpFecha.Value;
            empleados.activo = cbActivo.Checked;
            if (empleados.Insert())
            {
                MessageBox.Show("SE GUARDO CORRECTAMENTE :)", "PET ADOPTION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
            }
            else MessageBox.Show("NO SE GUARDO EL EMPLEADO :(", "PET ADOPTION", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            empleados.id_empleados = idempleados;
            empleados.nombre = txtNombre.Text;
            empleados.apellido = txtApellido.Text;
            empleados.telefono = txtTelefono.Text.Trim();
            empleados.cedula = txtCedula.Text.Trim();
            empleados.direccion = txtDireccion.Text;
            empleados.correo = txtCorreo.Text;
            empleados.cargo = txtcargo.Text;
            empleados.fecha_nacimiento = dtpFecha.Value;
            empleados.activo = cbActivo.Checked;
            if (empleados.Update())
            {
                MessageBox.Show("SE ACTUALIZO CORRECTAMENTE :)", "PET ADOPTION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
            }
            else MessageBox.Show("NO SE ACTUALIZO CORRECTAMENTE", "PET ADOPTION", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            empleados.id_empleados = idempleados;
            if (empleados.Delete())
            {
                MessageBox.Show("SE ELIMINO CORRECTAMENTE :)", "PET ADOPTION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                limpiar();
            }
            else MessageBox.Show("NO SE ELIMINO CORRECTAMENTE", "PET ADOPTION", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            empleados.cedula = txtCedula.Text;
            if (empleados.search())
            {
                idempleados = empleados.id_empleados;
                txtNombre.Text = empleados.nombre;
                txtApellido.Text = empleados.apellido;
                txtTelefono.Text = empleados.telefono;
                txtCedula.Text = empleados.cedula;
                txtDireccion.Text = empleados.direccion;
                txtCorreo.Text = empleados.correo;
                txtcargo.Text = empleados.cargo;
                dtpFecha.Value = empleados.fecha_nacimiento;
                cbActivo.Checked = empleados.activo;
                BtnActualizar.Enabled = true;
                BtnEliminar.Enabled = true;
            }
            else MessageBox.Show("NO SE ENCONTRO EL EMPLEADO :(", "PET ADOPTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            ListarE listar = new ListarE();
            listar.Show();
        }
        private void ConfigurarDiseño()
        {
            label1.Dock = DockStyle.Left;
            label2.Dock = DockStyle.Left;
            label3.Dock = DockStyle.Left;
        }
    }
}
