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
    /// Логика взаимодействия для PageFeed.xaml
    /// </summary>
    public partial class PageFeed : Page
    {
        public string pathPage { get; set; }
        public PageFeed(int idArticle, string path)
        {
            InitializeComponent();

            try
            {
                pathPage = path;
                var art = ClassF.ClDataBase.mAD.Articles.FirstOrDefault(x => x.ID == idArticle);
                TbName.Text = art.Name;
                TbText.Text = art.Text;
                borderVverx();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public async void borderVverx() 
        {
            for (int i = -55; i <= 0; i++)
            { 
                await Task.Delay(1);
                BrMain.Margin = new Thickness(0, 0, 0, i*8);
            }
        }

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                if (pathPage == "MyArticles")
                {
                    ClassF.FrameClass.frmUser.Navigate(new MyArticles(UserPage.IDUSR));
                }
                if (pathPage == "Nov")
                {
                    ClassF.FrameClass.frmUser.Navigate(new NovostiPage());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
