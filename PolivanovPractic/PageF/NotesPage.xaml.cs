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
    /// Логика взаимодействия для NotesPage.xaml
    /// </summary>
    public partial class NotesPage : Page
    {
        public NotesPage()
        {
            InitializeComponent();
        }

        private void Border_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            if (BrCollor.Visibility == Visibility.Collapsed)
            {
                BrCollor.Visibility = Visibility.Visible;
            }
            else if (BrCollor.Visibility == Visibility.Visible)
            {
                BrCollor.Visibility = Visibility.Collapsed;
            }
        }

        private void Border_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
            var border = (Border)sender;
            if (border.Background == Brushes.Orange) { InkCanvasss.DefaultDrawingAttributes.Color = Colors.Orange; BrCollor.Background = Brushes.Orange; BrButton.Background = Brushes.Orange; }
            if (border.Background == Brushes.DarkViolet) { InkCanvasss.DefaultDrawingAttributes.Color = Colors.DarkViolet; BrCollor.Background = Brushes.DarkViolet; BrButton.Background = Brushes.DarkViolet; }
            if (border.Background == Brushes.Red) { InkCanvasss.DefaultDrawingAttributes.Color = Colors.Red; BrCollor.Background = Brushes.Red; BrButton.Background = Brushes.Red; }
            if (border.Background == Brushes.Yellow) { InkCanvasss.DefaultDrawingAttributes.Color = Colors.Yellow; BrCollor.Background = Brushes.Yellow; BrButton.Background = Brushes.Yellow; }
            if (border.Background == Brushes.Green) { InkCanvasss.DefaultDrawingAttributes.Color = Colors.Green; BrCollor.Background = Brushes.Green; BrButton.Background = Brushes.Green; }
            if (border.Background == Brushes.Aquamarine) { InkCanvasss.DefaultDrawingAttributes.Color = Colors.Aquamarine; BrCollor.Background = Brushes.Aquamarine; BrButton.Background = Brushes.Aquamarine; }
            if (border.Background == Brushes.Blue) { InkCanvasss.DefaultDrawingAttributes.Color = Colors.Blue; BrCollor.Background = Brushes.Blue; BrButton.Background = Brushes.Blue; }
            if (border.Background == Brushes.Black) { InkCanvasss.DefaultDrawingAttributes.Color = Colors.Black; BrCollor.Background = Brushes.Black; BrButton.Background = Brushes.Black; }
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (BrPen.Visibility == Visibility.Collapsed)
            {
                BrPen.Visibility = Visibility.Visible;
            }
            else if (BrPen.Visibility == Visibility.Visible)
            {
                BrPen.Visibility = Visibility.Collapsed;
            }
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            InkCanvasss.DefaultDrawingAttributes.Width = e.NewValue;
            InkCanvasss.DefaultDrawingAttributes.Height = e.NewValue;
        }

        private void InkCanvasss_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            BrPen.Visibility = Visibility.Collapsed;
            BrCollor.Visibility = Visibility.Collapsed;
        }

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            var colr = new BrushConverter();
            InkCanvasss.DefaultDrawingAttributes.Color = Colors.LightGray;
        }

        private void Image_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
            ClassF.FrameClass.frmUser.GoBack();
        }
    }
}
