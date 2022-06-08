using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Dz_23_BookLibrary
{
    class Book
    {
        public string name { get; set; }
        public string avtor { get; set; }
        public string kategory { get; set; }
        public int price { get; set; }

        public Book() { }

        public Book(string n, string a, string k, int p)
        { 
            name = n;
            avtor = a;
            kategory = k;
            price = p; 
        } 
    }
}
