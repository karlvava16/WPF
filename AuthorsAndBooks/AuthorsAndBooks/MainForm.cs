using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace AuthorsAndBooks
{
    public partial class MainForm : Form, IView
    {

        public MainForm()
        {
            InitializeComponent();
            Show_All?.Invoke(this, EventArgs.Empty);
            MinimizeBox = false;
            MaximizeBox = false;
        }

        public int indexBook { get; set; }
        public int indexAuthor { get; set; }
        public string Text { get; set; }
        public string curAuthor { get; set; }

        public string curBook { get; set; }


        public event EventHandler<EventArgs> Show_All;
        public event EventHandler<EventArgs> Add_Author;
        public event EventHandler<EventArgs> Change_Author;
        public event EventHandler<EventArgs> Delete_Author;
        public event EventHandler<EventArgs> Add_BookName;
        public event EventHandler<EventArgs> Change_BookName;
        public event EventHandler<EventArgs> Delete_BookName;
        public event EventHandler<EventArgs> Show_BooksA;
        public event EventHandler<EventArgs> SaveFile;
        public event EventHandler<EventArgs> LoadFile;

        public void ShowErrorMessages(string mes)
        {

            MessageBox.Show(mes);
        }

        public void WriteAllBooks(List<string> list)
        {

            ListBox.Items.Clear();

            foreach (var item in list)
            {
                ListBox.Items.Add(item);
            }
        }
        public void WriteAllAuthors(List<string> list)
        {
            ChoiseBox.Items.Clear();

            foreach (var item in list)
            {
                ChoiseBox.Items.Add(item);
            }

        }
        private void AddAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                try
                {
                    AddForm form2 = new AddForm("Введите нового Автора");
                    DialogResult result = form2.ShowDialog();

                    if (result == DialogResult.Yes)
                    {
                        Text = form2.newText;
                        Add_Author?.Invoke(this, EventArgs.Empty);
                    }
                    else
                    {
                        throw new Exception("Canceled");
                    }
                }
                catch (Exception mes)
                {

                    MessageBox.Show(mes.Message);
                }
            }
            catch (Exception mes)
            {

                MessageBox.Show(mes.Message);
            }
        }

        private void DeleteAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are u sure ?", "Warning", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Delete_Author?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    throw new Exception("Canceled");
                }
            }
            catch (Exception mes)
            {

                MessageBox.Show(mes.Message);
            }
        }

        private void EditAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                AddForm form2 = new AddForm("Введите нового Автора");
                DialogResult result = form2.ShowDialog();

                if (result == DialogResult.Yes)
                {
                    Text = form2.newText;
                    Change_Author?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    throw new Exception("Canceled");
                }
            }
            catch (Exception mes)
            {

                MessageBox.Show(mes.Message);
            }
        }

        private void AddBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                AddForm form2 = new AddForm("Введите новую книгу");
                DialogResult result = form2.ShowDialog();
                if (result == DialogResult.Yes)
                {
                    Text = form2.newText;
                    Add_BookName?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    throw new Exception("Canceled");
                }
            }
            catch (Exception mes)
            {

                MessageBox.Show(mes.Message);
            }
        }

        private void DeleteBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are u sure", "Warning", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    Delete_BookName?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    throw new Exception("Canceled");
                }
            }
            catch (Exception mes)
            {

                MessageBox.Show(mes.Message);
            }
        }

        private void EditBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                AddForm form2 = new AddForm("Введите новую книгу");
                DialogResult result = form2.ShowDialog();
                if (result == DialogResult.Yes)
                {
                    Text = form2.newText;
                    Change_BookName?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    throw new Exception("Canceled");
                }
            }
            catch (Exception mes)
            {

                MessageBox.Show(mes.Message);
            }
        }

        private void ChoiseBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexAuthor = ChoiseBox.SelectedIndex;
            curAuthor = ChoiseBox.Text;
            if (Filter.Checked)
            {
                Show_BooksA?.Invoke(this, EventArgs.Empty);

            }


        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexBook = ListBox.SelectedIndex;
            if (ListBox.SelectedIndex != -1)
            {
                curBook = ListBox.SelectedItem.ToString();
            }
        }

        private void Filter_CheckedChanged(object sender, EventArgs e)
        {
            curAuthor = ChoiseBox.Text;
            if (Filter.Checked)
            {
                Show_BooksA?.Invoke(this, EventArgs.Empty);

            }
            else
            {
                Show_All?.Invoke(this, EventArgs.Empty);
                indexAuthor = -1;
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Json files(*.json)|*.json";
            if (DialogResult.OK == saveFileDialog.ShowDialog())
            {

                Text = saveFileDialog.FileName;
                SaveFile?.Invoke(this, EventArgs.Empty);
            }

        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Json files(*.json)|*.json";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {


                Text = openFileDialog.FileName;
                LoadFile?.Invoke(this, EventArgs.Empty);
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}