using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace CarReportSystem {
    public partial class Form1 : Form {
        //設定情報保存用オブジェクト 
        Settings settings = Settings.getInstance(); //シングルトン

      

        int mode = 0;
        public Form1() {
            InitializeComponent();
         
        }

        private void btExit_Click(object sender, EventArgs e) {
            //アプリケーションの終了
            Application.Exit();
        }

        private void 設定ToolStripMenuItem_Click(object sender, EventArgs e) {
            //色設定ダイアログの表示
            if (colorDialog.ShowDialog() == DialogResult.OK) {
                BackColor = colorDialog.Color;
                settings.MainFromColor = colorDialog.Color.ToArgb();   //設定オブジェクトへセット
            }


        }

        private void pbModeSelect_Click(object sender, EventArgs e) {
            pbPicture.SizeMode = (PictureBoxSizeMode)mode;
            mode = mode < 4 ? ++mode : 0;

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {

            //設定ファイルをシリアル化（P305）
            using (var writer = XmlWriter.Create("settings.xml")) {
                var serializer = new XmlSerializer(settings.GetType());
                serializer.Serialize(writer, settings);
            }
        }

        private void Form1_Load(object sender, EventArgs e) {

            try {
                //設定ファイルを逆シリアル化（P307）して背景の色を設定
                using (var reader = XmlReader.Create("settings.xml")) {
                    var serializer = new XmlSerializer(typeof(Settings));
                    settings = serializer.Deserialize(reader) as Settings;
                    BackColor = Color.FromArgb(settings.MainFromColor);
                }
            }
            catch (Exception) {

            }


        }

        private void btAddReport_Click(object sender, EventArgs e) {
            //氏名が未入力なら登録しない
            if (String.IsNullOrWhiteSpace(cbAuther.Text)) {
                MessageBox.Show("氏名が入力されていません");
                return;
            }
            //各テキストボックスからデータグリッドビューへの設定
            DataRow newRow = infosys202227DataSet.CarReportDB.NewRow();
            newRow[1] = dtpRegistDate.Value;
            newRow[2] = cbAuther.Text;
            newRow[3] = GetRadioButtonMaker();
            newRow[4] = cbCarName.Text;
            newRow[5] = tbReport.Text;
            newRow[6] = ImageToByteArray(pbPicture.Image);
            //データセットへ新しいレコードを追加
            infosys202227DataSet.CarReportDB.Rows.Add(newRow);
            //データベース更新
            this.carReportDBTableAdapter.Update(this.infosys202227DataSet.CarReportDB);

            //データセットの中をデータベースへ反映（保存）
            this.Validate();
            this.carReportDBBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202227DataSet);

            //EnabledCheck(); //マスク処理呼び出し
            setCbAuther(cbAuther.Text);
            setCbCarName(cbCarName.Text);

        }
        //設定されているメーカーを返す
        private string GetRadioButtonMaker() {
            if (rbToyota.Checked) {
                return "トヨタ";
            }
            if (rbNissan.Checked) {
                return "日産";
            }
            if (rbHonda.Checked) {
                return "ホンダ";
            }
            if (rbSubaru.Checked) {
                return "スバル";
            }
            if(rbGaisya.Checked) {
                return "外車";
            }

            return "その他";
        }

        private void btModifyReport_Click(object sender, EventArgs e) {
            dgvCars.CurrentRow.Cells[1].Value = dtpRegistDate.Value;
            dgvCars.CurrentRow.Cells[2].Value = cbAuther.Text;
            dgvCars.CurrentRow.Cells[3].Value = GetRadioButtonMaker();
            dgvCars.CurrentRow.Cells[4].Value = cbCarName.Text;
            dgvCars.CurrentRow.Cells[5].Value = tbReport.Text;
            dgvCars.CurrentRow.Cells[6].Value = ImageToByteArray(pbPicture.Image);

        }

        //コンボボックスに記録者を登録する（重複なし）
        private void setCbAuther(string company) {
            if (!cbAuther.Items.Contains(company)) {
                //まだ登録されていなければ登録処理
                cbAuther.Items.Add(company);
            }
        }
        //コンボボックスに車名を登録する（重複なし）
        private void setCbCarName(string company) {
            if (!cbCarName.Items.Contains(company)) {
                //まだ登録されていなければ登録処理
                cbCarName.Items.Add(company);
            }
        }

        private void btPictureOpen_Click(object sender, EventArgs e) {
            if (ofdOpenFileDialog.ShowDialog() == DialogResult.OK) {
                pbPicture.Image = Image.FromFile(ofdOpenFileDialog.FileName);
            }
        }

        private void btPictureDelete_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }

        private void SetMakerRadioset(string maker) {
            switch (maker) {
                case "トヨタ":
                    rbToyota.Checked = true;
                    break;
                case "日産":
                    rbNissan.Checked = true;
                    break;
                case "ホンダ":
                    rbHonda.Checked = true;
                    break;
                case "スバル":
                    rbSubaru.Checked = true;
                    break;
                case "外車":
                    rbGaisya.Checked = true;
                    break;
                case "その他":
                    rbOther.Checked = true;
                    break;



            }
        }
        private void carReportDBDataGridView_Click(object sender, EventArgs e) {
            if (dgvCars.CurrentRow == null)
                return;

            dtpRegistDate.Value = (DateTime)dgvCars.CurrentRow.Cells[1].Value;
            cbAuther.Text = dgvCars.CurrentRow.Cells[2].Value.ToString();
            dgvCars.CurrentRow.Cells[3].Value.ToString();
            cbCarName.Text = dgvCars.CurrentRow.Cells[4].Value.ToString();
            tbReport.Text = dgvCars.CurrentRow.Cells[5].Value.ToString();
            if (!(dgvCars.CurrentRow.Cells[6].Value is DBNull))
                pbPicture.Image = ByteArrayToImage((byte[])dgvCars.CurrentRow.Cells[6].Value);

            else
                pbPicture.Image = null;
        }

        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void btUpdate_Click(object sender, EventArgs e) {

            dgvCars.CurrentRow.Cells[1].Value = dtpRegistDate.Value;
            dgvCars.CurrentRow.Cells[2].Value = cbAuther.Text;
            dgvCars.CurrentRow.Cells[3].Value = GetRadioButtonMaker();
            dgvCars.CurrentRow.Cells[4].Value = cbCarName.Text;
            dgvCars.CurrentRow.Cells[5].Value = tbReport.Text;
            dgvCars.CurrentRow.Cells[6].Value = ImageToByteArray(pbPicture.Image);


            //データセットの中をデータベースへ反映（保存）
            this.Validate();
            this.carReportDBBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202227DataSet);
        }


        

        // バイト配列をImageオブジェクトに変換
        public static Image ByteArrayToImage(byte[] b) {
            try {
                ImageConverter imgconv = new ImageConverter();
                Image img = (Image)imgconv.ConvertFrom(b);
                return img;
            }
            catch (Exception) {
                return null;
            }
            
        }

        // Imageオブジェクトをバイト配列に変換
        public static byte[] ImageToByteArray(Image img) {
            ImageConverter imgconv = new ImageConverter();
            byte[] b = (byte[])imgconv.ConvertTo(img, typeof(byte[]));
            return b;
        }

        private void データベース接続ToolStripMenuItem_Click(object sender, EventArgs e) {
            this.carReportDBTableAdapter.Fill(this.infosys202227DataSet.CarReportDB);
        }

        private void btSearch(object sender, EventArgs e) {
  
        }

        private void dgvCars_DataError(object sender, DataGridViewDataErrorEventArgs e) {

        }

        private void btDelete_Click(object sender, EventArgs e) {
            dgvCars.Rows.RemoveAt(dgvCars.CurrentRow.Index);

            this.Validate();
            this.carReportDBBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202227DataSet);
        }

        private void btPictureClear_Click(object sender, EventArgs e) {
            pbPicture.Image  = null;
        }

        private void tbSearch_TextChanged(object sender, EventArgs e) {

        }
    }
}
