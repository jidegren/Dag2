using System;
using System.Collections.Generic;
using System.Text;

namespace lab08
{
    public class Ort
    {
        public string Name { get; set; }
        public int Temp { get; set; }

        public Ort(string name, int temp)
        {
            this.Name = name;
            this.Temp = temp;
        }
        public Ort(string name)
        {
            this.Name = name;
        }
        public Ort()
        {

        }
    }
}
