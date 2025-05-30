using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoptopiaMT
{
    public partial class Recepcion : Form
    {
        public Recepcion()
        {
            InitializeComponent();
        }

        private void Recepcion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'adoptopiaDataSet8.mascota' Puede moverla o quitarla según sea necesario.
            this.mascotaTableAdapter.Fill(this.adoptopiaDataSet8.mascota);

        }
        void limpiar()
        {
            BtnActualizar.Enabled = false;
            BtnEliminar.Enabled = false;
            idrecepcion = 0;
            txtEspecie.Clear();
            txtDireccion.Clear();
            txtPersona_entrega.Clear();
            dtpfecha_entrega.Value = DateTime.Now;
            txtRaza.Clear();
            cbGenero.SelectedIndex = -1;
            txtSalud_animal.Clear();
            cbMascota.SelectedIndex = -1;
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        BLL.recepcion recepcion = new BLL.recepcion();
        static int idrecepcion = 0;

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            recepcion.especie = txtEspecie.Text;
            recepcion.direccion = txtDireccion.Text;
            recepcion.persona_entrega = txtPersona_entrega.Text;
            recepcion.fecha_hora_recepcion = dtpfecha_entrega.Value;
            recepcion.raza = txtRaza.Text;
            recepcion.genero = cbGenero.SelectedIndex;
            recepcion.salud_animal = txtSalud_animal.Text;
            recepcion.id_mascota = cbMascota.SelectedIndex;
            if (recepcion.Insert())
            {
                MessageBox.Show("SE GUARDO CORRECTAMENTE :)", "PET ADOPTION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
            }
            else MessageBox.Show("NO SE GUARDO :(", "PET ADOPTION", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            recepcion.id_recepcion = idrecepcion;
            recepcion.especie = txtEspecie.Text;
            recepcion.direccion = txtDireccion.Text;
            recepcion.persona_entrega = txtPersona_entrega.Text;
            recepcion.fecha_hora_recepcion = dtpfecha_entrega.Value;
            recepcion.raza = txtRaza.Text;
            recepcion.genero = cbGenero.SelectedIndex;
            recepcion.salud_animal = txtSalud_animal.Text;
            recepcion.id_mascota = cbMascota.SelectedIndex;
            if (recepcion.Update())
            {
                MessageBox.Show("SE ACTUALIZO CORRECTAMENTE :)", "PET ADOPTION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
            }
            else MessageBox.Show("NO SE ACTUALIZO", "PET ADOPTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            recepcion.id_recepcion = idrecepcion;
            if (recepcion.Delete())
            {
                MessageBox.Show("SE ELIMINO CORRECTAMENTE :)", "PET ADOPTION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                limpiar();
            }
            else MessageBox.Show("NO SE ELIMINO CORRECTAMENTE", "PET ADOPTION", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            recepcion.persona_entrega = txtPersona_entrega.Text;
            if (recepcion.search())
            {
                idrecepcion = recepcion.id_recepcion;
                txtEspecie.Text = recepcion.especie;
                txtDireccion.Text = recepcion.direccion;
                txtPersona_entrega.Text = recepcion.persona_entrega;
                dtpfecha_entrega.Value = recepcion.fecha_hora_recepcion;
                txtRaza.Text = recepcion.raza;
                cbGenero.SelectedIndex = recepcion.genero;
                txtSalud_animal.Text = recepcion.salud_animal;
                cbMascota.SelectedIndex = recepcion.id_mascota;
                BtnActualizar.Enabled = true;
                BtnEliminar.Enabled = true;
            }
            else MessageBox.Show("NO SE ENCONTRO :(", "PET ADOPTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnlistar_Click(object sender, EventArgs e)
        {
            ListarR listar = new ListarR();
            listar.Show();
        }
    }
}

