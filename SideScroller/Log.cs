using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;

namespace SideScroller
{
    public static class Log
    {
        private static string LogFile;
        private static bool DebugMode;

        public static void Initialize(string logfile, bool debug = false)
        {
            DebugMode = debug;
            LogFile = logfile;
            if (debug)
                Win32.Console.AllocConsole();
        }

        public static void Write(string Key, string Message, ConsoleColor color = ConsoleColor.Black)
        {
            StackTrace trace = new StackTrace();
            StackFrame frame = null;

            frame = trace.GetFrame(2);

            string caller = "";

            if (frame != null && frame.GetMethod().DeclaringType != null)
            {
                caller = frame.GetMethod().DeclaringType.Name + ": ";
            }

            String text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture) + " - " + caller + Message;

            if (DebugMode)
            {
                Console.ForegroundColor = color;
                Console.WriteLine(text);
                Console.ResetColor();
            }
            
            File.AppendAllText(LogFile, text);
            
        }

        public static void Info(string Message)
        {
            Write("INFO", Message);
        }
        public static void Error(string Message)
        {
            Write("ERROR", Message, ConsoleColor.Red);
        }
        public static void Data(string Message)
        {
            Write("DATA", Message, ConsoleColor.Green);
        }

        public static void Debug(string Message)
        {
            Write("DEBUG", Message, ConsoleColor.Blue);
        }
    }
}
