using System;

namespace Task_02
{
    internal class Author
    {
        readonly string author;
        public Author(string author)
        {
            this.author = author;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(author);
        }
    }
}
