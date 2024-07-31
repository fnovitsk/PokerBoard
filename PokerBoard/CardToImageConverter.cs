using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace PokerBoard
{
    [ValueConversion(typeof(CardViewModel), typeof(BitmapImage))]
    public class CardToImageConverter : IValueConverter
    {
        public static CardToImageConverter Instance = new CardToImageConverter();
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var card = (CardViewModel)value;
            string path = $"Images/Cards/{card.Value}_of_{card.Suit}.png";
            return new BitmapImage(new Uri($"pack://application:,,,/{path}"));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
