using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace CalculadoraWPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Botones
        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;

            string value = (string)button.Content;

            if (IsNumero(value))
            {
                HandleNumeros(value);
            }
            else if (IsOperador(value))
            {
                HandleOperador(value);
            }
            else if (value == ",")
            {
                HandleComma();
            }
            else if (value == "C" || value == "CE")
            {
                HandleClear(value);
            }
            else if (value == "=")
            {
                HandleEquals(Screen.Text);
            }
        }

        // Métodos Auxiliares
        private bool IsNumero(string value)
        {
            return double.TryParse(value, out _);
        }

        private bool IsOperador(string value)
        {
            return value == "+" || value == "-" || value == "*" ||
                value == "/";
        }

        private bool ContieneOtroOperador(string value)
        {
            return value.Contains("+") || value.Contains("-") || value.Contains("*") ||
                value.Contains("/");
        }

        private string FindOperador(string value)
        {
           
            foreach (char c in value)
            {
                if (IsOperador(c.ToString()))
                {
                    return c.ToString();
                }
            }
            

            return String.Empty;
        }

        private void HandleNumeros(string value)
        {
            if (String.IsNullOrEmpty(Screen.Text))
            {
                Screen.Text = value;
            }
            else
            {
                Screen.Text += value;
            }
        }

        private void HandleComma()
        {
            int cantidadSubCadenas = Screen.Text.Split(new char[] { '+', '-', '*', '/' }).Length;
            int cantidadDeComas = Screen.Text.Where(c => c == ',').Count();

            if (!String.IsNullOrEmpty(Screen.Text))
            {
                if ((cantidadSubCadenas == 1 && cantidadDeComas == 0) || (cantidadSubCadenas == 2 && cantidadDeComas == 1))
                {
                    Screen.Text += ",";
                }
            }
        }

        private void HandleClear(string value)
        {
            if (value == "C")
            {
                if (Screen.Text.Length > 1)
                {
                    Screen.Text = Screen.Text.Remove(Screen.Text.Length - 1);
                }
                else
                {
                    Screen.Clear();
                }
            }
            else if (value == "CE")
            {
                Screen.Clear();
            }
        }

        private void HandleOperador(string value)
        {
            if (!ContieneOtroOperador(Screen.Text) && !String.IsNullOrEmpty(Screen.Text))
            {
                Screen.Text += value;
                
            }
        }

        private void HandleEquals(string value)
        {
            string op = FindOperador(value);

            // Arreglar bien el tema de los números negativos. Esto es temporal. 
            if (!String.IsNullOrEmpty(op))
            {
                switch (op)
                {
                    case "+":
                        Screen.Text = Sum();
                        break;
                    case "-":
                        Screen.Text = Rest();
                        break;
                    case "*":
                        Screen.Text = Mul();
                        break;
                    case "/":
                        Screen.Text = Div();
                        break;
                   
                }
            }
        }


        // Operaciones
        private string Sum()
        {
            string cadena = Screen.Text.Replace(',', '.');

            string[] numbers = cadena.Split('+');

            double.TryParse(numbers[0], out double n1);
            double.TryParse(numbers[1], out double n2);

            return Math.Round(n1 + n2, 12).ToString().Replace('.', ',');
        }

        private string Rest()
        {
            string cadena = Screen.Text.Replace(',', '.');
            string[] numbers = cadena.Split('-');

            double.TryParse(numbers[0], out double n1);
            double.TryParse(numbers[1], out double n2);

            return Math.Round(n1 - n2, 12).ToString().Replace('.', ',');
        }

        private string Mul()
        {
            string cadena = Screen.Text.Replace(',', '.');
            string[] numbers = cadena.Split('*');

            double.TryParse(numbers[0], out double n1);
            double.TryParse(numbers[1], out double n2);

            return Math.Round(n1 * n2, 12).ToString().Replace('.', ',');
        }

        private string Div()
        {
            string cadena = Screen.Text.Replace(',', '.');
            string[] numbers = cadena.Split('/');

            double.TryParse(numbers[0], out double n1);
            double.TryParse(numbers[1], out double n2);

            return Math.Round(n1 / n2, 12).ToString().Replace('.', ',');
        }
    }
}
