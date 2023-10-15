using P1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P1
{
    public partial class QuanlyLoaiTienNghi : Form
    {
        QLPTContextDB Context;
        public QuanlyLoaiTienNghi()
        {
            Context = new QLPTContextDB();
            InitializeComponent();
        }
        private void BindGrid(List<LOAITIENNGHI> listLoaiTienNghi)
        {
            dgvLoaiTienNghi.Rows.Clear();
            foreach (var item in listLoaiTienNghi)
            {
                int index = dgvLoaiTienNghi.Rows.Add();
                dgvLoaiTienNghi.Rows[index].Cells[0].Value = item.MALOAITIENNGHI;
                dgvLoaiTienNghi.Rows[index].Cells[1].Value = item.TENLOAITIENNGHI;
                
            }
        }
        private void ReLoadDSLTN()
        {
            List<LOAITIENNGHI> listLoaiTienNghi = Context.LOAITIENNGHI.ToList();

            BindGrid(listLoaiTienNghi);
        }
        private void QuanlyLoaiTienNghi_Load(object sender, EventArgs e)
        {
            try
            {
                QLPTContextDB context = new QLPTContextDB();
                List<LOAITIENNGHI> listLoaiTienNghi = Context.LOAITIENNGHI.ToList();
                BindGrid(listLoaiTienNghi);
                AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
                foreach (var item in listLoaiTienNghi)
                {
                    auto.Add(item.MALOAITIENNGHI);
                    auto.Add(item.TENLOAITIENNGHI);
                }
                txtTimkiem.AutoCompleteCustomSource = auto;
                txtTimkiem.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtTimkiem.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        
        public void RefeshData()
        {
            txtMaLTN.Text = "";
            txtTenLTN.Text = "";
            txtTimkiem.Text = "";
        }
        public void RefeshData1()
        {
            txtMaLTN.Text = "";
            txtTenLTN.Text = "";
        }
        private LOAITIENNGHI TimKiemMaLTN(String MaLTN)
        {
            return Context.LOAITIENNGHI.FirstOrDefault(mltn => mltn.MALOAITIENNGHI == MaLTN);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            LOAITIENNGHI timTN = TimKiemMaLTN(txtMaLTN.Text);
            if (timTN != null)
            {
                MessageBox.Show("Mã số loại tiện nghi này tồn tại nên không thêm được");
                return;
            }
            LOAITIENNGHI mltn = new LOAITIENNGHI()
            {
                MALOAITIENNGHI = txtMaLTN.Text,
                TENLOAITIENNGHI = txtTenLTN.Text,
                
            };
            Context.LOAITIENNGHI.Add(mltn);
            Context.SaveChanges();
            MessageBox.Show("Thêm tiện nghi thành Công ");
            ReLoadDSLTN();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            LOAITIENNGHI TimMLTN = TimKiemMaLTN(txtMaLTN.Text);
            if (TimMLTN == null)
            {
                MessageBox.Show("Mã tiện nghi không tồn tại");
            }
            else
            {
                TimMLTN.TENLOAITIENNGHI = txtTenLTN.Text;
                DialogResult result = MessageBox.Show("Bạn đồng ý sửa loại tiện nghi không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Context.SaveChanges();
                    ReLoadDSLTN();
                    MessageBox.Show("Đã lưu thay đổi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefeshData();
                }
            }
        }

        private void dgvLoaiTienNghi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvLoaiTienNghi.CurrentRow.Selected = true;
            txtMaLTN.Text = dgvLoaiTienNghi.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTenLTN.Text = dgvLoaiTienNghi.Rows[e.RowIndex].Cells[1].Value.ToString();
           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            LOAITIENNGHI TimLTN = TimKiemMaLTN(txtMaLTN.Text);
            if (TimLTN == null)
            {
                MessageBox.Show("Mã số loại tiện nghi không tồn tại");
            }
            else
            {
                DialogResult result = MessageBox.Show($"Ban co chac chan xoa loại tiện nghi {TimLTN.TENLOAITIENNGHI}",
                        "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //Dong y xoa 
                if (result == DialogResult.Yes)
                {
                    Context.LOAITIENNGHI.Remove(TimLTN);
                    //Luu lai thay doi
                    MessageBox.Show("Xoa loại tiện nghi thanh cong");
                    Context.SaveChanges();
                    ReLoadDSLTN();
                    //Load lai data

                }
            }
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            RefeshData();
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            string timkiem = txtTimkiem.Text.Trim();
            List<LOAITIENNGHI> listLoaiTienNghi;

            if (!string.IsNullOrEmpty(timkiem))
            {
                listLoaiTienNghi = Context.LOAITIENNGHI
                    .Where(s => s.TENLOAITIENNGHI.Contains(timkiem) || s.MALOAITIENNGHI.Contains(timkiem))
                    .ToList();
            }
            else
            {
                listLoaiTienNghi = Context.LOAITIENNGHI.ToList();
            }
            BindGrid(listLoaiTienNghi);
            RefeshData1();
        }

        private void txtTenLTN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ' ')
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng chỉ nhập chữ vào ô này.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
