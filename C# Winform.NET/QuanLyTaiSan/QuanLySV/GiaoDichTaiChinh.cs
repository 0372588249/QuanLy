using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace QuanLySV
{
    public partial class GiaoDichTaiChinh : Form
    {

        /*PROPERTY*/
        // @IdUser: ID tài khoản của user đăng nhập thành công.
        // @root: Form cha mở form hiện tại
        // @dictWallets: List object Wallets
        public string IDUser;
        public TaiKhoan root;
        Dictionary<string, CWallet> dictWallets;

        public GiaoDichTaiChinh()
        {
            InitializeComponent();
            IDUser = "admin";
        }

        private void GiaoDichTaiChinh_Load(object sender, EventArgs e)
        {
            cbbVi.ValueMember = "Id";
            cbbVi.DisplayMember = "Name";
            getDataVi();
            cbbVi.SelectedIndex = 0;
        }
        private void cbbVi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbVi.SelectedIndex == -1) return;
            
        }

















        /* Lấy dữ liệu từ DB đổ lên List */
        void getDataVi()
        {
            dictWallets = new Dictionary<string, CWallet>();

            string query = @"SELECT ma_vi, img, ten_vi, so_tien, don_vi FROM VI
                                WHERE taikhoan = '" + IDUser + "'";
            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                CWallet wl = new CWallet(rd[0].ToString(), rd[1].ToString(), rd[2].ToString(), rd[3].ToString(), rd[4].ToString());
                cbbVi.Items.Add(wl);
                dictWallets[wl.Id] = wl;
            }
            DB.conn.Close();
        }

        void getImageVi()
        {
            string name_img = ((CWallet)cbbVi.SelectedItem).Img;
            pbVi.Image = Commom.getImage(name_img);
        }
        
    }
}
