using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Используя Visual Studio, создайте проект по шаблону Console Application. 
             * Требуется: Создать класс Book. Создать классы Title, Author и Content, 
             * каждый из которых должен содержать одно строковое поле и метод void Show(). 
             * Реализуйте возможность добавления в книгу названия книги, имени автора и содержания. 
             * Выведите на экран разными цветами при помощи метода Show() название книги, имя автора и содержание. 
             */

            string title = "The Great Gatsby";
            string author = "F. Scott Fitzgerald";
            string content = "The Great Gatsby is a 1925 novel by American writer F. Scott Fitzgerald. Set in the Jazz Age on Long Island, near New York City, the novel depicts first-person narrator Nick Carraway's interactions with mysterious millionaire Jay Gatsby and Gatsby's obsession to reunite with his former lover, Daisy Buchanan...";

            Book book = new Book(title, author, content);
            book.Show();

            Console.ReadKey();

        }
    }
}
