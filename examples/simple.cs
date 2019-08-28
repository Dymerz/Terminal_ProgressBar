using System;
using System.Collections.Generic;

namespace Terminal_ProgressBar
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a list
            List<string> list = new List<string>()
            {
                "Hello.txt", "README.md", "Long_title.txt", "my.mp4", "paswords.txt", "who is", "Task to do"
            };

            // iterate through the list
            foreach (string item in new ProgressBar(list))
            {
                Console.Write("Processing: " + item);

                // do some long task here
                System.Threading.Thread.Sleep(750);

                Console.Write(" Done\n");
            }

            Console.ReadKey();
        }
    }
}
