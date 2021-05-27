using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class ListNode<T>
    {
        public ListNode<T> next { get; set; }
        public ListNode<T> prev { get; set; }

        public T data
        {
            get; set;
        }

        public ListNode(T item)
        {
            data = item;
        }
    }
}
