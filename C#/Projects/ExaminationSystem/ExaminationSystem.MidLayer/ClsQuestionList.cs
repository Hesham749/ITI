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
            get; private set;
        }
        [JsonConstructor]
        public ClsQuestionList(int id)
        {
            _questionListCount++;
            Id = id;
            _fileName = $"QuestionList{Id}.json";
            ClsQuestionList questions = ReadFile();
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



        ClsQuestionList ReadFile()
        {
            Console.WriteLine(_questionListCount);
            if (!File.Exists(_fileName))
            {
                var sw1 = new StreamWriter(_fileName);
                sw1.Close();
            }

            var jsonString = File.ReadAllText(_fileName);
            if (!string.IsNullOrEmpty(jsonString))
                return JsonSerializer.Deserialize<ClsQuestionList>(jsonString);
            return this;
        }

        public void PrintQuestionList()
        {
            if (this != null)
            {
                foreach (var question in this)
                {
                    Console.WriteLine($"{question.Id}{question}");
                }
            }
        }
    }
}
