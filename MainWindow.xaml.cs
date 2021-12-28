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

namespace RandomPasswordGenerator
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
        
        private void Button_Click (object sender, RoutedEventArgs e)
        {
            char[] symbols = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxy1234567890_".ToCharArray();

            Random rand = new Random();

            // Generate random string that has 12 symbols
            string password = "";
            int num_symbols = 12;
            for (int i = 1; i <= num_symbols; i++) 
            {
                int symbol_num = rand.Next(0, symbols.Length - 1);

                password += symbols[symbol_num];
            }

            textBox.Text = password;
        }

        private void CopyButton_Click(object sender, RoutedEventArgs e) 
        {
            Clipboard.SetText(textBox.Text);
        }
    }
}
