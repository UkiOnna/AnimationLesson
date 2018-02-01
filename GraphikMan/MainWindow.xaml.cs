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

namespace GraphikMan
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DoubleAnimation animationWidth = new DoubleAnimation();
            DoubleAnimation animationHeight = new DoubleAnimation();

            animationWidth.From = Elipse.Width;
            animationHeight.From = Elipse.Height;

            animationWidth.To = Elipse.Width + 200;
            animationHeight.To = Elipse.Height + 200;

            animationWidth.Duration = TimeSpan.FromSeconds(1);
            animationHeight.Duration = TimeSpan.FromSeconds(1);

            animationWidth.AutoReverse = true;
            animationHeight.AutoReverse = true;

            animationWidth.SpeedRatio = 5;
            animationHeight.SpeedRatio = 5;

            animationWidth.RepeatBehavior = RepeatBehavior.Forever;
            animationHeight.RepeatBehavior = RepeatBehavior.Forever;

            Elipse.BeginAnimation(Ellipse.WidthProperty, animationWidth);
            Elipse.BeginAnimation(Ellipse.HeightProperty, animationHeight);
        }
    }
}
