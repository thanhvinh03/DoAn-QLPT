using P1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P1
{
    public partial class QuanlyCT_TienNghi : Form
    {
        QLPTContextDB Context;
      


        public QuanlyCT_TienNghi()
        {
            Context = new QLPTContextDB();
            InitializeComponent();
        }
        private void FillFalcultyComboboxMAHD(List<HOPDONG> listHopDong)
        {
            listHopDong.Insert(0, new HOPDONG());
            cmbMaHopDong.DataSource = listHopDong;
            cmbMaHopDong.ValueMember = "MAHD";
        }
        private void FillFalcultyComboboxMATN(List<TIENNGHI> listTienNghi)
        {
            listTienNghi.Insert(0, new TIENNGHI());
            cmbMaTienNghi.DataSource = listTienNghi;
            cmbMaTienNghi.ValueMember = "MATIENNGHI";
        }
        private void BindGrid(List<CT_TIENNGHI> listCT_TienNghi)
        {
            dgvCT_TienNghi.Rows.Clear();
            foreach (var item in listCT_TienNghi)
            {
                int index = dgvCT_TienNghi.Rows.Add();
                //dgvCT_TienNghi.Rows[index].Cells[0].Value = item.;
                dgvCT_TienNghi.Rows[index].Cells[0].Value = item.MAHD;
                dgvCT_TienNghi.Rows[index].Cells[1].Value = item.MATIENNGHI;
                dgvCT_TienNghi.Rows[index].Cells[2].Value = item.SOLUONGTN;
                dgvCT_TienNghi.Rows[index].Cells[3].Value = item.THANHTIENTN;

            }
        }
        private void QuanlyCT_TienNghi_Load(object sender, EventArgs e)
        {
            try
            {
                QLPTContextDB context = new QLPTContextDB();
                List<CT_TIENNGHI> listCT_TienNghi = Context.CT_TIENNGHI.ToList();
                List<HOPDONG> listHopDong = Context.HOPDONG.ToList();
                List<TIENNGHI> listTienNghi = Context.TIENNGHI.ToList();
                FillFalcultyComboboxMAHD(listHopDong);
                FillFalcultyComboboxMATN(listTienNghi);

                foreach (CT_TIENNGHI listCT_TN in listCT_TienNghi)
                {
                    if (listCT_TN.THANHTIENTN == null)
                    {
                        listCT_TN.THANHTIENTN = 0;
                    }
                }
                BindGrid(listCT_TienNghi);

                AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
                foreach (var item in listCT_TienNghi)
                {
                    auto.Add(item.MAHD);
                    auto.Add(item.MATIENNGHI);
                }
                txtTimKiemCT_TN.AutoCompleteCustomSource = auto;
                txtTimKiemCT_TN.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtTimKiemCT_TN.AutoCompleteSource = AutoCompleteSource.CustomSource;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvCT_TienNghi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvCT_TienNghi.CurrentRow.Selected = true;
            cmbMaHopDong.SelectedIndex = cmbMaHopDong.FindString(dgvCT_TienNghi.Rows[e.RowIndex].Cells[0].Value.ToString());
            cmbMaTienNghi.SelectedIndex = cmbMaTienNghi.FindString(dgvCT_TienNghi.Rows[e.RowIndex].Cells[1].Value.ToString());
            txtSoLuong.Text = dgvCT_TienNghi.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtThanhTien.Text = dgvCT_TienNghi.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
        public void RefeshData()
        {
            cmbMaTienNghi.SelectedIndex = 0;
            cmbMaHopDong.SelectedIndex = 0;
            txtSoLuong.Text = "";
            txtThanhTien.Text = "";
        }
        private void ReLoadDSCT_TN()
        {         
            List<CT_TIENNGHI> listCT_TienNghi = Context.CT_TIENNGHI.ToList();
            List<HOPDONG> listHopDong = Context.HOPDONG.ToList();
            List<TIENNGHI> listTienNghi = Context.TIENNGHI.ToList();
            FillFalcultyComboboxMAHD(listHopDong);
            FillFalcultyComboboxMATN(listTienNghi);
            BindGrid(listCT_TienNghi);
        }
        private  CT_TIENNGHI TimKiemCT_TN(String MaTN, string MaHD)
        {
            return Context.CT_TIENNGHI.FirstOrDefault(tn => tn.MATIENNGHI == MaTN && tn.MAHD == MaHD);
        }
        public List<CT_TIENNGHI> timtheoma (string matn, string hopdong)
        {
            var cttn = Context.CT_TIENNGHI.Where(s=> s.MATIENNGHI.Contains(matn) || s.MAHD.Contains(hopdong)).ToList() ;
            return cttn ;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            CT_TIENNGHI timCT_TN = TimKiemCT_TN(cmbMaTienNghi.Text, cmbMaHopDong.Text);
            if (timCT_TN != null)
            {
                MessageBox.Show("Mã số này tồn tại nên không thêm được");
                return;
            }
            CT_TIENNGHI ct_tn = new CT_TIENNGHI()
            {
                MATIENNGHI = cmbMaTienNghi.Text,
                MAHD = cmbMaHopDong.Text,
                SOLUONGTN = int.Parse(txtSoLuong.Text),              
            };
            Context.CT_TIENNGHI.Add(ct_tn);
            Context.SaveChanges();
            MessageBox.Show("Thêm tiện nghi thành Công ");
            ReLoadDSCT_TN();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
           
            CT_TIENNGHI TimCT_TN = TimKiemCT_TN(cmbMaTienNghi.Text, cmbMaHopDong.Text);
            if (TimCT_TN == null)
            {
                MessageBox.Show("Mã số hợp đồng hoặc mã dịch vụ không tồn tại");
            }
            else
            {
                //TimCTDV.MAHD = cbbMaHD.Text;
                //TimCTDV.MADICHVU = cbbMdv.SelectedValue.ToString();
                TimCT_TN.SOLUONGTN = int.Parse(txtSoLuong.Text);
                TimCT_TN.THANHTIENTN = float.Parse(txtThanhTien.Text);
                DialogResult result = MessageBox.Show(" Bạn đồng ý sửa không ?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Context.SaveChanges();
                    MessageBox.Show("Sửa thành công", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReLoadDSCT_TN();
                    RefeshData();
                       //TinhThanhTien();

                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            CT_TIENNGHI TimCT_TN = TimKiemCT_TN(cmbMaTienNghi.Text, cmbMaHopDong.Text);
            if (TimCT_TN == null)
            {
                MessageBox.Show("Mã số này không tồn tại");
            }
            else
            {
                DialogResult result = MessageBox.Show(" Bạn đồng ý xóa không ?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //Dong y xoa 
                if (result == DialogResult.Yes)
                {
                    Context.CT_TIENNGHI.Remove(TimCT_TN);
                    //Luu lai thay doi
                    Context.SaveChanges();
                    MessageBox.Show("Xóa thành công", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReLoadDSCT_TN();
                    //Load lai data

                }
            }
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            RefeshData();
        }

        private void txtTimKiemCT_TN_TextChanged(object sender, EventArgs e)
        {
            string timkiem = txtTimKiemCT_TN.Text.Trim();
            List<CT_TIENNGHI> listcttn;

            if (!string.IsNullOrEmpty(timkiem))
            { 
                listcttn = Context.CT_TIENNGHI
                    .Where(s => s.MATIENNGHI.Contains(timkiem) || s.MAHD.Contains(timkiem))
                    .ToList();
            }
            else
            {
                listcttn = Context.CT_TIENNGHI.ToList();
            }
            BindGrid(listcttn);

        }
    }
}
