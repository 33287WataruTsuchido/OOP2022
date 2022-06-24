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

namespace AddressBook {
    public partial class Form1 : Form {
        //住所データ管理用リスト 
        BindingList<Person> listPerson = new BindingList<Person>();

        public Form1() {


            InitializeComponent();
            dagvPersons.DataSource = listPerson;
        }

        private void Form1_Load(object sender, EventArgs e) {

            btDelete.Enabled = false; //削除ボタンをマスク
            btUpdate.Enabled = false; //更新ボタンをマスク





        }

        private void textBox2_TextChanged(object sender, EventArgs e) {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e) {

        }

        private void btPictureOpen_Click(object sender, EventArgs e) {
            if (ofdFileOpenDialog.ShowDialog() == DialogResult.OK) {
                pbPicture.Image = Image.FromFile(ofdFileOpenDialog.FileName);
            }

        }

        private void btAddPerson_Click(object sender, EventArgs e) {

            if (String.IsNullOrWhiteSpace(tbName.Text)) {
                MessageBox.Show("氏名が入力してください");


                return;
            }
            Person newPerson = new Person {
                Name = tbName.Text,
                MailAddress = tbMailAddress.Text,
                Address = tbAddress.Text,
                Company = cbCompany.Text,
                Picture = pbPicture.Image,
                KindNumber = GetRadioButton(),
                listGroup = GetCheckBoxGroup(),
                TelNumber = tbTelNumber.Text

            };

            listPerson.Add(newPerson);
            if (listPerson.Count() == 0) {
                EnableCheck(); //マスク処理呼び出し

            }


        }

        private Person.KindNumberType GetRadioButton() {
             var selectedKindNumber = Person.KindNumberType.その他;
            
            if (rbHome.Checked) {
                selectedKindNumber = Person.KindNumberType.自宅;
            }
            if(rbHome.Checked) {
                selectedKindNumber = Person.KindNumberType.携帯;
            }
            return selectedKindNumber;
        }
       

        private void EnableCheck() {
            btUpdate.Enabled = btDelete.Enabled = listPerson.Count() > 0 ? true : false;

            if (listPerson.Count() > 0) {
                //マスク解除
                btDelete.Enabled = true;
                btUpdate.Enabled = true;

            }
            else
                //マスク設定
                btDelete.Enabled = false;
            btUpdate.Enabled = false;
        }


        private void setcbCompany(string company) {

            if (!cbCompany.Items.Contains(company)) {

                cbCompany.Items.Add(company);
            }
        }
        
        


            //チェックボックスにセットされている値をリストとして取り出す。
            private List<Person.GroupType> GetCheckBoxGroup() {
            var listGroup = new List<Person.GroupType>();
            if (cbFamily.Checked == true) {
                listGroup.Add(Person.GroupType.家族);

            }
            if (cbFriend.Checked == true) {
                listGroup.Add(Person.GroupType.友人);
            }
            if (cbWork.Checked == true) {
                listGroup.Add(Person.GroupType.仕事);
            }
            if (cbOther.Checked == true) {
                listGroup.Add(Person.GroupType.その他);
            }


            return listGroup;
        }

        private void btPictureClear_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }

        private void pbPicture_Click(object sender, EventArgs e) {

        }

        private void tbName_TextChanged(object sender, EventArgs e) {

        }

