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
    public partial class Adopcion : Form
    {
        public Adopcion()
        {
            InitializeComponent();
        }
        void limpiar()
        {
            BtnActualizar.Enabled = false;
            BtnEliminar.Enabled = false;
            idadopcion = 0;
            dtpfecha.Value=DateTime.Now;
            txtEstadoseg.Clear();
            txtCostoci.Clear();
            cbcliente.SelectedIndex = -1;
            cbmascota.SelectedIndex = -1;
        }
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void Adopcion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'adoptopiaDataSet5.mascota' Puede moverla o quitarla según sea necesario.
            this.mascotaTableAdapter1.Fill(this.adoptopiaDataSet5.mascota);
            // TODO: esta línea de código carga datos en la tabla 'adoptopiaDataSet4.clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter1.Fill(this.adoptopiaDataSet4.clientes);

        }
        BLL.adopcion adop = new BLL.adopcion();
        static int idadopcion = 0;
        

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            adop.id_adopcion = idadopcion;
            adop.fecha_adopcion = dtpfecha.Value;
            adop.estado_seguimiento = txtEstadoseg.Text;
            adop.costo_cuidado_inicial = txtCostoci.Text;
            adop.id_clientes = cbcliente.SelectedIndex;
            adop.id_mascota = cbmascota.SelectedIndex;
            if (adop.Update())
            {
                MessageBox.Show("SE ACTUALIZO CORRECTAMENTE :)", "PET ADOPTION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
            }
            else MessageBox.Show("NO SE ACTUALIZO LA DONACION :(", "PET ADOPTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            adop.id_adopcion = idadopcion;
            if (adop.Delete())
            {
                MessageBox.Show("SE ELIMINO CORRECTAMENTE :)", "PET ADOPTION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                limpiar();
            }
            else MessageBox.Show("NO SE ELIMINO CORRECTAMENTE", "PET ADOPTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            adop.costo_cuidado_inicial=txtCostoci.Text;
            if (adop.Search())
            {
                idadopcion = adop.id_adopcion;
                dtpfecha.Value = adop.fecha_adopcion;
                txtEstadoseg.Text = adop.estado_seguimiento;
                txtCostoci.Text = adop.costo_cuidado_inicial;
                cbcliente.SelectedIndex = adop.id_clientes;
                cbmascota.SelectedIndex = adop.id_mascota;
                BtnActualizar.Enabled = true;
                BtnEliminar.Enabled = true;
            }
            else MessageBox.Show("NO SE ENCONTRO SU DONACION :(", "PET ADOPTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            adop.fecha_adopcion = dtpfecha.Value;
            adop.estado_seguimiento = txtEstadoseg.Text;
            adop.costo_cuidado_inicial = txtCostoci.Text;
            adop.id_clientes = cbcliente.SelectedIndex;
            adop.id_mascota = cbmascota.SelectedIndex;
            if (adop.Insert())
            {
                MessageBox.Show("SE GUARDÓ CORRECTAMENTE :)", "PET ADOPTION", MessageBoxButtons.OK, MessageBoxIcon.Information);

                limpiar();
            }
            else MessageBox.Show("NO SE GUARDO EL SU DONACION :( ", "PET ADOPTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnlistar_Click(object sender, EventArgs e)
        {
            ListarA listar = new ListarA();
            listar.Show();
        }
    }
}
