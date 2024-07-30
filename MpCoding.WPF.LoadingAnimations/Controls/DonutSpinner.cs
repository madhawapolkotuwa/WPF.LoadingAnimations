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
    public class DonutSpinner : Control
    {
        static DonutSpinner()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(DonutSpinner), new FrameworkPropertyMetadata(typeof(DonutSpinner)));
        }

        public Duration Duration
        {
            get { return (Duration)GetValue(DurationProperty); }
            set { SetValue(DurationProperty, value); }
        }

        public static readonly DependencyProperty DurationProperty =
            DependencyProperty.Register("Duration", typeof(Duration), typeof(DonutSpinner), new PropertyMetadata(default(Duration)));

        public Brush SpinnerColor
        {
            get { return (Brush)GetValue(SpinnerColorProperty); }
            set { SetValue(SpinnerColorProperty, value); }
        }

        public static readonly DependencyProperty SpinnerColorProperty =
            DependencyProperty.Register("SpinnerColor", typeof(Brush), typeof(DonutSpinner), new PropertyMetadata(Brushes.AliceBlue));

        
    }
}
