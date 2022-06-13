using System;
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
        //住所データ管理用リスト 
        BindingList<Person> listPerson = new BindingList<Person>();
        public Form1() {
                  
            
            InitializeComponent();
            dagvPersons.DataSource = listPerson;
        }

        private void Form1_Load(object sender, EventArgs e) {

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
            Person newPerson = new Person {
                Name = tbName.Text,
                MailAddress = tbMailAddress.Text,
                Address = tbAddress.Text,
                Company = tbCompany.Text,
                Picture = pbPicture.Image,
                listGroup = GetCheckBoxGroup()
                
        };

            listPerson.Add(newPerson);
            
        }

        //チェックボックスにセットされている値をリストとして取り出す。
        private List<Person.GroupType> GetCheckBoxGroup() {
            var listGroup = new List<Person.GroupType>();
            if (cbFamily.Checked == true ) {
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

            foreach (DataGridViewRow row in dagvPersons.SelectedRows) 
                {
                tbName.Text = listPerson[row.Index].Name;
                tbMailAddress.Text = listPerson[row.Index].MailAddress;
                tbAddress.Text = listPerson[row.Index].Address;
                tbCompany.Text = listPerson[row.Index].Company;
                pbPicture.Image = listPerson[row.Index].Picture;

                cbFamily.Checked = cbFriend.Checked = cbWork.Checked = cbOther.Checked = false;


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

        }
    }
}