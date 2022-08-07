using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_1
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            Model mod = new Model();
            var products = mod.findone(textBox1.Text);
            if (products == null)
            {

                MessageBox.Show("Enter Something");
            }
            else
            {
                label12.Text = products.objectname;
                label7.Text = products.price;
                label8.Text = products.count;
                label9.Text = products.number;
                label10.Text = products.inventorynum;
                label11.Text = products.date;
            }
        }
    }
}
