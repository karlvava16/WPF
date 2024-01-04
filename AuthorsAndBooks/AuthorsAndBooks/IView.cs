using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorsAndBooks
{
    public interface IView
    {
        event EventHandler<EventArgs> Show_All;
        event EventHandler<EventArgs> Add_Author;
        event EventHandler<EventArgs> Change_Author;
        event EventHandler<EventArgs> Delete_Author;
        event EventHandler<EventArgs> Add_Book_Name;
        event EventHandler<EventArgs> Change_Book_Name;
        event EventHandler<EventArgs> Delete_Book_Name;
        event EventHandler<EventArgs> Show_Books_Author;
        event EventHandler<EventArgs> Save_File;
        event EventHandler<EventArgs> Load_File;


        int indexBook { get; set; }
        int indexAuthor { get; set; }
        string Text { get; set; }
        string curAuthor { get; set; }
        string curBook { get; set; }
        void ShowErrorMessages(string message);

        void WriteAllBooks(List<string> list);
        void WriteAllAuthors(List<string> list);

    }
}
