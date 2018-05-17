﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Syncfusion.DataSource.Extensions;

namespace WeekPlanner.Helpers
{
    public static class ObservableCollectionExtensions
    {
        public static void Sort<T>(this ObservableCollection<T> collection, Comparison<T> comparison)
        {
            var sortableList = new List<T>(collection);
            sortableList.Sort(comparison);

            for (int i = 0; i < sortableList.Count; i++)
            {
                collection.Move(collection.IndexOf(sortableList[i]), i);
            }
        }
        
        public static void AddRange<T>(this ObservableCollection<T> observableCollection, 
            IEnumerable<T> rangeToAdd)
        {
            rangeToAdd.ForEach(observableCollection.Add);
        }
    }
}