using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoLoi
{
    public partial class Form4 : Form
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlDataAdapter adapter2 = new SqlDataAdapter();
        DataTable table = new DataTable();
        DataTable table2 = new DataTable();
        string str = @"Data Source=(local);Initial Catalog=DBMS_ThucHanh_Nhom15;Integrated Security=True";
        public Form4()
        {
            InitializeComponent();
            connection = new SqlConnection(str);
            connection.Open();
            loadCN();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void loadCN()
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=(local);Initial Catalog=DBMS_ThucHanh_Nhom15;Integrated Security=True"))
            {
                try
                {
                    string queryStr = "SELECT * FROM HOPDONG";
                    SqlDataAdapter da = new SqlDataAdapter(queryStr, connection);
                    connection.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "HOPDONG");
                    //chiNhanhNV.DisplayMember = "NgayBD";
                    //chiNhanhNV.ValueMember = "NgayBD";
                    chiNhanhNV.DataSource = ds.Tables["HOPDONG"];
                    chiNhanhNV.SelectedItem = null;

                    SqlDataAdapter da2 = new SqlDataAdapter(queryStr, connection);
                    DataSet ds2 = new DataSet();
                    da2.Fill(ds2, "HOPDONG");
                    chiNhanhKH.DisplayMember = "MaHD";
                    chiNhanhKH.ValueMember = "MaHD";
                    chiNhanhKH.DataSource = ds2.Tables["HOPDONG"];
                    chiNhanhKH.SelectedItem = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi kết nối với cơ sở dữ liệu!");
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void LoadNV()
        {
            try
            {
                command = connection.CreateCommand();
                command.CommandText = "select * from HOPDONG where NgayBD > '05-08-2020'";
                command.CommandType = CommandType.Text;
                //command.Parameters.AddWithValue("@NgayBD", chiNhanhNV.SelectedValue);
                adapter.SelectCommand = command;
                table.Clear();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadKH()
        {
            try
            {
                command = connection.CreateCommand();
                command.CommandText = "select * from CUNGCAP_SP cc, SANPHAM sp where sp.MaSP = cc.MaSP and cc.MaCN = @MaCN";
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@MaCN", chiNhanhKH.SelectedValue);
                adapter2.SelectCommand = command;
                table2.Clear();
                adapter2.Fill(table2);
                dataGridView2.DataSource = table2;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void NVChayLoi_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(str))
            {
                using (SqlCommand cmd = new SqlCommand("Xem_DanhSachHD", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.Parameters.AddWithValue("@MaCN", chiNhanhNV.SelectedValue);
                    cmd.Parameters.AddWithValue("@NgayBD", tbGiaGiam.Text);
                    con.Open();
                    cmd.ExecuteScalar();
                    MessageBox.Show("Chạy thành công.");
                }
            }
        }

        private void NVSuaLoi_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(str))
            {
                using (SqlCommand cmd = new SqlCommand("NV_giamgia_SP2", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaCN", chiNhanhNV.SelectedValue);
                    cmd.Parameters.AddWithValue("@GiaGiam", tbGiaGiam.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Chạy thành công.");
                }
            }
        }

        private void KHChayLoi_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(str))
            {
                using (SqlCommand cmd = new SqlCommand("NV_themHD", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NgayBD", tbGiaGiam.Text);
                    cmd.Parameters.AddWithValue("@MaDT", tbMaDT.Text);
                    cmd.Parameters.AddWithValue("@MaSoThue", tbMaSoThue.Text);
                    cmd.Parameters.AddWithValue("@NguoiDaiDien", tbNguoiDaiDien.Text);
                    cmd.Parameters.AddWithValue("@SoChiNhanhDK", tbSoChiNhanhDK.Text);
                    cmd.Parameters.AddWithValue("@NgayKT", tbNgayKT.Text);
                    cmd.Parameters.AddWithValue("@KichHoat", tbKichHoat.Text);
                    cmd.Parameters.AddWithValue("@PhiHoaHong", tbPhiHoaHong.Text);
                    cmd.Parameters.AddWithValue("@NgayBDTieuChuan", tbNgayBDTieuChuan.Text);
                    con.Open();
                    table2.Clear();
                    adapter2 = new SqlDataAdapter(cmd);
                    adapter2.Fill(table2);
                    dataGridView2.DataSource = table2;
                    MessageBox.Show("Chạy thành công.");
                }
            }
        }

        private void KHSuaLoi_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(str))
            {
                using (SqlCommand cmd = new SqlCommand("NV_themHD2", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NgayBD", tbGiaGiam.Text);
                    cmd.Parameters.AddWithValue("@MaDT", tbMaDT.Text);
                    cmd.Parameters.AddWithValue("@MaSoThue", tbMaSoThue.Text);
                    cmd.Parameters.AddWithValue("@NguoiDaiDien", tbNguoiDaiDien.Text);
                    cmd.Parameters.AddWithValue("@SoChiNhanhDK", tbSoChiNhanhDK.Text);
                    cmd.Parameters.AddWithValue("@NgayKT", tbNgayKT.Text);
                    cmd.Parameters.AddWithValue("@KichHoat", tbKichHoat.Text);
                    cmd.Parameters.AddWithValue("@PhiHoaHong", tbPhiHoaHong.Text);
                    cmd.Parameters.AddWithValue("@NgayBDTieuChuan", tbNgayBDTieuChuan.Text);
                    con.Open();
                    table2.Clear();
                    adapter2 = new SqlDataAdapter(cmd);
                    adapter2.Fill(table2);
                    dataGridView2.DataSource = table2;
                    MessageBox.Show("Chạy thành công.");
                }
            }
        }

        private void btnLoadNV_Click(object sender, EventArgs e)
        {
            LoadNV();
        }

        private void btnLoadKH_Click(object sender, EventArgs e)
        {
            LoadKH();
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void tbGiaGiam_TextChanged(object sender, EventArgs e)
        {

        }
        private void tbMaDT_TextChanged(object sender, EventArgs e)
        {

        }
        private void tbMaSoThue_TextChanged(object sender, EventArgs e)
        {

        }
        private void tbNguoiDaiDien_TextChanged(object sender, EventArgs e)
        {

        }
        private void tbSoChiNhanhDK_TextChanged(object sender, EventArgs e)
        {

        }
        private void tbNgayKT_TextChanged(object sender, EventArgs e)
        {

        }
        private void tbKichHoat_TextChanged(object sender, EventArgs e)
        {

        }
        private void tbPhiHoaHong_TextChanged(object sender, EventArgs e)
        {

        }
        private void tbNgayBDTieuChuan_TextChanged(object sender, EventArgs e)
        {

        }
       
        private void chiNhanhNV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
