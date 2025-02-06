using System.Collections;
namespace Enumerators_Iterators.IEnumerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Intgers fiveIntergers = new(4, 5, 3, 2, 1);
            List<int> I1 = [];
            foreach (int item in fiveIntergers)
            {
                I1.Add(item);
                Console.WriteLine(item);
            }
            I1.Sort();
            Console.WriteLine();
            foreach (var item in I1)
            {
                Console.WriteLine(item);
            }
        }
    }
    class Intgers : IEnumerable<int>, IComparable
    {
        int[] _vlaues;
        public Intgers(params int[] ints)
        {
            _vlaues = ints;
        }

        public int CompareTo(object? obj)
        {
            if (obj is null)
                return 1;
            var Intg = obj as Intgers;
            if (Intg is null)
                throw new ArgumentException("object is not a Integers");
            return Intg.CompareTo(_vlaues);

        }

        public IEnumerator<int> GetEnumerator()
        {
            return ((IEnumerable<int>)_vlaues).GetEnumerator();
        }

        System.Collections.IEnumerator IEnumerable.GetEnumerator()
        {
            return _vlaues.GetEnumerator();
        }

        //public System.Collections.IEnumerator GetEnumerator()
        //{
        //    foreach (var item in _vlaues)
        //    {
        //        yield return item;
        //    }
        //}

        //IEnumerator<int> IEnumerable<int>.GetEnumerator()
        //{
        //    return ((IEnumerable<int>)_vlaues).GetEnumerator();
        //}
    }


}
