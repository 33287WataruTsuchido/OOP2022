using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberGame {
    public partial class Form1 : Form {

        private Random rand = new Random(); //乱数オブジェクト取得
        private int randomNumber;

        public Form1() {


            InitializeComponent();
        }
        //アプリケーション起動時に一度だけ呼ばれるハンドラ
        private void Form1_Load(object sender, EventArgs e) {

            //乱数取得
            randomNumber = rand.Next(1, (int)maxNum.Value);
            this.Text = randomNumber.ToString();
        }

        private void button1_Click(object sender, EventArgs e) {
            //入力した値とあらかじめ指定した乱数を比較し結果を表示
            if (randomNumber > Number.Value)
                

        }
              
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void statusStrip3_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {

        }
    }
}