/*
 * 
 * Name: Logan Brown
 * Date: 2/7/2021
 * File: MainWindow.xaml.cs
 * Description: The C# code that implements functionality of all buttons in the application
 * 
 */
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
        

        // Simple Canvas Clear on button push
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Canvy.Strokes.Clear();
        }


        /*
         * These next three functions are the "pretty colors"
         * I have implemented into the project. For
         * Simplicities sake I've implemented three, 
         * but could easily add more.
         */
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

        // Simple brush size increase
        private void PinUp_Click(object sender, RoutedEventArgs e)
        {
            Canvy.DefaultDrawingAttributes.Width += 3;
            Canvy.DefaultDrawingAttributes.Height += 3;
        }

        /*
         * For this, I put an error handling clause because the program crashes if 
         * the user tries to put the brush under zero size. This quitely prevents it,
         * shooting a message to a console that the user can't even see.
         */
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

        //Simple reset of all relevant brush values.
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Canvy.DefaultDrawingAttributes.Color = Colors.Black;
            Canvy.DefaultDrawingAttributes.Height = 2;
            Canvy.DefaultDrawingAttributes.Width = 2;
        }

        // A reset to black, put away from the other colors so it is easy to find
        private void SetPinBlack_Click(object sender, RoutedEventArgs e)
        {
            Canvy.DefaultDrawingAttributes.Color = Colors.Black;
        }
    }
}
