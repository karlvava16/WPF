using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows;

namespace ColorPicker
{
    class MyColor : DependencyObject
    {
        private static readonly DependencyProperty AlphaProperty;

        private static readonly DependencyProperty RedProperty;

        private static readonly DependencyProperty GreenProperty;

        private static readonly DependencyProperty BlueProperty;

        private static readonly DependencyProperty ColorARGB_Property;



        public int Alpha
        {
            get { return (int)GetValue(AlphaProperty); }
            set { SetValue(AlphaProperty, value); }
        }

        public int Red
        {
            get { return (int)GetValue(RedProperty); }
            set { SetValue(RedProperty, value); }
        }

        public int Green
        {
            get { return (int)GetValue(GreenProperty); }
            set { SetValue(GreenProperty, value); }
        }
        public int Blue
        {
            get { return (int)GetValue(BlueProperty); }
            set { SetValue(BlueProperty, value); }
        }

        public SolidColorBrush Col
        {
            get { return (SolidColorBrush)GetValue(ColorARGB_Property); }
            set { SetValue(ColorARGB_Property, value); }
        }

        public MyColor(int alpha, int red, int green, int blue, SolidColorBrush col)
        {
            Alpha = alpha;
            Red = red;
            Green = green;
            Blue = blue;
            Col = col;
        }

        static MyColor()
        {
            AlphaProperty = DependencyProperty.Register("Alpha", typeof(int), typeof(MyColor));
            RedProperty = DependencyProperty.Register("Red", typeof(int), typeof(MyColor));
            GreenProperty = DependencyProperty.Register("Green", typeof(int), typeof(MyColor));
            BlueProperty = DependencyProperty.Register("Blue", typeof(int), typeof(MyColor));
            ColorARGB_Property = DependencyProperty.Register("Col", typeof(SolidColorBrush), typeof(MyColor));
        }

    }
}
