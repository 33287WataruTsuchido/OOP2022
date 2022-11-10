using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Reflection;

namespace ColarChecker {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {

        List<MyColor> colorList = new List<MyColor>();
        MyColor myColor = new MyColor();
        //コンストラクタ
        public MainWindow() {
            InitializeComponent();


            DataContext = GetColorList(); //←追加

        }

        private MyColor[] GetColorList() {
            return typeof(Colors).GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static)
                .Select(i => new MyColor() { Color = (Color)i.GetValue(null), Name = i.Name }).ToArray();
        }



        public class MyColor {
            public Color Color { get; set; }
            public string Name { get; set; }
        }

        private void rSampleSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            colorLabel.Background = new SolidColorBrush(Color.FromRgb((byte)rSampleSlider.Value, (byte)gSampleSlider.Value, (byte)bSampleSlider.Value));
        }

        private void Border_Loaded(object sender, RoutedEventArgs e) {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var mycolor = (MyColor)((ComboBox)sender).SelectedItem;
            var color = mycolor.Color;
            var name = mycolor.Name;

            colorLabel.Background = new SolidColorBrush(Color.FromRgb(color.R, color.G, color.B));
            rSampleSlider.Value = color.R;
            gSampleSlider.Value = color.G;
            bSampleSlider.Value = color.B;
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            MyColor stColor = new MyColor();
            RGBListBox.Items.Add($"R : {(byte)rSampleSlider.Value} G : {(byte)gSampleSlider.Value} B : {(byte)bSampleSlider.Value}");

            var colorName = ((IEnumerable<MyColor>)DataContext)
                                    .Where(c => c.Color.R == stColor.Color.R &&
                                                c.Color.G == stColor.Color.G &&
                                                c.Color.B == stColor.Color.B).FirstOrDefault();

            if (colorName != null) {
                RGBListBox.Items.Add(colorName.Name);
            }
            else 
            {
                RGBListBox.Items.Add("R:"+rValue.Text+ "G:" + gValue.Text + "B:" + bValue.Text);

            }


        }

        private void setColor() {
            var r = byte.Parse(rValue.Text);
            var g = byte.Parse(gValue.Text);
            var b = byte.Parse(bValue.Text);

            Color color = Color.FromRgb(r, g, b);

        }

        private void RGBListBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            rSampleSlider.Value = colorList[RGBListBox.SelectedIndex].Color.R;
            gSampleSlider.Value = colorList[RGBListBox.SelectedIndex].Color.G;
            bSampleSlider.Value = colorList[RGBListBox.SelectedIndex].Color.B;
           
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e) {

        }
    }
}