using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ExaminationSystem.MidLayer
{
    public class ClsQuestionList : List<ClsQuestion>
    {
        private static int _questionListCount;
        private string _fileName;
        public int Id
        {
            get; set;
        }
        public ClsQuestionList()
        {
            _questionListCount++;
            Id = _questionListCount;
            _fileName = $"QuestionList{Id}.json";
            List<ClsQuestion> questions = ReadFile();
            if (questions?.Count > 0)
            {
                foreach (var question in questions)
                    Add(question);
            }
        }


        public new void Add(ClsQuestion question)
        {
            if (question == null || Exists(q => question.Id == q.Id)) return;
            base.Add(question);
            SaveToFile();
        }

        void SaveToFile()
        {
            var options = new JsonSerializerOptions();
            options.WriteIndented = true;
            File.WriteAllText(_fileName, JsonSerializer.Serialize(this, options));
        }



        List<ClsQuestion> ReadFile()
        {
            if (!File.Exists(_fileName))
            {
                var sw1 = new StreamWriter(_fileName);
                sw1.Close();
            }

            string jsonString = File.ReadAllText(_fileName);
            if (string.IsNullOrEmpty(jsonString)) return this;
            return JsonSerializer.Deserialize<List<ClsQuestion>>(jsonString) ?? this;
        }

        public void PrintQuestionList()
        {
            if (this != null)
            {
                Console.WriteLine($"Question List({Id}) :");
                Console.WriteLine("=====================================================================================");
                foreach (var question in this)
                {
                    Console.WriteLine($"{question}");
                }
                Console.WriteLine("=====================================================================================");
            }
        }
    }
}
