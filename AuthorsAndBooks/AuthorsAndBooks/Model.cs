using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AuthorsAndBooks
{
    public interface IModel
    {

        List<Book> books { get; set; }
        void AddAuthor(string author);
        void ChangeAuthor(int index, string author);
        void DeleteAuthor(int index);
        void AddBookName(int index, string newBookName);
        void ChangeBookName(int index, string author, string curBook);
        void DeleteBookName(int index, string BookName);
        List<string> ShowAll();
        List<string> ShowAllAuthors();
        List<string> ShowBooksAuthor(string A);


        void SaveFile(string name);
        void LoadFile(string name);

    }


    public class Books_Program : IModel
    {

        public List<Book> books { get; set; }
        public string filename { get; set; }

        public Books_Program()
        {
            books = new List<Book>();
        }
        public void AddAuthor(string newAuthor)
        {


            books.Add(new Book("", "title", newAuthor));



        }

        public void AddBookName(int index, string newA)
        {

            if (index < 0 || index > books.Count() || books.Count < 1) { throw new Exception("Автора не сущесвтует"); }

            books[index].Name.Add(newA);


        }

        public void ChangeAuthor(int index, string newAuthor)
        {
            if (index < 0 || index > books.Count() || books.Count < 1) { throw new Exception("Ничего не произошло"); }
            books[index].Author = newAuthor;

        }

        public void ChangeBookName(int index, string newBookName, string curBook)
        {
            if (index < 0 || index > books.Count() || books.Count < 1) { throw new Exception("Что-то пошло не так"); }


            foreach (var item in books)
            {

                if (item.Name.Contains(curBook))
                {
                    item.Name[item.Name.IndexOf(curBook)] = newBookName;
                }


            }



        }



        public void DeleteAuthor(int index)
        {

            if (index < 0 || index > books.Count() || books.Count() == 0) { throw new Exception("Ничего не произошло"); }
            books.RemoveAt(index);

        }

        public void DeleteBookName(int index, string BookName)
        {
            if (index > books.Count()) { throw new Exception("Что-то пошло не так"); }

            foreach (var item in books)
            {
                if (item.Name.Contains(BookName))
                {
                    item.Name.Remove(BookName);
                }
            }




        }

        public void LoadFile(string name)
        {
            string jsonFromFile = File.ReadAllText($"{name}");
            books = JsonSerializer.Deserialize<List<Book>>(jsonFromFile);


        }

        public void SaveFile(string name)
        {
            string json = JsonSerializer.Serialize(books);
            File.WriteAllText(name, json);



        }

        public List<string> ShowAll()
        {
            List<string> list = new List<string>();
            foreach (var item in books)
            {
                foreach (var item2 in item.Name)
                {
                    if (item2 != "")
                    {
                        list.Add(item2);
                    }
                }


            }
            return list;
        }

        public List<string> ShowBooksAuthor(string author)
        {
            List<string> list = new List<string>();
            foreach (var item in books)
            {
                foreach (var item2 in item.Name)
                {
                    if (item.Author.Contains(author))
                    {
                        if (item2 != "")
                        {
                            list.Add(item2);
                        }
                    }
                }

            }
            return list;
        }
        public List<string> ShowAllAuthors()
        {
            List<string> list = new List<string>();
            foreach (var item in books)
            {
                if (!list.Contains(item.Author))
                {
                    list.Add(item.Author);
                }
            }
            return list;
        }
    }


}
