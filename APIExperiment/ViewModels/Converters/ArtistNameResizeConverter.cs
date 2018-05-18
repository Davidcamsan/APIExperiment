using System;
using System.Globalization;
using Xamarin.Forms;
using System.Linq;

namespace APIExperiment.ViewModels.Converters
{
    public class ArtistNameResizeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value.ToString().Length > 20)
                return (value.ToString().Remove(15) + "...");
            else
                return value;

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
