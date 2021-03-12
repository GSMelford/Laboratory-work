using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_12_Calculator
{
    public partial class CalculatorForm : Form
    {
        private Point LastPoint;
        private readonly int ButtonCounter = 16;
        private string[] symbols = new string[] { "7", "8", "9", "/", "4", "5", "6", "*", "1", "2", "3", "-", "0", ".", "=", "+" };
        private bool OperationActive = false;
        private bool FirstClick = false;
        public CalculatorForm()
        {
            InitializeComponent();
            CreateKeyboardCalc();
        }

        private void CreateKeyboardCalc()
        {
            CalculatorField.Text = "0";
            int size = 35;
            int counter = 0;
            for (int i = 0; i < ButtonCounter / 4; i++)
            {
                for (int j = 0; j < ButtonCounter / 4; j++)
                {
                    Button button = new Button();
                    button.Location = new Point((size + 10 )* j, (size + 10) * i);
                    button.Size = new Size(size,size);
                    button.FlatStyle = FlatStyle.Flat;
                    button.ForeColor = Color.White;
                    button.BackColor = Color.FromArgb(64, 64, 64);
                    button.Text = symbols[counter++];
                    button.Click += new EventHandler(Button_Click);
                    KeyboardCalc.Controls.Add(button);
                }
            }
        }
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            CalculatorField.Clear();
            ArithmeticOperations.Reset();
            CalculatorField.Text = "0";
            FirstClick = false;
        }
        private void ButtonPM_Click(object sender, EventArgs e)
        {
            int number = int.Parse(CalculatorField.Text);
            if(number != 0)
            {
                if (number > 0)
                    CalculatorField.Text = "-" + CalculatorField.Text;
                else
                    CalculatorField.Text = (number * (-1)).ToString();
            }
        }
        private void Button_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            double number = 0;

            if (!FirstClick)
            {
                CalculatorField.Clear();
                FirstClick = true;
            }
                
            if (OperationActive)
            {
                CalculatorField.Clear();
                OperationActive = false;
            }

            if (double.TryParse(button.Text, out number))
            {
                CalculatorField.Text += button.Text;
                return;
            }

            switch (button.Text)
            {
                case "+":
                    OperationActive = true;
                    SetResult(ArithmeticOperations.GetResult(button.Text, double.Parse(CalculatorField.Text)));
                    break;
                case "-":
                    OperationActive = true;
                    SetResult(ArithmeticOperations.GetResult(button.Text, double.Parse(CalculatorField.Text)));
                    break;
                case "*":
                    OperationActive = true;
                    SetResult(ArithmeticOperations.GetResult(button.Text, double.Parse(CalculatorField.Text)));
                    break;
                case "/":
                    OperationActive = true;
                    SetResult(ArithmeticOperations.GetResult(button.Text, double.Parse(CalculatorField.Text)));
                    break;
                case "=":
                    OperationActive = true;
                    SetResult(ArithmeticOperations.GetResult(button.Text, double.Parse(CalculatorField.Text)));
                    break;
                case ".":
                    if(string.IsNullOrEmpty(CalculatorField.Text))
                    {
                        CalculatorField.Text += "0.";
                        return;
                    }
                    for (int i = 0; i < CalculatorField.Text.Length; i++)
                        if (CalculatorField.Text[i] == '.')
                            return;

                    CalculatorField.Text += ".";
                    break;
               default:
                    MessageBox.Show("Что-то пошло не так...");
                    break;
            }
        }
        private void SetResult(string result)
        {
            if (!string.IsNullOrEmpty(result))
                CalculatorField.Text = result;
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }
        private void UpPanel_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

    }
}
