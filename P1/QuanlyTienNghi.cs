using P1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;

namespace P1
{
    public partial class QuanlyTienNghi : Form
    {
        QLPTContextDB Context;

        public QuanlyTienNghi()
        {
            Context = new QLPTContextDB();
            InitializeComponent();
        }
        private void FillFalcultyCombobox(List<LOAITIENNGHI> listLoaiTienNghi)
        {
            listLoaiTienNghi.Insert(0, new LOAITIENNGHI());
            cmbLoaiTienNghi.DataSource = listLoaiTienNghi;
            cmbLoaiTienNghi.DisplayMember = "TENLOAITIENNGHI";
            cmbLoaiTienNghi.ValueMember = "MALOAITIENNGHI";
        }
        private void BindGrid(List<TIENNGHI> listTienNghi)
        {
            dgvTiennghi.Rows.Clear();
            foreach (var item in listTienNghi)
            {
                int index = dgvTiennghi.Rows.Add();
                dgvTiennghi.Rows[index].Cells[0].Value = item.MATIENNGHI;
                dgvTiennghi.Rows[index].Cells[1].Value = item.TENTIENNGHI;
                dgvTiennghi.Rows[index].Cells[2].Value = item.LOAITIENNGHI.TENLOAITIENNGHI;
                dgvTiennghi.Rows[index].Cells[3].Value = item.TONKHO;
                dgvTiennghi.Rows[index].Cells[4].Value = item.GIAMUA;
                dgvTiennghi.Rows[index].Cells[5].Value = item.GIATHUE;


            }
        }
        private bool rangbuoc()
        {
            if (txtMatiennghi.Text == " " || txxTentnghi.Text == "" || txtGiathue.Text == "" || txtGiatiennghi.Text == "" || txtTonKho.Text == "" || cmbLoaiTienNghi.Text == "" ) 
            {
                MessageBox.Show("Bạn cần nhập đầy đủ thông tin");
                return false;

            }
            if (float.TryParse(txtGiathue.Text, out float gtValue))
            {
                if (gtValue <= 0)
                {
                    MessageBox.Show("Sai giá");
                    return false;
                }
            }
            if (float.TryParse(txtGiatiennghi.Text, out float gmValue))
            {
                if (gmValue <= 0)
                {
                    MessageBox.Show("Sai giá");
                    return false;
                }
            }
            return true;
        }
        private void QuanlyTienNghi_Load(object sender, EventArgs e)
        {

            QLPTContextDB context = new QLPTContextDB();
            List<TIENNGHI> listTienNghi = Context.TIENNGHI.ToList();
            List<LOAITIENNGHI> listLoaiTienNghi = Context.LOAITIENNGHI.ToList();
            FillFalcultyCombobox(listLoaiTienNghi);
            BindGrid(listTienNghi);
            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
            foreach (var item in listTienNghi)
            {
                auto.Add(item.TENTIENNGHI);
                auto.Add(item.MATIENNGHI);
            }
            txtTimKiemTN.AutoCompleteCustomSource = auto;
            txtTimKiemTN.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtTimKiemTN.AutoCompleteSource = AutoCompleteSource.CustomSource;

        }


        private void ReLoadDSTN()
        {
            List<TIENNGHI> listTienNghi = Context.TIENNGHI.ToList();
            List<LOAITIENNGHI> listLoaiTienNghi = Context.LOAITIENNGHI.ToList();

            FillFalcultyCombobox(listLoaiTienNghi);
            BindGrid(listTienNghi);
        }


        private void txtTonKho_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // Ngăn không cho ký tự được nhập vào ô văn bản
                e.Handled = true;

