using System;
using System.Collections.Generic;
using System.Text;

namespace NoteApp
{
    class View
    {
        public string UserInput()
        {
            Console.WriteLine("Input -> ");
            return Console.ReadLine();
        }

        public void ViewOutLine(String line)
        {
            Console.WriteLine(line);
        }

        public void ViewOutList(String[] list)
        {
            foreach (var line in list)
            {
                Console.WriteLine($"-> {line}");
            }
        }
    }
}
