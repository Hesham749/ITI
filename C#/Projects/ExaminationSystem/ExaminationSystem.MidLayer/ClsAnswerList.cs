using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ExaminationSystem.MidLayer
{
    public class ClsAnswerList : Dictionary<ClsQuestion, ClsAnswer>
    {


        public new bool Add(ClsQuestion q, ClsAnswer a)
        {
            if (q != null && a != null && Count < 5)
            {

                int c = Count;
                base.Add(q, a);
                if (Count == c + 1)
                    return true;
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Answer List is Full , Can't Add Answer");
                    Console.ResetColor();
                    return false;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Answer Didn't Add");
                Console.ResetColor();
                return false;
            }
        }

        public new bool Remove(ClsQuestion q)
        {
            if (q != null)
            {
                int c = Count;
                base.Remove(q);
                if (Count == c - 1)
                    return true;
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Answer Didn't Remove");
                    Console.ResetColor();
                    return false;
                }

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Question is not exist");
                Console.ResetColor();
                return false;
            }

        }

    }
}
