//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
////using Excel = Microsoft.Win32.Interop.Excel;

//namespace KiemTraCSDL
//{
//    internal class ExeclExporter
//    {
//        public void ExportToExcel(DataTable data)
//        {
//            if (data.Rows.Count > 0)
//            {
//                // Khởi tạo các đối tượng Excel
//                Excel.Application exApp = new Excel.Application();
//                Excel.Workbook exBook = null;
//                Excel.Worksheet exSheet = null;

//                try
//                {
//                    exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
//                    exSheet = (Excel.Worksheet)exBook.Worksheets[1];

//                    // Ghi tiêu đề cột từ DataTable vào Excel
//                    for (int i = 0; i < data.Columns.Count; i++)
//                    {
//                        exSheet.Cells[1, i + 1] = data.Columns[i].ColumnName;
//                    }

//                    // Ghi dữ liệu từ DataTable vào Excel
//                    for (int i = 0; i < data.Rows.Count; i++)
//                    {
//                        for (int j = 0; j < data.Columns.Count; j++)
//                        {
//                            exSheet.Cells[i + 2, j + 1] = data.Rows[i][j].ToString();
//                        }
//                    }

//                    // Mở SaveFileDialog để lưu file Excel
//                    SaveFileDialog dlgSave = new SaveFileDialog();
//                    dlgSave.Filter = "Excel files (*.xls)|*.xls";
//                    if (dlgSave.ShowDialog() == DialogResult.OK)
//                    {
//                        exBook.SaveAs(dlgSave.FileName.ToString());
//                        MessageBox.Show("Xuất file thành công!");
//                    }
//                }
//                catch (Exception ex)
//                {
//                    MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
//                }
//                finally
//                {
//                    // Đóng ứng dụng Excel và giải phóng bộ nhớ
//                    if (exBook != null)
//                    {
//                        exBook.Close(false);
//                        System.Runtime.InteropServices.Marshal.ReleaseComObject(exBook);
//                    }
//                    if (exApp != null)
//                    {
//                        exApp.Quit();
//                        System.Runtime.InteropServices.Marshal.ReleaseComObject(exApp);
//                    }
//                    if (exSheet != null)
//                    {
//                        System.Runtime.InteropServices.Marshal.ReleaseComObject(exSheet);
//                    }
//                }
//            }
//            else
//            {
//                MessageBox.Show("Không có dữ liệu để xuất!");
//            }
//        }
//    }
//}
