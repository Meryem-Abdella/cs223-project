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
    public partial class Display : Form
    {
        public Display()
        {
            InitializeComponent();
        }

        private void Display_Load(object sender, EventArgs e)
        {

          
            grid2_view.DataSource = null;
            grid2_view.DataSource =Model.GetAll();
        }
    }
}
