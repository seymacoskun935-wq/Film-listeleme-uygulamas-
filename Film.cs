using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Film
    {
        public string Ad { get; set; }
        public bool İzlendi { get; set; }
        public double Puan { get; set; }
        public Film (string ad)
        {
            Ad = ad;
            İzlendi = false;
           
            
            
        }


    }
}
