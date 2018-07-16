using System;
using System.Collections.Generic;

namespace GenericStacks.Library
{
    public class MyStack<T>
    {
        private List<T> _items = new List<T>();
        
        public MyStack<T> Push(T item) {
            _items.Add(item);
            return this;
        }

        public T Pop() {
            if (_items.Count == 0) {
                // return default value of type, string -> null
                return default(T);
            } else {
                var item = _items[_items.Count -1];
                _items.RemoveAt(_items.Count - 1);
                return item;
            }
        }
    }
}
