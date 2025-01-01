using System.Text.Json;

namespace Lab10.Demo2
{
    internal class ClsEmpList : List<ClsEmp>
    {
        public ClsEmpList()
        {
            string json = File.ReadAllText(_filePath);
            List<ClsEmp> Emps = JsonSerializer.Deserialize<List<ClsEmp>>(json);
            foreach (var emp in Emps)
            {
                Add(emp);
            }
            foreach (var item in Emps)
            {
                Console.WriteLine(item);
            }
        }

        string _filePath = @"D:\Courses\ITI\C#\Advanced\Day3\Lab10\Lab10.Demo2\save.json";
        public new void Add(ClsEmp e)
        {

            base.Add(e);
            SaveToFile();
        }

        public new void Remove(ClsEmp e)
        {
            JsonSerializer.Deserialize<List<ClsEmp>>(File.ReadAllText(_filePath));
            base.Remove(e);

        }


        private void SaveToFile()
        {

            string json = JsonSerializer.Serialize(this);
            File.AppendAllText(this._filePath, json);
        }
    }
}
