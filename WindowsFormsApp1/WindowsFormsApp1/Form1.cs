using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DTO;
using WindowsFormsApp1.BLL;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            khoaBLL.HienThi(dgv);
        }

        KhoaBLL khoaBLL = new KhoaBLL();
        KhoaDTO khoaDTO = new KhoaDTO();

        private void buttonThem_Click(object sender, EventArgs e)
        {
            if (txtMaKhoa.Text.Trim() != "")
            {
                khoaDTO.MKhoa1 = txtMaKhoa.Text.ToLower();
                khoaDTO.TKhoa1 = txtTenKhoa.Text;
                khoaDTO.SDTKhoa1 = txtSDT.Text;
                khoaBLL.Them(khoaDTO);
                khoaBLL.HienThi(dgv);
            }

        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            if (txtMaKhoa.Text.Trim() != "")
            {
                khoaDTO.MKhoa1 = txtMaKhoa.Text.ToLower();
                khoaDTO.TKhoa1 = txtTenKhoa.Text;
                khoaDTO.SDTKhoa1 = txtSDT.Text;
                khoaBLL.Sua(khoaDTO);
                khoaBLL.HienThi(dgv);
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (txtMaKhoa.Text.Trim() != "")
            {
                //gán dữ liệu vào DTO
                khoaDTO.MKhoa1 = txtMaKhoa.Text.ToLower();
                khoaBLL.Xoa(khoaDTO);
                khoaBLL.HienThi(dgv);
            }
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            if (indexRow >= 0 && indexRow < dgv.RowCount - 1)
            {
                txtMaKhoa.Text = dgv.Rows[indexRow].Cells[0].Value.ToString();
                txtTenKhoa.Text = dgv.Rows[indexRow].Cells[1].Value.ToString();
                txtSDT.Text = dgv.Rows[indexRow].Cells[2].Value.ToString();

            }
        }

        private void buttonHT_Click(object sender, EventArgs e)
        {

        }
    }
}
