using System.Globalization;

namespace Dooku.App.Converters
{
    internal class ArrayToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var a = value as int[,];
            string p = parameter.ToString();
            var index1 = int.Parse(p.Split(",")[0]);
            var index2 = int.Parse(p.Split(",")[1]);
            return a[index1, index2];
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
