using System;
using System.Globalization;
using Xamarin.Forms;

namespace APIExperiment.ViewModels.Converters
{
	public class IsSelectedToColorConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if ((bool)value == true)
				return "Orange";
			else
				return "White";
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
