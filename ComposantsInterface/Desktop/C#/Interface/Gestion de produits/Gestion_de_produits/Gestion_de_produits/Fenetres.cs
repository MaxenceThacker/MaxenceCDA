using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Gestion_de_produits
{
    class Fenetres : Window
    {
        public MainWindow W { get; set; }
        public Produits Produit { get; set; }

        public Fenetres(Produits produit, MainWindow w)
        {
            this.W = w;
            this.Produit = produit;
        }

        private void btn_Ajouter_Click(object sender, RoutedEventArgs e)
        {
            W.MAJRetour("test");
            this.Close();
        }
    }
}

