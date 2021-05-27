using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable.HashTabel
{
    class Hash<T>
    {
        public List<T>[] items { get; private set; }

        const float A = 0.618f;

        public Hash(int size)
        {
            items = new List<T>[size];
        }


        private int getHash(T value)
        {
            bool IsDigit = value.ToString().Length == value.ToString().Where(c => Char.IsDigit(c)).Count();

            if (IsDigit)
                return (int)(items.Length * (Convert.ToInt32(value) * A % 1));

            int sum = 5381;
            float hash = 0;

            foreach (var c in value.ToString().ToCharArray())
            {
                unchecked
                {
                    sum = ((sum << 5) + sum) + c;
                }
            }

            hash = Math.Abs(sum) * A % 1;

            return (int)(items.Length * hash);
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
                items[index].Add(value);
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

        public List<T> GetList(int index)
        {
            if (index < items.Length) return items[index];

            return new List<T>();
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