        private void dagvPersons_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }
        //データグリッドビューをクリックした時のイベントハンドラ
        private void dagvPersons_Click(object sender, EventArgs e) {

            foreach (DataGridViewRow row in dagvPersons.SelectedRows) {
                tbName.Text = listPerson[row.Index].Name;
                tbMailAddress.Text = listPerson[row.Index].MailAddress;
                tbAddress.Text = listPerson[row.Index].Address;
                cbCompany.Text = listPerson[row.Index].Company;
                pbPicture.Image = listPerson[row.Index].Picture;
                dtpRegistDate.Value = listPerson[row.Index].Reistration.Year > 1900 ?
                                      listPerson[row.Index].Reistration : DateTime.Today;

                cbFamily.Checked = cbFriend.Checked = cbWork.Checked = cbOther.Checked = false;

                setGroupType(row); //グループを設定

            }

        }

        private void setGroupType(DataGridViewRow row) {
            foreach (var group in listPerson[row.Index].listGroup) {
                switch (group) {
                    case Person.GroupType.家族:
                        cbFamily.Checked = true;
                        break;
                    case Person.GroupType.友人:
                        cbFriend.Checked = true;
                        break;
                    case Person.GroupType.仕事:
                        cbWork.Checked = true;
                        break;
                    case Person.GroupType.その他:
                        cbOther.Checked = true;
                        break;
                    default:
                        break;
                }

            }
        }

        //更新ボタンが押された時の処理
        private void btUpdate_Click(object sender, EventArgs e) {
            listPerson[dagvPersons.CurrentRow.Index].Name = tbName.Text;
            listPerson[dagvPersons.CurrentRow.Index].MailAddress = tbMailAddress.Text;
            listPerson[dagvPersons.CurrentRow.Index].Address = tbAddress.Text;
            listPerson[dagvPersons.CurrentRow.Index].Company = cbCompany.Text;
            listPerson[dagvPersons.CurrentRow.Index].listGroup = GetCheckBoxGroup();
            listPerson[dagvPersons.CurrentRow.Index].Picture = pbPicture.Image;
            listPerson[dagvPersons.CurrentRow.Index].Reistration = dtpRegistDate.Value;
            dagvPersons.Refresh(); //データグリッドビュー更新



        }

        private void btDelete_Click(object sender, EventArgs e) {
            MessageBox.Show("本当に削除しますか？",
     "確認",
     MessageBoxButtons.OKCancel,
     MessageBoxIcon.Hand);

            listPerson.RemoveAt(dagvPersons.CurrentRow.Index);
            if (listPerson.Count() == 0) {
               //btDelete.Enabled = false; //削除ボタンをマスク
               // btUpdate.Enabled = false; //更新ボタンをマスク

            }
        }

        private void cbCompany_SelectedIndexChanged(object sender, EventArgs e) {

        }
        //保存ボタンのイベントハンドラ
        private void btSave_Click(object sender, EventArgs e) {

            if (ofdFileOpenDialog.ShowDialog() == DialogResult.OK) {
                try {
                    //バイナリ形式でシリアル化
                    var bf = new BinaryFormatter();

                    using (FileStream fs = File.Open(sfdSaveDialog.FileName, FileMode.Create)) {
                        bf.Serialize(fs, listPerson);
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);

                }
            }

        }

        private void btOpen_Click(object sender, EventArgs e) {
            if (ofdFileOpenDialog.ShowDialog() == DialogResult.OK) {
                try {
                    //バイナリ形式で逆シリアル化
                    var bf = new BinaryFormatter();

                    using (FileStream fs = File.Open(ofdFileOpenDialog.FileName, FileMode.Open, FileAccess.Read)) {

                        //逆シリアル化して読み込む
                        listPerson = (BindingList<Person>)bf.Deserialize(fs);
                        dagvPersons.DataSource = null;
                        dagvPersons.DataSource = listPerson;
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                    cbCompany.Items.Clear();

                }

                //コンボボックスの登録
                foreach (var item in listPerson.Select(p => p.Company)) {
                    setcbCompany(item); //存在する会社を登録

                }
                EnableCheck();//マスク呼び出し
            }

        }

        private void dtpRegistDate_ValueChanged(object sender, EventArgs e) {

        }

       

        private void gbKindNumber_Enter(object sender, EventArgs e) {
            if (true) {

            }
        }

        private void rbHome_CheckedChanged(object sender, EventArgs e) {

        }

        private void rbMobile_CheckedChanged(object sender, EventArgs e) {

        }
    }
}