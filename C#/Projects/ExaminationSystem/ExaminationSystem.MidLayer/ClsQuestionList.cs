using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ExaminationSystem.MidLayer
{
    internal class ClsQuestionList : List<ClsQuestion>
    {
        private static int _questionListCount;
        private string _fileName;
        public int Id
        {
            get; private set;
        }
        public ClsQuestionList()
        {
            Id = ++_questionListCount;
            _fileName = $"QuestionList{Id}.json";
            ClsQuestionList questions = GetQuestionList();
            if (questions?.Count > 0)
            {
                foreach (var question in questions)
                    Add(question);
            }
        }

        public new void Add(ClsQuestion question)
        {
            base.Add(question);
        }

        ClsQuestionList GetQuestionList()
        {
            string jsonString = File.ReadAllText(_fileName);
            if (jsonString == "") return null;
            return JsonSerializer.Deserialize<ClsQuestionList>(jsonString);
        }

    }
}
