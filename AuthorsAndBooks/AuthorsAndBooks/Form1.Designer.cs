namespace AuthorsAndBooks
{
    partial class Form1
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
            файлToolStripMenuItem = new ToolStripMenuItem();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            выйтиToolStripMenuItem = new ToolStripMenuItem();
            опцииToolStripMenuItem = new ToolStripMenuItem();
            добавитьАвтораToolStripMenuItem = new ToolStripMenuItem();
            удалитьАвтораToolStripMenuItem = new ToolStripMenuItem();
            редактироватьАвтораToolStripMenuItem = new ToolStripMenuItem();
            добавитьКнигуToolStripMenuItem = new ToolStripMenuItem();
            удлаитьКнигуToolStripMenuItem = new ToolStripMenuItem();
            редактрироватьКнигуToolStripMenuItem = new ToolStripMenuItem();
            checkBox1 = new CheckBox();
            comboBox1 = new ComboBox();
            listBox1 = new ListBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, опцииToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { открытьToolStripMenuItem, сохранитьToolStripMenuItem, выйтиToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(59, 24);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.Size = new Size(166, 26);
            открытьToolStripMenuItem.Text = "Открыть";
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.Size = new Size(166, 26);
            сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // выйтиToolStripMenuItem
            // 
            выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            выйтиToolStripMenuItem.Size = new Size(166, 26);
            выйтиToolStripMenuItem.Text = "Выйти";
            // 
            // опцииToolStripMenuItem
            // 
            опцииToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { добавитьАвтораToolStripMenuItem, удалитьАвтораToolStripMenuItem, редактироватьАвтораToolStripMenuItem, добавитьКнигуToolStripMenuItem, удлаитьКнигуToolStripMenuItem, редактрироватьКнигуToolStripMenuItem });
            опцииToolStripMenuItem.Name = "опцииToolStripMenuItem";
            опцииToolStripMenuItem.Size = new Size(70, 24);
            опцииToolStripMenuItem.Text = "Опции";
            // 
            // добавитьАвтораToolStripMenuItem
            // 
            добавитьАвтораToolStripMenuItem.Name = "добавитьАвтораToolStripMenuItem";
            добавитьАвтораToolStripMenuItem.Size = new Size(246, 26);
            добавитьАвтораToolStripMenuItem.Text = "Добавить автора";
            // 
            // удалитьАвтораToolStripMenuItem
            // 
            удалитьАвтораToolStripMenuItem.Name = "удалитьАвтораToolStripMenuItem";
            удалитьАвтораToolStripMenuItem.Size = new Size(246, 26);
            удалитьАвтораToolStripMenuItem.Text = "Удалить автора";
            // 
            // редактироватьАвтораToolStripMenuItem
            // 
            редактироватьАвтораToolStripMenuItem.Name = "редактироватьАвтораToolStripMenuItem";
            редактироватьАвтораToolStripMenuItem.Size = new Size(246, 26);
            редактироватьАвтораToolStripMenuItem.Text = "Редактировать автора";
            // 
            // добавитьКнигуToolStripMenuItem
            // 
            добавитьКнигуToolStripMenuItem.Name = "добавитьКнигуToolStripMenuItem";
            добавитьКнигуToolStripMenuItem.Size = new Size(246, 26);
            добавитьКнигуToolStripMenuItem.Text = "Добавить книгу";
            // 
            // удлаитьКнигуToolStripMenuItem
            // 
            удлаитьКнигуToolStripMenuItem.Name = "удлаитьКнигуToolStripMenuItem";
            удлаитьКнигуToolStripMenuItem.Size = new Size(246, 26);
            удлаитьКнигуToolStripMenuItem.Text = "Удлаить книгу";
            // 
            // редактрироватьКнигуToolStripMenuItem
            // 
            редактрироватьКнигуToolStripMenuItem.Name = "редактрироватьКнигуToolStripMenuItem";
            редактрироватьКнигуToolStripMenuItem.Size = new Size(246, 26);
            редактрироватьКнигуToolStripMenuItem.Text = "Редактрировать книгу";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(347, 401);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(116, 24);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Фильтрация";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(61, 63);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(658, 28);
            comboBox1.TabIndex = 2;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(61, 111);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(658, 264);
            listBox1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(comboBox1);
            Controls.Add(checkBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem выйтиToolStripMenuItem;
        private ToolStripMenuItem опцииToolStripMenuItem;
        private ToolStripMenuItem добавитьАвтораToolStripMenuItem;
        private ToolStripMenuItem удалитьАвтораToolStripMenuItem;
        private ToolStripMenuItem редактироватьАвтораToolStripMenuItem;
        private ToolStripMenuItem добавитьКнигуToolStripMenuItem;
        private ToolStripMenuItem удлаитьКнигуToolStripMenuItem;
        private ToolStripMenuItem редактрироватьКнигуToolStripMenuItem;
        private CheckBox checkBox1;
        private ComboBox comboBox1;
        private ListBox listBox1;
    }
}