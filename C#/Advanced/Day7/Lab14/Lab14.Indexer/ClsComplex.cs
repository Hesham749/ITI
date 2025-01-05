namespace Lab14.Indexer
{
    internal class ClsComplex
    {
        public int Real { get; set; }
        public int Img { get; set; }
        public int this[int x]
        {
            get
            {
                if (x == 0)
                    return Real;
                else if (x == 1)
                    return Img;
                else throw new IndexOutOfRangeException();

            }
            set
            {
                if (x == 0)
                    Real = value;
                else if (x == 1)
                    Img = value;
                else throw new IndexOutOfRangeException();
            }
        }
    }
}
