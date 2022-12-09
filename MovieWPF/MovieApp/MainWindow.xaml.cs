using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MessageBox = System.Windows.Forms.MessageBox;

namespace MovieApp
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }



        private void btSearch_Click(object sender, RoutedEventArgs e)
        {
            {


                this.Hide();
                Window1 f2 = new Window1();
                f2.Show();


                var wc = new WebClient()
                {
                    Encoding = Encoding.UTF8
                };

                var url = " ";
                url = wc.DownloadString("https://api.themoviedb.org/3/movie/550?api_key=6e89cd650ebfbdcb78abf5d855137280");

                var json = JsonConvert.DeserializeObject<Rootobject>(url);


               




            }
        }

        private void btHistory_Click(object sender, RoutedEventArgs e)
        {

            this.Hide();
            Window2 f2 = new Window2();
            f2.Show();

        }
    }
}
