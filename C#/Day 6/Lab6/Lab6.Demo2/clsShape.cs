namespace Lab6.Demo2
{
    internal abstract class clsShape
    {
        public int Diminsion1 { get; protected set; }
        public int Diminsion2 { get; protected set; }

        public virtual bool SetDiminsion1(int dim)
        {
            if (dim < 1)
                return false;
            Diminsion1 = dim;
            return true;
        }

        public virtual bool SetDiminsion2(int dim)
        {
            if (dim < 1)
                return false;
            Diminsion2 = dim;
            return true;
        }

        public abstract float GetArea();

        public abstract void ShapeStatus();
    }
}
