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
        IEnumerable<string> xTitle, xLink;
        public Form1() {
            InitializeComponent();
        }

        private void btRSSget_Click(object sender, EventArgs e) {

            using (var wc = new WebClient()) {
                var stream = wc.OpenRead(cbRssUrl.Text);

                var xdoc = XDocument.Load(stream);
                xTitle = xdoc.Root.Descendants("item").Select(x => (string)x.Element("title"));
                xLink = xdoc.Root.Descendants("item").Select(x => (string)x.Element("link"));

                foreach (var data in xTitle) {
                    lbRssTitle.Items.Add(data);


                }

            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            goForwardMaskCheck();
            

        }

    

        private void lbRssTitle_Click(object sender, EventArgs e) {
            int index = lbRssTitle.SelectedIndex; //選択したインデックスを取得(0～ )

            try {
                var url = xLink.ElementAt(index);

                // wbBrowser.Navigate(url);
                wvBrower.Source = new Uri(url);

            }
            catch {

            }





        }

        private void btForward_Click(object sender, EventArgs e) {
           wvBrower.GoForward();
        }

        private void wvBrower_DOMContentLoaded(object sender, Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT.WebViewControlDOMContentLoadedEventArgs e) {

        }

        private void wvBrower_NavigationCompleted(object sender, Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT.WebViewControlNavigationCompletedEventArgs e) {
            goForwardMaskCheck();

        }

        private void goForwardMaskCheck() {
            btBack.Enabled = wvBrower.CanGoBack;
            btForward.Enabled = wvBrower.CanGoBack;
        }

        private void btBack_Click(object sender, EventArgs e) {
           wvBrower.GoBack();
        }
    }   
}