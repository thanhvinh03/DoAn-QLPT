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
    public partial class QuanlyCT_DICHVU : Form
    {
        QLPTContextDB context;
        public QuanlyCT_DICHVU()
        {
            context = new QLPTContextDB();
            InitializeComponent();
        }
        private void BindGrid(List<CT_DICHVU> listCTDV)
        {
            List<DICHVU> listDV = context.DICHVU.ToList();
            dgvCT_Dichvu.Rows.Clear();
            foreach (var item in listCTDV)
            {
                int index = dgvCT_Dichvu.Rows.Add();
                dgvCT_Dichvu.Rows[index].Cells[0].Value = item.MAHD;
                dgvCT_Dichvu.Rows[index].Cells[1].Value = item.MADICHVU;
                dgvCT_Dichvu.Rows[index].Cells[2].Value = item.DICHVU.GIATIEN;
                dgvCT_Dichvu.Rows[index].Cells[3].Value = item.SOLUONGDV;
                dgvCT_Dichvu.Rows[index].Cells[4].Value = item.THANHTIENDV;
            }
        }
        private void FillFalcultyCombobox(List<DICHVU> listCTDV)
        {
            //listCTDV.Insert(0, new DICHVU());
            this.cbbMdv.DataSource = listCTDV;
            this.cbbMdv.DisplayMember = "MADICHVU";
            this.cbbMdv.ValueMember = "MADICHVU";

        }
        private void FillfalcultyCombobox(List<HOPDONG> listHD)
        {
            //listCTDV.Insert(0, new DICHVU());
            this.cbbMaHD.DataSource = listHD;
            this.cbbMaHD.DisplayMember = "MAHD";
            this.cbbMaHD.ValueMember = "MAHD";

        }

        private void QuanlyCT_DICHVU_Load(object sender, EventArgs e)
        {
            List<DICHVU> listDV = context.DICHVU.ToList();
            List<HOPDONG> listHD = context.HOPDONG.ToList();
            List<CT_DICHVU> listCTDV = context.CT_DICHVU.ToList();
            foreach (CT_DICHVU listctdv in listCTDV)
            {
                if (listctdv.THANHTIENDV == null)
                {
                    listctdv.THANHTIENDV = 0;
                }
            }
            FillfalcultyCombobox(listHD);
            FillFalcultyCombobox(listDV);
            BindGrid(listCTDV);
            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
            foreach (var item in listCTDV)
            {
                auto.Add(item.MAHD);
                auto.Add(item.MADICHVU);
            }
            txtTimKiem.AutoCompleteCustomSource = auto;
            txtTimKiem.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtTimKiem.AutoCompleteSource = AutoCompleteSource.CustomSource;
            TinhThanhTien();
        }
        public void clear()
        {

            txtSoluong.Text = " ";
            txtThanhtien.Text = " ";
            txtGiadv.Text = " ";
            cbbMaHD.SelectedIndex = 0;
            cbbMdv.SelectedIndex = 0;
        }
        private bool rangbuoc()
        {
            if (txtSoluong.Text.Trim() == "" || cbbMaHD.SelectedIndex == -1 || cbbMdv.SelectedIndex == -1 || txtGiadv.Text.Trim() == "" || txtThanhtien.Text.Trim() == "")
            {
                MessageBox.Show("Bạn cần nhập đầy đủ thông tin");
                return false;
            }
            if (int.TryParse(txtSoluong.Text, out int slValue))
            {
                if (slValue < 0)
                {
                    MessageBox.Show("Số lượng lớn hơn 0");
                    return false;
                }
            }
            return true;
        }

        private void dgvCT_Dichvu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvCT_Dichvu.CurrentRow.Index;
            {
                cbbMaHD.Text = dgvCT_Dichvu.Rows[i].Cells[0].Value.ToString();
                cbbMdv.Text = dgvCT_Dichvu.Rows[i].Cells[1].Value.ToString();
                txtGiadv.Text = dgvCT_Dichvu.Rows[i].Cells[2].Value.ToString();
                txtSoluong.Text = dgvCT_Dichvu.Rows[i].Cells[3].Value.ToString();
                txtThanhtien.Text = dgvCT_Dichvu.Rows[i].Cells[4].Value.ToString();

            }
        }
        private CT_DICHVU TimkiemCTDV(string mahd, string madv)
        {
            return context.CT_DICHVU.FirstOrDefault(ctdv => ctdv.MAHD == mahd && ctdv.MADICHVU == madv);
        }
        private CT_DICHVU Timkiem(string madv)
        {
            return context.CT_DICHVU.FirstOrDefault(ctdv => ctdv.MADICHVU == madv);
        }
        private DICHVU TimkiemDV(string madv)
        {
            return context.DICHVU.FirstOrDefault(dv => dv.MADICHVU == madv);
        }
        public void TinhThanhTien()
        {
            if (float.TryParse(txtGiadv.Text, out float Giadv) && int.TryParse(txtSoluong.Text, out int soluong))
            {
                float thanhTien = soluong * Giadv;
                txtThanhtien.Text = thanhTien.ToString();
            }
            else
            {
                txtThanhtien.Text = "0"; // Đặt tổng thành tiền thành 0 nếu không thể tính được
            }
            for (int i = 0; i < dgvCT_Dichvu.Rows.Count; i++)
            {
                float giaDV = float.Parse(dgvCT_Dichvu.Rows[i].Cells[2].Value.ToString());
                int soLuong = int.Parse(dgvCT_Dichvu.Rows[i].Cells[3].Value.ToString());
                dgvCT_Dichvu.Rows[i].Cells[4].Value = giaDV * soLuong;
            }
        }
        private void ReLoadSV()
        {
            List<CT_DICHVU> dsctdichvu = context.CT_DICHVU.ToList();
            BindGrid(dsctdichvu);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (rangbuoc() == false)
            {
                return;
            }
            CT_DICHVU TimCTDV = TimkiemCTDV(cbbMaHD.Text, cbbMdv.Text);
            if (TimCTDV == null)
            {
                MessageBox.Show("Mã số hợp đồng hoặc mã dịch vụ không tồn tại");
            }
            else
            {
                //TimCTDV.MAHD = cbbMaHD.Text;
                //TimCTDV.MADICHVU = cbbMdv.SelectedValue.ToString();
                TimCTDV.SOLUONGDV = int.Parse(txtSoluong.Text);
                TimCTDV.THANHTIENDV = float.Parse(txtThanhtien.Text);
                DialogResult result = MessageBox.Show(" Bạn đồng ý sửa không ?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    context.SaveChanges();
                    MessageBox.Show("Sửa thành công", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReLoadSV();
                    clear();
                    TinhThanhTien();

                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (rangbuoc() == false)
            {
                return;
            }
            CT_DICHVU timct = TimkiemCTDV(cbbMaHD.Text, cbbMdv.Text);
            if (timct != null)
            {
                MessageBox.Show("Mã hợp đồng và mã dịch vụ đã tồn tại");
                return;
            }
            CT_DICHVU sv = new CT_DICHVU()
            {
                MAHD = cbbMaHD.SelectedValue.ToString(),
                MADICHVU = cbbMdv.SelectedValue.ToString(),
                SOLUONGDV = int.Parse(txtSoluong.Text),
                THANHTIENDV = float.Parse(txtThanhtien.Text),
            };
            context.CT_DICHVU.Add(sv);
            context.SaveChanges();
            MessageBox.Show("Thêm thành công");
            ReLoadSV();
            clear();
            TinhThanhTien();
        }

        private void txtSoluong_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtSoluong.Text, out int value) && float.TryParse(txtGiadv.Text, out float giadv))
            {
                float tien = value * giadv;
                txtThanhtien.Text = tien.ToString();

                // Cập nhật lại giá trị của dòng hiện tại trong DataGridView
                if (dgvCT_Dichvu.CurrentRow != null)
                {
                    int currentIndex = dgvCT_Dichvu.CurrentRow.Index;
                    dgvCT_Dichvu.Rows[currentIndex].Cells[3].Value = value; // Cập nhật số lượng
                    dgvCT_Dichvu.Rows[currentIndex].Cells[4].Value = tien;  // Cập nhật thành tiền
                }
            }
            else
            {
                txtThanhtien.Text = "0"; // Hoặc gán giá trị mặc định khác
            }
        }
        public void Xoact_dv(string madv)
        {
            if (madv == cbbMdv.Text)
            {
                CT_DICHVU tk = Timkiem(madv);
                if (tk != null)
                {
                    context.CT_DICHVU.Remove(tk);
                    //Luu lai thay doi               
                    context.SaveChanges();
                    ReLoadSV();
                    clear();
                }
            }
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            CT_DICHVU timct = TimkiemCTDV(cbbMaHD.Text, cbbMdv.Text);
            if (timct == null)
            {
                MessageBox.Show("Mã hợp đồng không tồn tại");
            }
            else
            {
                DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa .",
                        "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //Dong y xoa 
                if (result == DialogResult.Yes)
                {
                    context.CT_DICHVU.Remove(timct);
                    //Luu lai thay doi
                    MessageBox.Show("Xóa thành công");
                    context.SaveChanges();
                    ReLoadSV();
                    clear();


                }
            }
        }

        private void cbbMdv_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedMadv = cbbMdv.SelectedValue.ToString(); // Lấy mã dịch vụ được chọn
            DICHVU selectedDv = TimkiemDV(selectedMadv); // Tìm dịch vụ tương ứng

            if (selectedDv != null)
            {
                // Nếu dịch vụ được tìm thấy, cập nhật giá dịch vụ vào txtGiadv
                txtGiadv.Text = selectedDv.GIATIEN.ToString();
                TinhThanhTien(); // Sau khi cập nhật giá, tính lại tổng thành tiền
            }
        }

        private void txtSoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // Ngăn không cho ký tự được nhập vào ô văn bản
                e.Handled = true;

                // Xuất thông báo cho người dùng
                MessageBox.Show("Vui lòng chỉ nhập số vào ô này.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string timkiem = txtTimKiem.Text.Trim();
            List<CT_DICHVU> listCTDV;
            if (!string.IsNullOrEmpty(timkiem))
            {
                listCTDV = context.CT_DICHVU
                    .Where(s => s.MAHD.Contains(timkiem) || s.MADICHVU.Contains(timkiem))
                    .ToList();
            }
            else
            {
                listCTDV = context
                    .CT_DICHVU.ToList();
            }
            BindGrid(listCTDV);
        }
    }
}
