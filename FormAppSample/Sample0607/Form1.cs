using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample0607 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {

            if (int.Parse(tbNum2.Text) != 0) {
                tbMod.Text = (int.Parse(tbNum1.Text) % int.Parse(tbNum2.Text)).ToString();
                tbAns.Text = (int.Parse(tbNum1.Text) / int.Parse(tbNum2.Text)).ToString();
            }
            else { 
            MessageBox.Show("正しい値を入力してください。",
                "エラー",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void tbNum2_TextChanged(object sender, EventArgs e) {

        }

        private void tbNum1_TextChanged(object sender, EventArgs e) {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }
    }
}
