using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Lab_15_Calculator
{
    public partial class MainWindow
    {
        private const int KeyboardButtonsCounter = 16;
        private const int ButtonSize = 64;
        private bool _operationActive;
        
        private readonly string[] _symbols = 
            { "7", "8", "9", "/", "4", "5", "6", "*", "1", "2", "3", "-", "0", ".", "=", "+" };
        
        public MainWindow()
        {
            InitializeComponent();
            ConstructCalculator();
            ResizeMode = ResizeMode.NoResize;
        }

        private void ConstructCalculator()
        {
            Keyboard.ItemHeight = ButtonSize;
            Keyboard.ItemWidth = ButtonSize;
            
            for (int i = 0; i < KeyboardButtonsCounter; i++)
            {
                Button button = new Button
                {
                    Background = new SolidColorBrush(Colors.LightSeaGreen),
                    BorderBrush = new SolidColorBrush(Colors.DarkSlateGray),
                    FontSize= 18,
                    Content = _symbols[i],
                };

                button.Click += ButtonClick;
                
                Keyboard.Children.Add(button);
            }
        }

        private void ButtonChangeSignClick(object sender, RoutedEventArgs e)
        {
            double number = double.Parse(NumberField.Text);

            if (number == 0)
            {
                return;
            }

            if (number > 0)
            {
                NumberField.Text = "-" + NumberField.Text;
            }
            else
            {
                NumberField.Text = (number * -1).ToString(CultureInfo.InvariantCulture);
            }
                
        }
        
        private void ButtonClearClick(object sender, RoutedEventArgs e)
        {
            NumberField.Clear();
            ArithmeticOperations.Reset();
            NumberField.Text = "0";
        }
        
        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            if (!(sender is Button button))
            {
                return;
            }
                
            if (double.TryParse(button.Content.ToString(), out _))
            {
                if (_operationActive)
                {
                    NumberField.Clear();
                    _operationActive = false;
                }

                if (NumberField.Text == "0" || NumberField.Text == "∞" || NumberField.Text == "-∞")
                {
                    NumberField.Text = button.Content.ToString();
                }
                else
                {
                    NumberField.Text += button.Content.ToString();
                }
                
                return;
            }

            switch (button.Content.ToString())
            {
                case "+":
                    _operationActive = true;
                    SetResult(ArithmeticOperations.GetResult(button.Content.ToString(), double.Parse(NumberField.Text)));
                    break;
                case "-":
                    _operationActive = true;
                    SetResult(ArithmeticOperations.GetResult(button.Content.ToString(), double.Parse(NumberField.Text)));
                    break;
                case "*":
                    _operationActive = true;
                    SetResult(ArithmeticOperations.GetResult(button.Content.ToString(), double.Parse(NumberField.Text)));
                    break;
                case "/":
                    _operationActive = true;
                    SetResult(ArithmeticOperations.GetResult(button.Content.ToString(), double.Parse(NumberField.Text)));
                    break;
                case "=":
                    SetResult(ArithmeticOperations.GetResult(button.Content.ToString(), double.Parse(NumberField.Text)));
                    break;
                case ".":

                    if (_operationActive)
                    {
                        return;
                    }
                       
                    if (NumberField.Text.Any(t => t == '.'))
                    {
                        return;
                    }

                    NumberField.Text += ".";
                    break;
                default:
                    MessageBox.Show("Something went wrong...");
                    break;
            }
        }
        
        private void SetResult(string result)
        {
            if (!string.IsNullOrEmpty(result))
            {
                NumberField.Text = result;
            }
        }
    }
}