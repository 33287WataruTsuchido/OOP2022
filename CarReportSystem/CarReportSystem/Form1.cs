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

        //カーレポート管理用リスト
        BindingList<CarReport> listCarReports = new BindingList<CarReport>();

        int mode = 0;
        public Form1() {
            InitializeComponent();
            dgvCarReport.DataSource = listCarReports;
        }

        private void btExit_Click(object sender, EventArgs e) {
            //アプリケーションの終了
            Application.Exit();
        }

        private void 設定ToolStripMenuItem_Click(object sender, EventArgs e) {
            //色設定ダイアログの表示
            if (ofdOpenFileDialog.ShowDialog() == DialogResult.OK) {
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
            // TODO: このコード行はデータを 'infosys202200DataSet.CarReportDB' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.carReportDBTableAdapter.Fill(this.infosys202227DataSet.CarReportDB);
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

            CarReport carReport = new CarReport {
                Date = dtpRegistDate.Value,
                Auther = cbAuther.Text,
                Maker = GetRadioButtonMaker(),
                CarName = cbCarName.Text,
                Report = tbReport.Text,
                Picture = pbPicture.Image,
            };
            listCarReports.Add(carReport);

            //EnabledCheck(); //マスク処理呼び出し
            setCbAuther(cbAuther.Text);
            setCbCarName(cbCarName.Text);

        }
        //設定されているメーカーを返す
        private CarReport.MakerGroup GetRadioButtonMaker() {
            if (rbToyota.Checked) {
                return CarReport.MakerGroup.トヨタ;
            }
            if (rbNissan.Checked) {
                return CarReport.MakerGroup.日産;
            }
            if (rbHonda.Checked) {
                return CarReport.MakerGroup.ホンダ;
            }
            if (rbSubaru.Checked) {
                return CarReport.MakerGroup.スバル;
            }
            if (rbGaisya.Checked) {
                return CarReport.MakerGroup.外国車;
            }

            return CarReport.MakerGroup.その他;
        }

        private void btModifyReport_Click(object sender, EventArgs e) {
            listCarReports[dgvCarReport.CurrentRow.Index].Date = dtpRegistDate.Value;
            listCarReports[dgvCarReport.CurrentRow.Index].Auther = cbAuther.Text;
            listCarReports[dgvCarReport.CurrentRow.Index].Maker = GetRadioButtonMaker();
            listCarReports[dgvCarReport.CurrentRow.Index].CarName = cbCarName.Text;
            listCarReports[dgvCarReport.CurrentRow.Index].Report = tbReport.Text;
            listCarReports[dgvCarReport.CurrentRow.Index].Picture = pbPicture.Image;
            dgvCarReport.Refresh(); //データグリッドビュー更新
        }

        private void btDeleteReport_Click(object sender, EventArgs e) {
            listCarReports.RemoveAt(dgvCarReport.CurrentRow.Index);
         

        


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

        private void btOpenReport_Click(object sender, EventArgs e) {
            if (ofdOpenFileDialog.ShowDialog() == DialogResult.OK) {
                try {
                    //バイナリ形式で逆シリアル化
                    var bf = new BinaryFormatter();
                    using (FileStream fs = File.Open(ofdOpenFileDialog.FileName, FileMode.Open, FileAccess.Read)) {
                        //逆シリアル化して読み込む
                        listCarReports = (BindingList<CarReport>)bf.Deserialize(fs);
                        dgvCarReport.DataSource = null;
                        dgvCarReport.DataSource = listCarReports;
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
                cbAuther.Items.Clear();    //コンボボックスのアイテム消去
                cbCarName.Items.Clear();    //コンボボックスのアイテム消去
                //コンボボックスへ新規登録
                foreach (var item in listCarReports.Select(p => p.Auther)) {
                    setCbAuther(item);
                }
                foreach (var item in listCarReports.Select(p => p.CarName)) {
                    setCbCarName(item);
                }
            }
          
        }

        private void btSaveReport_Click(object sender, EventArgs e) {
            if (sfdCarReportSave.ShowDialog() == DialogResult.OK) {
                try {
                    //バイナリ形式でシリアル化
                    var bf = new BinaryFormatter();
                    using (FileStream fs = File.Open(sfdCarReportSave.FileName, FileMode.Create)) {
                        bf.Serialize(fs, listCarReports);
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void carReportDBBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.carReportDBBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202227DataSet);

        }

        private void btAddPerson_Click(object sender, EventArgs e) {
            DataRow newRow = infosys202227DataSet.CarReportDB.NewRow();
            newRow[1] = dtpRegistDate.Value;
            newRow[2] = cbAuther.Text;
            newRow[3] = cbAuther.Text;
            newRow[4] = tbReport.Text;
            newRow[5] = pbPicture.Image;
           
        }
           

            

        

        private void carReportDBDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void carReportDBDataGridView_Click(object sender, EventArgs e) {
            if (carReportDBDataGridView.CurrentRow == null)
                return;
        }

        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void btUpdate_Click(object sender, EventArgs e) {
            carReportDBDataGridView.CurrentRow.Cells[1].Value = dtpRegistDate.Value
            carReportDBDataGridView.CurrentRow.Cells[2].Value = cbAuther.
            carReportDBDataGridView.CurrentRow.Cells[3].Value = 
            carReportDBDataGridView.CurrentRow.Cells[4].Value = tbMail.Text;
            carReportDBDataGridView.CurrentRow.Cells[5].Value = tbMemo.Text;
            carReportDBDataGridView.CurrentRow.Cells[6].Value = ImageToByteArray(pbImage.Image);
        }
    }
}
