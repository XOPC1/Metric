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
using System.Text.RegularExpressions;

namespace Metric
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Convert.ToDouble(textBox.Text);
            double Znach = Convert.ToDouble(textBox.Text);
            int index = Combo1.SelectedIndex;
            switch (index)
            {
                case 0:
                    Znach = Znach * 2.54;
                    MessageBox.Show(Znach + "см", "Результат");
                    break;
                case 1:
                    Znach = Znach * 0.3048;
                    MessageBox.Show(Znach + " м", "Результат");
                    break;
                case 2:
                    Znach = Znach * 0.9144;
                    MessageBox.Show(Znach + " м", "Результат");
                    break;
                case 3:
                    Znach = Znach * 1.6093;
                    MessageBox.Show(Znach + "км", "Результат");
                    break;
            }
            textBox.Text = "";
            textBox.Clear();

        }
    }
}
