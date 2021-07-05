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

namespace PolivanovPractic.PageF
{
    /// <summary>
    /// Логика взаимодействия для FovouritesPage.xaml
    /// </summary>
    public partial class FovouritesPage : Page
    {
        public FovouritesPage(int idUSe)
        {
            InitializeComponent();
            FavData.ItemsSource = ClassF.ClDataBase.mAD.Favorites.Where(x => x.UserID == idUSe).ToList();
        }
    }
}
