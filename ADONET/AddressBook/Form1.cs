﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void addressTableBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.addressTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202227DataSet);

        }

        private void Form1_Load(object sender, EventArgs e) {
    

        }

        private void btConnect_Click(object sender, EventArgs e) {
            // TODO: このコード行はデータを 'infosys202221DataSet.AddressTable' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.addressTableTableAdapter.Fill(this.infosys202227DataSet.AddressTable);
        }

        private void btAdd_Click(object sender, EventArgs e) {
            DataRow newRow = infosys202227DataSet.AddressTable.NewRow();
            newRow[1] = tbName.Text;
            newRow[2] = tbAddress.Text;
            //データセットへ新しいレコードを追加
            infosys202227DataSet.AddressTable.Rows.Add(newRow);
            //データベース更新
            this.addressTableTableAdapter.Update(this.infosys202227DataSet.AddressTable);
           
        }

        private void btUpdate_Click(object sender, EventArgs e) {
            //各テキストボックスからデータグリッドビューへの設定
            addressTableDataGridView.CurrentRow.Cells[1].Value = tbName.Text;
            addressTableDataGridView.CurrentRow.Cells[2].Value = tbAddress.Text;
            addressTableDataGridView.CurrentRow.Cells[3].Value = tbTel.Text;
            addressTableDataGridView.CurrentRow.Cells[4].Value = tbMail.Text;
            addressTableDataGridView.CurrentRow.Cells[5].Value = tbMemo.Text;
            addressTableDataGridView.CurrentRow.Cells[6].Value = ImageToByteArray(pbImage.Image);

            //データセットの中をデータベースへ反映（保存）
            this.Validate();
            this.addressTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202227DataSet);
        }

        private void addressTableDataGridView_Click(object sender, EventArgs e) {
            //データグリッドビューの選択レコードを各テキストボックスへ設定
            tbName.Text = addressTableDataGridView.CurrentRow.Cells[1].Value.ToString();
            tbAddress.Text = addressTableDataGridView.CurrentRow.Cells[2].Value.ToString();
            tbTel.Text = addressTableDataGridView.CurrentRow.Cells[3].Value.ToString();
            tbMail.Text = addressTableDataGridView.CurrentRow.Cells[4].Value.ToString();
            tbMemo.Text = addressTableDataGridView.CurrentRow.Cells[5].Value.ToString();
            if (!(addressTableDataGridView.CurrentRow.Cells[6].Value is DBNull)) 
                pbImage.Image = ByteArrayToImage((byte[])addressTableDataGridView.CurrentRow.Cells[6].Value);

                else
                    pbImage.Image = null;
                    
            
        }

        private void btImageOpen_Click(object sender, EventArgs e) {
            ofdFileOpen.Filter = "画像ファイル(*.jpg;*.png;*.bmp)| *.jpg;*.png;*.bmp.";
            if (ofdFileOpen.ShowDialog() == DialogResult.OK) {
                pbImage.Image = System.Drawing.Image.FromFile(ofdFileOpen.FileName);

            }
        }

        private void btImageDel_Click(object sender, EventArgs e) {
            pbImage.Image = null;
        }

        // バイト配列をImageオブジェクトに変換
        public static Image ByteArrayToImage(byte[] b) {
            ImageConverter imgconv = new ImageConverter();
            Image img = (Image)imgconv.ConvertFrom(b);
            return img;
        }

        // Imageオブジェクトをバイト配列に変換
        public static byte[] ImageToByteArray(Image img) {
            ImageConverter imgconv = new ImageConverter();
            byte[] b = (byte[])imgconv.ConvertTo(img, typeof(byte[]));
            return b;
        }

        private void addressTableDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (addressTableDataGridView.CurrentRow == null)
                return;
        }

        private void btSearch_Click(object sender, EventArgs e) {
            addressTableTableAdapter.FillBy(infosys202227DataSet.AddressTable, tbSearch.Text);
        }

        private void btClear_Click(object sender, EventArgs e) {
            tbName.Text = null;
            tbAddress.Text = null;
            tbTel.Text = null;
            tbMail.Text = null;
            tbMemo.Text = null;
            tbSearch.Text = null;
        }

        private void 接続ToolStripMenuItem_Click(object sender, EventArgs e) {
            // TODO: このコード行はデータを 'infosys202221DataSet.AddressTable' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.addressTableTableAdapter.Fill(this.infosys202227DataSet.AddressTable);
        }

        private void ファイルFToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void btSearchClear_Click(object sender, EventArgs e) {
            // TODO: このコード行はデータを 'infosys202221DataSet.AddressTable' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.addressTableTableAdapter.Fill(this.infosys202227DataSet.AddressTable);
        }

        

        private void バージョン情報ToolStripMenuItem_Click(object sender, EventArgs e) {
            new Version().ShowDialog();
        }

        private void addressTableBindingSource_CurrentChanged(object sender, EventArgs e) {

        }
    }
}
