using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rdoTamGiac_CheckedChanged(object sender, EventArgs e)
        {
            lblR.Visible = false;
            lblA.Visible = true;
            lblB.Visible = true;
            lblC.Visible = true;
            txtR.Visible = false;
            txtA.Visible = true;
            txtB.Visible = true;
            txtC.Visible = true;
        }

        private void rdoTron_CheckedChanged(object sender, EventArgs e)
        {
            lblR.Visible = true;
            lblA.Visible = false;
            lblB.Visible = false;
            lblC.Visible = false;
            txtR.Visible = true;
            txtA.Visible = false;
            txtB.Visible = false;
            txtC.Visible = false;
        }

        private void rdoChuNhat_CheckedChanged(object sender, EventArgs e)
        {
            lblR.Visible = false;
            lblA.Visible = true;
            lblB.Visible = true;
            lblC.Visible = false;
            txtR.Visible = false;
            txtA.Visible = true;
            txtB.Visible = true;
            txtC.Visible = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtR.Text = string.Empty;
            txtA.Text = string.Empty;
            txtB.Text = string.Empty;
            txtC.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a, b, c, r;
            string str = "";
            bool kt = false;
            if (rdoTamGiac.Checked == true)
            {
                if (chkDienTich.Checked == false && chkChuVi.Checked == false)
                {
                    MessageBox.Show("Vui lòng chọn chu vi hoặc diện tích");
                } else
                { 
                    a = float.Parse(txtA.Text);
                    b = float.Parse(txtB.Text);
                    c = float.Parse(txtC.Text);
                    if (a > 0 && b > 0 && c > 0 && a + b > c && c + b > a && c + a > b)
                    {
                        if (chkChuVi.Checked == true)
                        {
                            kt = true;
                            str += "Chu vi: ";
                            float p = a + b + c;
                            str += p.ToString() + Environment.NewLine;
                        }
                        if (chkDienTich.Checked == true)
                        {
                            kt = true;
                            str += "Diện tích: ";
                            double p = (a + b + c) / 2;
                            p = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                            str += p.ToString();
                        }
                    }
                    else
                    {
                        txtA.Text = string.Empty;
                        txtB.Text = string.Empty;
                        txtC.Text = String.Empty;
                        MessageBox.Show("Đây không phải là 3 cạnh của một tam giác");
                    }
                }
            }
            else if (rdoChuNhat.Checked == true)
            {
                if (chkDienTich.Checked == false && chkChuVi.Checked == false)
                {
                    MessageBox.Show("Vui lòng chọn chu vi hoặc diện tích");
                }
                else{
                    a = float.Parse(txtA.Text);
                    b = float.Parse(txtB.Text);
                    if (a > 0 && b > 0)
                    {
                        if (chkChuVi.Checked == true)
                        {
                            kt = true;
                            str += "Chu vi: ";
                            float p = (a + b) * 2;
                            str += p.ToString() + Environment.NewLine;
                        }
                        if (chkDienTich.Checked == true)
                        {
                            kt = true;
                            str += "Diện tích: ";
                            float p = a * b;
                            str += p.ToString();
                        }
                    }
                    else
                    {
                        txtA.Text = string.Empty;
                        txtB.Text = string.Empty;
                        MessageBox.Show("Đây không phải là 2 cạnh của một hình chữ nhật");
                    }
                }
            }
            else if (rdoTron.Checked == true)
            {
                if (chkDienTich.Checked == false && chkChuVi.Checked == false)
                {
                    MessageBox.Show("Vui lòng chọn chu vi hoặc diện tích");
                } else
                {
                    r = float.Parse(txtR.Text);
                    if (r > 0)
                    {
                        if (chkChuVi.Checked == true)
                        {
                            kt = true;
                            str += "Chu vi: ";
                            float p = 2 * r * 3.14f;
                            str += p.ToString() + Environment.NewLine;
                        }
                        if (chkDienTich.Checked == true)
                        {
                            kt = true;
                            str += "Diện tích: ";
                            float p = r * r * 3.14f;
                            str += p.ToString();
                        }
                    }
                    else
                    {
                        txtR.Text = string.Empty;
                        MessageBox.Show("Đây không phải bán kính của một hình tròn");
                    }
                }
            } else MessageBox.Show("Chưa tích chọn hình", "LỖI!");
            if (kt) MessageBox.Show(str, "Kết quả");
        }
    }
}
