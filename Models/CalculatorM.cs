using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Simple.Models
{
    public class CalculatorM
    {
        private string result;
        public string First_Num { get; set; }
        public string Second_Num { get; set; }
        public string Operation { get; set; }
        public string Result { get { return result; } }

        public void Plus(string First_Num, string Second_Num)
        {
            double f = Convert.ToDouble(First_Num);
            double s = Convert.ToDouble(Second_Num);
        }
    }
}
