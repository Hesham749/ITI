using System.Collections;
using System.Linq;
using System;
namespace Enumerators_Iterators.IEnumerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Intgers fiveIntergers = new(1, 2, 3, 4, 5);
            foreach (var item in fiveIntergers)
            {
                Console.WriteLine(item);
            }
        }
    }
    class Intgers : IEnumerable
    {
        int[] _vlaues;
        public Intgers(params int[] ints)
        {
            _vlaues = ints;
        }

        public System.Collections.IEnumerator GetEnumerator()
        {
            foreach (var item in _vlaues)
            {
                yield return item;
            }
        }
    }


}
