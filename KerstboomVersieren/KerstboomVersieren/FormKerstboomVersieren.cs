using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KerstboomVersieren
{
    public partial class FormKerstboomVersieren : Form
    {
        // naam en nummer

        public FormKerstboomVersieren()
        {
            InitializeComponent();
        }

        private void buttonBereken_Click(object sender, EventArgs e)
        {
            // declareren variabelen
            double hoogteKerstboom;
            int aantalKerstballen;
            double lengteKerstslinger;
            double lengteLichtsnoer;
            double hoogteKerstster;

            // invoer
            hoogteKerstboom = double.Parse(textBoxHoogte.Text);

            // berekeningen
            hoogteKerstboom = hoogteKerstboom / 10;
            aantalKerstballen = (int)(((Math.Sqrt(17) / 20) * hoogteKerstboom));
            lengteKerstslinger = (((13 * Math.PI) / 8) * hoogteKerstboom);
            lengteLichtsnoer = Math.Round(Math.PI * hoogteKerstboom, 1);
            hoogteKerstster = Math.Round(hoogteKerstboom / 10, 1);

            // uitvoer
            labelAantalBallen.Text = aantalKerstballen.ToString();
            labelLengteSlinger.Text = lengteKerstslinger.ToString("#,##0.00");
            labelLengteLicht.Text = lengteLichtsnoer.ToString("#,##0.00");
            labelHoogteSter.Text = hoogteKerstster.ToString("#,##0.0");
        }
    }
}
