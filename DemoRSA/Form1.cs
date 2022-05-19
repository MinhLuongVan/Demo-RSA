using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoRSA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void ClearAll()
        {
            txtP.Clear();
            txtQ.Clear();
            txtE.Clear();
            txtD.Clear();
            txtN.Clear();
            txtPhiN.Clear();
            txtMMa.Clear();
            txtCMa.Clear();
            txtMGiai.Clear();
            txtCGiai.Clear();
            labd.Text = "(d)";
            laben.Text = "(E,N)";
            txtP.Focus();
        }
        public static bool KTNT(int n)
        {
            if (n < 2) return false;
            for(int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int Q = Convert.ToInt32(txtQ.Text);
                int P = Convert.ToInt32(txtP.Text);
                if(P == Q)
                {
                    MessageBox.Show("Vui lòng nhập P khác Q");
                }
              else
                {
                   
                    if (KTNT(P) == false)
                    {
                        MessageBox.Show("Không hợp lệ.Vui lòng nhập P là số nguyên tố");
                    }
                    else
                    {
                        if (KTNT(Q) == false)
                        {
                            MessageBox.Show("Không hợp lệ.Vui lòng nhập Q là số nguyên tố");
                        }
                        else
                        {
                            int kq = (P * Q);
                            txtN.Text = kq.ToString();
                        }
                    }
                } 

            }
            catch
            {
                MessageBox.Show("Vui lòng nhập đúng và đủ thông tin");
            }
        }

        private void btnPhiN_Click(object sender, EventArgs e)
        {
            try
            {
                int P = Convert.ToInt32(txtP.Text);
                int Q = Convert.ToInt32(txtQ.Text);
                int kq = (P -1) * (Q-1);
                txtPhiN.Text = kq.ToString();

            }
            catch
            {
                MessageBox.Show("Vui lòng nhập đúng và đủ thông tin");
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            int P = Convert.ToInt32(txtP.Text);
            int Q = Convert.ToInt32(txtQ.Text);
            int kq = (P - 1) * (Q - 1);
            int c = Convert.ToInt32(txtN.Text);
            int d = Convert.ToInt32(txtE.Text);
            int v = Convert.ToInt32(txtPhiN.Text);
            int n = Convert.ToInt32(txtPhiN.Text);
            int m = Convert.ToInt32(txtE.Text);
                if (KTNT(m) == true && m > 0 && m < kq)
                {
                    int a0 = 1, a1 = 0;
                    int x, y, kq1 = 0;
                    while (n > 0)
                    {
                        x = m % n;
                        if (x == 0)
                        {
                            break;
                        }
                        else
                        {
                            y = m / n;
                            kq1 = a0 - a1 * y;
                            m = n;
                            n = x;
                            a0 = a1;
                            a1 = kq1;

                        }
                    }
                    if (n > 1)
                    {
                        MessageBox.Show("Không có phần tử nghịch đảo !");
                    }
                    if (kq1 < 0)
                    {
                        txtD.Text = (kq1+v).ToString();
                        labd.Text = "("+(kq1+v)+")";
                     }
                    else
                    {
                        txtD.Text = kq1.ToString();
                        labd.Text = "("+kq1+")";
                    }
                    laben.Text = "("+d+" , "+c+")";
                }
                else 
                {
                    MessageBox.Show("E không hợp lệ.Vui lòng nhập SNT 0 < E < ΦN "); 
                }
               
        }
        public   int BinhPhuongVaNhan(int a,int x, int n)
        {
            int d = 1;
            while(x != 0)
            {
                if(x%2 != 0)
                {
                    d = (a * d) % n;
                }
                x = x / 2;
                a = (a * a) % n;
            }
            return d;
           
        }
        private void btnMaHoa_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtMMa.Text);
            int P = Convert.ToInt32(txtP.Text);
            int Q = Convert.ToInt32(txtQ.Text);
            int kq = (P * Q);
            if (a < 0 || a > kq - 1)
            {
                MessageBox.Show("M không hợp lệ");
            }
            else
            {
                int x = Convert.ToInt32(txtE.Text);
                int n = Convert.ToInt32(txtN.Text);
                int kq1 = BinhPhuongVaNhan(a, x, n);
                txtCMa.Text = kq1.ToString();
                txtCGiai.Text = kq1.ToString();
            }
        }

        private void linkResert_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClearAll();
        }

        private void btnGiaiMa_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtCMa.Text);
            int x = Convert.ToInt32(txtD.Text);
            int n = Convert.ToInt32(txtN.Text);
            int kq = BinhPhuongVaNhan(a, x, n);
            txtMGiai.Text = kq.ToString();
            
        }
        private void labelC_Click(object sender, EventArgs e)
        {
        }
        private void txtMMa_TextChanged(object sender, EventArgs e)
        {  
        }
        private void label4_Click(object sender, EventArgs e)
        {
            int P = Convert.ToInt32(txtP.Text);
            int Q = Convert.ToInt32(txtQ.Text);
            int kq = (P * Q);
            txtN.Text = kq.ToString();
            Random rand = new Random();
            long m = rand.Next(0, (kq - 1));
            txtMMa.Text = m.ToString();
        }
        private void btnTuSinh_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            int p = rd.Next(2,100);
            while(KTNT(p)== false)
            {
                 p = rd.Next(2, 100);
             }
            txtP.Text = p.ToString();
            int q = rd.Next(2, 100);
            while (KTNT(q) == false)
            {
                q = rd.Next(2, 100);
            }
            txtQ.Text = q.ToString();
            int P = Convert.ToInt32(txtP.Text);
            int Q = Convert.ToInt32(txtQ.Text);
            int kq = (P - 1) * (Q - 1);
            int E = rd.Next(0, kq);
            while (KTNT(E) == false || E >= kq || E <= 0)
            {
                E = rd.Next(2, kq);
            }
            txtE.Text = E.ToString();
        }
    }
}
