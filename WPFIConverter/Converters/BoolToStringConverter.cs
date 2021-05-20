using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WPFIConverter.Converters
{
    public class BoolToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var booleanValue = (bool)value;
            if (booleanValue)
            {
                return "Yes";
            }
            else
            {
                return "No";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var stringValue = (string)value;
            if (stringValue.Equals("yes",StringComparison.InvariantCultureIgnoreCase))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
