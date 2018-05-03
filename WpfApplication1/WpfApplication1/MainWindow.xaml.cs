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

namespace WpfApplication1
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void HeightSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            //Slider輸出
            double h = HeightSlider.Value;        
            HeightText.Text = "身高: " + h.ToString() + "cm";
            //position
            double hb = (h - 100) * 4;
            Canvas.SetLeft(HeightBorder, hb);
            //Bmi
            double h1 = double.Parse(h.ToString());
            double w1 = double.Parse(w.ToString());
            double result = w / Math.Pow(h, 2);
            string[] parts = Math.Round(result, 1).ToString().Split(',');
            Result1.Text = parts[0];
            if (parts.Length > 1)
            {
                Result2.Text = parts[1];
            }
            else
                Result2.Text = ".0";
        }

        private void WeightSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            //Slider輸出
            double w = WeightSlider.Value;
            WeightText.Text = "體重: " + w.ToString() + "kg";
            //position
            double wb = (w - 1) * 2;
            Canvas.SetLeft(WeightBorder, wb);
            //Bmi
            double result = w / Math.Pow(h, 2);
            string[] parts = Math.Round(result, 1).ToString().Split(',');
            Result1.Text = parts[0];
            if (parts.Length > 1)
            {
                Result2.Text = parts[1];
            }
            else
                Result2.Text = ".0";
        }
    }
}
