using System.Text.Json;

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
                {
                    base.Add(question);
                }
            }

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

         new bool Remove(ClsQuestion question)
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
