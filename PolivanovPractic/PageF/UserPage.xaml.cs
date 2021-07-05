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
    /// Логика взаимодействия для UserPage.xaml
    /// </summary>
    public partial class UserPage : Page
    {
        public static int IDUSR { get; set; }
        public UserPage(int iduser)
        {
            InitializeComponent();

            try
            {
                IDUSR = iduser;
                var userInSys = ClassF.ClDataBase.mAD.Users.FirstOrDefault(x => x.ID == iduser);
                TbEmail.Text = userInSys.Email;
                TbName.Text = userInSys.Name;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                ClassF.FrameClass.frmUser.Navigate(new MyArticles(IDUSR));
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
                ClassF.FrameClass.frmMain.Navigate(new Autorization());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void Border_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
            try
            {
                ClassF.FrameClass.frmMain.Navigate(new NotesPage());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
