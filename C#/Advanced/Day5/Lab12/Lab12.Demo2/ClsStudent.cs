namespace Lab12.Demo2
{
    internal class ClsStudent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public EventHandler AbsentAndHandler;
        public EventHandler FialHandler;
        public int AbsentDays { get; private set; }
        public int NumberOfFails { get; private set; }
        public void IncreaseAbsentDays()
        {
            AbsentDays++;
            if (AbsentDays >= 3)
                AbsentAndHandler?.Invoke(this, null);
        }
        public void IncreaseFails()
        {
            AbsentDays++;
            if (AbsentDays >= 3)
                FialHandler?.Invoke(this, null);
        }

        public override string ToString()
        {
            return $"Student data : ID : {Id} , Name : {Name}";
        }
    }
}
