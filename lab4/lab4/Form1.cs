using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Model model = new Model();
            model.num = txt_number.Text;
            model.date = txt_date.Text;
            model.inventory_num=txt_inventorynumber.Text;
            model.price = txt_price.Text;
            model.object_name = txt_objectname.Text;  
            model.count = txt_count.Text;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
        this.Close();
        }
    }
}
