using System.CodeDom.Compiler;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Lab10.Demo2
{
    internal class ClsEmpList : List<ClsEmp>
    {
        public ClsEmpList()
        {
            List<ClsEmp> Emps = GetEmps();
            if (Emps != null)
            {
                foreach (var emp in Emps)
                {
                    Add(emp);
                }
            }
        }

        private List<ClsEmp> GetEmps()
        {
            string json = File.ReadAllText(_filePath);
            if (string.IsNullOrEmpty(json)) return null;
            List<ClsEmp> Emps = JsonSerializer.Deserialize<List<ClsEmp>>(json);
            return Emps;
        }

        string _filePath = @"E:\Courses\ITI\C#\Advanced\Day3\Lab10\Lab10.Demo2\save.json";
        public new void Add(ClsEmp e)
        {

            foreach (var emp in this)
            {
                if (emp.Id == e.Id)
                    return;
            }
            base.Add(e);
            SaveToFile();
        }

        public new void Remove(ClsEmp e)
        {
            if (e == null) return;
            foreach (var emp in this)
            {
                if (emp.Id == e.Id)
                {
                    e = emp;
                    break;
                }
            }
            base.Remove(e);
            SaveToFile();
        }

        public bool Update(ClsEmp e, string name, byte age = 0, double salary = 0)
        {
            if (e == null) return false;
            e.SetName(name);
            e.SetAge(age);
            e.SetSalary(salary);
            SaveToFile();
            return true;
        }

        private void SaveToFile()
        {
            var jsonOption = new JsonSerializerOptions();
            jsonOption.WriteIndented = true;
            string json = JsonSerializer.Serialize(this, jsonOption);
            File.WriteAllText(this._filePath, json);
        }
    }
}
