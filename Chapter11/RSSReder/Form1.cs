using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RSSReder {
    public partial class Form1 : Form {
        IEnumerable<string> xTitle,xLink;
        public Form1() {
            InitializeComponent();
        }

        private void btRSSget_Click(object sender, EventArgs e) {

            using (var wc = new WebClient()) {
                var stream = wc.OpenRead(cbRssUrl.Text);

                var xdoc = XDocument.Load(stream);
                xTitle = xdoc.Root.Descendants("item").Select(x => (string)x.Element("title"));
                xLink  = xdoc.Root.Descendants("item").Select(x => (string)x.Element("link"));

                foreach (var data in xTitle) {
                    lbRssTitle.Items.Add(data);
                  

                }

            }
        }
        private void lbRssTitle_Click(object sender, EventArgs e) {
            int index = lbRssTitle.SelectedIndex; //選択したインデックスを取得(0～ )
            using (var wc = new WebClient()) {
                


            }
        }

        

        
    }
}