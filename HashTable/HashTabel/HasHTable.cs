using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestC
{
    public class HashTable<T>
    {
        public List<T>[] items { get; private set; }

        const float A = 0.618f;

        public HashTable(int size)
        {
            items = new List<T>[size];
        }

        
        private int getHash(T value)
        {
            float sum = 1000.0f;
            bool IsDigit = value.ToString().Length == value.ToString().Where(c => Char.IsDigit(c)).Count();

            if (IsDigit)
                return (int)(items.Length * (Convert.ToInt32(value) * A % 1));

            byte[] bytes = Encoding.Unicode.GetBytes(value.ToString());
            

            for (int i = 0; i < bytes.Length / 2; i++)
            {
                
                if(bytes[i] != 0)
                    sum /= bytes[i];
            }
            sum *= 1000;

            return (int)(items.Length * ((int)sum * A % 1));
        }

        private bool findEl(T value)
        {
            int index = getHash(value);

            foreach (var el in items[index])
                if (el.Equals(value)) return true;

            return false;
        }

        public void Add(T value)
        {
            int index = getHash(value);

            if (items[index] == null) items[index] = new List<T> { value };
            
            else if (!items[index].Contains(value))
            {
                items[index].Add(value);
            }
                
        }

        public void Delete(T value)
        {
            int index = getHash(value);

            foreach (var el in items[index])
                if (el.Equals(value)) items[index].Remove(value);
        }

        public bool Find(T value)
        {
            return findEl(value);
        }

        public int GetIndex(T value)
        {
            if (findEl(value))
                return getHash(value);

            return default;
        }

        public int GetHash(T value)
        {
            return getHash(value);
        }
    }
}