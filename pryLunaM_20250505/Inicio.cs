using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryLunaM_20250505
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            cmbSuperheroe.Items.Clear();
            cmbSuperheroe.Items.Add("Superman");
            cmbSuperheroe.Items.Add("Batman");
            cmbSuperheroe.Items.Add("Wonderwoman");


        }

        private void cmbSuperheroe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSuperheroe.SelectedIndex == -1)
            {
                picImagen.Show();
            }
        }
    }
}
