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
    public partial class FormCustomer : Form
    {
        public FormCustomer()
        {
            InitializeComponent();
        }

        DataSet ds = new DataSet();
        public static string NameData =
    @"Data Source=DESKTOP-K1PU41N\SQLEXPRESS;Initial Catalog=Ex1_030;Integrated Security=True;";

        //public static string NameData = @"Server=.;Database=Ex1_030;Trusted_Connection=True;";
        //Data source = ชื่อฐานข้อมูล; Initail Catalog = ชื่อตาราชฐานข้อมูล;UID = ชื่อ username;Password = รหัส;
        private void Form1_Load(object sender, EventArgs e)
        {
            string sql = "SELECT* FROM VIEW_Customer";
            SqlDataAdapter da = new SqlDataAdapter(sql, NameData);
            da.Fill(ds,"ViewCT");
            DTGV_CT.DataSource = ds.Tables["ViewCT"];

            string sqlCT = "SELECT* FROM TBL_Customer";
            da = new SqlDataAdapter(sqlCT, NameData);
            da.Fill(ds, "CT");

            //เซต combobox SEX และ Member
            //Sex
            string sqlsex = "SELECT* FROM TBL_Sex";
            da = new SqlDataAdapter(sqlsex, NameData);
            da.Fill(ds, "Sex");
            CBSex.DisplayMember = "Type_Sex";
            CBSex.ValueMember = "ID_Sex";
            CBSex.DataSource = ds.Tables["Sex"];
            
            
            //Member
            string sqlMember = "SELECT* FROM TBL_Member";
            da = new SqlDataAdapter(sqlMember, NameData);
            da.Fill(ds, "Member");
            CBMember.DisplayMember = "Type_Member";
            CBMember.ValueMember = "ID_Member";
            CBMember.DataSource = ds.Tables["Member"];

            //ตั้งค่าวันเกิด
            DTP_BP.Value = DateTime.Today.AddYears(-15);
            DTP_BP.MinDate = DateTime.Today.AddYears(-99);
            DTP_BP.MaxDate = DateTime.Today.AddYears(-10);
        }

        private void CL()
        {
            LBID.Text = "";
            TBName.Text = "";
            TBSname.Text = "";
            TBTel.Text = "";
            TBEmail.Text = "";
            TBAdd.Text = "";
            CBSex.Text = "";
            CBMember.Text = "";
            DTP_BP.Value = DateTime.Today.AddYears(-16);
        }

        private void BTGen_Click(object sender, EventArgs e)
        {
            CL();
            string sql = "SELECT TOP 1 * FROM TBL_Customer Order BY ID_Customer DESC";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, NameData);
            da.Fill(dt);
            int TOPid = Convert.ToInt32(dt.Rows[0]["ID_Customer"]) + 1;
            LBID.Text = TOPid.ToString();
        }

        private void UpdateData()
        {
            string sqlCT = "SELECT* FROM TBL_Customer";
            SqlDataAdapter da = new SqlDataAdapter(sqlCT, NameData);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Update(ds, "CT");
            //ล้างค่าตาราง
            ds.Tables.Remove("VIewCT");
            //อัพเดทตาราง
            string sql = "SELECT* FROM VIEW_Customer";
            da = new SqlDataAdapter(sql, NameData);
            da.Fill(ds, "ViewCT");
            DTGV_CT.DataSource = ds.Tables["ViewCT"];

        }

        private void BTAdd_Click(object sender, EventArgs e)
        {
            string sqlCT = "SELECT* FROM TBL_Customer";
            SqlDataAdapter da = new SqlDataAdapter(sqlCT, NameData);
            da.Fill(ds, "CT");
            //สร้างตัวแปรมาเช็คว่าIDซ์้ำมั้ย
            DataRow[] drs = ds.Tables["CT"].Select("ID_Customer ='" + LBID.Text + "'");
            if (drs.Length == 0)
            {
                DataRow dr = ds.Tables["CT"].NewRow();
                dr["ID_Customer"] = LBID.Text;
                dr["Name_Customer"] = TBName.Text;
                dr["Sname_Customer"] = TBSname.Text;
                dr["BD_Customer"] = DTP_BP.Text;
                dr["Add_Customer"] = TBAdd.Text;
                dr["Tel_Customer"] = TBTel.Text;
                dr["Email_Customer"] = TBEmail.Text;
                dr["Sex_Customer"] = CBSex.SelectedValue;
                dr["Member_Customer"] = CBMember.SelectedValue;
                ds.Tables["CT"].Rows.Add(dr);//ใส่ช้อความลงตาราง
            }
            else
            {
                MessageBox.Show("เลข id ซ้ำ", "ERROR");
            }
            UpdateData();
            CL();
        }

        private void DTGV_CT_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BTGen.Enabled = false;
            CBSex.Enabled = false;
            if (e.RowIndex == -1)//เช็คว่าได้เลือกมั้ย 
            {
                return;
            }

            else
            {
                DTGV_CT.Rows[e.RowIndex].Selected = true;//เลือกทั้งแถว
                DataRow dr = ds.Tables["ViewCT"].Rows[e.RowIndex];
                LBID.Text = dr["ID_Customer"].ToString();
                TBName.Text = dr["Name_Customer"].ToString();
                TBSname.Text = dr["Sname_Customer"].ToString();
                TBAdd.Text = dr["Add_Customer"].ToString();
                TBTel.Text = dr["Tel_Customer"].ToString();
                TBEmail.Text = dr["Email_Customer"].ToString();
                CBSex.Text = dr["Type_Sex"].ToString();
                CBMember.Text = dr["Type_Member"].ToString();
            }
        }

        private void BTDel_Click(object sender, EventArgs e)
        {
            ds.Tables.Remove("CT");
            string sqlCT = "SELECT* FROM TBL_Customer";
            SqlDataAdapter da = new SqlDataAdapter(sqlCT, NameData);
            da.Fill(ds, "CT");
            DataRow[] drs = ds.Tables["CT"].Select("ID_Customer ='" + LBID.Text + "'");//ไปหาบรรทัดที่ซ้ำละเก็บ
            if (drs.Length == 0)
            {
                MessageBox.Show("ไม่มีข้อมูลที่ต้องการลบ", "ERROR");
            }
            else 
            {
                MessageBoxButtons MBB = MessageBoxButtons.YesNo;
                DialogResult Dls = MessageBox.Show("กรุณษยืนยันการลบ Yes / NO", "ยืนยันการลบ", MBB);
                if (Dls == DialogResult.Yes)
                { 
                   drs[0].Delete();
                   UpdateData();
                    ds.Tables["CT"].AcceptChanges();
                    CL();
                    MessageBox.Show("ลบข้อมูลสำเร็จ", "ข้อความแจ้ง");
                }
                BTGen.Enabled = true;
                CBSex.Enabled = true;
            }
        }

        private void DTGV_CT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BTEdit_Click(object sender, EventArgs e)
        {
            string sqlCT = "SELECT* FROM TBL_Customer";
            SqlDataAdapter da = new SqlDataAdapter(sqlCT, NameData);
            da.Fill(ds, "CT");
            DataRow[] drs = ds.Tables["CT"].Select("ID_Customer ='" + LBID.Text + "'");//ไปหาบรรทัดที่ซ้ำละเก็บ
            if (drs.Length == 0)
            {
                MessageBox.Show("ไม่มีข้อมูลที่ต้องการแก้ไข", "ERROR");
            }
            else
            {
                MessageBoxButtons MBB = MessageBoxButtons.YesNo;
                DialogResult Dls = MessageBox.Show("กรุณษยืนยันการแก้ไข Yes / NO", "ยืนยันการแก้ไข", MBB);
                if (Dls == DialogResult.Yes)
                {
                    drs[0]["ID_Customer"] = LBID.Text;
                    drs[0]["Name_Customer"] = TBName.Text;
                    drs[0]["Sname_Customer"] = TBSname.Text;
                    //dr["BD_Customer"] = DTP_BP.Text;
                    drs[0]["Add_Customer"] = TBAdd.Text;
                    drs[0]["Tel_Customer"] = TBTel.Text;
                    drs[0]["Email_Customer"] = TBEmail.Text;
                    //dr["Sex_Customer"] = CBSex.SelectedValue;
                    drs[0]["Member_Customer"] = CBMember.SelectedValue;
                    UpdateData();
                    CL();
                    MessageBox.Show("ลบข้อมูลสำเร็จ", "ข้อความแจ้ง");
                    BTGen.Enabled = true;
                    CBSex.Enabled = true;
                }
            }
        }

        private void BTCL_Click(object sender, EventArgs e)
        {
            CL();
            BTGen.Enabled = true;
            CBSex.Enabled = true;
        }

        private void BTSR_Click(object sender, EventArgs e)
        {
            if (ds.Tables.Contains("SR"))
            {
                ds.Tables.Remove("SR");
            }
            string sql = "SELECT* FROM View_Customer WHERE ID_Customer LIKE '%" + TBSR.Text +
                "%' OR Name_Customer LIKE '%" + TBSR.Text + "%' OR Tel_Customer LIKE '%"+TBSR.Text +"%'";
            SqlDataAdapter da = new SqlDataAdapter(sql, NameData);
            da.Fill(ds, "SR");
            DTGV_CT.DataSource = ds.Tables["SR"];
        }
    }
}
