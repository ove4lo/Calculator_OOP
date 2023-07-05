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

            foreach(UIElement el in MainRoot.Children)
            {
                if(el is Button)
                {
                    ((Button) el).Click += Button_Click;
                }
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string str = (string)((Button)e.OriginalSource).Content;

            if (str == "C")
            {
                label.Text = "";
            }
            else if (str == "CE")
            {
                if (label.Text.Length != 0)
                    label.Text = label.Text.Remove(label.Text.Length - 1, 1);

            }
            else if (str == "MC")
            {
                if (memory.Count != 0)
                {
                    memory.RemoveAt(memory.Count - 1);
                }
            }
            else if (str == "MR")
            {
                if (memory.Count != 0)
                {
                    label.Text = memory[memory.Count - 1];
                }
            }
            else if (str == "MS")
            {
                memory.Add(label.Text);

            }
            else if (str == "M+")
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
            else if (str == "M-")
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
            else if (str == "M^-")
            {
                if (memory.Count == 0)
                {
                    memory.Add("0");
                }
                else
                {
                    double a = Convert.ToDouble(memory[memory.Count - 1]);
                    double b = Convert.ToDouble(label.Text);

                    memory[memory.Count - 1] = Math.Pow(a,b).ToString();
                }

            }
            else if (str == "1/x")
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
            else if (str == "x^2")
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
            else if (str == "sqrtx")
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
            else if (str == "+/-")
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
            else if (str == "delete")
            {
                if (label.Text.Length != 0)
                    label.Text = label.Text.Remove(label.Text.Length - 1, 1);
            }
            else if(str == "=")
            {
                string value = new DataTable().Compute(label.Text, null).ToString();

                value = value.Replace(",", ".");

                label.Text = value;
            }
            else
            {
                label.Text += str;
            }

        }


    }
}
