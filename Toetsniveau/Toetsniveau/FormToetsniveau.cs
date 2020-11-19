using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toetsniveau
{
    public partial class FormToetsniveau : Form
    {
        public FormToetsniveau()
        {
            InitializeComponent();
        }

        private void buttonBepaal_Click(object sender, EventArgs e)
        {
            // declareren variabelen
            double behaaldeScore;
            int maximumScore;
            int aantalBonuspunten = 0;
            double totaalScore;
            double behaaldPercentage;

            char niveau = 'X';
            string commentaar = "Geen cijfer";

            // invoer
            behaaldeScore = double.Parse(textBoxBehaald.Text);
            maximumScore = int.Parse(listBoxMaximum.SelectedItem.ToString());

            if (radioButton1.Checked)
                aantalBonuspunten = int.Parse(radioButton1.Text.ToString());
            else if (radioButton2.Checked)
                aantalBonuspunten = int.Parse(radioButton2.Text.ToString());
            else if (radioButton3.Checked)
                aantalBonuspunten = int.Parse(radioButton3.Text.ToString());


            // berekeningen
            totaalScore = behaaldeScore + aantalBonuspunten;
            behaaldPercentage = totaalScore / maximumScore * 100;

            if (behaaldPercentage <= 40)
            {
                niveau = 'F';
            }
            else if (behaaldPercentage <= 50)
            {
                niveau = 'E';
            }
            else if (behaaldPercentage <= 60)
            {
                niveau = 'D';
            }
            else if (behaaldPercentage <= 70)
            {
                niveau = 'C';
            }
            else if (behaaldPercentage <= 80)
            {
                niveau = 'B';
            }
            else if (behaaldPercentage > 80)
            {
                niveau = 'A';
            }

            labelNiveau.Text = niveau.ToString();

            if (checkBoxCommentaar.Checked)
            {
                switch (niveau)
                {
                    case 'E':
                    case 'F':
                        commentaar = "onvoldoende";
                        break;
                    case 'D':
                        commentaar = "matig";
                        break;
                    case 'C':
                        commentaar = "goed";
                        break;
                    case 'B':
                    case 'A':
                        commentaar = "schitterend";
                        break;
                }

                labelCommentaar.Text = commentaar;
                labelCommentaar.Visible = true;
            }

        }
    }
}
