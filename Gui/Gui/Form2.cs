using System;
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
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var activescreen = ActiveMdiChild;
            if(activescreen != null)
            {
                activescreen.Close();
            }
            Form1 screen = new Form1();
            screen.MdiParent = this;
            screen.Show();

            
        }

        private void displayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var activescreen = ActiveMdiChild;
            if (activescreen != null)
            {
                activescreen.Close();
            }
            Form3 scren = new Form3();
            scren.MdiParent = this;
            scren.Show();
           
            
           
          
        }
    }
}
