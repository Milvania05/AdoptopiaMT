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
    public partial class Lasmascotas : Form
    {
        public Lasmascotas()
        {
            InitializeComponent();
        }

        private void pbnext_Click(object sender, EventArgs e)
        {
            Masmascotas masmascotas = new Masmascotas();
            masmascotas.Show();
        }
    }
}
