using System.Drawing;
using System.Windows.Forms;


namespace Lab_14
{
    public partial class MainForm : Form
    {
        private int X;
        private int Y;
        private int Shift = 20;
        private bool ShowName = true;
        private int TimerCounter = 0;
        private int TimerCounterMax = 8;
        private bool GameOver = false;
        public MainForm()
        {
            InitializeComponent();
            CreateAreas();
            ChangePanelPosition();
        }
        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            MousePositionLabel.Text = $"({e.X},{e.Y}) ({OKButton.Location.X},{OKButton.Location.Y})";
            X = e.X;
            Y = e.Y;
        }
        private void CreateAreas()
        {
            Color color = Color.Transparent;
            int size = 20;
            Panel[] panels = new Panel[8]
            {
                new Panel { Size = new Size(size,size), BackColor = color, Tag = 0},
                new Panel { Size = new Size(OKButton.Size.Width,size), BackColor = color, Tag = 1},
                new Panel { Size = new Size(size,size), BackColor = color, Tag = 2},
                new Panel { Size = new Size(size,OKButton.Size.Height), BackColor = color, Tag = 3},
                new Panel { Size = new Size(size,size), BackColor = color, Tag = 4},
                new Panel { Size = new Size(OKButton.Size.Width,size), BackColor = color, Tag = 5},
                new Panel { Size = new Size(size,size), BackColor = color, Tag = 6},
                new Panel { Size = new Size(size,OKButton.Size.Height), BackColor = color, Tag = 7}
            };

            foreach (Panel control in panels)
            {
                control.MouseMove += Panel_MouseMove;
            }

            Controls.AddRange(panels);
        }
        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            if(sender is Panel panel)
            {
                OKButton.Location = GetNewLocation((int)panel.Tag);

                if(OKButton.Location.X + OKButton.Size.Width > Size.Width)
                {
                    OKButton.Location = new Point(X-OKButton.Size.Width, Y);
                }
                else if (OKButton.Location.X < 0)
                {
                    OKButton.Location = new Point(X + OKButton.Size.Width, Y);
                }
                else if(OKButton.Location.Y < 0)
                {
                    OKButton.Location = new Point(X, Y + OKButton.Size.Height);
                }
                else if (OKButton.Location.Y + OKButton.Size.Height > Size.Height)
                {
                    OKButton.Location = new Point(X, Y - OKButton.Size.Height);
                }

                ChangePanelPosition();
                OKButton.Size = new Size(OKButton.Size.Width - 1, OKButton.Size.Height - 1);

                if(OKButton.Size.Height == 0 && !GameOver)
                {
                    Timer.Tick -= Timer_Tick;
                    Timer.Tick += Timer_Tick_Lose;
                    Timer.Interval = 800;
                    GameOver = true;
                    Timer.Start();
                }
            }
        }
        private Point GetNewLocation(int area)
        {
            switch (area)
            {
                case 0:
                    return new Point(OKButton.Location.X + Shift, OKButton.Location.Y + Shift);
                case 1:
                    return new Point(OKButton.Location.X, OKButton.Location.Y + Shift);
                case 2:
                    return new Point(OKButton.Location.X- Shift, OKButton.Location.Y + Shift);
                case 3:
                    return new Point(OKButton.Location.X - Shift, OKButton.Location.Y);
                case 4:
                    return new Point(OKButton.Location.X - Shift, OKButton.Location.Y- Shift);
                case 5:
                    return new Point(OKButton.Location.X, OKButton.Location.Y - Shift);
                case 6:
                    return new Point(OKButton.Location.X + Shift, OKButton.Location.Y - Shift);
                case 7:
                    return new Point(OKButton.Location.X + Shift, OKButton.Location.Y);
                default:
                    return new Point(0, 0);
            }
        }
        private void ChangePanelPosition()
        {
            Point[] points = new Point[8]
            { 
                new Point(OKButton.Location.X - Shift, OKButton.Location.Y - Shift),
                new Point(OKButton.Location.X, OKButton.Location.Y - Shift),
                new Point(OKButton.Location.X + OKButton.Size.Width, OKButton.Location.Y - Shift),
                new Point(OKButton.Location.X + OKButton.Size.Width, OKButton.Location.Y),
                new Point(OKButton.Location.X + OKButton.Size.Width, OKButton.Location.Y + OKButton.Size.Height),
                new Point(OKButton.Location.X, OKButton.Location.Y + OKButton.Size.Height),
                new Point(OKButton.Location.X - Shift, OKButton.Location.Y + OKButton.Size.Height),
                new Point(OKButton.Location.X - Shift, OKButton.Location.Y)
            };

            foreach (var control in Controls)
            {
                if (control is Panel panel)
                {
                    panel.Location = points[(int)panel.Tag];
                }
            }
        }
        private void OKButton_MouseMove(object sender, MouseEventArgs e)
        {
            if (sender is Button)
            {
                OKButton.Location = new Point(OKButton.Location.X + 30, OKButton.Location.Y + 30);
                ChangePanelPosition();
                OKButton.Size = new Size(OKButton.Size.Width - 1, OKButton.Size.Height - 1);
            }
        }
        private void ExitButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }
        private void MainForm_Load(object sender, System.EventArgs e)
        {
            Timer.Tick += Timer_Tick;
            Timer.Interval = 800;
            Timer.Start();
        }
        private void Timer_Tick(object sender, System.EventArgs e)
        {
            if(ShowName)
            {
                Text = "";
                ShowName = false;
            }
            else
            {
                Text = "Натисніть кнопку “Ок”!!!";
                ShowName = true;
            }

            if(TimerCounter == TimerCounterMax)
            {
                Text = "Натисніть кнопку “Ок”!!!";
                TimerCounter = 0;
                Timer.Stop();
            }
            TimerCounter++;
        }
        private void Timer_Tick_Lose(object sender, System.EventArgs e)
        {
            if (ShowName)
            {
                Text = "";
                ShowName = false;
            }
            else
            {
                Text = "Кнопка “Ок” не може бути натиснута";
                ShowName = true;
            }
        }
    }
}