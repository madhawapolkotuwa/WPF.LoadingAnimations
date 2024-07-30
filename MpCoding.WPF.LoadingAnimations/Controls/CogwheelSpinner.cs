using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace MpCoding.WPF.LoadingAnimations.Controls
{
    public class CogwheelSpinner : Control
    {
        public static ObservableCollection<KeyTime> KeyTimes { get; set; } = new ObservableCollection<KeyTime>();

        static CogwheelSpinner()
        {
            Init();
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CogwheelSpinner), new FrameworkPropertyMetadata(typeof(CogwheelSpinner)));
        }
        private static void Init()
        {
            for (int i = 0; i < 18; i++)
            {
                KeyTimes.Add(KeyTime.FromTimeSpan(TimeSpan.FromSeconds(1.0)));
            }
        }
        public void SetKeyTime(int index, KeyTime value)
        {
            KeyTimes[index] = value;
        }

        public Duration Duration
        {
            get { return (Duration)GetValue(DurationProperty); }
            set { SetValue(DurationProperty, value); }
        }
        public static readonly DependencyProperty DurationProperty =
            DependencyProperty.Register("Duration", typeof(Duration), typeof(CogwheelSpinner), new PropertyMetadata(default(Duration), SetValueSpeedToKeytimes));
        public Brush Color
        {
            get { return (Brush)GetValue(ColorProperty); }
            set { SetValue(ColorProperty, value); }
        }
        public static readonly DependencyProperty ColorProperty =
            DependencyProperty.Register("Color", typeof(Brush), typeof(CogwheelSpinner), new PropertyMetadata(Brushes.LightBlue));
        public string Content
        {
            get { return (string)GetValue(ContentProperty); }
            set { SetValue(ContentProperty, value); }
        }
        public static readonly DependencyProperty ContentProperty =
            DependencyProperty.Register("Content", typeof(string), typeof(CogwheelSpinner), new PropertyMetadata(string.Empty));
        private static void SetValueSpeedToKeytimes(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            try
            {
                double key_time = 0.0;
                if (d is CogwheelSpinner control)
                {
                    double speed = control.Duration.TimeSpan.TotalSeconds;
                    for (int i = 0; i < 18; i++)
                    {
                        control.SetKeyTime(i, KeyTime.FromTimeSpan(TimeSpan.FromSeconds(key_time)));
                        if(speed != 0.0)
                            key_time = speed / 18.0 + key_time;
                    }
                }
            }
            catch
            {
                Init();
            }
        }

    }
}
