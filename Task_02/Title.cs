using System;

namespace Task_02
{
    internal class Title
    {
        readonly string title;
        public Title(string title)
        {
            this.title = title;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(title);
        }
    }
}
