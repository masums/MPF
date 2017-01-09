﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;

namespace MPF.Data
{
    public class BindingOperations
    {
        public static void SetBinding<T>(DependencyObject d, DependencyProperty<T> property, BindingBase binding)
        {
            BindingDependencyValueProvider.Current.SetValue(d, property, d.ValueStorage, binding);
        }

        public static void ClearBinding<T>(DependencyObject d, DependencyProperty<T> property)
        {
            BindingDependencyValueProvider.Current.ClearValue(property, d.ValueStorage);
        }

        public static BindingBase GetBinding<T>(DependencyObject d, DependencyProperty<T> property)
        {
            BindingBase binding;
            if (BindingDependencyValueProvider.Current.TryGetValue(property, d.ValueStorage, out binding))
                return binding;
            return null;
        }
    }
}
