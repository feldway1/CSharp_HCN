using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_HCN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btncv_Click(object sender, EventArgs e)
        {
            if (txtA.Text == "" || txtB.Text == "")
            {
                MessageBox.Show("Phải nhập chiều ngang và dọc");
                return;
            }
            Double a, b, S, P;
            a = Convert.ToDouble(txtA.Text);
            b = Convert.ToDouble(txtB.Text);
            P = 2 * (a + b);
            txtketqua.Text=P.ToString();

        }

        private void btndt_Click(object sender, EventArgs e)
        {
            if (txtA.Text == "" || txtB.Text == "")
            {
                MessageBox.Show("Phải nhập chiều ngang và dọc");
                return;
            }
            Double a, b, S, P;
            a = Convert.ToDouble(txtA.Text);
            b = Convert.ToDouble(txtB.Text);
            S = a * b;
            txtketqua.Text = S.ToString();

        }

        private void btnthoat_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnthoat1_Click(object sender, EventArgs e)
        {
            this.Close ();  
        }

        private void btntinh_Click(object sender, EventArgs e)
        {
            if(rdbchuvi.Checked)
            {
                lbltinh.Text = "Chu vi";
                if (txtA.Text == "" || txtB.Text == "")
                {
                    MessageBox.Show("Phải nhập chiều ngang và dọc");
                    return;
                }
                Double a, b, S, P;
                a = Convert.ToDouble(txtA.Text);
                b = Convert.ToDouble(txtB.Text);
                P = 2 * (a + b);
                txtketqua.Text = P.ToString();

            }
            if (rdbdientich.Checked)
            {
                lbltinh.Text = "Diện tích";
                if (txtA.Text == "" || txtB.Text == "")
                {
                    MessageBox.Show("Phải nhập chiều ngang và dọc");
                    return;
                }
                Double a, b, S, P;
                a = Convert.ToDouble(txtA.Text);
                b = Convert.ToDouble(txtB.Text);
                S = a * b;
                txtketqua.Text = S.ToString();
            }
        }
    }
}