                // Xuất thông báo cho người dùng
                MessageBox.Show("Vui lòng chỉ nhập số vào ô này.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtGiatiennghi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // Ngăn không cho ký tự được nhập vào ô văn bản
                e.Handled = true;

                // Xuất thông báo cho người dùng
                MessageBox.Show("Vui lòng chỉ nhập số vào ô này.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtGiathue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // Ngăn không cho ký tự được nhập vào ô văn bản
                e.Handled = true;

                // Xuất thông báo cho người dùng
                MessageBox.Show("Vui lòng chỉ nhập số vào ô này.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        
        private TIENNGHI TimKiemTN(String MaTN)
        {
            return Context.TIENNGHI.FirstOrDefault(tn => tn.MATIENNGHI == MaTN);
        }
        private void btnThemTN_Click(object sender, EventArgs e)
        {
            if (rangbuoc() == false)
                return;
            TIENNGHI timTN = TimKiemTN(txtMatiennghi.Text);
            if (timTN != null)
            {
                MessageBox.Show("Mã số tiện nghi này tồn tại nên không thêm được");
                return;
            }
            TIENNGHI tn = new TIENNGHI()
            {
                MATIENNGHI = txtMatiennghi.Text,
                TENTIENNGHI = txxTentnghi.Text,
                GIATHUE = int.Parse(txtGiatiennghi.Text),
                GIAMUA = int.Parse(txtGiathue.Text),
                TONKHO = int.Parse(txtTonKho.Text),
                MALOAITIENNGHI = cmbLoaiTienNghi.SelectedValue.ToString(),
            };
            Context.TIENNGHI.Add(tn);
            Context.SaveChanges();
            MessageBox.Show("Thêm tiện nghi thành Công ");
            ReLoadDSTN();
        }
        public void RefeshData()
        {
            txtMatiennghi.Text = "";
            txxTentnghi.Text = "";
            txtGiathue.Text = "";
            txtGiatiennghi.Text = "";
            txtTonKho.Text = "";
            cmbLoaiTienNghi.SelectedIndex = 0;
            txtTimKiemTN.Text = "";
        }
        public void RefeshData1()
        {
            txtMatiennghi.Text = "";
            txxTentnghi.Text = "";
            txtGiathue.Text = "";
            txtGiatiennghi.Text = "";
            txtTonKho.Text = "";
            cmbLoaiTienNghi.SelectedIndex = 0;
        }
        private TIENNGHI TimKiemMaTN(String matn)
        {
            return Context.TIENNGHI.FirstOrDefault(tn => tn.MATIENNGHI == matn);
        }
        private void btnSuaTN_Click(object sender, EventArgs e)
        {
            if (rangbuoc() == false)
                return;
            TIENNGHI TimTN = TimKiemMaTN(txtMatiennghi.Text);
            if (TimTN == null)
            {
                MessageBox.Show("Mã tiện nghi không tồn tại");
            }
            else
            {
                TimTN.TENTIENNGHI = txxTentnghi.Text;

                if (int.TryParse(txtGiathue.Text, out int giaThue))
                {
                    TimTN.GIATHUE = giaThue;
                }
                else
                {
                    MessageBox.Show("Giá thuê không hợp lệ");
                    return; // Không cần tiếp tục nếu dữ liệu không hợp lệ.
                }

                if (int.TryParse(txtGiatiennghi.Text, out int giaMua))
                {
                    TimTN.GIAMUA = giaMua;
                }
                else
                {
                    MessageBox.Show("Giá mua không hợp lệ");
                    return; // Không cần tiếp tục nếu dữ liệu không hợp lệ.
                }

                if (int.TryParse(txtTonKho.Text, out int tonKho))
                {
                    TimTN.TONKHO = tonKho;
                }
                else
                {
                    MessageBox.Show("Tồn kho không hợp lệ");
                    return; // Không cần tiếp tục nếu dữ liệu không hợp lệ.
                }

                TimTN.MALOAITIENNGHI = cmbLoaiTienNghi.SelectedValue.ToString();
                DialogResult result = MessageBox.Show("Bạn đồng ý sửa tiện nghi không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Context.SaveChanges();
                    ReLoadDSTN();
                    MessageBox.Show("Đã lưu thay đổi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefeshData();
                }
            }        
        }

        private void dgvTiennghi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvTiennghi.CurrentRow.Selected = true;
            txtMatiennghi.Text = dgvTiennghi.Rows[e.RowIndex].Cells[0].Value.ToString();
            cmbLoaiTienNghi.SelectedIndex = cmbLoaiTienNghi.FindString(dgvTiennghi.Rows[e.RowIndex].Cells[2].Value.ToString());
            txxTentnghi.Text = dgvTiennghi.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtTonKho.Text = dgvTiennghi.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtGiatiennghi.Text = dgvTiennghi.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtGiathue.Text = dgvTiennghi.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btnxoati_Click(object sender, EventArgs e)
        {
            if (rangbuoc() == false)
                return;
            TIENNGHI TimTN = TimKiemMaTN(txtMatiennghi.Text);
            if (TimTN == null)
            {
                MessageBox.Show("Mã số sinh viên không tồn tại");
            }
            else
            {
                DialogResult result = MessageBox.Show($"Ban co chac chan xoa tiện nghi {TimTN.TENTIENNGHI}",
                        "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //Dong y xoa 
                if (result == DialogResult.Yes)
                {
                    Context.TIENNGHI.Remove(TimTN);
                    //Luu lai thay doi
                    MessageBox.Show("Xoa tiện nghi thanh cong");
                    Context.SaveChanges();
                    ReLoadDSTN();
                    //Load lai data

                }
            }
        }

        private void btnLammoiti_Click(object sender, EventArgs e)
        {
            RefeshData();

        }

        private void txtTimKiemTN_TextChanged(object sender, EventArgs e)
        {
            string timkiem = txtTimKiemTN.Text.Trim();
            List<TIENNGHI> listTienNghi;

            if (!string.IsNullOrEmpty(timkiem))
            {
                listTienNghi = Context.TIENNGHI
                    .Where(s => s.TENTIENNGHI.Contains(timkiem) || s.MATIENNGHI.Contains(timkiem))
                    .ToList();
            }
            else
            {
                listTienNghi = Context.TIENNGHI.ToList();
            }
            BindGrid(listTienNghi);
            RefeshData1();
        }
    }
}
