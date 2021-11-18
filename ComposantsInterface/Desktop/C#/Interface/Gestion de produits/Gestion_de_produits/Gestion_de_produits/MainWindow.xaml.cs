using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace Gestion_de_produits
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Produits> liste;
        string path = @"../../Produits.json";

        public MainWindow()
        {
            InitializeComponent();
            liste = TransformeJson();
            RemplirGrid();
            //CreerFichier();
        }
        public void RemplirGrid()
        {
            listeProduits.ItemsSource = liste;
        }
        private void CreerFichier()
        {
            File.WriteAllText(path, JsonConvert.SerializeObject(liste, Formatting.Indented));
        }

        private string LireFichier()
        // Renvoi un tableau de chaine contenant les informations stockées dans le fichier 
        {
            string chaine;
            try
            {
                // Lecture et stockage dans chaine
                chaine = File.ReadAllText(path);
            }
            catch (Exception e)
            {
                Console.WriteLine("Une exception s'est produite : " + e.Message);
                Console.WriteLine("Indiquer le path :");
                path = Console.ReadLine();
                chaine = LireFichier();
            }
            return chaine;
        }

        private List<Produits> TransformeJson()
        {
            string chaine = LireFichier();
            List<Produits> liste = JsonConvert.DeserializeObject<List<Produits>>(chaine);
            return liste;
        }

        private void btn_Ajouter_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_Modifier_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_Supprimer_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_Dupliquer_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_Vider_Click(object sender, RoutedEventArgs e)
        {

        }
        private void btn_ListeCategories_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_ListeRayons_Click(object sender, RoutedEventArgs e)
        {

        }
        private void btnNvFenetre_Click(object sender, RoutedEventArgs e)
        {
            Fenetres f = new Fenetres(new Produits(12, "Melon", 1), this); ;
            this.Opacity = 0.7;
            this.Visibility = Visibility.Hidden;
            f.ShowDialog();

            this.Visibility = Visibility.Visible;
            this.Opacity = 1;

        }
        public void MAJRetour(string valeur)
        {
            this.btn_Ajouter.Content = valeur;
        }
    }
}
