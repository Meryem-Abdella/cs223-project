﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gui
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            model md = new model();
            {
                md.name = txt_name.Text;
                md.price = txt_price.Text;
              

            }
            md.save();
            
            grid_register.DataSource = null;
            grid_register.DataSource = model.GetAll();
            MessageBox.Show("Item Added");





            
        }
    }
}
