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
    public partial class main_page : Form
    {
        public main_page()
        {
            InitializeComponent();
        }

        private void registerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var activescreen = ActiveMdiChild;
            if (activescreen != null)
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
            Display scren = new Display();
            scren.MdiParent = this;
            scren.Show();
        }

        private void searchToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var activescreen = ActiveMdiChild;
            if (activescreen != null)
            {
                activescreen.Close();
            }
            Search scren = new Search();
            scren.MdiParent = this;
            scren.Show();
        }
    }
}
