using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace XamarinFormsBooksSample.Converters
{
    public class StringArrayToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string[] names = (string[])value;
            string separator = parameter.ToString();
            return string.Join(separator, names);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            char sep = char.Parse(parameter.ToString());
            return value.ToString().Split(sep);
        }
    }
}
