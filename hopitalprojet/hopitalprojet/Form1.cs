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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        dbcontrol sql = new dbcontrol();
        private void btnregister_Click(object sender, EventArgs e)
        {
            Register rg = new Register();
            Hide();
            rg.ShowDialog();
        }
            bool login()
            {
                sql.param("@username", txtusername.Text);
                sql.param("@password", txtpassword.Text);
                sql.query("select count(*) from tbluser where username=@username and password = @password");
                if ((int)sql.dt.Rows[0][0] == 1)
                {
                    return true;

                }
                MessageBox.Show("check your username or password ","invalid",MessageBoxButtons.OK,MessageBoxIcon.Exclamation); 

                return false;
            }
        

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (login() == true)
            {
                     Acceuil acc = new Acceuil();
            Hide();
            acc.ShowDialog();
            }
       
        }
    }
}
