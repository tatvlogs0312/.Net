using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Demo1___WindowsForms
{
    public partial class frmtext : Form
    {
        public frmtext()
        {
            InitializeComponent();
        }

        private void btnKetNoi_Click(object sender, EventArgs e)
        {
            try {
                // kịch bản
                // Bước 1 : tạo chuỗi kết nối
                String svName = "(local)";
                String dbName = "QLNV";
                // String Security = "SSPI";
                String userID = "sa";
                String passWord = "123456";

                // String con_str = $"Data Source = {svName}; Initial Catalog = {dbName} ; Integrated Security = {Security}";
                String con_str = $"Data Source = {svName}; Initial Catalog = {dbName} ; user ID = {userID} ; Password = {passWord}";
                // Bước 2 Tạo đối tượng kết nối
                SqlConnection conn = new SqlConnection(con_str);

                // Bước 3 Mở kết nối CSDL
                conn.Open();

                // Bước ? Thực thi các truy vấn / thông báo trạng thái kết nối
                MessageBox.Show($"kết nối thành công đến sv : {svName} , db : {dbName}");

                // Bước 4 Đóng kết nối
                conn.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Kết nối thất bại" + ex.Message);
            }
        }

        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            try
            {
                // kịch bản
                // Bước 1 : tạo chuỗi kết nối
                String svName = "(local)";
                String dbName = "QLNV";
                // String Security = "SSPI";
                String userID = "sa";
                String passWord = "123456";

                // String con_str = $"Data Source = {svName}; Initial Catalog = {dbName} ; Integrated Security = {Security}";
                String con_str = $"Data Source = {svName}; Initial Catalog = {dbName} ; user ID = {userID} ; Password = {passWord}";
                // Bước 2 Tạo đối tượng kết nối
                SqlConnection conn = new SqlConnection(con_str);

                // Bước 3 Mở kết nối CSDL
                conn.Open();

                // Bước ? Thực thi các truy vấn / thông báo trạng thái kết nối
                MessageBox.Show($"kết nối thành công đến sv : {svName} , db : {dbName}");
                // Bước ?1 Tạo truy vấn 
                String maPhong = txtMaPhong.Text;
                String tenPhong = txtTenPhong.Text;
                String Query = $"Insert into PhongBan(MaPhong, TenPhong) VALUE (N'{maPhong}' , N'{tenPhong}')";
                // Bước ?2 Tạo đối tượng thực thi truy vẫn 
                SqlCommand cmd = new SqlCommand(Query, conn);
                // Bước ?3 Thực thi truy vấn => Thực thi truy vấn là insert => chọn phương thức thực thi ExecuteNonQuery()
                int sl = cmd.ExecuteNonQuery();
                if (sl == 1)
                {
                    MessageBox.Show("Thêm thành công");
                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
                }

                // Bước 4 Đóng kết nối
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Kết nối thất bại" + ex.Message);
            }
        }
    }
}
