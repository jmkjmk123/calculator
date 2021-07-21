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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        StringBuilder op1 = new StringBuilder();
        StringBuilder op2 = new StringBuilder();
        StringBuilder result = new StringBuilder();
        char Oper = ' ';
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_1_Click(object sender, RoutedEventArgs e)
        {
            result.Append('1');
            text_result.Text = result.ToString();
        }

        private void button_clear_Click(object sender, RoutedEventArgs e)
        {
            result.Clear();
            text_result.Text = result.ToString();
        }

        private void button_2_Click_1(object sender, RoutedEventArgs e)
        {
            result.Append('2');
            text_result.Text = result.ToString();
        }

        private void button_3_Click(object sender, RoutedEventArgs e)
        {
            result.Append('3');
            text_result.Text = result.ToString();
        }

        private void button_4_Click(object sender, RoutedEventArgs e)
        {
            result.Append('4');
            text_result.Text = result.ToString();
        }

        private void button_5_Click(object sender, RoutedEventArgs e)
        {
            result.Append('5');
            text_result.Text = result.ToString();
        }

        private void button_6_Click(object sender, RoutedEventArgs e)
        {
            result.Append('6');
            text_result.Text = result.ToString();
        }

        private void button_7_Click(object sender, RoutedEventArgs e)
        {
            result.Append('7');
            text_result.Text = result.ToString();
        }

        private void button_8_Click(object sender, RoutedEventArgs e)
        {
            result.Append('8');
            text_result.Text = result.ToString();
        }

        private void button_9_Click(object sender, RoutedEventArgs e)
        {
            result.Append('9');
            text_result.Text = result.ToString();
        }

        private void button_0_Click(object sender, RoutedEventArgs e)
        {
            result.Append('0');
            text_result.Text = result.ToString();
        }
    }
}
