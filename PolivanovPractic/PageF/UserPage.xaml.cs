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

            IDUSR = iduser;
            var userInSys = ClassF.ClDataBase.mAD.Users.FirstOrDefault(x => x.ID == iduser);
            TbEmail.Text = userInSys.Email;
            TbName.Text = userInSys.Name;
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ClassF.FrameClass.frmUser.Navigate(new MyArticles(IDUSR));
        }
    }
}
