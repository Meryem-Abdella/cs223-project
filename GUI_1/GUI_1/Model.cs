using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_1
{
    internal class Model
    {

        private static List<Model> products = new List<Model>();
        public string number { get; set; }
        public string date { get; set; }
        public string inventorynum { get; set; }
        public string objectname { get; set; }
        public string count { get; set; }
        public string price { get; set; }

        public Model findone(String Name)
        {
            return products.Find(p => p.objectname == Name);
        }
        public void save()
        {
            products.Add(this);
            //Console.WriteLine("SAVE");
        }
        public static List<Model> GetAll()
        {
            return products;
        }


    }
}
