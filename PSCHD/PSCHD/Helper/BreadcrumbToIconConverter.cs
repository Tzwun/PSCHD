using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Data;

namespace PSCHD.Helper
{
    public class BreadcrumbToIconConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string temp = value as string;
            //temp = Regex.Replace(temp, @"[V]\d|[B]\d|\d{2}|[A-Z]{2}", string.Empty);
            if (temp != null)
            {
                switch (temp)
                {
                    case "PSCHD.Views.MainWindow":
                        return "Home";
                    case "PSCHD.Views.UserView":
                        return "Account";
                    case "PSCHD.Views.CardsOverview":
                        return "CardsOutline";
                    case "PSCHD.Views.UserCollectionsView":
                        return "Graph";
                    case "PSCHD.Views.StonksView":
                        return "GraphLine";
                    case "ChevronRight":
                        return "ChevronRight";
                    default:
                        return "";
                }
            }
            return "";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
