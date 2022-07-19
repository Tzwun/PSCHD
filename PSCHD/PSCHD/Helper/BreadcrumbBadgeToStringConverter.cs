using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Data;

namespace PSCHD.Helper
{
    public class BreadcrumbBadgeToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string temp = value as string;
            if (Regex.IsMatch(temp, @"[V]\d|[B]\d|\d{2}|[A-Z]{2}"))
            {
                return Regex.Match(temp, @"[V]\d|[B]\d|\d{2}|[A-Z]{2}").ToString();
            }
            else
            {
                return null;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

    }
}
