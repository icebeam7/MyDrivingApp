﻿using System;
using Windows.UI.Xaml.Data;

namespace MyDriving.UWP.Converters
{
    public sealed class StringFormatConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            string stringFormat = parameter as string;
            if (!String.IsNullOrEmpty(stringFormat))
                return String.Format(stringFormat, value);

            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}