using System;
using System.Collections.Generic;
using System.Text;

namespace Lab07
{
    class Orter
    {
        public string Name { get; set; }
        public double Temp { get; set; }

        public Orter(string name, double temp)
        {
            this.Name = name;
            this.Temp = temp;
        }
    }
}
