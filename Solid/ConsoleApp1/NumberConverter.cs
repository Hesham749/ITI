using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public enum BaseType : Byte
    {
        Binary = 2,
        Octal = 8,
        None = 0
    }
    internal class NumberConverter
    {
        public int DecimalNumber { get; set; }
        public Logger Logger { get; set; } = new();
        public Reader Reader { get; set; } = new();
        public void Convert()
        {
            Logger.Log("Program is starting...");
            Logger.Log("Enter the number to convert:");
            DecimalNumber = Reader.ReadInteger();
            Logger.Log("Enter the base type (Ex: 2,8):");
            var baseType = (BaseType)Reader.ReadInteger();

            string result = baseType switch
            {
                BaseType.Binary => System.Convert.ToString(DecimalNumber, 2),
                BaseType.Octal => System.Convert.ToString(DecimalNumber, 8),
                _ => "No base found!",
            };

            Logger.Log($"The result is: {result} ");
            Logger.Log("Program is ending..");

        } 
    }

    public class Logger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class Reader
    {
        public int ReadInteger() => int.Parse(Console.ReadLine());
    }

    public interface IConverter
    {
        public int DecimalNumber { get; set; }

        public void Convert();
    }



}
