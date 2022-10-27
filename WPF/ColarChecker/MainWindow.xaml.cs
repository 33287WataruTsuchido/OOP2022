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
        //コンストラクタ
        public MainWindow() {
            InitializeComponent();
            

            DataContext = GetColorList(); //←追加

        }

        private MyColor[] GetColorList() {
            return typeof(Colors).GetProperties(System.Reflection.BindingFlags.Public |System.Reflection.BindingFlags.Static)
                .Select(i => new MyColor() { Color = (Color)i.GetValue(null), Name = i.Name }).ToArray();
        }



        public class MyColor {
            public Color Color { get; set; }
            public string Name { get; set; }
        }

        private void rSampleSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            colorLabel.Background = new SolidColorBrush(Color.FromRgb((byte)SampleSlider.Value, (byte)SampleSlider2.Value, (byte)SampleSlider3.Value));
        }

        private void Border_Loaded(object sender, RoutedEventArgs e) {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var mycolor = (MyColor)((ComboBox)sender).SelectedItem;
            var color = mycolor.Color;
            var name = mycolor.Name;


        }
    }
}
