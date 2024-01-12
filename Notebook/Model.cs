using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Notebook
{
    public class Model : DependencyObject
    {
        private static readonly DependencyProperty FullNameProperty;
        private static readonly DependencyProperty AddressProperty;
        private static readonly DependencyProperty PhoneProperty;

        static Model()
        {
            FullNameProperty = DependencyProperty.Register("FullName", typeof(string), typeof(Model));
            AddressProperty = DependencyProperty.Register("Address", typeof(string), typeof(Model));
            PhoneProperty = DependencyProperty.Register("Phone", typeof(string), typeof(Model));
        }

        public string FullName
        {
            get { return (string)GetValue(FullNameProperty); }
            set { SetValue(FullNameProperty, value); }
        }

        public string Address
        {
            get { return (string)GetValue(AddressProperty); }
            set { SetValue(AddressProperty, value); }
        }

        public string Phone
        {
            get { return (string)GetValue(PhoneProperty); }
            set { SetValue(PhoneProperty, value); }
        }
    }
}
