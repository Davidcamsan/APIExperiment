using System;
using System.Globalization;
using Xamarin.Forms;

namespace APIExperiment.ViewModels.Converters
{
	public class AnswerToEnabledConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if ((bool)value == true)
				return false;
			else
				return true;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
