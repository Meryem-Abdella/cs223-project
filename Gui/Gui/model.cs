using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gui
{
    internal class model
    {
        private static List<model> models = new List<model>();
        public string name { get; set; }
        public string price { get; set; }
       
        public model findone (String Name)
        {
            return models.Find(p => p.name == Name);
        }
        
        public void save()
        {
            models.Add(this);
            //Console.WriteLine("SAVE");
        }
        public static List<model> GetAll()
        {
            return models;
        }
    }
}
