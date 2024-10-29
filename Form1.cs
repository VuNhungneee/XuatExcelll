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
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;

namespace KiemTraCSDL
{
    public partial class Form1 : Form
    {
        private DataTable dt;
        private String sql;
        private DatabaseRun run = new DatabaseRun();
        String txtAnh;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo:", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void Reset()
        {
            txtHang.Clear();
            txtKhung.Clear();
            txtMau.Clear();
            txtMay.Clear();
            txtTen.Clear();
            cbDungTich.SelectedIndex = -1;
            pbAnh.Image = null;
            txtKhung.Focus();
        }
        private void ThemAnh()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbAnh.Image = Image.FromFile(ofd.FileName);
                txtAnh = ofd.FileName; // Lưu đường dẫn của ảnh
            }
        }
        private void btnMoi_Click(object sender, EventArgs e)
        {
            txtHang.Clear();
            txtKhung.Clear();
            txtMau.Clear();
            txtMay.Clear();
            txtTen.Clear();
            cbDungTich.SelectedIndex = -1;
            txtAnh = null;
            pbAnh.Image = null;
            txtKhung.Enabled = true;
            txtMay.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dtb = run.DocData("select * from XeMay");
            dtgXe.DataSource = dtb;
            dtb.Dispose();

        }

        private void dtgXe_Click(object sender, EventArgs e)
        {
            if (dtgXe.CurrentRow != null)
            {
                txtKhung.Enabled = false;
                txtMay.Enabled = false;
                txtKhung.Text = dtgXe.CurrentRow.Cells[0].Value.ToString();
                txtMay.Text = dtgXe.CurrentRow.Cells[1].Value.ToString();
                txtMau.Text = dtgXe.CurrentRow.Cells[2].Value.ToString();
                cbDungTich.Text = dtgXe.CurrentRow.Cells[3].Value.ToString();
                txtHang.Text = dtgXe.CurrentRow.Cells[4].Value.ToString();
                txtTen.Text = dtgXe.CurrentRow.Cells[5].Value.ToString();
                txtAnh = dtgXe.CurrentRow.Cells[6].Value.ToString();
                if (!string.IsNullOrEmpty(txtAnh) && System.IO.File.Exists(txtAnh))
                {
                    pbAnh.Image = Image.FromFile(txtAnh);
                }
                else
                {
                    pbAnh.Image = null; // Nếu không có ảnh, xóa ảnh hiện tại
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Bạn có muốn xóa xe {txtTen.Text} không?", "Thông báo:", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                run.DocData($"delete from XeMay where SoKhung = '{txtKhung.Text.Trim()}'");
                dtgXe.DataSource = run.DocData("select * from XeMay");
                MessageBox.Show("Bạn đã xóa thành công!");
                Reset();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if
            if (MessageBox.Show("Bạn có  muốn sửa thông tin về xe này không?", "Thông báo:", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (String.IsNullOrEmpty(txtTen.Text))
                {
                    MessageBox.Show("Bạn phải điền tên xe!", "Thông báo:", MessageBoxButtons.OK);
                    return;
                }
                if (String.IsNullOrEmpty(txtHang.Text))
                {
                    MessageBox.Show("Bạn phải điền hãng!", "Thông báo:", MessageBoxButtons.OK);
                    return;
                }
                if (cbDungTich.SelectedIndex == -1)
                {
                    MessageBox.Show("Bạn phải chọn dung tích!", "Thông báo:", MessageBoxButtons.OK);
                    return;
                }
                if (String.IsNullOrEmpty(txtMau.Text))
                {
                    MessageBox.Show("Bạn phải điền màu!", "Thông báo:", MessageBoxButtons.OK);
                    return;
                }
                if (txtMay.Text != dtgXe.CurrentRow.Cells[1].Value.ToString())
                {
                    MessageBox.Show("Bạn không được sửa số máy!", "Thông báo:", MessageBoxButtons.OK);
                    return;
                }
                run.CapNhat($"update XeMay set Mau = N'{txtMau.Text.Trim()}',DungTich='{cbDungTich.SelectedItem.ToString()}',Hang = '{txtHang.Text}', Ten = '{txtTen.Text.Trim()}' where SoKhung ='{txtKhung.Text.Trim()}'");
                dtgXe.DataSource = run.DocData("select * from XeMay");
                MessageBox.Show("Bạn đã sửa thành công!");
                Reset();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtKhung.Text))
            {
                MessageBox.Show("Bạn phải điền khung!", "Thông báo:", MessageBoxButtons.OK);
                return;
            }
            if (String.IsNullOrEmpty(txtMay.Text))
            {
                MessageBox.Show("Bạn phải điền máy!", "Thông báo:", MessageBoxButtons.OK);
                return;
            }
            if (String.IsNullOrEmpty(txtTen.Text))
            {
                MessageBox.Show("Bạn phải điền tên xe!", "Thông báo:", MessageBoxButtons.OK);
                return;
            }
            if (String.IsNullOrEmpty(txtHang.Text))
            {
                MessageBox.Show("Bạn phải điền hãng!", "Thông báo:", MessageBoxButtons.OK);
                return;
            }
            if (cbDungTich.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn phải chọn dung tích!", "Thông báo:", MessageBoxButtons.OK);
                return;
            }
            if (String.IsNullOrEmpty(txtMau.Text))
            {
                MessageBox.Show("Bạn phải điền màu!", "Thông báo:", MessageBoxButtons.OK);
                return;
            }
            if (txtAnh == null)
            {
                MessageBox.Show("Bạn phải chọn ảnh!", "Thông báo:", MessageBoxButtons.OK);
                ThemAnh();
            }
            if (IsDuplicate(txtKhung.Text, txtMay.Text))
            {
                MessageBox.Show("Số khung hoặc số máy đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            run.CapNhat($"insert into XeMay(SoKhung,SoMay,Mau,DungTich,Hang,Ten,Anh) values ('{txtKhung.Text}','{txtMay.Text}',N'{txtMau.Text}','{cbDungTich.SelectedItem.ToString()}','{txtHang.Text}',N'{txtTen.Text}',N'{txtAnh}')");
            dtgXe.DataSource = run.DocData("SELECT * FROM XeMay");
            MessageBox.Show("Bạn đã thêm mới thành công");
            Reset();
        }
        private bool IsDuplicate(string soKhung, string soMay)
        {
            string query = $"SELECT COUNT(*) FROM XeMay WHERE SoKhung = '{soKhung}' OR SoMay = '{soMay}'";
            DataTable result = run.DocData(query);
            return Convert.ToInt32(result.Rows[0][0]) > 0; // Nếu có bản ghi trùng lặp
        }
        private void btnAnh_Click(object sender, EventArgs e)
        {
            ThemAnh();
        }
        private void ExportToExcel(string brand, string filePath)
        {
            // Lấy dữ liệu theo hãng
            string query = $"SELECT * FROM XeMay WHERE Hang = '{brand}'";
            DataTable dt = run.DocData(query);

            if (dt.Rows.Count > 0)
            {
                Excel.Application excelApp = new Excel.Application();
                Excel.Workbook workbook = excelApp.Workbooks.Add();

                // Ép kiểu để lấy worksheet
                Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[1];

                // Xuất tiêu đề
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1] = dt.Columns[i].ColumnName;
                }

                // Xuất dữ liệu
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dt.Rows[i][j];
                    }
                }

                // Lưu và đóng file
                workbook.SaveAs(filePath);
                workbook.Close();
                excelApp.Quit();
            }

        }
		private void btnXuat_Click(object sender, EventArgs e)
		{
			string Hang = Prompt.ShowDialog("Nhập tên hãng muốn xuất:", "Xuất theo hãng");
			if (string.IsNullOrEmpty(Hang))
			{
				MessageBox.Show("Vui lòng nhập tên hãng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			// Kiểm tra có hãng trong CSDL không
			string checkQuery = $"SELECT COUNT(*) FROM XeMay WHERE Hang = '{Hang}'";
			int count = Convert.ToInt32(run.DocData(checkQuery).Rows[0][0]);
			if (count == 0)
			{
				MessageBox.Show("Không có hãng sản xuất này trong cơ sở dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			// Hiển thị hộp thoại để chọn vị trí và tên file để lưu
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "Excel files (*.xls)|*.xls|Excel files (*.xlsx)|*.xlsx";
			saveFileDialog.Title = "Lưu file Excel";
			saveFileDialog.FileName = $"{Hang}_XeMay_{DateTime.Now:dd/mm/yyyy}.xlsx";

			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				ExportToExcel(Hang, saveFileDialog.FileName);
				MessageBox.Show("Xuất file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
	}
}
