using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace MpCoding.WPF.LoadingAnimations.Controls
{
    public class ThreeDotsAnimation : Control
    {
        static ThreeDotsAnimation()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ThreeDotsAnimation), new FrameworkPropertyMetadata(typeof(ThreeDotsAnimation)));
        }
        public Brush Color
        {
            get { return (Brush)GetValue(ColorProperty); }
            set { SetValue(ColorProperty, value); }
        }
        public static readonly DependencyProperty ColorProperty =
            DependencyProperty.Register("Color", typeof(Brush), typeof(ThreeDotsAnimation), new PropertyMetadata(Brushes.LightBlue));
        public double SpeedRatio
        {
            get { return (double)GetValue(SpeedRatioProperty); }
            set { SetValue(SpeedRatioProperty, value); }
        }
        public static readonly DependencyProperty SpeedRatioProperty =
            DependencyProperty.Register("SpeedRatio", typeof(double), typeof(ThreeDotsAnimation), new PropertyMetadata(1.0));
        public Duration Duration
        {
            get { return (Duration)GetValue(DurationProperty); }
            set { SetValue(DurationProperty, value); }
        }
        public static readonly DependencyProperty DurationProperty =
            DependencyProperty.Register("Duration", typeof(Duration), typeof(ThreeDotsAnimation), new PropertyMetadata(default(Duration), CalculateSpeedRatio));
        private static void CalculateSpeedRatio(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            try
            {
                if (d is ThreeDotsAnimation control)
                {
                    double spr = 1.0 / control.Duration.TimeSpan.TotalSeconds;
                    control.SpeedRatio = spr;
                }
            }
            catch
            {
                if (d is ThreeDotsAnimation control)
                    control.SpeedRatio = 1.0;
            }
        }
    }
}
