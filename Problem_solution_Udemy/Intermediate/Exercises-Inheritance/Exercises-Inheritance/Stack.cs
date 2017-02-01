using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Exercises_Inheritance
{
    public class Stack
    {
        private readonly List<object> _list = new List<object>();

        public void Push(object obj)
        {
            if (obj == null)
            {
                throw new InvalidOperationException("you can not add a null object to the stake");
            }
            else
            {
                _list.Add(obj);
            }
//            foreach (var list in _list)
//            {
//                Console.WriteLine($"here is the list {list}");
//            }
        }

        public object Pop()
        {
            if (_list.Count == 0)
            {
                throw new InvalidComObjectException("The are no element in this Stake");
            }

            object returnItem = _list[_list.Count - 1];

            _list.RemoveAt(_list.Count - 1);

            return returnItem;
        }

        public void Clear()
        {
            _list.Clear();
        }
    }
}