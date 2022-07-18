using PSCHD.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace PSCHD.Helper
{
    public class ImageSourceConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            IEnumerable<ImageUris> temp = value as IEnumerable<ImageUris>;
            string selector = parameter as string;
            if (temp != null && selector != null && temp.Count() != 0)
            {
                var result = ImageSize.art_crop;
                Enum.TryParse<ImageSize>(selector, out result);
                return temp.Single(e => e.ImageSize == result).URI;
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
