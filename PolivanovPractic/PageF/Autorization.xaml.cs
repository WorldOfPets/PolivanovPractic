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
    /// Логика взаимодействия для Autorization.xaml
    /// </summary>
    public partial class Autorization : Page
    {
        public Autorization()
        {
            InitializeComponent();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                ClassF.FrameClass.frmMain.Navigate(new Registration());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void Border_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            try
            {
                if (TbEmail.Text != "" && TbPass.Text != "")
                {
                    var user = ClassF.ClDataBase.mAD.Users.FirstOrDefault(x => x.Email == TbEmail.Text && x.Password == TbPass.Text);
                    if (user != null)
                    {
                        ClassF.FrameClass.frmMain.Navigate(new MainPage(user.ID));
                    }
                    else { MessageBox.Show("Пользовтель не найден!"); }
                }
                else { MessageBox.Show("Пустые поля!"); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void TbEmail_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                var tbox = (TextBox)sender;
                if (tbox.Text == "Account" || tbox.Text == "Password")
                {
                    tbox.Text = "";
                    tbox.Foreground = Brushes.Black;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void Border_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
            ClassF.FrameClass.frmMain.GoBack();
        }

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
