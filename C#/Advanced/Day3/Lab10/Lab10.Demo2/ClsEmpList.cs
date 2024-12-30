using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10.Demo2
{
    internal class ClsEmpList : List<ClsEmp>
    {
        string _filePath = @"E:\Courses\ITI\C#\Advanced\Day3\Lab10\Lab10.Demo2\save.txt";
        public new void Add(ClsEmp e)
        {
            base.Add(e);
            UpdateFile();
        }

        public new void Remove(ClsEmp e)
        {
            base.Remove(e);
            UpdateFile();
        }

        private void UpdateFile()
        {
            StreamWriter sw = new StreamWriter(_filePath);
            sw.Close();
            sw = new StreamWriter(_filePath, true);
            foreach (var item in this)
            {
                sw.WriteLine(item);
            }
            sw.Close();
        }
    }
}
