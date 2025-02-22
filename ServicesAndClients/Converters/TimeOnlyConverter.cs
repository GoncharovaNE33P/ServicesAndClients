﻿using Avalonia.Data.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesAndClients.Converters
{
    internal class TimeOnlyConverter : IValueConverter
    {
        public object Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value is TimeOnly time) return new TimeSpan(time.Hour, time.Minute, time.Second);
            return null;
        }

        public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value is TimeSpan time) return new TimeOnly(time.Hours, time.Minutes, time.Seconds);
            return null;
        }
    }
}
