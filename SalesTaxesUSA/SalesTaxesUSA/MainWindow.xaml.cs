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
            List<Product> productList = new List<Product>();
            List<State> stateList = new List<State>();
            ProductCategory productCategory = new ProductCategory();

            stateList.Add(new State("Alaska", 0.5));
            stateList.Add(new State("California", 0.5));
            stateList.Add(new State("Kentucky", 0.5));
            stateList.Add(new State("Maine", 0.5));
            stateList.Add(new State("Michigan", 0.5));
            stateList.Add(new State("Montana", 0.5));
            stateList.Add(new State("Nevada", 0.5));
            stateList.Add(new State("New Jersey", 0.5));
            stateList.Add(new State("New Mexico", 0.5));
            stateList.Add(new State("South Carolina", 0.5));

        }
    }
}
