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

namespace WPF_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        string operators = "";
        double value = 0;
        bool operator_pressed = false;
        public MainWindow()
        {
            InitializeComponent();
        }
      
        private void button_Click(object sender, RoutedEventArgs e)
        {
            if ((result.Text == "0") || (operator_pressed))
            {
                result.Clear();
            }
            operator_pressed = false;
            Button b = (Button)sender;
            result.Text = result.Text + b.Content;
        }

        private void operator_Click(object sender, RoutedEventArgs e)
        {
            value = Double.Parse(result.Text);
            operator_pressed = true;
            Button b = (Button)sender;
            operators = b.Content.ToString();
            equation.Content = value + " " + operators;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            result.Text = "0";
            value = 0;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            equation.Content = "";
            switch (operators)
            {
                case "+":
                    result.Text = (value + Double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (value - Double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (value * Double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = (value / Double.Parse(result.Text)).ToString();
                    break;
                default:
                    break;
            }
            operator_pressed = false;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            result.Text = "0";
        }
    }
}

