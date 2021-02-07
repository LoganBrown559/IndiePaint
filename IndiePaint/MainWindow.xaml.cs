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

namespace IndiePaint
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Canvy.Strokes.Clear();
        }

        private void GreenPen_Click(object sender, RoutedEventArgs e)
        {
            Canvy.DefaultDrawingAttributes.Color = Colors.Green;
        }

        private void RedPin_Click(object sender, RoutedEventArgs e)
        {
            Canvy.DefaultDrawingAttributes.Color = Colors.Red;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Canvy.DefaultDrawingAttributes.Color = Colors.Blue;
        }

        private void PinUp_Click(object sender, RoutedEventArgs e)
        {
            Canvy.DefaultDrawingAttributes.Width += 3;
            Canvy.DefaultDrawingAttributes.Height += 3;
        }

        private void PinDown_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Canvy.DefaultDrawingAttributes.Width -= 3;
                Canvy.DefaultDrawingAttributes.Height -= 3;
            }

            catch
            {
                Console.WriteLine("Notice: Can not go smaller.");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Canvy.DefaultDrawingAttributes.Color = Colors.Black;
            Canvy.DefaultDrawingAttributes.Height = 2;
            Canvy.DefaultDrawingAttributes.Width = 2;
        }

        private void SetPinBlack_Click(object sender, RoutedEventArgs e)
        {
            Canvy.DefaultDrawingAttributes.Color = Colors.Black;
        }
    }
}
