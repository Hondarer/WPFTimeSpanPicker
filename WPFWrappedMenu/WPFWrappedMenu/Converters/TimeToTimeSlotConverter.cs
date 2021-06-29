﻿using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using WPFWrappedMenu.Resources;

namespace WPFWrappedMenu.Converters
{
    public class TimeToTimeSlotConverter : IValueConverter
    {
        /// <inheritdoc/>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
            {
                return StringResource.StartTimeNullValueString;
            }

            if (value is not DateTime parsedDateTime)
            {
                return DependencyProperty.UnsetValue;
            }

            return $"{parsedDateTime:HH:mm}–{parsedDateTime.AddMinutes(30):HH:mm}";
        }

        /// <inheritdoc/>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return DependencyProperty.UnsetValue;
        }
    }
}