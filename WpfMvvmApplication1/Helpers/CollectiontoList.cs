﻿using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace WpfMvvmApplication1.Helpers
{
    public static class CollectionUtils
    {
        public static ObservableCollection<T> ToObservableCollection<T>(this IEnumerable<T> thisCollection)
        {
            if (thisCollection == null) return null;
            var oc = new ObservableCollection<T>();

            foreach (var item in thisCollection)
            {
                oc.Add(item);
            }

            return oc;
        }
    }
}
