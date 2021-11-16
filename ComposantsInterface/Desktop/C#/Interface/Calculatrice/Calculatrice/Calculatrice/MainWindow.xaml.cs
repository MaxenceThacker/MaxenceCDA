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

namespace Calculatrice
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnNumerique_Click(object sender, RoutedEventArgs e)
        {
            // sender est l'élément qui a déclenché l'événement
            tbxResultat.Text += ((Button)sender).Content;
        }

        private void btnInit_Click(object sender, RoutedEventArgs e)
        {
            tbxResultat.Text = "";
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            double w = Application.Current.MainWindow.Width;
            double h = Application.Current.MainWindow.Height;
            btn0.FontSize = h / 20;
            btn1.FontSize = h / 20;
            btn2.FontSize = h / 20;
            btn3.FontSize = h / 20;
            btn4.FontSize = h / 20;
            btn5.FontSize = h / 20;
            btn6.FontSize = h / 20;
            btn7.FontSize = h / 20;
            btn8.FontSize = h / 20;
            btn9.FontSize = h / 20;
            btnAddition.FontSize = h / 20;
            btnSoustraction.FontSize = h / 20;
            btnDivision.FontSize = h / 20;
            btnMultiplication.FontSize = h / 20;
            btnInit.FontSize = h / 20;
            btnEgal.FontSize = h / 20;
            btnPoint.FontSize = h / 20;
        }

    }
}
