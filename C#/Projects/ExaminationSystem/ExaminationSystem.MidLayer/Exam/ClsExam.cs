using ExaminationSystem.MidLayer.Answer;
using ExaminationSystem.MidLayer.Question;
using ExaminationSystem.MidLayer.Subject;
using ExaminationSystem;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.MidLayer.Exam
{

    public abstract class ClsExam<T> where T : ClsSubject
    {
        System.Timers.Timer _timer = new(1000);
        private enExamMode _mode;

        public enum enExamMode
        {
            Started = 1,
            Queued,
            Finished
        }
        public ClsAnswerList StdAnswers { get; protected set; } = new();
        public string Name { get; protected set; } = string.Empty;
        public int TotalGrade { get; set; } = 0;
        public int StdGrade { get; set; } = 0;
        public enExamMode Mode
        {
            get => _mode;
            protected set
            {
                _mode = value;
                if (value != enExamMode.Started)
                    _timer.Stop();
                else
                {
                    TimeRemaining = Time;
                    _timer.Start();
                }
            }
        }
        public TimeSpan Time { get; protected set; }
        public TimeSpan TimeRemaining { get; protected set; }
        protected ClsExam()
        {
            Mode = enExamMode.Queued;
            _timer.Elapsed += OnTimeEvent;
        }

        private void OnTimeEvent(object? sender, EventArgs e)
        {
            if (TimeRemaining - TimeSpan.FromSeconds(1) == TimeSpan.Zero)
                Mode = enExamMode.Finished;
            TimeRemaining -= TimeSpan.FromSeconds(1);
            int left = 100, top = 5, aleft = Console.CursorLeft, atop = Console.CursorTop;
            Console.CursorVisible = false;
            Console.SetCursorPosition(left, top);
            if (TimeRemaining > Time / 2)
                Console.WriteLine($"Time remaining :{TimeRemaining}");
            else if (TimeRemaining > Time / 3)
                ClsColorText.ColorText($"Time remaining :{TimeRemaining}", ConsoleColor.Yellow);
            else
                ClsColorText.ColorText($"Time remaining :{TimeRemaining}", ConsoleColor.Red);
            Console.CursorVisible = true;
            Console.SetCursorPosition(aleft, atop);
        }

        public virtual void StartExam(T sub, ClsStudent st)
        {
            Name += $" {sub.Name} exam";
            Mode = enExamMode.Started;
            ClsColorText.ColorText("================================================================================================", ConsoleColor.Cyan);
            Console.WriteLine($"                                {Name} has {Mode}                    Time:{Time}         ");
            ClsColorText.ColorText("================================================================================================", ConsoleColor.Cyan);

        }

        void StartTimer(enExamMode mode)
        {
            if (mode == enExamMode.Started)
            {
                _timer.Elapsed += OnTimeEvent;

            }
            else
                _timer.Stop();
        }

        //private void OnTimeEvent(object? sender, System.Timers.ElapsedEventArgs e)
        //{
        //    if (MyTime + TimeSpan.FromSeconds(2) == TimeSpan.Zero || _mode != enExamMode.Started)
        //        _timer.Stop();
        //    _timer.Start();
        //    MyTime -= TimeSpan.FromSeconds(1);
        //    int left = 100, top = 5, aleft = Console.CursorLeft, atop = Console.CursorTop;
        //    Console.CursorVisible = false;
        //    Console.SetCursorPosition(left, top);
        //    Console.WriteLine($"Time remaining :{MyTime}");
        //    Console.CursorVisible = true;
        //    Console.SetCursorPosition(aleft, atop);
        //}

        protected void PrintAnswerResult(ClsQuestion q, ClsAnswer answer)
        {
            if (answer.Mark == q.Mark)
                ClsColorText.ColorText("Great job correct answer", ConsoleColor.DarkGreen);

            else
            {
                ClsColorText.ColorText("oops wrong answer", ConsoleColor.Red);
                ClsColorText.ColorText($"correct answer is {q.GetAnswer()}", ConsoleColor.Yellow);
            }
        }

        protected ClsAnswer GetAnswer(ClsQuestion q)
        {
            ClsAnswer answer = new();
            bool wrongAnswer = false;
            char c = ' ';
            int y = 0;
            do   //this
            {
                if (c == 13)
                {
                    wrongAnswer = true;
                    break;
                }
                int.TryParse((c = Console.ReadKey().KeyChar).ToString(), out y);

                if (y < q.Options.Count && y >= 1 && !answer.Answer.ContainsKey(y))
                    answer.Answer.Add(y, q.Options[y]);

            } while (y == 0 || c != 13);
            if (answer.Answer.Count > q.CorrectAnswer.Length || !q.CorrectAnswer.Contains(y))  // this
                wrongAnswer = true;
            answer.Mark = (wrongAnswer) ? 0 : q.Mark;
            return answer;
        }

        protected List<ClsQuestion> GetQuestionList(ClsSubject sub, int size)
        {
            var ql = new List<ClsQuestion>();
            size = size <1 ? 4 : size;
            if (size >= sub.QuestionList.Count)
                return sub.QuestionList;
            ClsQuestion q;
            do
            {
                Random random = new();
                int x = random.Next(0, sub.QuestionList.Count);
                q = sub.QuestionList[x];
                if (!ql.Contains(q))
                {
                    ql.Add(q);
                    TotalGrade += q.Mark;
                }
            } while (ql.Count < size);
            return ql;
        }



    }
}
