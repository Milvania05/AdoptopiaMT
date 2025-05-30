using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace AdoptopiaMT
{
    public partial class Donacion : Form
    {
        public Donacion()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            donacion.fecha_donacion=dtpfecha.Value;
            if (donacion.search())
            {
                iddonacion = donacion.id_donacion;
                txtProducto.Text = donacion.producto;
                txtDonacionefec.Text = donacion.monto;
                txtMetodopago.Text = donacion.metodo_pago;
                dtpfecha.Value = donacion.fecha_donacion;
                cbcliente.SelectedIndex = donacion.id_clientes;
                BtnActualizar.Enabled = true;
                BtnEliminar.Enabled = true;
            }
            else MessageBox.Show("NO SE ENCONTRO EL DONANTE :(", "PET ADOPTION");
        }
        void limpiar()
        {
            BtnActualizar.Enabled = false;
            BtnEliminar.Enabled = false;
            iddonacion = 0;
            txtProducto.Clear();
            txtDonacionefec.Clear();
            txtMetodopago.Clear();
            dtpfecha.Value=DateTime.Now;
            cbcliente.SelectedIndex = -1;
        }
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            donacion.id_donacion = iddonacion;
            donacion.producto = txtProducto.Text;
            donacion.monto = txtDonacionefec.Text;
            donacion.metodo_pago = txtMetodopago.Text;
            donacion.fecha_donacion = dtpfecha.Value;
            donacion.id_clientes = cbcliente.SelectedIndex;
            if (donacion.Update())
            {
                MessageBox.Show("SE ACTUALIZO CORRECTAMENTE :)", "PET ADOPTION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
            }
            else MessageBox.Show("NO SE ACTUALIZO EL DONANTE", "PET ADOPTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            donacion.id_donacion= iddonacion;
            if (donacion.Delete())
            {
                MessageBox.Show("SE ELIMINO CORRECTAMENTE :)", "PET ADOPTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpiar();
            }
            else MessageBox.Show("NO SE ELIMINO CORRECTAMENTE", "PET ADOPTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Donacion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'adoptopiaDataSet6.clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.adoptopiaDataSet6.clientes);

        }
        BLL.donacion donacion = new BLL.donacion();
        static int iddonacion = 0;

        private void BtnGuardar_Click_1(object sender, EventArgs e)
        {
            donacion.producto = txtProducto.Text;
            donacion.monto = txtDonacionefec.Text;
            donacion.metodo_pago = txtMetodopago.Text;
            donacion.fecha_donacion = dtpfecha.Value;
            donacion.id_clientes = cbcliente.SelectedIndex;
            if (donacion.Insert())
            {
                MessageBox.Show("SE GUARDO CORRECTAMENTE :)", "PET ADOPTION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
            }
            else MessageBox.Show("NO SE GUARDO EL DONANTE :(", "PET ADOPTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnBuscar_Click_1(object sender, EventArgs e)
        {

            donacion.producto = txtProducto.Text;
            if (donacion.search())
            {
                iddonacion = donacion.id_donacion;
                txtProducto.Text = donacion.producto;
                txtDonacionefec.Text = donacion.monto;
                txtMetodopago.Text = donacion.metodo_pago;
                dtpfecha.Value = donacion.fecha_donacion;
                cbcliente.SelectedIndex = donacion.id_clientes;
                BtnActualizar.Enabled = true;
                BtnEliminar.Enabled = true;
            }
            else MessageBox.Show("NO SE ENCONTRO EL DONANTE :(", "PET ADOPTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            ListarD listar = new ListarD();
            listar.Show();
        }
    }
}
