using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVolume
{
    public partial class Form1 : Form
    {

        double raio, altura, volume;

        private void txtAltura_Validating(object sender, CancelEventArgs e)
        {
            if (!double.TryParse(txtAltura.Text, out altura))
            {
                MessageBox.Show("Altura inválida.");
                e.Cancel = true;
            }
            else
            {
                if (altura <= 0)
                {
                    MessageBox.Show("Altura deve ser maior que zero.");
                    e.Cancel = true;
                }
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            volume = Math.PI * Math.Pow(raio, 2) * altura;
            txtVolume.Text = volume.ToString("N2");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAltura.Clear();
            txtRaio.Clear();
            txtVolume.Clear();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void txtRaio_Validated(object sender, EventArgs e)
        {

            if (!double.TryParse(txtRaio.Text, out raio))
            {


                MessageBox.Show("Raio inválido.");
                txtRaio.Focus();
            }
            else
            {
                if (raio <= 0)
                {
                    MessageBox.Show("Raio deve ser maior que zero.");
                    txtRaio.Focus();
                }
            }
        }
    }
}
