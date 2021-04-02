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

namespace WpfPanino
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            rbtPnormale.IsChecked = true;
            rbtProsciuto.IsChecked = true;
        }

        private void btnCalcola_Click(object sender, RoutedEventArgs e)
        {
            double totale = 0;
            if (rbtPnormale.IsChecked == true)
                totale += 1;
            else if (rbtPintegrale.IsChecked == true)
                totale += 1.25;
            else
                totale += 1.50;

            if (rbtProsciuto.IsChecked == true)
                totale += 0.50;
            else if (rbtMortadella.IsChecked == true)
                totale += 0.75;
            else if (rbtSalsiccia.IsChecked == true)
                totale += 1;
            else
                totale += 1.25;

            if (cbxCipolla.IsChecked == true)
                totale += 0.50;
            else if (cbxPeperoni.IsChecked == true)
                totale += 1.25;
            else if (cbxInsalata.IsChecked == true)
                totale += 0.75;
            else if(cbxFormaggio.IsChecked == true)
                totale += 1;

            lblTotale.Content = totale + "€";
        }


    }
}
