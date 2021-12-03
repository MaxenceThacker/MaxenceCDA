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
using System.Windows.Shapes;

namespace GestionProjet
{
    /// <summary>
    /// Logique d'interaction pour ArticleWindow.xaml
    /// </summary>
    public partial class ArticleWindow : Window
    {
        public ArticleWindow()
        {
            InitializeComponent();
        }
        private void Btn_Ajouter_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void Btn_Modifier_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_Supprimer_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_Dupliquer_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_Vider_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Btn_Category_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_Typesproduit_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
