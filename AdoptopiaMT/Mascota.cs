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
    public partial class Mascota : Form
    {
        public Mascota()
        {
            InitializeComponent();
        }
        void limpiar()
        {
            BtnActualizar.Enabled = false;
            BtnEliminar.Enabled = false;
            idmascota = 0;
            txtNombre.Clear();
            txtRaza.Clear();
            dtpFecha.Value=DateTime.Now;
            txtHistorialclinico.Clear();
            txtDescripcion.Clear();
            txtTamano.Clear();
            cbgenero.SelectedIndex = -1;
            txtEspecie.Clear();
            cbestadoadopcion.Checked = false;
        }
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        BLL.mascota mascota=new BLL.mascota();
        static int idmascota = 0;
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            mascota.nombre = txtNombre.Text;
            mascota.raza = txtRaza.Text;
            mascota.fecha_nacimiento=dtpFecha.Value;
            mascota.historial_clinico = txtHistorialclinico.Text;
            mascota.descripcion = txtDescripcion.Text;
            mascota.tamano = txtTamano.Text;
            mascota.Genero = cbgenero.SelectedIndex;
            mascota.especie = txtEspecie.Text;
            mascota.estado_adopcion = cbestadoadopcion.Checked;
            if (mascota.Insert())
            {
                MessageBox.Show("SE GUARDO CORRECTAMENTE :)", "PET ADOPTION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
            }
            else MessageBox.Show("NO SE GUARDO LA MASCOTA :(", "PET ADOPTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            mascota.Id_mascota = idmascota;
            mascota.nombre = txtNombre.Text;
            mascota.raza = txtRaza.Text;
            mascota.fecha_nacimiento = dtpFecha.Value;
            mascota.historial_clinico = txtHistorialclinico.Text;
            mascota.descripcion = txtDescripcion.Text;
            mascota.tamano = txtTamano.Text;
            mascota.Genero = cbgenero.SelectedIndex;
            mascota.especie = txtEspecie.Text;
            mascota.estado_adopcion = cbestadoadopcion.Checked;
            if (mascota.Update())
            {
                MessageBox.Show("SE ACTUALIZO CORRECTAMENTE :)", "PET ADOPTION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
            }
            else MessageBox.Show("NO SE ACTUALIZO LA MASCOTA :(", "PET ADOPTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            mascota.Id_mascota= idmascota;
            if (mascota.Delete())
            {
                    MessageBox.Show("SE ELIMINO CORRECTAMENTE :)", "PET ADOPTION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    limpiar();
            }
            else MessageBox.Show("NO SE ELIMINO LA MASCOTA", "PET ADOPTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            mascota.nombre=txtNombre.Text;
            if (mascota.search())
            {
                idmascota = mascota.Id_mascota;
                txtNombre.Text = mascota.nombre;
                txtRaza.Text = mascota.raza;
                dtpFecha.Value = mascota.fecha_nacimiento;
                txtHistorialclinico.Text = mascota.historial_clinico;
                txtDescripcion.Text = mascota.descripcion;
                txtTamano.Text = mascota.tamano;
                cbgenero.SelectedIndex = mascota.Genero;
                txtEspecie.Text = mascota.especie;
                cbestadoadopcion.Checked = mascota.estado_adopcion;
                BtnActualizar.Enabled = true;
                BtnEliminar.Enabled = true;
            }
            else MessageBox.Show("NO SE ENCONTRO LA MASCOTA :(", "PET ADOPTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnlistar_Click(object sender, EventArgs e)
        {
            Listarma listarma = new Listarma();
            listarma.Show();
        }
    }
}
