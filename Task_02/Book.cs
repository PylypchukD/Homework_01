using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    internal class Book
    {
        readonly Title title;
        readonly Author author;
        readonly Content content;
        public Book(string title, string author, string content)
        {
            this.title = new Title(title);
            this.author = new Author(author);
            this.content = new Content(content);
        }
        public void Show()
        {
            title.Show();
            author.Show();
            content.Show();
        }
    }
}
