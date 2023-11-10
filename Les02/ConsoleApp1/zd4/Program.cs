using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd4
{
    using System;

    public abstract class Log
    {
        public abstract void Debug(string message);
        public abstract void Info(string message);
        public abstract void Warn(string message);
        public abstract void Error(string message);
        public abstract void Crit(string message);
    }

    public class ConsoleLog : Log
    {
        public override void Debug(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"[DEBUG] {message}");
            Console.ResetColor();
        }

        public override void Info(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"[INFO] {message}");
            Console.ResetColor();
        }

        public override void Warn(string message)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"[WARN] {message}");
            Console.ResetColor();
        }

        public override void Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"[ERROR] {message}");
            Console.ResetColor();
        }

        public override void Crit(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[CRIT] {message}");
            Console.ResetColor();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleLog logger = new ConsoleLog();
            logger.Debug("Debug message");
            logger.Info("Info message");
            logger.Warn("Warning message");
            logger.Error("Error message");
            logger.Crit("Critical message");
            Console.ReadLine();
        }
    }
}
