using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuthorsAndBooks
{
    public class Presenter
    {
        private readonly IModel _iModel;

        private readonly IView _IView;

        public int Index;
        public string Text;


        public Presenter(IModel iModel, IView iView)
        {


            Text = " ";
            _iModel = iModel;
            _IView = iView;
            _IView.Load_File += new EventHandler<EventArgs>(LoadFile);
            _IView.Load_File += new EventHandler<EventArgs>(ShowAllAuthor);
            _IView.Load_File += new EventHandler<EventArgs>(ShowAllBooks);


            _IView.Delete_Author += new EventHandler<EventArgs>(DeleteAuthor);
            _IView.Delete_Author += new EventHandler<EventArgs>(ShowAllAuthor);
            _IView.Delete_Author += new EventHandler<EventArgs>(ShowAllBooks);


            _IView.Add_Book_Name += new EventHandler<EventArgs>(AddBook);

            _IView.Add_Book_Name += new EventHandler<EventArgs>(ShowAllBooks);


            _IView.Show_All += new EventHandler<EventArgs>(ShowAllAuthor);
            _IView.Show_All += new EventHandler<EventArgs>(ShowAllBooks);


            _IView.Add_Author += new EventHandler<EventArgs>(AddAuthor);
            _IView.Add_Author += new EventHandler<EventArgs>(ShowAllAuthor);



            _IView.Change_Book_Name += new EventHandler<EventArgs>(ChangeBookName);

            _IView.Change_Book_Name += new EventHandler<EventArgs>(ShowAllBooks);

            _IView.Delete_Book_Name += new EventHandler<EventArgs>(DeleteBookName);

            _IView.Delete_Book_Name += new EventHandler<EventArgs>(ShowAllBooks);



            _IView.Change_Author += new EventHandler<EventArgs>(ChangeAuthor);
            _IView.Change_Author += new EventHandler<EventArgs>(ShowAllAuthor);


            _IView.Save_File += new EventHandler<EventArgs>(SAVE);
            _IView.Save_File += new EventHandler<EventArgs>(ShowAllAuthor);
            _IView.Save_File += new EventHandler<EventArgs>(ShowAllBooks);


            _IView.Load_File += new EventHandler<EventArgs>(LoadFile);
            _IView.Load_File += new EventHandler<EventArgs>(ShowAllAuthor);
            _IView.Load_File += new EventHandler<EventArgs>(ShowAllBooks);


            _IView.Show_Books_Author += new EventHandler<EventArgs>(ShowAllBooks_A);

        }


        public void SAVE(object sender, EventArgs e)
        {
            try
            {
                _iModel.SaveFile(_IView.Text);
            }
            catch (Exception mes)
            {
                _IView.ShowErrorMessages(mes.Message);
            }
        }


        public void ChangeBookName(object sender, EventArgs e)
        {
            try
            {
                _iModel.ChangeBookName(_IView.indexBook, _IView.Text, _IView.curBook);
            }
            catch (Exception mes)
            {
                _IView.ShowErrorMessages(mes.Message);
            }
        }


        public void ChangeAuthor(object sender, EventArgs e)
        {
            try
            {
                _iModel.ChangeAuthor(_IView.indexAuthor, _IView.Text);
            }
            catch (Exception mes)
            {
                _IView.ShowErrorMessages(mes.Message);
            }
        }


        public void AddAuthor(object sender, EventArgs e)
        {
            _iModel.AddAuthor(_IView.Text);
        }


        public void ShowAllAuthor(object sender, EventArgs e)
        {
            _IView.WriteAllAuthors(_iModel.ShowAllAuthors());
        }


        public void ShowAllBooks(object sender, EventArgs e)
        {
            _IView.WriteAllBooks(_iModel.ShowAll());
        }


        public void ShowAllBooks_A(object sender, EventArgs e)
        {
            _IView.WriteAllBooks(_iModel.ShowBooksAuthor(_IView.curAuthor));
        }


        public void AddBook(object sender, EventArgs e)
        {
            try
            {
                _iModel.AddBookName(_IView.indexAuthor, _IView.Text);
            }
            catch (Exception mes)
            {
                _IView.ShowErrorMessages(mes.Message);
            }
        }


        public void DeleteBookName(object sender, EventArgs e)
        {
            try
            {
                _iModel.DeleteBookName(_IView.indexAuthor, _IView.curBook);
            }
            catch (Exception mes)
            {
                _IView.ShowErrorMessages(mes.Message);
            }
        }


        public void DeleteAuthor(object sender, EventArgs e)
        {
            try
            {
                _iModel.DeleteAuthor(_IView.indexAuthor);
            }
            catch (Exception mes)
            {
                _IView.ShowErrorMessages(mes.Message);
            }
        }


        private void LoadFile(object sender, EventArgs e)
        {
            try
            {
                _iModel.LoadFile(_IView.Text);
            }
            catch (Exception mes)
            {
                _IView.ShowErrorMessages(mes.Message);
            }
        }
    }


}

