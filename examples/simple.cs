using System;
using System.Collections.Generic;

namespace Terminal_ProgressBar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>()
            {
                "Hello.txt", "README.md", "Long_title.txt", "my.mp4", "paswords.txt", "who is", "Task to do"
            };

            foreach (string item in new ProgressBar(list, clear_line: true, title: "Process"))
            {
                Console.Write("Processing: " + item);
                System.Threading.Thread.Sleep(750);
                Console.Write(" Done\n");
            }

            Console.ReadKey();
        }
    }
}
