namespace AuthorsAndBooks
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            FileToolStripMenuItem = new ToolStripMenuItem();
            OpenToolStripMenuItem = new ToolStripMenuItem();
            SaveToolStripMenuItem = new ToolStripMenuItem();
            ExitToolStripMenuItem = new ToolStripMenuItem();
            OptionsToolStripMenuItem = new ToolStripMenuItem();
            AddAuthorToolStripMenuItem = new ToolStripMenuItem();
            DeleteAuthorToolStripMenuItem = new ToolStripMenuItem();
            EditAuthorToolStripMenuItem = new ToolStripMenuItem();
            AddBookToolStripMenuItem = new ToolStripMenuItem();
            DeleteBookToolStripMenuItem = new ToolStripMenuItem();
            EditBookToolStripMenuItem = new ToolStripMenuItem();
            Filter = new CheckBox();
            ChoiseBox = new ComboBox();
            ListBox = new ListBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { FileToolStripMenuItem, OptionsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(700, 24);
            menuStrip1.TabIndex = 0;
            // 
            // FileToolStripMenuItem
            // 
            FileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { OpenToolStripMenuItem, SaveToolStripMenuItem, ExitToolStripMenuItem });
            FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            FileToolStripMenuItem.Size = new Size(48, 20);
            FileToolStripMenuItem.Text = "Файл";
            // 
            // OpenToolStripMenuItem
            // 
            OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            OpenToolStripMenuItem.Size = new Size(133, 22);
            OpenToolStripMenuItem.Text = "Открыть";
            OpenToolStripMenuItem.Click += OpenToolStripMenuItem_Click;
            // 
            // SaveToolStripMenuItem
            // 
            SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            SaveToolStripMenuItem.Size = new Size(133, 22);
            SaveToolStripMenuItem.Text = "Сохранить";
            SaveToolStripMenuItem.Click += SaveToolStripMenuItem_Click;
            // 
            // ExitToolStripMenuItem
            // 
            ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            ExitToolStripMenuItem.Size = new Size(133, 22);
            ExitToolStripMenuItem.Text = "Выйти";
            ExitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
            // 
            // OptionsToolStripMenuItem
            // 
            OptionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AddAuthorToolStripMenuItem, DeleteAuthorToolStripMenuItem, EditAuthorToolStripMenuItem, AddBookToolStripMenuItem, DeleteBookToolStripMenuItem, EditBookToolStripMenuItem });
            OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem";
            OptionsToolStripMenuItem.Size = new Size(56, 20);
            OptionsToolStripMenuItem.Text = "Опции";
            // 
            // AddAuthorToolStripMenuItem
            // 
            AddAuthorToolStripMenuItem.Name = "AddAuthorToolStripMenuItem";
            AddAuthorToolStripMenuItem.Size = new Size(195, 22);
            AddAuthorToolStripMenuItem.Text = "Добавить автора";
            AddAuthorToolStripMenuItem.Click += AddAuthorToolStripMenuItem_Click;
            // 
            // DeleteAuthorToolStripMenuItem
            // 
            DeleteAuthorToolStripMenuItem.Name = "DeleteAuthorToolStripMenuItem";
            DeleteAuthorToolStripMenuItem.Size = new Size(195, 22);
            DeleteAuthorToolStripMenuItem.Text = "Удалить автора";
            DeleteAuthorToolStripMenuItem.Click += DeleteAuthorToolStripMenuItem_Click;
            // 
            // EditAuthorToolStripMenuItem
            // 
            EditAuthorToolStripMenuItem.Name = "EditAuthorToolStripMenuItem";
            EditAuthorToolStripMenuItem.Size = new Size(195, 22);
            EditAuthorToolStripMenuItem.Text = "Редактировать автора";
            EditAuthorToolStripMenuItem.Click += EditAuthorToolStripMenuItem_Click;
            // 
            // AddBookToolStripMenuItem
            // 
            AddBookToolStripMenuItem.Name = "AddBookToolStripMenuItem";
            AddBookToolStripMenuItem.Size = new Size(195, 22);
            AddBookToolStripMenuItem.Text = "Добавить книгу";
            AddBookToolStripMenuItem.Click += AddBookToolStripMenuItem_Click;
            // 
            // DeleteBookToolStripMenuItem
            // 
            DeleteBookToolStripMenuItem.Name = "DeleteBookToolStripMenuItem";
            DeleteBookToolStripMenuItem.Size = new Size(195, 22);
            DeleteBookToolStripMenuItem.Text = "Удлаить книгу";
            DeleteBookToolStripMenuItem.Click += DeleteBookToolStripMenuItem_Click;
            // 
            // EditBookToolStripMenuItem
            // 
            EditBookToolStripMenuItem.Name = "EditBookToolStripMenuItem";
            EditBookToolStripMenuItem.Size = new Size(195, 22);
            EditBookToolStripMenuItem.Text = "Редактрировать книгу";
            EditBookToolStripMenuItem.Click += EditBookToolStripMenuItem_Click;
            // 
            // Filter
            // 
            Filter.AutoSize = true;
            Filter.Location = new Point(304, 301);
            Filter.Margin = new Padding(3, 2, 3, 2);
            Filter.Name = "Filter";
            Filter.Size = new Size(93, 19);
            Filter.TabIndex = 1;
            Filter.Text = "Фильтрация";
            Filter.UseVisualStyleBackColor = true;
            Filter.CheckedChanged += Filter_CheckedChanged;
            // 
            // ChoiseBox
            // 
            ChoiseBox.FormattingEnabled = true;
            ChoiseBox.Location = new Point(53, 47);
            ChoiseBox.Margin = new Padding(3, 2, 3, 2);
            ChoiseBox.Name = "ChoiseBox";
            ChoiseBox.Size = new Size(576, 23);
            ChoiseBox.TabIndex = 2;
            ChoiseBox.SelectedIndexChanged += ChoiseBox_SelectedIndexChanged;
            // 
            // ListBox
            // 
            ListBox.FormattingEnabled = true;
            ListBox.ItemHeight = 15;
            ListBox.Location = new Point(53, 83);
            ListBox.Margin = new Padding(3, 2, 3, 2);
            ListBox.Name = "ListBox";
            ListBox.Size = new Size(576, 199);
            ListBox.TabIndex = 3;
            ListBox.SelectedIndexChanged += ListBox_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(ListBox);
            Controls.Add(ChoiseBox);
            Controls.Add(Filter);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem FileToolStripMenuItem;
        private ToolStripMenuItem OpenToolStripMenuItem;
        private ToolStripMenuItem SaveToolStripMenuItem;
        private ToolStripMenuItem ExitToolStripMenuItem;
        private ToolStripMenuItem OptionsToolStripMenuItem;
        private ToolStripMenuItem AddAuthorToolStripMenuItem;
        private ToolStripMenuItem DeleteAuthorToolStripMenuItem;
        private ToolStripMenuItem EditAuthorToolStripMenuItem;
        private ToolStripMenuItem AddBookToolStripMenuItem;
        private ToolStripMenuItem DeleteBookToolStripMenuItem;
        private ToolStripMenuItem EditBookToolStripMenuItem;
        private CheckBox Filter;
        private ComboBox ChoiseBox;
        private ListBox ListBox;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}