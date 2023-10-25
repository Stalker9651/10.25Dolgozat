using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Bolygo
    {
        public string Nev {  get; set; }
        public int Holdjai { get; set; }
        public double Terfogataranya { get; set; }

        public Bolygo(string str)
        {
            var x = str.Split(';');
            Nev = x[0];
            Holdjai = int.Parse(x[1]);
            Terfogataranya = double.Parse(x[2].Replace(".",","));


        }
    }
}
