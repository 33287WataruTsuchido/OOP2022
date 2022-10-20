﻿using System;
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

namespace SampleApplication {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>1
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            seasonComboBox.SelectedIndex = GetseasonIndex();

        }


        private int GetseasonIndex() {
            var today = DataTime.Now;


            int ret =((int)today.Month) / 3 - 1;

            if (ret < 0) {
                ret = 3;

            }

            return ret;           
        }
        private void checkBox_Checked(object sender, RoutedEventArgs e) {
            checkBoxTextBlock.Text = "チェック済み";

        }

        private void checkBox_Unchecked(object sender, RoutedEventArgs e) {
            checkBoxTextBlock.Text = "未チェック";
        }

        private void seasonComboBox_SelectionChanged(object sender, RoutedEventArgs e) {
            seasonTextBlock.Text = (string)((ComboBoxItem)seasonComboBox.SelectedItem).Content;

        }
        private void yellowRadioButton_Checked(object sender, RoutedEventArgs e) {
            colorTextBox.Text = "黄";
        }
        private void redRadioButton_Checked(object sender, RoutedEventArgs e) {
            colorTextBox.Text = "赤";
        }
        private void blueRadioButton_Checked(object sender, RoutedEventArgs e) {
            colorTextBox.Text = "青";
        }
    }
}