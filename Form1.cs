using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_dangkymonhoc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_load(object sender, EventArgs e)
        {

            for (int i = 2020; i <= 2025; i++)
            {
                cbxNienkhoa.Items.Add(i.ToString());
            }
            cbxNienkhoa.SelectedIndex = 5;
            cbxLop.Items.Add("Ứng dụng phần mềm 1");
            cbxLop.Items.Add("Ứng dụng phần mềm 2");
            cbxLop.Items.Add("Ứng dụng phần mềm 3");
            cbxLop.Items.Add("Thiết kế đồ họa 1");
            cbxLop.Items.Add("Thiết kế đồ họa 2");
            cbxLop.Items.Add("Thiết kế đồ họa 3");
            cbxLop.Items.Add("Quản trị mạng 1");
            cbxLop.Items.Add("Quản trị mạng 2");
            cbxLop.Items.Add("Quản trị mạnh 3");
            /*( string[] lopArray = { "Ứng dụng phần mềm 1", "Ứng dụng phần mềm 2", "Ứng dụng phần mềm 3", "Thiết kế đồ họa 1", "Thiết kế đồ họa 2", "Thiết kế đồ họa 3", "Quản trị mạng 1", "Quản trị mạng 2", "Quản trị mạng 3" };
             foreach (var items in lopArray)
             {
                 cbxLop.Items.Add(items);
             }*/
            rdb1.Checked = true;
            LTWin.Items.Add("LT Win", CheckState.Checked);
            LTWin.Items.Add("LT Internet", CheckState.Checked);
            LTWin.Items.Add("Mạng máy tính", CheckState.Checked);
            LTWin.Items.Add("UML", CheckState.Checked);
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbxNienkhoa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDangky_Click(object sender, EventArgs e)
        {
            string thongtin;
            thongtin = "Mã số sinh viên: " + txtMSSV.Text;
            thongtin = "\nHọ và tên: " + txtHovaten.Text;
            thongtin = "\nNiên khóa: " + cbxNienkhoa.SelectedItem;
            thongtin = "\nLớp:" + cbxLop.SelectedItem;
            string hocky = "";
            if (rdb1.Checked)
            {
                hocky = rdb1.Text;
            }
            else if (rdb2.Checked)
            {
                hocky = rdb2.Text;
            }
            else if (rdb3.Checked)
            {
                hocky = rdb3.Text;
            }
            else if (rdb4.Checked)
            {
                hocky = rdb4.Text;
            }
            thongtin += "\nĐã đăng ký học kỳ " + hocky + " các môn học sau:";
            int stt = 1;
            foreach (var item in LTWin.CheckedItems)
            {
                thongtin += "\n" + stt + " " + item.ToString();
                stt++;
            }
            MessageBox.Show(thongtin, "Thông tin sinh viên");
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

            for (int i = 2020; i <= 2025; i++)
            {
                cbxNienkhoa.Items.Add(i.ToString());
            }
            cbxNienkhoa.SelectedIndex = 5;
            cbxLop.Items.Add("Ứng dụng phần mềm 1");
            cbxLop.Items.Add("Ứng dụng phần mềm 2");
            cbxLop.Items.Add("Ứng dụng phần mềm 3");
            cbxLop.Items.Add("Thiết kế đồ họa 1");
            cbxLop.Items.Add("Thiết kế đồ họa 2");
            cbxLop.Items.Add("Thiết kế đồ họa 3");
            cbxLop.Items.Add("Quản trị mạng 1");
            cbxLop.Items.Add("Quản trị mạng 2");
            cbxLop.Items.Add("Quản trị mạnh 3");
            /*( string[] lopArray = { "Ứng dụng phần mềm 1", "Ứng dụng phần mềm 2", "Ứng dụng phần mềm 3", "Thiết kế đồ họa 1", "Thiết kế đồ họa 2", "Thiết kế đồ họa 3", "Quản trị mạng 1", "Quản trị mạng 2", "Quản trị mạng 3" };
             foreach (var items in lopArray)
             {
                 cbxLop.Items.Add(items);
             }*/
            rdb1.Checked = true;
            LTWin.Items.Add("LT Win", CheckState.Checked);
            LTWin.Items.Add("LT Internet", CheckState.Checked);
            LTWin.Items.Add("Mạng máy tính", CheckState.Checked);
            LTWin.Items.Add("UML", CheckState.Checked);
        }
    }
}


