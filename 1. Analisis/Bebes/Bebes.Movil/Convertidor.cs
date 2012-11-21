using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Data;

namespace Bebes.Movil
{
    public class Convertidor:IValueConverter
    {

        public object Convert(object Value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            switch (Value.ToString())
            {
                case "Gordo":
                    return "/Imagenes/Gordo.png";

                case "Buena Salud":
                    return "/Imagenes/Salud.png";

                case "Bebe Flaco":
                    return "/Imagenes/Flaco.png";
                default:
                    return "";


            }

        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
