using Newtonsoft.Json;
using System;
using System.Net;
using System.Text;
using System.Windows.Forms;
using WeatherApp;

namespace WeatherApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();

        }

        private void btGetWeather_Click(object sender, EventArgs e)
        {
            var wc = new WebClient()
            {
                Encoding = Encoding.UTF8
            };

            var url1 = " ";
            var url2 = " ";

            //概況（三日間）
            //   url1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/130000.json");
            //   url2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/130000.json");

            switch (cbHokkaidou.SelectedItem)
            {
                case "宗谷地方":
                    url1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/011000.json");
                    url2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/011000.json");
                    break;
                case "上川・留萌地方":
                    url1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/012000.json");
                    url2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/012000.json");
                    break;
                case "網走・北見・紋別地方":
                    url1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/013000.json");
                    url2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/013000.json");
                    break;
                case "十勝地方":
                    url1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/013000.json");
                    url2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/013000.json");
                    break;
                case "釧路・根室地方":
                    url1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/014100.json");
                    url2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/014100.json");
                    break;
                case "胆振・日高地方":
                    url1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/015000.json");
                    url2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/015000.json");
                    break;
                case "石狩・空知・後志地方":
                    url1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/016000.json");
                    url2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/016000.json");
                    break;
                case "渡島・檜山地方":
                    url1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/017000.json");
                    url2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/017000.json");
                    break;


            }
            switch (cbTouhoku.SelectedItem)
            {
                case "青森県":
                    url1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/020000.json");
                    url2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/020000.json");
                    break;
                case "岩手県":
                    url1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/030000.json");
                    url2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/030000.json");
                    break;
                case "宮城県":
                    url1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/040000.json");
                    url2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/040000.json");
                    break;
                case "秋田県":
                    url1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/050000.json");
                    url2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/050000.json");
                    break;
                case "山形県":
                    url1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/060000.json");
                    url2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/060000.json");
                    break;
                case "福島県":
                    url1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/070000.json");
                    url2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/070000.json");
                    break;
            }
            switch (cbKanntou.SelectedItem)
            {
                case "茨城県":
                    url1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/080000.json");
                    url2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/080000.json");
                    break;
                case "栃木県":
                    url1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/090000.json");
                    url2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/090000.json");
                    break;
                case "群馬県":
                    url1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/100000.json");
                    url2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/100000.json");
                    break;
                case "埼玉県":
                    url1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/110000.json");
                    url2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/110000.json");
                    break;
                case "千葉県":
                    url1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/120000.json");
                    url2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/120000.json");
                    break;
                case "東京都":
                    url1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/130000.json");
                    url2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/130000.json");
                    break;
                case "神奈川県":
                    url1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/140000.json");
                    url2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/140000.json");
                    break;
            }
            switch (cbChuubu.SelectedItem)
            {
                case "新潟県":
                    url1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/150000.json");
                    url2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/150000.json");
                    break;
                case "富山県":
                    url1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/160000.json");
                    url2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/160000.json");
                    break;
                case "石川県":
                    url1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/170000.json");
                    url2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/170000.json");
                    break;
                case "福井県":
                    url1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/180000.json");
                    url2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/180000.json");
                    break;
                case "山梨県":
                    url1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/190000.json");
                    url2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/190000.json");
                    break;
                case "長野県":
                    url1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/200000.json");
                    url2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/200000.json");
                    break;
                case "岐阜県":
                    url1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/210000.json");
                    url2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/210000.json");
                    break;
                case "静岡県":
                    url1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/220000.json");
                    url2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/220000.json");
                    break;
                case "愛知県":
                    url1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/230000.json");
                    url2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/230000.json");
                    break;

            }
            switch (cbKannsai.SelectedItem)
            {
                case "三重県":
                    url1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/240000.json");
                    url2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/240000.json");
                    break;
                case "滋賀県":
                    url1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/250000.json");
                    url2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/250000.json");
                    break;
                case "京都府":
                    url1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/260000.json");
                    url2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/260000.json");
                    break;
                case "大阪府":
                    url1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/270000.json");
                    url2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/270000.json");
                    break;
                case "兵庫県":
                    url1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/280000.json");
                    url2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/280000.json");
                    break;
                case "奈良県":
                    url1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/290000.json");
                    url2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/290000.json");
                    break;
                case "和歌山県":
                    url1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/300000.json");
                    url2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/300000.json");
                    break;
            }
            switch (cbChuugoku.SelectedItem)
            {
                case "鳥取県":
                    url1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/310000.json");
                    url2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/310000.json");
                    break;
                case "島根県":
                    url1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/320000.json");
                    url2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/320000.json");
                    break;
                case "岡山県":
                    url1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/330000.json");
                    url2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/330000.json");
                    break;
                case "広島県":
                    url1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/340000.json");
                    url2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/340000.json");
                    break;
                case "山口県":
                    url1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/350000.json");
                    url2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/350000.json");
                    break;
            }
            switch (cbShikoku.SelectedItem)
            {
                case "徳島県":
                    url1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/360000.json");
                    url2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/360000.json");
                    break;
                case "香川県":
                    url1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/370000.json");
                    url2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/370000.json");
                    break;
                case "愛媛県":
                    url1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/380000.json");
                    url2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/380000.json");
                    break;
                case "高知県":
                    url1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/390000.json");
                    url2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/390000.json");
                    break;
            }
            switch (cbKyuushuu.SelectedItem)
            {

                case "福岡県":
                    url1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/400000.json");
                    url2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/400000.json");
                    break;
                case "佐賀県":
                    url1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/410000.json");
                    url2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/410000.json");
                    break;
                case "長崎県":
                    url1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/420000.json");
                    url2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/420000.json");
                    break;
                case "熊本県":
                    url1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/430000.json");
                    url2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/430000.json");
                    break;
                case "大分県":
                    url1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/440000.json");
                    url2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/440000.json");
                    break;
                case "宮崎県":
                    url1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/450000.json");
                    url2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/450000.json");
                    break;
                case "鹿児島県":
                    url1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/460100.json");
                    url2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/460100.json");
                    break;
                default:
                    break;

            }
            switch (cbOkinawa.SelectedItem)
            {
                case "沖縄本島地方":
                    url1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/471000.json");
                    url2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/471000.json");
                    break;
                case "大東島地方":
                    url1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/472000.json");
                    url2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/472000.json");
                    break;
                case "宮古島地方":
                    url1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/473000.json");
                    url2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/473000.json");
                    break;
                case "八重山地方":
                    url1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/474000.json");
                    url2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/474000.json");
                    break;
            }





            var json1 = JsonConvert.DeserializeObject<Rootobject>(url1);
            var json2 = JsonConvert.DeserializeObject<Class1[]>(url2);


            if (json1 == null)
            {
                DialogResult result = MessageBox.Show("地域が選択されていません",
                 "エラー",
                  MessageBoxButtons.OKCancel,
                  MessageBoxIcon.None);
            }
            else
            {

               
                tbAreaInfo.Text = json1.text;
                DateTime today = DateTime.Today;
                label3.Text = (today.Month.ToString() + "/" + today.Day.ToString());
                DateTime tomorrow = DateTime.Today.AddDays(1);
                label4.Text = (tomorrow.Month.ToString() + "/" + tomorrow.Day.ToString());
                DateTime twodays = DateTime.Today.AddDays(2);
                label5.Text = (twodays.Month.ToString() + "/" + twodays.Day.ToString());
                DateTime now = DateTime.Now;
                label6.Text = now.ToLongTimeString();
                label7.Text = json1.publishingOffice;
               // label9.Text = json2[0].timeSeries[0].areas[0].temps[0];
                tbWeather1.Text = json2[0].timeSeries[0].areas[0].weathers[0];
                tbWeather2.Text = json2[0].timeSeries[0].areas[0].weathers[1];
                tbWeather3.Text = json2[0].timeSeries[0].areas[0].weathers[2];
                pbWeather1.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/" + json2[0].timeSeries[0].areas[0].weatherCodes[0] + ".png";
                pbWeather2.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/" + json2[0].timeSeries[0].areas[0].weatherCodes[1] + ".png";
                pbWeather3.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/" + json2[0].timeSeries[0].areas[0].weatherCodes[2] + ".png";

            }


        }

        private void btClear_Click(object sender, EventArgs e)
        {
            cbHokkaidou.SelectedItem =null;
            cbHokkaidou.Text = "北海道";
            cbTouhoku.SelectedItem = null;
            cbTouhoku.Text = "東北地方";
            cbKanntou.SelectedItem = null;
            cbKanntou.Text = "関東地方";
            cbChuubu.SelectedItem = null;
            cbChuubu.Text = "中部地方";
            cbKannsai.SelectedItem = null;
            cbKannsai.Text = "関西地方";
            cbChuugoku.SelectedItem = null;
            cbChuugoku.Text = "中国地方";
            cbShikoku.SelectedItem = null;
            cbShikoku.Text = "四国地方";
            cbKyuushuu.SelectedItem = null;
            cbKyuushuu.Text = "九州地方";
            cbOkinawa.SelectedItem = null;
            cbOkinawa.Text = "沖縄";
            tbAreaInfo.Text = null;
            label3.Text = null;
            label3.Text = "-";
            label4.Text = null;
            label4.Text = "-";
            label5.Text = null;
            label5.Text = "-";
            label6.Text = null;
            label6.Text = "-";
            label7.Text = null;
            label7.Text = "-";
            tbWeather1.Text = null;
            tbWeather2.Text = null;
            tbWeather3.Text = null;
            pbWeather1.Image = null;
            pbWeather2.Image = null;
            pbWeather3.Image = null;
            
        }


    }
}
