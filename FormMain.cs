using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace final
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void OpenForm(Form fop)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name != fop.Name)
                {
                    f.Close();
                }
                else 
                {
                    return;
                }
            }
            fop.MdiParent = this;
            fop.WindowState = FormWindowState.Maximized;
            fop.Show();
        }

        private void ลกคาToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (StatusUser == 1)
            {
                FormCustomer fct = new FormCustomer();
                OpenForm(fct);
            }
            else
            {
                MessageBox.Show("สถานะของท่านไม่สามารถใช้งานส่วนนี้ได้","คำเตือน");
            }
        }

        public static string Loginstat = "";
        public static int StatusUser = 0;

        private void FormMain_Load(object sender, EventArgs e)
        {
            FormLogin fl = new FormLogin();
            fl.ShowDialog();
            if (Loginstat == "")
            {
                Application.Exit();
            }
        }

        private void ออกจากโปรแกรมToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxButtons bt = MessageBoxButtons.YesNo;
            DialogResult Ds = MessageBox.Show("ยืนยันการLog Out","Log out",bt);
            if (Ds == DialogResult.Yes)
            {
                foreach (Form f in this.MdiChildren)
                {
                    f.Close();
                }
                Loginstat = "";
                StatusUser = 0;
                FormLogin fl = new FormLogin();
                fl.ShowDialog();
                if (Loginstat == "")
                {
                    Application.Exit();
                }
            }
        }
    }
}
