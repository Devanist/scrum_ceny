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
        List<Product> productList = new List<Product>();
        public MainWindow()
        {
            InitializeComponent();
            List<State> stateList = new List<State>();
            //ProductCategory productCategory = new ProductCategory();
            //productCategory.

            stateList.Add(new State("Alaska", 0.0));
            stateList.Add(new State("California", 0.075));
            stateList.Add(new State("Kentucky", 0.06));
            stateList.Add(new State("Maine", 0.055));
            stateList.Add(new State("Michigan", 0.06));
            stateList.Add(new State("Montana", 0.0));
            stateList.Add(new State("Nevada", 0.0685));
            stateList.Add(new State("New Jersey", 0.07));
            stateList.Add(new State("New Mexico", 0.05125));
            stateList.Add(new State("South Carolina", 0.05));

            productList.Add(new Product(0, "Spodnie", 30, -1));
            productList.Add(new Product(1, "APAP", 4, -1));
            productList.Add(new Product(2, "AspirynaMax", 10, -1));
            productList.Add(new Product(3, "Ziemniak", 1, -1));
            productList.Add(new Product(4, "Pampuchy", 3, -1));
            productList.Add(new Product(5, "Pomidor", 2, -1));
            productList.Add(new Product(6, "T-shirt", 15, -1));
            productList.Add(new Product(7, "Nospa", 6, -1));
            productList.Add(new Product(8, "Pierogi", 5, -1));
            productList.Add(new Product(9, "Witaminex", 30, -1));

            foreach(var element in stateList)
            {
                stateComboBox.Items.Add(element.name);
            }

            foreach(var element in productList)
            {
                productComboBox.Items.Add(element.name);
            }
        }

        /**
            Jeżeli zmieniamy base price, to finalPrice podaj -1.
            Jeżeli zmieniasz final price, to basePrice podaj -1.
        */
        double calculatePrice(double basePrice, double finalPrice, double baseTax, double categoryTax) {

            double calculatedPrice = 0;

            if (basePrice != -1)
            {
                calculatedPrice = basePrice * ( 1 + baseTax + categoryTax);
            }
            else if (finalPrice != -1)
            {
                calculatedPrice = finalPrice / (1 + baseTax + categoryTax);
            }

            return calculatedPrice;

        }

        private void productComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Product product;
            product = productList[1];
            foreach (var element in productList)
            {
                if(productComboBox.SelectedValue == element.name)
                {
                    product = element;
                }
                //stateComboBox.Items.Add(element.name);
            }
            basePriceTextBox.Text = product.basePrice.ToString();
        }
    }
}
