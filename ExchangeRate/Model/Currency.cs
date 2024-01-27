using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ExchangeRate.Models
{
    public class ValCurs
    {
        public string date { get; set; }
        public string previousDate { get; set; }
        public string previousURL { get; set; }
        public string timestamp { get; set; }
        public List<Valute> valutes { get; set; }
    }

    public class Valute
    {
        public int numCode { get; set; }
        public string charCode { get; set; }
        public int nominal { get; set; }
        public string name { get; set; }
        public double value { get; set; }
        public double vunitRate { get; set; }
    }
}
