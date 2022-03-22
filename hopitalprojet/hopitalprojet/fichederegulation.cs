using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hopitalprojet
{
    public partial class fichederegulation : Form
    {
        public fichederegulation()
        {
            InitializeComponent();
        }

        private void label208_Click(object sender, EventArgs e)
        {
            label208.Text = DateTime.Now.ToLongDateString();
            
        }

        private void label172_Click(object sender, EventArgs e)
        {
            label172.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
