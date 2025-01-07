using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ExaminationSystem.MidLayer
{
    public class ClsSubjectList
    {
        string _filePath = "SubjectList.json";
        public SortedList<string, ClsSubject> SubList { get; private set; } = new SortedList<string, ClsSubject>();
        public bool Add(ClsSubject sub)
        {
            int c = SubList.Count;
            if (!SubList.ContainsKey(sub.Name))
                SubList.Add(sub.Name, sub);
            else
                sub = SubList[sub.Name];
            if (SubList.Count == c + 1)
            {
                SaveToFile();
                return true;
            }
            return false;
        }
        static ClsSubjectList sL;

        private ClsSubjectList()
        {
            foreach (var sub in ReadFile())
            {
                SubList.Add(sub.Key, new(sub.Value.Name, sub.Value.StdList));
            }
        }
        public static ClsSubjectList CreateSubList()
        {
            if (sL == null)
                return new ClsSubjectList();
            return sL;
        }

        public new bool Remove(ClsSubject sub)
        {
            if (SubList.Remove(sub.Name))
            {
                SaveToFile();
                return true;
            }
            return false;

        }

        void SaveToFile()
        {
            var options = new JsonSerializerOptions();
            options.WriteIndented = true;
            File.WriteAllText(_filePath, JsonSerializer.Serialize(SubList, options));
        }



        SortedList<string, ClsSubject> ReadFile()
        {
            if (!File.Exists(_filePath))
            {
                var sw1 = new StreamWriter(_filePath);
                sw1.Close();
            }

            string jsonString = File.ReadAllText(_filePath);
            if (string.IsNullOrEmpty(jsonString)) return SubList;
            return JsonSerializer.Deserialize<SortedList<string, ClsSubject>>(jsonString) ?? SubList;
        }

        //public override string ToString()
        //{

        //}


    }
}
