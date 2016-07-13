using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;
using LetsTalk.Core.Common.Utils;

namespace LetsTalk.Core.Common.Core
{
    public class NotificationObject : INotifyPropertyChanged
    {
        private event PropertyChangedEventHandler PropertyChangedEvent;

        protected List<PropertyChangedEventHandler> PropertyChangedSubscribers = new List<PropertyChangedEventHandler>();

        public event PropertyChangedEventHandler PropertyChanged
        {
            add
            {
                if (PropertyChangedSubscribers.Contains(value)) return;
                PropertyChangedEvent += value;
                PropertyChangedSubscribers.Add(value);
            }
            remove
            {
                PropertyChangedEvent -= value;
                PropertyChangedSubscribers.Remove(value);
            }
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEvent?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected virtual void OnPropertyChanged<T>(Expression<Func<T>> propertyExpression)
        {
            var propertyName = PropertySupport.ExtractPropertyName(propertyExpression);
            OnPropertyChanged(propertyName);
        }
    }
}
