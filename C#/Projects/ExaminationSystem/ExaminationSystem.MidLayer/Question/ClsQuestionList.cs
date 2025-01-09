using ExaminationSystem.MidLayer.Subject;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text.Json;

namespace ExaminationSystem.MidLayer.Question
{
    public class ClsQuestionList<T> : List<ClsQuestion> where T : ClsSubject
    {

        JsonSerializerSettings settings = new JsonSerializerSettings
        {
            TypeNameHandling = TypeNameHandling.Objects,
            Formatting = Formatting.Indented,
            NullValueHandling = NullValueHandling.Ignore,
        };

        private static int _questionListCount;
        private string _fileName;
        public int Id
        {
            get; set;
        }
        public string SubjectName { get; init; }
        public ClsQuestionList(string subjectName)
        {
            _questionListCount++;
            Id = _questionListCount;
            SubjectName = subjectName.ToUpper();
            _fileName = $"{SubjectName}QuestionList.json";
            ReadFromFile();
        }


        public new bool Add(ClsQuestion question)
        {
            if (question == null || Exists(q => question.Body == q.Body)) return false;
            if (Count < 5)
            {
                question.Id = Count + 1;
                base.Add(question);
                SaveToFile();
                return true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Question List is Full , Can't Add Question");
                Console.ResetColor();
                return false;
            }
        }

        public new bool Remove(ClsQuestion question)
        {
            if (base.Remove(question))
            {
                SaveToFile();
                return true;
            }
            return false;
        }


        void SaveToFile()
        {
            string json = JsonConvert.SerializeObject(this, settings);
            File.WriteAllText(_fileName, json);
        }

        public void ReadFromFile()
        {
            if (File.Exists(_fileName))
            {
                string jsonString = File.ReadAllText(_fileName);
                var questions = JsonConvert.DeserializeObject<List<ClsQuestion>>(jsonString, settings);
                AddRange(questions);
            }
        }


        public void PrintQuestionList()
        {
            if (this?.Count > 0)
            {
                Console.WriteLine($"Question List({Id}) :");
                Console.WriteLine("=====================================================================================\n");
                foreach (var question in this)
                {
                    Console.WriteLine($"{question}");
                    Console.WriteLine();
                }
                Console.WriteLine("=====================================================================================\n");
            }
        }
    }
}
