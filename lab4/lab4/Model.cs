using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Model
    {
        public string num { get; set; }
        public string count { get; set; }
        public string inventory_num { get; set; }
        public string price { get; set; }
        public string object_name { get; set; }
        public string date { get; set; }
        public void save()
        {
            Console.WriteLine("Saved Succesfully");

        }


    }
}
