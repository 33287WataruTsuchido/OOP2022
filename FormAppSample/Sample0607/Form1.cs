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
      
        // Random クラスのインスタンス生成
        Random rand = new Random();

        public Form1() {
            InitializeComponent();
        }

        private void btRandom_Click(object sender, EventArgs e) {
            Number.Value= rand.Next(minValue: 10, maxValue: 1000);
          

        }
            

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e) {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e) {

        }
    }
}   