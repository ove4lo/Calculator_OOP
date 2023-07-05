using System;
using System.Data;
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
using System.Windows.Shapes;
using System.Media;

namespace Calculator_Simple.Views
{
    /// <summary>
    /// Логика взаимодействия для Calculator_App.xaml
    /// </summary>
    public partial class Calculator_App : Window
    {
        List<string> memory = new List<string>();
        public Calculator_App()
        {
            InitializeComponent();
        }

        private void C_btn(object sender, RoutedEventArgs e)
        {
            label.Text = "";
        }
        private void CE_btn(object sender, RoutedEventArgs e)
        {
            if (label.Text.Length != 0)
                label.Text = label.Text.Remove(label.Text.Length - 1, 1);
        }
        private void MC_btn(object sender, RoutedEventArgs e)
        {
            if (memory.Count != 0)
            {
                memory.RemoveAt(memory.Count - 1);
            }
        }
        private void MR_btn(object sender, RoutedEventArgs e)
        {
            if (memory.Count != 0)
            {
                label.Text = memory[memory.Count - 1];
            }
        }
        private void MS_btn(object sender, RoutedEventArgs e)
        {
            memory.Add(label.Text);
        }
        private void MPlus_btn(object sender, RoutedEventArgs e)
        {
            if (memory.Count == 0)
            {
                memory.Add("0");
            }
            else
            {
                double a = Convert.ToDouble(memory[memory.Count - 1]);
                double b = Convert.ToDouble(label.Text);

                memory[memory.Count - 1] = (a + b).ToString();
            }
        }
        private void MMinus_btn(object sender, RoutedEventArgs e)
        {
            if (memory.Count == 0)
            {
                memory.Add("0");
            }
            else
            {
                double a = Convert.ToDouble(memory[memory.Count - 1]);
                double b = Convert.ToDouble(label.Text);

                memory[memory.Count - 1] = (a - b).ToString();
            }
        }
        private void MStepMinus_btn(object sender, RoutedEventArgs e)
        {
            if (memory.Count == 0)
            {
                memory.Add("0");
            }
            else
            {
                double a = Convert.ToDouble(memory[memory.Count - 1]);
                double b = Convert.ToDouble(label.Text);

                memory[memory.Count - 1] = Math.Pow(a, b).ToString();
            }
        }
        private void Reverse_btn(object sender, RoutedEventArgs e)
        {
            string y = label.Text.Replace(".", ",");

            if (double.TryParse(y, out double num))
            {
                double x = (1 / Convert.ToDouble(y));
                y = x.ToString();

                y = y.Replace(",", ".");
                label.Text = y;
            }
        }
        private void Step2_btn(object sender, RoutedEventArgs e)
        {
            string y = label.Text.Replace(".", ",");

            if (double.TryParse(y, out double num))
            {
                double x = Math.Pow(Convert.ToDouble(y), 2);
                y = x.ToString();

                y = y.Replace(",", ".");
                label.Text = y;
            }
        }
        private void Sqrt_btn(object sender, RoutedEventArgs e)
        {
            string y = label.Text.Replace(".", ",");

            if (double.TryParse(y, out double num))
            {
                double x = Math.Pow(Convert.ToDouble(y), 0.5);
                y = x.ToString();

                y = y.Replace(",", ".");
                label.Text = y;
            }
        }
        private void PlusMinus_btn(object sender, RoutedEventArgs e)
        {
            string y = label.Text.Replace(".", ",");

            if (double.TryParse(y, out double num))
            {
                double x = Convert.ToDouble(y);
                x = -x;

                y = x.ToString();

                y = y.Replace(",", ".");
                label.Text = y;
            }
        }
        private void Delete_btn(object sender, RoutedEventArgs e)
        {
            if (label.Text.Length != 0)
                label.Text = label.Text.Remove(label.Text.Length - 1, 1);
        }
        private void Equals_btn(object sender, RoutedEventArgs e)
        {
            string value = new DataTable().Compute(label.Text, null).ToString();

            value = value.Replace(",", ".");

            label.Text = value;
        }
        private void Num0_btn(object sender, RoutedEventArgs e)
        {
            label.Text += "0";
        }
        private void Num1_btn(object sender, RoutedEventArgs e)
        {
            label.Text += "1";
        }
        private void Num2_btn(object sender, RoutedEventArgs e)
        {
            label.Text += "2";
        }
        private void Num3_btn(object sender, RoutedEventArgs e)
        {
            label.Text += "3";
        }
        private void Num4_btn(object sender, RoutedEventArgs e)
        {
            label.Text += "4";
        }
        private void Num5_btn(object sender, RoutedEventArgs e)
        {
            label.Text += "5";
        }
        private void Num6_btn(object sender, RoutedEventArgs e)
        {
            label.Text += "6";
        }
        private void Num7_btn(object sender, RoutedEventArgs e)
        {
            label.Text += "7";
        }
        private void Num8_btn(object sender, RoutedEventArgs e)
        {
            label.Text += "8";
        }
        private void Num9_btn(object sender, RoutedEventArgs e)
        {
            label.Text += "9";
        }
        private void Plus_btn(object sender, RoutedEventArgs e)
        {
            label.Text += "+";
        }
        private void Minus_btn(object sender, RoutedEventArgs e)
        {
            label.Text += "-";
        }
        private void Multi_btn(object sender, RoutedEventArgs e)
        {
            label.Text += "*";
        }
        private void Divison_btn(object sender, RoutedEventArgs e)
        {
            label.Text += "/";
        }
        private void Procent_btn(object sender, RoutedEventArgs e)
        {
            label.Text += "%";
        }
        private void Dot_btn(object sender, RoutedEventArgs e)
        {
            label.Text += ".";
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string str = (string)((Button)e.OriginalSource).Content;

            if (str == "C")
            {
                label.Text = "";
            }
            else
            {
                label.Text += str;
            }

        }


    }
}
