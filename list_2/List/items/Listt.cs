using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Listt<T> : IEnumerable where T : IComparable<T>
    {
        public ListNode<T> First { get; set; }
        public ListNode<T> Last { get; set; }

        public int Count { get; private set; }

        public Listt()
        {
            Count = 0;
        }

        public Listt(T item)
        {
            CreateList(item);
        }

        public T this[int index]
        {
            get
            {
                OutIndex(index);

                return Find(index);
            }
            set
            {
                OutIndex(index);

                Find(index, value);
            }
        }

        public void Append(T item)
        {
            if (Count > 0)
            {
                var data = new ListNode<T>(item);
                Last.next = data;
                var prev = Last;
                Last = data;
                Last.prev = prev;

                Count++;
            }
            else
            {
                CreateList(item);
            }
        }

        public void Prepend(T item)
        {
            if (First != null)
            {
                var data = new ListNode<T>(item);
                First.prev = data;
                var next = First;
                First = data;
                First.next = next;

                Count++;
            }

            else
            {
                CreateList(item);
            }
        }

        public void DeleteByIndex(int index)
        {
            if (First != null)
            {
                OutIndex(index);
                DelIndex(index);
            }
            
        }

        public void Delete(T item)
        {
           
                Del(item);

        }

        public T[] ToArray()
        {
            T[] source = new T[Count];
            var item = First;
            for (int i = 0; i < Count; i++)
            {
                source[i] = item.data;
                item = item.next;
            }

            return source;
        }

        public void Sort()
        {
            T[] source = ToArray();
            source = Sort(source);

            var item = First;
            int i = 0;

            while (item != null)
            {
                item.data = source[i];
                item = item.next;
                i++;
            }

        }

        public T GoRight()
        {
            var item = First;

            return item.data;
        }

        #region private void
        private void CreateList(T item)
        {
            var data = new ListNode<T>(item);

            First = data;
            First.prev = null;
            Last = data;
            Last.next = null;
            Count = 1;
        }

        private T Find(int index)
        {
            var item = First;

            for (int i = 0; i < index; i++)
            {
                item = item.next;
            }

            return item.data;
        }

        private void Find(int index, T value)
        {
            if(Count == 0)
            {
                CreateList(value);
            }

            var item = First;

            for (int i = 0; i < index; i++)
            {
                item.prev = item;
                item = item.next;
            }

            item.data = value;
        }

        private void DelIndex(int index)
        {
            var item = First;

            for (int i = 0; i < index; i++)
            {
                item = item.next;
            }

            if (item.prev != null)
            {
                item.prev.next = item.next;
            }
            else if (item.prev == null)
            {
                First = item.next;
            }

            if (item.next != null) { 
                
                item.next.prev = item.prev; 
                item = item.next;
                
            }

            Count--;
        }

        private void Del(T item)
        {
            if (First != null)
            {
                if (First.data.Equals(item))
                {
                    First = First.next;
                    First.prev = null;  
                    Count--;
                    return;
                }

                else
                {
                    var element = First;

                    while (element != null)
                    {
                        if (element.data.Equals(item))
                        {
                            if (element.prev != null)
                                element.prev.next = element.next;
                            if(element.next != null)
                                element.next.prev = element.prev;

                            Count--;
                            return;
                        }

                        element = element.next;
                    }
                }
            }
        }

        private T[] Sort(T[] src)
        {
            if(src.Length > 0)
            {
                if (src.Length == 1) { return src; }

                int middle = src.Length / 2;

                T[] left = Sort(src.Take(middle).ToArray());
                T[] right = Sort(src.Skip(middle).ToArray());

                return Merge(left, right);
            }

            return null;
        }

        private T[] Merge(T[] left, T[] right)
        {
            int length = left.Length + right.Length;
            int leftPoint = 0;
            int rightPoint = 0;

            T[] result = new T[length];

            for (int i = 0; i < length; i++)
            {
                if (leftPoint < left.Length && rightPoint < right.Length)
                {
                    if (left[leftPoint].CompareTo(right[rightPoint]) == -1)
                    {
                        result[i] = left[leftPoint];
                        leftPoint++;
                    }
                    else
                    {
                        result[i] = right[rightPoint];
                        rightPoint++;
                    }
                }
                else
                {
                    if (rightPoint < right.Length)
                    {
                        result[i] = right[rightPoint];
                        rightPoint++;
                    }
                    if (leftPoint < left.Length)
                    {
                        result[i] = left[leftPoint];
                        leftPoint++;
                    }
                }
            }
            return result;
        }

        private void OutIndex(int index)
        {
            if (index > Count - 1)
            {
                throw new Exception("Индекс за пределами диапазона");
            }
        }

        public int CompareTo(T other)
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            var item = First;
            while (item != null)
            {
                yield return item.data;
                item = item.next;
            }
        }
        #endregion
    }
}
