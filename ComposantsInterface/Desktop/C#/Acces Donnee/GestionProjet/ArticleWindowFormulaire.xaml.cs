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
    /// Logique d'interaction pour ArticleWindowFormulaire.xaml
    /// </summary>
    public partial class ArticleWindowFormulaire : Window
    {
        public ArticleWindowFormulaire()
        {
            ArticleWindowFormulaire w1 = new ArticleWindowFormulaire();

            Nullable<bool> dialogResult = w1.ShowDialog();
        }
    }
}
