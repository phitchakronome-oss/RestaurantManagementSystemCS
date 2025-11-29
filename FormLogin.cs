using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace final
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void CBShow_CheckedChanged(object sender, EventArgs e)
        {
            if (CBShow.Checked == true)
            {
                TBPW.PasswordChar = '\0';
            }
            else 
            {
                TBPW.PasswordChar = '*';
            }
        }

        private void BTLogin_Click(object sender, EventArgs e)
        {
            if (ck > 3)
            {
                Application.Exit();
            }
            string sql = string.Format("SELECT * FROM TBL_USER WHERE USER_ID ='{0}'AND Password_ID ='{1}'", TBUser.Text, TBPW.Text);
            SqlDataAdapter da = new SqlDataAdapter(sql, FormCustomer.NameData);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                string name = dt.Rows[0]["USER_ID"].ToString();
                MessageBox.Show("ยินดีต้อนรับ คุณ "+name,"เข้าสู้ระบบสำเร็จ");
                FormMain.StatusUser = Convert.ToInt32(dt.Rows[0]["Status_ID"]);
                FormMain.Loginstat = "1";
                this.Close();
            }
            else 
            {
                MessageBox.Show("Username หรือ Password ไม่ถูกต้อง ","เข้าสู้ระบบไม่สำเร็จ");
                TBUser.Text = "";
                TBPW.Text = "";
                ck = ck + 1;
            }
        }

        private int ck;

        private void FormLogin_Load(object sender, EventArgs e)
        {
            ck = 1;
        }
    }
}
