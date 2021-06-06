using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Lab_16
{
    public partial class MainWindow
    {
        private const int ButtonSize = 64;
        
        private const int ButtonsCounter = 16;
        
        private readonly List<int> _numbers;
        
        private int _numberNow = 1;
        
        private readonly HashSet<int> _tempNumbers;
        
        private readonly Random _random;
        
        private readonly Stopwatch _stopWatch;
        
        public MainWindow()
        {
            _tempNumbers = new HashSet<int>();
            _random = new Random();
            _stopWatch = new Stopwatch();
            _numbers = new List<int>();
            
            InitializeComponent();
            CreateButtons();
        }

        private void AddButtonOnClick(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(SentenceTextBox.Text))
            {
                return;
            }
            
            SentenceBox.Items.Add(SentenceTextBox.Text);
            SentenceTextBox.Text = string.Empty;
        }

        private void RemoveButtonOnClick(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(SentenceTextBox.Text))
            {
                return;
            }

            if (!SentenceBox.Items.Contains(SentenceTextBox.Text))
            {
                return;
            }
            
            SentenceBox.Items.Remove(SentenceTextBox.Text);
            SentenceTextBox.Text = string.Empty;
        }
        
        private void CreateButtons()
        {
            _numbers.AddRange(Enumerable.Range(1, ButtonsCounter));

            Buttons.ItemHeight = ButtonSize;
            Buttons.ItemWidth = ButtonSize;
            
            for (int i = 0; i < ButtonsCounter; i++)
            {
                int number = RandomNumber(0, ButtonsCounter);
                
                Button button = new Button
                {
                    Background = new SolidColorBrush(Colors.MediumSeaGreen),
                    BorderBrush = new SolidColorBrush(Colors.ForestGreen),
                    FontSize= 18,
                    Content = number.ToString(),
                    Margin = new Thickness(8)
                };

                button.Click += ButtonClick;
                _tempNumbers.Add(number);
                
                Buttons.Children.Add(button);
            }
            
            _tempNumbers.Clear();
        }
        
        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            if (!(sender is Button button))
            {
                return;
            }
            
            if (int.TryParse(button.Content.ToString(),out int number) && number == _numberNow)
            {
                switch (_numberNow)
                {
                    case 1:
                        _stopWatch.Start();
                        break;
                    case 16:
                    {
                        TimeSpan ts = _stopWatch.Elapsed;
                        string elapsedTime = $"{ts.Hours:00}:{ts.Minutes:00}:{ts.Seconds:00}.{ts.Milliseconds / 10:00}";
                        
                        StatusBox.Text = $"Well done!\nYou won for: {elapsedTime}";
                        _stopWatch.Reset();
                        ResetButton();
                        return;
                    }
                }

                button.IsEnabled = false;
                _numberNow++;
                ChangeNumber();
            }
            else
            {
                TimeSpan ts = _stopWatch.Elapsed;
                string elapsedTime = $"{ts.Hours:00}:{ts.Minutes:00}:{ts.Seconds:00}.{ts.Milliseconds / 10:00}";
                
                StatusBox.Text = $"You lost for:\n {elapsedTime}";
                _stopWatch.Reset();
                ResetButton();
            }
        }
        
        private void ChangeNumber()
        {
            foreach (object children in Buttons.Children)
            {
                if (!(children is Button button))
                {
                    continue;
                }

                if (!button.IsEnabled)
                {
                    continue;
                }
                
                int number = RandomNumber(_numberNow-1, ButtonsCounter);
                _tempNumbers.Add(number);
                button.Content = number.ToString();
            }
            
            _tempNumbers.Clear();
        }
        
        private void ResetButton()
        {
            _numberNow = 1;
            Buttons.Children.Clear();
            CreateButtons();
        }
        
        private int RandomNumber(int min,int max)
        {
            int number;
            
            do
            {
                int index = _random.Next(min, max);
                number = _numbers[index];
            } while (_tempNumbers.Contains(number));
            
            return number;
        }
    }
}