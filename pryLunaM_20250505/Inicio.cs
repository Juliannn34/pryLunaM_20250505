using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace pryLunaM_20250505
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private decimal fuerza;
        private decimal destreza;


        private void Inicio_Load(object sender, EventArgs e)
        {
            cmbSuperheroe.Items.Clear();
            cmbSuperheroe.Items.Add("Superman");
            cmbSuperheroe.Items.Add("Batman");
            cmbSuperheroe.Items.Add("Wonderwoman");


            numFuerza.Minimum = 1;
            numFuerza.Maximum = 10;

            numDestreza.Minimum = 1;
            numDestreza.Maximum = 10;



        }

      

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                fuerza = numFuerza.Value;
                destreza = numDestreza.Value;
                MessageBox.Show("Superhéroe creado con Fuerza: " + fuerza + " y Destreza: " + destreza);
            }
            catch (Exception error)
            {
                MessageBox.Show("Ocurrió un error: " + error.Message);
            }
        }

        private void cmbSuperheroe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSuperheroe.SelectedItem != null)
            {
                if (cmbSuperheroe.SelectedItem.ToString() == "Superman")
                    picImagen.Image = Properties.Resources.Superman_logo1;
                else if (cmbSuperheroe.SelectedItem.ToString() == "Batman")
                    picImagen.Image = Properties.Resources.vector_batman_logo;
                else if (cmbSuperheroe.SelectedItem.ToString() == "Wonderwoman")
                    picImagen.Image = Properties.Resources.fea23152696aa824fc0bbd224a6d889a;

                picImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
