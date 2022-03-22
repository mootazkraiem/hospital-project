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
    public partial class Acceuil : Form
    {
        public Acceuil()
        {
            InitializeComponent();
        }
       
        private void Acceuil_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach(Form frm in Application.OpenForms)
            {
                if( frm is Form1)
                {   
                    frm.Show(); 
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fichederegulation f1 = new fichederegulation();
            f1.Show();
        }
    }
}
