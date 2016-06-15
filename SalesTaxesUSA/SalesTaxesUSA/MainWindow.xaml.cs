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

namespace SalesTaxesUSA
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

        /**
            Jeżeli zmieniamy base price, to finalPrice podaj -1.
            Jeżeli zmieniasz final price, to basePrice podaj -1.
        */
        double calculatePrice(double basePrice, double finalPrice, double baseTax, double categoryTax) {

            double calculatedPrice = 0;

            if (basePrice != -1)
            {
                calculatedPrice = basePrice * (baseTax + categoryTax);
            }
            else if (finalPrice != -1)
            {
                calculatedPrice = finalPrice / (baseTax + categoryTax);
            }

            return calculatedPrice;

        }

    }
}
