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
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Page
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ClassF.FrameClass.frmMain.GoBack();
        }

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void TbEmail_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            var tbox = (TextBox)sender;
            if (tbox.Text == "Name" || tbox.Text == "Password" || tbox.Text == "RePassword" || tbox.Text == "Email")
            {
                tbox.Text = "";
                tbox.Foreground = Brushes.Black;
            }
        }

        private void Border_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            if (TbEmail.Text != "" && TbName.Text != "" && TbPass.Text != "" && TbRePass.Text == TbPass.Text && TbEmail.Foreground == Brushes.Green)
            {
                DataBaseF.Users users = new DataBaseF.Users()
                {
                    Name = TbName.Text,
                    Email = TbEmail.Text,
                    Password = TbPass.Text
                };
                ClassF.ClDataBase.mAD.Users.Add(users);
                ClassF.ClDataBase.mAD.SaveChanges();
                MessageBox.Show("Пользователь успешно добавлен!");
            }
            else { MessageBox.Show("Пустые поля!"); }
        }

        private void TbEmail_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TbEmail.Text.Contains("@") && TbEmail.Text.Contains("."))
            {
                TbEmail.Foreground = Brushes.Green;
            }
            else 
            { 
                TbEmail.Foreground = Brushes.Red; 
            }
        }
    }
}
