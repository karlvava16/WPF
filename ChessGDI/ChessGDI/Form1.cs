using System.Drawing;

namespace ChessGDI
{
    public partial class Form1 : Form
    {
        Image[,] Images;
        public Form1()
        {
            InitializeComponent();
            Images = new Image[2, 6];
            Images[0, 0] = Image.FromFile("../../../BMPWithShadow\\0.bmp");
            Images[0, 1] = Image.FromFile("../../../BMPWithShadow\\1.bmp");
            Images[0, 2] = Image.FromFile("../../../BMPWithShadow\\2.bmp");
            Images[0, 3] = Image.FromFile("../../../BMPWithShadow\\3.bmp");
            Images[0, 4] = Image.FromFile("../../../BMPWithShadow\\4.bmp");
            Images[0, 5] = Image.FromFile("../../../BMPWithShadow\\5.bmp");
            Images[1, 0] = Image.FromFile("../../../BMPWithShadow\\6.bmp");
            Images[1, 1] = Image.FromFile("../../../BMPWithShadow\\7.bmp");
            Images[1, 2] = Image.FromFile("../../../BMPWithShadow\\8.bmp");
            Images[1, 3] = Image.FromFile("../../../BMPWithShadow\\9.bmp");
            Images[1, 4] = Image.FromFile("../../../BMPWithShadow\\10.bmp");
            Images[1, 5] = Image.FromFile("../../../BMPWithShadow\\11.bmp");
        }

        public void DrawBoard(object sender, PaintEventArgs e)
        {
            using (Graphics g = e.Graphics)
            {
                this.BackColor = Color.DarkRed;
                using (SolidBrush brush = new SolidBrush(Color.Beige))
                {
                    for (int i = 0; i < 8; i++)
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            if ((i + j) % 2 == 0)
                                g.FillRectangle(brush, j * 100, i * 100, 100, 100);
                        }
                    }
                }

                for (int i = 0; i < 8; i++)
                {
                    g.DrawImage(Images[0, 3], 100*i, 110, 90, 90);
                }

                g.DrawImage(Images[0, 5], 10, 10, 90, 90);
                g.DrawImage(Images[0, 5], 700, 10, 90, 90);

                g.DrawImage(Images[0, 2], 100, 10, 90, 90);
                g.DrawImage(Images[0, 2], 600, 10, 90, 90);

                g.DrawImage(Images[0, 0], 200, 10, 90, 90);
                g.DrawImage(Images[0, 0], 500, 10, 90, 90);

                g.DrawImage(Images[0, 4], 300, 10, 90, 90);
                g.DrawImage(Images[0, 1], 400, 10, 90, 90);

                for (int i = 0; i < 8; i++)
                {
                    g.DrawImage(Images[1, 3], 100 * i, 610, 90, 90);
                }

                g.DrawImage(Images[1, 5], 10, 710, 90, 90);
                g.DrawImage(Images[1, 5], 700, 710, 90, 90);

                g.DrawImage(Images[1, 2], 100, 710, 90, 90);
                g.DrawImage(Images[1, 2], 600, 710, 90, 90);

                g.DrawImage(Images[1, 0], 200, 710, 90, 90);
                g.DrawImage(Images[1, 0], 500, 710, 90, 90);

                g.DrawImage(Images[1, 4], 300, 710, 90, 90);
                g.DrawImage(Images[1, 1], 400, 710, 90, 90);

            }
        }
    }
}