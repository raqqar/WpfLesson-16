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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfДуыыщт_16
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        ////private void btn_Click(object sender, RoutedEventArgs e)
        ////{
        ////    DoubleAnimation doubleAnimation = new DoubleAnimation();
        ////    //doubleAnimation.From = 150;
        ////    doubleAnimation.To = 500;
        ////    //doubleAnimation.By = 10;
        ////    //doubleAnimation.RepeatBehavior = new RepeatBehavior(2);//(TimeSpan.FromSeconds(6));
        ////    //doubleAnimation.AccelerationRatio = 0;
        ////    //doubleAnimation.SpeedRatio = 0.5;
        ////    //doubleAnimation.AutoReverse=true;
        ////    //doubleAnimation.FillBehavior=FillBehavior.Stop
        ////    doubleAnimation.Duration = TimeSpan.FromSeconds(2);
        ////    btn.BeginAnimation(Button.WidthProperty, doubleAnimation);
        ////    btn.BeginAnimation(Button.HeightProperty, doubleAnimation);
        ////    ColorAnimation colorAnimation = new ColorAnimation();
        ////    //colorAnimation.AutoReverse = true;
        ////    colorAnimation.From = Colors.LightCyan;
        ////    colorAnimation.To = Colors.Green;
        ////    colorAnimation.Duration=TimeSpan.FromSeconds(2);
        ////    btn.Background = new SolidColorBrush(Colors.LightCyan);
        ////    btn.Background.BeginAnimation(SolidColorBrush.ColorProperty,colorAnimation);
        ////}
    }
}
