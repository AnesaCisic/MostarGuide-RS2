using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using Xamarin.Forms;

namespace MostarGuide.MobileApp.Converters
{
    public class ImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return null;

            byte[] bytes = value as byte[]; //nas image je kao byte array i kao ulazni parametar dobit cemo byte array

            Func<Stream> myFunc = () => new MemoryStream(bytes);

            return ImageSource.FromStream(myFunc); //sami imagesource ima nekoliko metoda, pa smo pretvorili byte array u stream
            //tako sto se instacira memory stream objekat i njega proslijedimo
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

    }
}
