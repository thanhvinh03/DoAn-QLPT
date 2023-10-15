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
    public partial class QuanlyDichvu : Form
    {
        QLPTContextDB context;
        public QuanlyDichvu()
        {
            context = new QLPTContextDB();
            InitializeComponent();
        }
        private void BindGrid(List<DICHVU> dsdichvu)
        {
            dgvDichvu.Rows.Clear();
            foreach (var item in dsdichvu)
            {
                int index = dgvDichvu.Rows.Add();
                dgvDichvu.Rows[index].Cells[0].Value = item.MADICHVU;
                dgvDichvu.Rows[index].Cells[1].Value = item.TENDICHVU;
                dgvDichvu.Rows[index].Cells[2].Value = item.DONVITINH;
                dgvDichvu.Rows[index].Cells[3].Value = item.GIATIEN;
            }
        }

        private void QuanlyDichvu_Load(object sender, EventArgs e)
        {
            List<DICHVU> dICHVUs = context.DICHVU.ToList();
            BindGrid(dICHVUs);
            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
            foreach (var item in dICHVUs)
            {
                auto.Add(item.TENDICHVU);
                auto.Add(item.MADICHVU);
            }
            txtTimKiem.AutoCompleteCustomSource = auto;
            txtTimKiem.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtTimKiem.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        private bool rangbuoc()
        {
            if (txtDonvitinh.Text == " " || txtTendv.Text == "" || txtMadv.Text == "" || txtGiadv.Text == " ")
            {
                MessageBox.Show("Bạn cần nhập đầy đủ thông tin");
                return false;

            }
            if (float.TryParse(txtGiadv.Text, out float tgValue))
            {
                if (tgValue <= 0)
                {
                    MessageBox.Show("Sai giá");
                    return false;
                }
            }
            return true;
        }
        private void ReLoadSV()
        {
            List<DICHVU> dsdichvu = context.DICHVU.ToList();
            BindGrid(dsdichvu);
        }
        private DICHVU TimkiemDV(string DichVu)
        {
            return context.DICHVU.FirstOrDefault(dv => dv.MADICHVU == DichVu);
        }
        public void clear()
        {
            txtMadv.Text = "";
            txtTendv.Text = "";
            txtDonvitinh.Text = " ";
            txtGiadv.Text = "";
        }

        private void dgvDichvu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvDichvu.CurrentRow.Index;
            {

                txtMadv.Text = dgvDichvu.Rows[i].Cells[0].Value.ToString();
                txtTendv.Text = dgvDichvu.Rows[i].Cells[1].Value.ToString();
                txtDonvitinh.Text = dgvDichvu.Rows[i].Cells[2].Value.ToString();
                txtGiadv.Text = dgvDichvu.Rows[i].Cells[3].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (rangbuoc() == false)
            {
                return;
            }
            DICHVU timdv = TimkiemDV(txtMadv.Text);
            if (timdv != null)
            {
                MessageBox.Show("Mã dịch vụ đã tồn tại");
                return;
            }
            DICHVU dv = new DICHVU()
            {
                MADICHVU = txtMadv.Text,
                TENDICHVU = txtTendv.Text,
                DONVITINH = txtDonvitinh.Text,
                GIATIEN = float.Parse(txtGiadv.Text),
            };
            context.DICHVU.Add(dv);
            context.SaveChanges();
            MessageBox.Show("Thêm dịch vụ thành công");
            ReLoadSV();
            clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DICHVU Timdv = TimkiemDV(txtMadv.Text);
            if (Timdv == null)
            {
                MessageBox.Show("Mã dịch vụ không tồn tại");
            }
            else
            {
                Timdv.TENDICHVU = txtTendv.Text;
                Timdv.DONVITINH = txtDonvitinh.Text;
                Timdv.GIATIEN = float.Parse(txtGiadv.Text);
                DialogResult result = MessageBox.Show("Ban dong y sua dịch vụ khong ?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    context.SaveChanges();
                    MessageBox.Show("Sua dich vu thanh cong", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReLoadSV();
                    clear();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            QuanlyCT_DICHVU qlctdv = new QuanlyCT_DICHVU();
            DICHVU Timdv = TimkiemDV(txtMadv.Text);
            if (Timdv == null)
            {
                MessageBox.Show("Mã dịch vụ không tồn tại");
            }
            else
            {
                DialogResult result = MessageBox.Show($"Bạn có chắc chắn xóa dịch vụ.",
                        "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //Dong y xoa 
                if (result == DialogResult.Yes)
                {
                    qlctdv.Xoact_dv(txtMadv.Text);
                    /*context.DICHVUs.Remove(Timdv);
                    //Luu lai thay doi
                    MessageBox.Show("Xóa dịch vụ thành công");
                    context.SaveChanges();
                    ReLoadSV();
                    clear();*/
                }
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string timkiem = txtTimKiem.Text.Trim();
            List<DICHVU> listDV;

            if (!string.IsNullOrEmpty(timkiem))
            {
                listDV = context.DICHVU
                    .Where(s => s.TENDICHVU.Contains(timkiem) || s.MADICHVU.Contains(timkiem))
                    .ToList();
            }
            else
            {
                listDV = context
                    .DICHVU.ToList();
            }
            BindGrid(listDV);
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
