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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        dbcontrol sql = new dbcontrol();
        void register()
        {
            sql.param("@user", usernamebox);
            sql.param("@password", Passwordbox);
            sql.param("@nom", nombox);
            sql.param("@prenom", prenombox);
            sql.param("@adresse", adressebox);
            sql.param("@telephone", telephonebox);
            sql.param("@metier", metierbox);
            sql.param("@email", emailbox);
            sql.query("insert into tbluser (username ,password ,nom , prenom , adresse ,telephone ,metier ,email) values (@username ,@password ,@nom , @prenom , @adresse ,@telephone ,@metier ,@email)");
            if (sql.checkerror(true)){
                return;
            }
            MessageBox.Show("register done !", "success", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }


        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is Form1 )
                {
                    frm.Show();
                }
            }
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Registerbtn_Click(object sender, EventArgs e)
        {
            register();
        }
    }
}
