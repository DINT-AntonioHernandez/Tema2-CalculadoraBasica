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

namespace Tema2_CalculadoraBasica
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int primerNum = 0;
        int secunNum = 0;

        char operador = '+';

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            string valor = btn.Content.ToString();

            salidaTextBox.Text = salidaTextBox.Text+valor;
        }



        private void divisionButton_Copiar_Click(object sender, RoutedEventArgs e)
        {
            int resultado = 0;
            switch (operador)
            {
                case '+':
                    resultado =  primerNum + int.Parse(salidaTextBox.Text);
                    break;
                case '-':
                    resultado = primerNum- int.Parse(salidaTextBox.Text);
                    break;
                case '*':
                    resultado = primerNum * int.Parse(salidaTextBox.Text);
                    break;
                case '/':
                    resultado = primerNum / int.Parse(salidaTextBox.Text);
                    break;
            }

            salidaTextBox.Text = $"{resultado}";
        }

        private void sumButton_Click(object sender, RoutedEventArgs e)
        {
            primerNum = int.Parse(salidaTextBox.Text);
            operador = '+';
            salidaTextBox.Text = "";
        }

        private void minusButton_Click(object sender, RoutedEventArgs e)
        {
            primerNum = int.Parse(salidaTextBox.Text);
            operador = '-';
            salidaTextBox.Text = "";
        }

        private void multButton_Click(object sender, RoutedEventArgs e)
        {
            primerNum = int.Parse(salidaTextBox.Text);
            operador = '*';
            salidaTextBox.Text = "";
        }

        private void divisionButton_Click(object sender, RoutedEventArgs e)
        {
            primerNum = int.Parse(salidaTextBox.Text);
            operador = '/';
            salidaTextBox.Text = "";
        }

        private void delButton_Click(object sender, RoutedEventArgs e)
        {
            salidaTextBox.Text = "";
        }
    }
}
