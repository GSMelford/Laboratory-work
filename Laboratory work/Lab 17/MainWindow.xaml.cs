using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Lab_17
{
    public partial class MainWindow
    {
        private const int CatchButtonWidth = 128;

        private const int CatchButtonHeight = 64;

        private int _panelX;
        
        private int _panelY;
        
        private const int Step = 1;

        private readonly System.Windows.Threading.DispatcherTimer _timer;

        private int _timerTick;

        private const int MaxTimerTick = 8;

        private bool _showName;

        private string _titleText = "Натисніть кнопку “Catch Me”!!!";
        
        private enum Position
        {
            Top,
            Bottom,
            TopRight,
            BottomRight,
            Right,
            TopLeft,
            BottomLeft,
            Left
        }

        public MainWindow()
        {
            InitializeComponent();
            
            _timer = new System.Windows.Threading.DispatcherTimer();
 
            _timer.Tick += Timer_Tick;
            _timer.Interval = new TimeSpan(0, 0, 1);
            _timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if(_showName)
            {
                if (Application.Current.MainWindow != null) Application.Current.MainWindow.Title = "";
                _showName = false;
            }
            else
            {
                if (Application.Current.MainWindow != null)
                    Application.Current.MainWindow.Title = _titleText;
                _showName = true;
            }

            if(_timerTick == MaxTimerTick)
            {
                if (Application.Current.MainWindow != null)
                    Application.Current.MainWindow.Title = _titleText;
                _timerTick = 0;
                _timer.Stop();
            }
            
            _timerTick++;
        }
        
        private void ExitButtonOnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            _panelX = (int) Canvas.GetLeft(Panel);
            _panelY = (int) Canvas.GetTop(Panel);
            int catchButtonX = _panelX + 20;
            int catchButtonY = _panelY + 20 + 16;
            
            if (MousePosition.X > catchButtonX)
            {
                if (MousePosition.X < catchButtonX + CatchButtonWidth)
                {
                    if (MousePosition.Y < catchButtonY)
                    {
                        Block.Text = "Top";
                        UpdateCatchButtonPosition(Position.Top);
                    }
                    else
                    {
                        Block.Text = "Bottom";
                        UpdateCatchButtonPosition(Position.Bottom);
                    }
                }
                else if(MousePosition.X > catchButtonX + CatchButtonWidth)
                {
                    if (MousePosition.Y < catchButtonY)
                    {
                        Block.Text = "TopRight";
                        UpdateCatchButtonPosition(Position.TopRight);
                    }
                    else if(MousePosition.Y > catchButtonY + CatchButtonHeight )
                    {
                        Block.Text = "BottomRight";
                        UpdateCatchButtonPosition(Position.BottomRight);
                    }
                    else
                    {
                        Block.Text = "Right";
                        UpdateCatchButtonPosition(Position.Right);
                    }
                }
            }
            else
            {
                if (MousePosition.Y < catchButtonY)
                {
                    Block.Text = "TopLeft";
                    UpdateCatchButtonPosition(Position.TopLeft);
                }
                else if(MousePosition.Y > catchButtonY + CatchButtonHeight )
                {
                    Block.Text = "BottomLeft";
                    UpdateCatchButtonPosition(Position.BottomLeft);
                }
                else
                {
                    Block.Text = "Left";
                    UpdateCatchButtonPosition(Position.Left);
                }
            }

            UpdateCatchButtonSize();
            CheckBoundaries();
        }

        private void UpdateCatchButtonSize()
        {
            if (CatchButton.Height > 1)
            {
                CatchButton.Height -= 0.02;
            }
            else
            {
                MessageBox.Show("And the button is no longer a button ...");
                _titleText = "Кнопка “Catch Me” не може бути натиснута";
                MyCanvas.Children.Clear();
                _timer.Start();
            }
        }
        
        private void UpdateCatchButtonPosition(Position position)
        {
            switch (position)
            {
                case Position.Top:
                    Canvas.SetTop(Panel, _panelY + Step);
                    break;
                case Position.Bottom:
                    Canvas.SetTop(Panel, _panelY - Step);
                    break;
                case Position.TopRight:
                    Canvas.SetTop(Panel, _panelY + Step);
                    Canvas.SetLeft(Panel, _panelX - Step);
                    break;
                case Position.BottomRight:
                    Canvas.SetTop(Panel, _panelY - Step);
                    Canvas.SetLeft(Panel, _panelX - Step);
                    break;
                case Position.Right:
                    Canvas.SetLeft(Panel, _panelX - Step);
                    break;
                case Position.TopLeft:
                    Canvas.SetTop(Panel, _panelY + Step);
                    Canvas.SetLeft(Panel, _panelX + Step);
                    break;
                case Position.BottomLeft:
                    Canvas.SetTop(Panel, _panelY - Step);
                    Canvas.SetLeft(Panel, _panelX + Step);
                    break;
                case Position.Left:
                    Canvas.SetLeft(Panel, _panelX + Step);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(position), position, null);
            }
        }

        private void CheckBoundaries()
        {
            _panelX = (int) Canvas.GetLeft(Panel);
            _panelY = (int) Canvas.GetTop(Panel);
            int width = WindowSize.Width;
            int height = WindowSize.Height;
            int catchButtonX = _panelX + 20;
            int catchButtonY = _panelY + 20 + 16;
            
            if (catchButtonX < 0)
            {
                Canvas.SetLeft(Panel, _panelX + CatchButtonWidth + CatchButtonWidth);
            }
            
            if (catchButtonX + CatchButtonWidth > width)
            {
                Canvas.SetLeft(Panel, _panelX - CatchButtonWidth - CatchButtonWidth);
            }
            
            if (catchButtonY < 0)
            {
                Canvas.SetTop(Panel, _panelY + CatchButtonHeight + CatchButtonHeight);
            }
            
            if (catchButtonY + CatchButtonHeight > height)
            {
                Canvas.SetTop(Panel, _panelY - CatchButtonHeight - CatchButtonHeight);
            }
        }

        private void CatchButton_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("What? Did you do it ??");
        }
    }
}