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
    public partial class FormOrder : Form
    {
        public FormOrder()
        {
            InitializeComponent();
        }
        DataSet Ds = new DataSet();
        private void FormOrder_Load(object sender, EventArgs e)
        {
            string sqlOR = "SELECT * FROM TBL_TypeOrder";
            SqlDataAdapter da = new SqlDataAdapter(sqlOR, FormCustomer.NameData);
            da.Fill(Ds, "Type_Order");
            CBTypeOrder.DisplayMember = "Type_Order";
            CBTypeOrder.DataSource = Ds.Tables["Type_Order"];

            string sqlFd = "SELECT * FROM TBL_TypeFood";
            da = new SqlDataAdapter(sqlFd, FormCustomer.NameData);
            da.Fill(Ds,"TypeFood");
            CBTypeFood.DisplayMember = "Name_Type";
            CBTypeFood.DataSource = Ds.Tables["TypeFood"];

            string sqlTop = "Select Top 1 * FROM TBL_Order ORDER BY ID_Order DESC";
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(sqlTop, FormCustomer.NameData);
            da.Fill(dt);
            int Topid = Convert.ToInt32(dt.Rows[0]["ID_Order"])+1;
            LB_IDOrder.Text = Topid.ToString();
        }

        private void CBTypeOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = CBTypeOrder.SelectedIndex + 1;
            if (id == 2)
            {
                NUD_TB.Value = 0;
                NUD_TB.Enabled = false;
            }
            else 
            {
                NUD_TB.Enabled = true;
            }
        }

        int[] IDMENU = new int[6];

        private void CBTypeFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Ds.Tables.Contains("MENU")) 
            {
                Ds.Tables.Remove("MENU");
            }
            int id = CBTypeFood.SelectedIndex +1;
            string sql = "SELECT * FROM TBL_Food WHERE Type_Food LIKE '%" + id.ToString() + "%'";
            SqlDataAdapter da = new SqlDataAdapter(sql, FormCustomer.NameData);
            da.Fill(Ds, "MENU");
            DataRow [] drs = Ds.Tables["MENU"].Select("Type_Food='"+id.ToString() +"'");
            int i;
            string[] NameMenu = new string[6];
            for (i = 0; i < drs.Length; i++) 
            {
                IDMENU[i] = 0;
                NameMenu[i] = "";
            }
            for (i = 0; i < drs.Length; i++) 
            {
                NameMenu[i] = drs[i]["Name_Food"].ToString();
                IDMENU[i] = Convert.ToInt32(drs[i]["ID_Food"].ToString());
            }
            BT_Menu1.Text = NameMenu[0];
            BT_Menu2.Text = NameMenu[1];
            BT_Menu3.Text = NameMenu[2];
            BT_Menu4.Text = NameMenu[3];
            BT_Menu5.Text = NameMenu[4];
            BT_Menu6.Text = NameMenu[5];
        }

        private void SaveOrderToDatabase(ListViewItem item)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(FormCustomer.NameData))
                {
                    conn.Open();

                    // ดึงค่าจาก ListViewItem
                    int idOrder = int.Parse(item.SubItems[0].Text);
                    string typeFood = item.SubItems[1].Text;
                    string foodName = item.SubItems[2].Text;
                    int quantity = int.Parse(item.SubItems[3].Text);
                    int price = int.Parse(item.SubItems[4].Text);
                    int tableNumber = int.Parse(item.SubItems[5].Text);
                    string typeOrder = item.SubItems[6].Text;

                    // ดึงรหัสประเภทอาหาร และรหัสประเภทการสั่ง
                    int idFood = GetFoodID(foodName);
                    int idTypeOrder = GetTypeOrderID(typeOrder);

                    string sql = @"
                    INSERT INTO TBL_Order (ID_Order, Type_Order, ID_FOrder, Num_Order, TB_Order)
                    VALUES (@ID_Order, @Type_Order, @ID_FOrder, @Num_Order, @TB_Order)";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@ID_Order", idOrder);
                    cmd.Parameters.AddWithValue("@Type_Order", idTypeOrder);
                    cmd.Parameters.AddWithValue("@ID_FOrder", idFood);
                    cmd.Parameters.AddWithValue("@Num_Order", quantity);
                    cmd.Parameters.AddWithValue("@TB_Order", tableNumber);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาดในการบันทึก: " + ex.Message);
            }
        }

        private void SeleMenu(int idFD) 
        {
            if (Ds.Tables.Contains("SELEMENU"))
            {
                Ds.Tables.Remove("SELEMENU");
            }
            if (idFD == 0)
            {
                LB_NameFood.Text = "";
                LB_priceFood.Text = "0";
            }
            else
            {
                string sql = "SELECT * FROM TBL_Food WHERE ID_Food LIKE '%" + idFD.ToString() + "%'";
                SqlDataAdapter da = new SqlDataAdapter(sql, FormCustomer.NameData);
                da.Fill(Ds, "SELEMENU");
                DataRow[] drs = Ds.Tables["SELEMENU"].Select("ID_Food='" + idFD.ToString() + "'");
                LB_NameFood.Text = drs[0]["Name_Food"].ToString();
                LB_priceFood.Text = drs[0]["Price_Food"].ToString();
            }
        }

        private void BT_Menu1_Click(object sender, EventArgs e)
        {
            SeleMenu(IDMENU[0]);
        }

        private void BT_Menu2_Click(object sender, EventArgs e)
        {
            SeleMenu(IDMENU[1]);
        }

        private void BT_Menu3_Click(object sender, EventArgs e)
        {
            SeleMenu(IDMENU[2]);
        }

        private void BT_Menu4_Click(object sender, EventArgs e)
        {
            SeleMenu(IDMENU[3]);
        }

        private void BT_Menu5_Click(object sender, EventArgs e)
        {
            SeleMenu(IDMENU[4]);
        }

        private void BT_Menu6_Click(object sender, EventArgs e)
        {
            SeleMenu(IDMENU[5]);
        }

        private void BTAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(LB_NameFood.Text) || string.IsNullOrEmpty(LB_priceFood.Text))
            {
                MessageBox.Show("กรุณาเลือกเมนูอาหาร");
                return;
            }

            int qty;
            if (!int.TryParse(NUD_NumOR.Text, out qty) || qty <= 0)
            {
                MessageBox.Show("กรุณาระบุจำนวนให้ถูกต้อง");
                return;
            }

            int price = int.Parse(LB_priceFood.Text);
            string foodName = LB_NameFood.Text;

            // เพิ่มลงใน ListView
            ListViewItem item = new ListViewItem(LB_IDOrder.Text);
            item.SubItems.Add(CBTypeFood.Text);
            item.SubItems.Add(foodName);
            item.SubItems.Add(qty.ToString());
            item.SubItems.Add(price.ToString());
            item.SubItems.Add(NUD_TB.Value.ToString());
            item.SubItems.Add(CBTypeOrder.Text);

            // เพิ่มเข้า ListView
            LVOrder.Items.Add(item);

            // เคลียร์ค่าหลังเพิ่ม ไม่ต้องแก้
            LB_NameFood.Text = "";
            LB_priceFood.Text = "";
            NUD_NumOR.Value = 0;
        }

        private int GetTypeOrderID(string typeName)
        {
            using (SqlConnection conn = new SqlConnection(FormCustomer.NameData))
            {
                conn.Open();
                string sql = "SELECT id_Type FROM TBL_TypeOrder WHERE Type_Order = @name";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", typeName);
                return (int)cmd.ExecuteScalar();
            }
        }

        private int GetFoodID(string foodName)
        {
            using (SqlConnection conn = new SqlConnection(FormCustomer.NameData))
            {
                conn.Open();
                string sql = "SELECT ID_Food FROM TBL_Food WHERE Name_Food = @name";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", foodName);
                return (int)cmd.ExecuteScalar();
            }
        }

        private void BTDel_Click(object sender, EventArgs e)
        {
            if (LVOrder.SelectedItems.Count > 0)
            {
                var item = LVOrder.SelectedItems[0];
                int idOrder = int.Parse(item.SubItems[0].Text);
                string foodName = item.SubItems[2].Text;

                int idFood = GetFoodID(foodName);

                using (SqlConnection conn = new SqlConnection(FormCustomer.NameData))
                {
                    conn.Open();
                    string sql = "DELETE FROM TBL_Order WHERE ID_Order = @ID_Order AND ID_FOrder = @ID_FOrder";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@ID_Order", idOrder);
                    cmd.Parameters.AddWithValue("@ID_FOrder", idFood);

                    cmd.ExecuteNonQuery();
                }

                LVOrder.Items.Remove(item);
                MessageBox.Show("ลบรายการเรียบร้อยแล้ว");
            }
            else
            {
                MessageBox.Show("กรุณาเลือกรายการที่จะลบ");
            }
        }

        private void BTExit_Click(object sender, EventArgs e)
        {
            // บันทึกข้อมูลจาก ListView ลงฐานข้อมูล
            foreach (ListViewItem item in LVOrder.Items)
            {
                SaveOrderToDatabase(item);
            }

            MessageBox.Show("บันทึกข้อมูลทั้งหมดเรียบร้อยแล้ว");

            // ปิดโปรแกรม
            Application.Exit();
        }
    }
}
