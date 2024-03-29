﻿using System;
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
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public int idUS { get; set; }
        public MainPage(int IDUSER)
        {
            InitializeComponent();

            try
            {
                idUS = IDUSER;
                ClassF.FrameClass.frmUser = FrmUserLog;
                ClassF.FrameClass.frmUser.Navigate(new UserPage(IDUSER));
                BrPeople.Visibility = Visibility.Visible;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                var img = (Border)sender;
                if (img.Name == BtnHeart.Name)
                {
                    BrHeart.Visibility = Visibility.Visible;
                    ClassF.FrameClass.frmUser.Navigate(new FovouritesPage(idUS));
                }
                else
                {
                    BrHeart.Visibility = Visibility.Collapsed;
                }
                //----------------------------------------
                if (img.Name == BtnLupa.Name)
                {
                    BrLupa.Visibility = Visibility.Visible;
                    ClassF.FrameClass.frmUser.Navigate(new Recipes());
                }
                else
                {
                    BrLupa.Visibility = Visibility.Collapsed;
                }
                //----------------------------------------
                if (img.Name == BtnNew.Name)
                {
                    BrNew.Visibility = Visibility.Visible;
                    ClassF.FrameClass.frmUser.Navigate(new NovostiPage());
                }
                else
                {
                    BrNew.Visibility = Visibility.Collapsed;
                }
                //----------------------------------------
                if (img.Name == BtnPeople.Name)
                {
                    BrPeople.Visibility = Visibility.Visible;
                    ClassF.FrameClass.frmUser.Navigate(new UserPage(idUS));
                }
                else
                {
                    BrPeople.Visibility = Visibility.Collapsed;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
