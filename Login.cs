using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSound
{
    public partial class Login : Form
    {
        SqlCommands cmd = new SqlCommands("DB_Tagneed");
        public Login()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

           // new Timming().ShowDialog();

            var query = string.Format(@"select  r.role_name from users inner join roles r on role_id =r.id where username='{0}' and password='{1}'", txtusername.Text, txtpassword.Text);
            cmd.GetCMDConnection(query, _cmd =>
            {
                var results = _cmd.ExecuteScalar();
                if (results != null)
                {
                    Users.RoleName = results.ToString();
                    this.Hide();
                    new LoadingPage().ShowDialog();
                    this.Dispose();
                }
                else MessageBox.Show("اسم المستخدم او رقم المرور غير صحيح !!! ؟");
            });

        }
    }
}
