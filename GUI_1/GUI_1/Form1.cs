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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            Model md = new Model();
            {
                md.number = txt_number.Text;
                md.date = txt_date.Text;
                md.inventorynum = txt_inventorynum.Text;
                md.objectname = txt_objectname.Text;
                md.price = txt_price.Text;
                md.count = txt_count.Text;


            }
            md.save();

            grid_view.DataSource = null;
            grid_view.DataSource = Model.GetAll();
            MessageBox.Show("Item Added");
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
