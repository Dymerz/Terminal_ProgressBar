using System;
using System.Collections.Generic;

namespace Terminal_ProgressBar
{
    class Program2
    {
        static void Main2(string[] args)
        {
            // create a list
            List<string> list = new List<string>()
            {
                "Hello.txt", "README.md", "Long_title.txt", "my.mp4", "paswords.txt", "whois", "Todo"
            };

            // iterate through the list
            foreach (string item in new ProgressBar(list, clear_line: true, auto_title: true))
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
