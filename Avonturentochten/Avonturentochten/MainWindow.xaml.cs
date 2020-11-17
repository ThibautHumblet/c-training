using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Avonturentochten
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // declareren
            const double vastePrijs = 1870;
            const double prijsVertrekAntwerpen = 175.75;
            const double prijsVertrekBrussel = 150.25;
            const double prijsAnnulatieVerzekering = 120.20;
            double totaalPrijs;

            int aantalPersonen;
            double prijsPerPersoon;

            // invoer
            aantalPersonen = int.Parse(textBoxAantal.Text);
            totaalPrijs = 0;

            if (checkBoxAnnulatie.IsChecked == true)
            {
                totaalPrijs += prijsAnnulatieVerzekering;
            }

            if (radioButtonAntwerpen.IsChecked == true)
            {
                totaalPrijs +=  prijsVertrekAntwerpen;
            }

            if (radioButtonBrussel.IsChecked == true)
            {
                totaalPrijs += prijsVertrekBrussel;
            }

            // berekeningen
            if (aantalPersonen <10 || aantalPersonen > 40)
            {
                MessageBox.Show("De avonturentochten zijn enkel voor groepen van 10 tot en met 40 personen.", "Mededeling", MessageBoxButton.OK, MessageBoxImage.Information);
            } else
            {
                totaalPrijs += vastePrijs;
                prijsPerPersoon = totaalPrijs / aantalPersonen;
                labelPerPersoon.Content = prijsPerPersoon.ToString("€ #,##0.00");
            }
            
        }


        //---------------------------------------------------------------------------
        // testgegevens
        // aantal personen | vertrekplaats | annulatieverzekering | prijs per persoon
        // 27              | Brussel       | niet                 | 74,82
        // 18              | Namen         | wel                  | 110,56
        //                 |               |                      | geen berekening
        //                 |               |                      |
        //---------------------------------------------------------------------------

    }
}
