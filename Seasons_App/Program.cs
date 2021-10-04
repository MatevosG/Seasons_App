using System;
using System.Collections;
using System.Collections.Generic;

namespace Customer_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Seasons seasons = new Seasons();

            foreach (string item in seasons)
            {
                Console.WriteLine(item);
            }
        }
    }

    public class Seasons : IEnumerable
    {
        private string[] _items = new string[] { "Winter", "Spring", "Summer", "Autumn" };      
        public IEnumerator GetEnumerator()
        {
            return new Enumerator(_items);
        }
    }
    public class Enumerator : IEnumerator
    {
        private string[] items;
        private int count;
        public Enumerator(string[] items)
        {
            this.items = items;
        }
        public object Current => items[count++];
        public bool MoveNext()
        {
            return count < items.Length;
        }
        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}