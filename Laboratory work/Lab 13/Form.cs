using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Lab_13
{
    public partial class MainForm : Form
    {
        private const int ButtonCounter = 16;
        private int NumberNow = 1;
        private List<int> numbers;
        HashSet<int> tempNumbers;
        Random random;
        Stopwatch stopWatch;

        public MainForm()
        {
            InitializeComponent();
            numbers = new List<int>(ButtonCounter);
            tempNumbers = new HashSet<int>(ButtonCounter);
            random = new Random();
            stopWatch = new Stopwatch();
            CreateButtons();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if(TextBox.Text != string.Empty)
            {
                ComboBox.Items.Add(TextBox.Text);
                TextBox.BackColor = Color.White;
                TextBox.ForeColor = Color.Black;
                TextBox.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Ведіть текст!");
                TextBox.BackColor = Color.Red;
                TextBox.ForeColor = Color.White;
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (TextBox.Text != string.Empty)
            {
                if(ComboBox.Items.Contains(TextBox.Text))
                {
                    ComboBox.Items.Remove(TextBox.Text);
                    TextBox.BackColor = Color.White;
                    TextBox.ForeColor = Color.Black;
                    TextBox.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Такого тексту немає.");
                    TextBox.BackColor = Color.Red;
                    TextBox.ForeColor = Color.White;
                }
            }
            else
            {
                MessageBox.Show("Ведіть текст!");
                TextBox.BackColor = Color.Red;
                TextBox.ForeColor = Color.White;
            }
        }

        private void CreateButtons()
        {
            numbers.AddRange(Enumerable.Range(1, ButtonCounter));

            int size = 40;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < ButtonCounter / 4; j++)
                {
                    Button button = new Button
                    {
                        Location = new Point((size + 10) * i, (size + 10) * j),
                        Size = new Size(size, size)
                    };
                    button.Click += new EventHandler(ButtonClick);
                    int number = RandomNumber(0, ButtonCounter);
                    tempNumbers.Add(number);

                    button.Text = number.ToString();
                    PanelNumbers.Controls.Add(button);
                }
            }

            tempNumbers.Clear();
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            Button button = sender as Button; 
            if(NumberNow == int.Parse(button?.Text))
            {
                if(NumberNow == 1)
                {
                    stopWatch.Start();
                }
                if (NumberNow == 16)
                {
                    TimeSpan ts = stopWatch.Elapsed;
                    string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
                    StatusBox.Text = $"Молодець! За {elapsedTime}";
                    stopWatch.Reset();
                    ResetButton();
                    return;
                }
                button.Visible = false;
                NumberNow++;
                ChangeNumber();
            }
            else
            {
                ResetButton();
            }
        }

        private void ResetButton()
        {
            NumberNow = 1;
            PanelNumbers.Controls.Clear();
            CreateButtons();
        }

        private void ChangeNumber()
        {
            foreach (var item in PanelNumbers?.Controls)
            {
                Button button = item as Button;
                if (button != null && button.Visible)
                {
                    int number = RandomNumber(NumberNow-1, ButtonCounter);
                    tempNumbers.Add(number);
                    button.Text = number.ToString();
                }
            }
            tempNumbers.Clear();
        }

        private int RandomNumber(int min,int max)
        {
            int number;
            do
            {
                int index = random.Next(min, max);
                number = numbers[index];
            } while (tempNumbers.Contains(number));
            return number;
        }
    }
}
