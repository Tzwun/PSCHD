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
            temp = Regex.Replace(temp, @"[V]\d|[B]\d|\d{2}|[A-Z]{2}", string.Empty);
            if (temp != null)
            {
                switch (temp)
                {
                    case "Lama.Views.MainWindow":
                        return "Home";
                    case "Lama.Views.UserView":
                        return "Account";
                    case "Lama.Views.OrderToMachineView":
                        return "ChartTimeline";
                    case "Lama.Views.DeliveryOrderView":
                        return "TruckDelivery";
                    case "Lama.Views.MachineRegistrationDetailView":
                        return "TruckDelivery";
                    case "Lama.Views.PersonalOrdersView":
                        return "TruckFast";
                    case "Lama.Views.PersonalAchievementsView":
                        return "AccountStar";
                    case "Lama.Views.PersonalChatView":
                        return "CommentProcessing";
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
