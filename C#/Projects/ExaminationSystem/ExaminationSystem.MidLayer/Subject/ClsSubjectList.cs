using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ExaminationSystem.MidLayer.Subject
{
    public static class ClsSubjectList
    {
        static JsonSerializerSettings settings = new JsonSerializerSettings()
        {
            TypeNameHandling = TypeNameHandling.Objects,
            Formatting = Formatting.Indented,
            NullValueHandling = NullValueHandling.Ignore
        };
        static string _filePath = "SubjectList.json";
        static public Dictionary<string, ClsSubject> SubList { get; private set; } = new Dictionary<string, ClsSubject>();
        static public bool Add(ClsSubject sub)
        {
            int c = SubList.Count;
            if (!SubList.ContainsKey(sub.Name))
                SubList.Add(sub.Name, sub);
            if (SubList.Count == c + 1)
            {
                SaveToFile();
                return true;
            }
            return false;
        }

        static ClsSubjectList()
        {
            SubList = ReadFile();
        }


        static public bool Remove(ClsSubject sub)
        {
            if (SubList.Remove(sub.Name))
            {
                SaveToFile();
                return true;
            }
            return false;

        }

        static void SaveToFile()
        {
            File.WriteAllText(_filePath, JsonConvert.SerializeObject(SubList, settings));
        }



        static Dictionary<string, ClsSubject> ReadFile()
        {
            if (!File.Exists(_filePath))
            {
                var sw1 = new StreamWriter(_filePath);
                sw1.Close();
            }

            string jsonString = File.ReadAllText(_filePath);
            if (string.IsNullOrEmpty(jsonString)) return SubList;
            var subList = JsonConvert.DeserializeObject<Dictionary<string, ClsSubject>>(jsonString);
            return subList ?? SubList;
        }

        public static string Print()
        {
            string s = "";
            SortedSet<ClsSubject> sorted = SortedSubjectSet();
            foreach (var item in sorted)
            {
                s += $"{item.Id}) {item.Name} \t";
            }
            s = s.Trim();
            return s;
        }

        private static SortedSet<ClsSubject> SortedSubjectSet()
        {
            SortedSet<ClsSubject> sorted = [];
            foreach (var sub in SubList)
            {
                sorted.Add(sub.Value);
            }
            return sorted;
        }
    }
}
