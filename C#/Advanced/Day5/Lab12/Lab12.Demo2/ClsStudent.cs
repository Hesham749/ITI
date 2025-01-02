namespace Lab12.Demo2
{
    internal class ClsStudent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        event Action<ClsStudent> FireStudentEvent;
        public int AbsentDays { get; private set; }
        public int NumberOfFails { get; private set; }

        public void FireStudentRegister(Action<ClsStudent> reg)
        {
            FireStudentEvent += reg;
        }

        public void FireStudentUnRegister(Action<ClsStudent> reg)
        {
            FireStudentEvent -= reg;
        }

        public void IncreaseAbsentDays()
        {
            AbsentDays++;
            if (AbsentDays >= 3)
                FireStudentEvent?.Invoke(this);
        }

        public void IncreaseFails()
        {
            NumberOfFails++;
            if (NumberOfFails >= 3)
                FireStudentEvent?.Invoke(this);
        }

        public override string ToString()
        {
            return $"Student data : ID : {Id} , Name : {Name}";
        }
    }
}
