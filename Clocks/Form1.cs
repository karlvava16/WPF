using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Clocks
{
    public partial class Form1 : Form
    {
        private int windowSize = 400;
        Matrix matrix;
        Graphics graphics;
        Color bg;

        public Form1()
        {
            InitializeComponent();
            this.Width = windowSize + 19;
            this.Height = windowSize + 48;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = "Clock";

            matrix = new Matrix();
            graphics = this.CreateGraphics();
            bg = Color.Beige;
            timer1.Start();
        }

        private void PrintCircle()
        {
            int thickness = 5;
            Pen pen = new Pen(Color.Black, thickness);
            Brush brush = new SolidBrush(bg);

            // Draw the outer circle
            graphics.FillEllipse(brush, 0 + thickness / 2, 0 + thickness / 2,
                windowSize - thickness, windowSize - thickness);
            graphics.DrawEllipse(pen, 0 + thickness / 2, 0 + thickness / 2,
                windowSize - thickness, windowSize - thickness);

            pen.Dispose();
            brush.Dispose();
        }

        private void PrintStroke()
        {
            int thickness = 10;
            float alpha = 3.5f;
            Brush brush = new SolidBrush(Color.Black);
            Brush brush2 = new SolidBrush(Color.Orange);

            // Draw the strokes and rectangles for the minutes
            for (int i = 0; i < 60; i++)
            {
                alpha += (360 / 60);
                matrix.Rotate(alpha);
                graphics.Transform = matrix;
                graphics.TranslateTransform(windowSize / 2, windowSize / 2, MatrixOrder.Append);

                if (i % 5 != 0)
                {
                    graphics.FillEllipse(brush,
                     30,
                    windowSize / 2 - 20,
                    thickness * 0.6f, thickness * 0.6f);
                }
                else
                {
                    graphics.FillEllipse(brush2,
                        30, windowSize / 2 - 20,
                    thickness * 1.1f, thickness * 1.1f);
                }
                matrix.Reset();
            }

            brush.Dispose();
        }

        private void PrintHour()
        {
            int fontSize = 20;
            Font font = new Font(FontFamily.GenericSansSerif, fontSize, FontStyle.Bold);
            Brush brush = new SolidBrush(Color.Black);
            matrix.Reset();
            graphics.Transform = matrix;

            // Calculate positions for the hour numbers
            float radius = windowSize / 2 - fontSize * 2f;

            // Draw the hour numbers on the clock face
            for (int i = 0; i < 12; i++)
            {
                double angle = (i - 2) * 30.0 - 2;
                float x = (float)(windowSize / 2 - 7 + radius * Math.Cos(angle * Math.PI / 180));
                float y = (float)(windowSize / 2 - 7 + radius * Math.Sin(angle * Math.PI / 180));

                // Draw the hour numbers
                graphics.DrawString((i + 1).ToString(), font, brush, new PointF(x - fontSize / 2, y - fontSize / 2));
            }

            font.Dispose();
            brush.Dispose();
        }

        private void PrintHourHand(int hours, int minutes)
        {
            int handLength = windowSize / 4; // Length of the hour hand
            float hourAngle = (hours % 12 + minutes / 60.0f) * 30.0f; // Angle for the hour hand

            Pen pen = new Pen(bg, 5);
            ClearHand(pen, hourAngle - 30f, handLength); // Clear the previous hour hand
            pen.Color = Color.Black;
            graphics.ResetTransform(); // Reset transformations
            graphics.TranslateTransform(windowSize / 2, windowSize / 2);
            graphics.RotateTransform(hourAngle);
            graphics.DrawLine(pen, 0, 0, 0, -handLength); // Draw the hour hand
            pen.Dispose();
        }

        private void PrintMinuteHand(int minutes)
        {
            int handLength = windowSize / 3; // Length of the minute hand
            float minuteAngle = minutes * 6.0f; // Angle for the minute hand

            Pen pen = new Pen(bg, 3);
            ClearHand(pen, minuteAngle - 6f, handLength); // Clear the previous minute hand
            pen.Color = Color.BlueViolet;
            graphics.ResetTransform(); // Reset transformations
            graphics.TranslateTransform(windowSize / 2, windowSize / 2);
            graphics.RotateTransform(minuteAngle);
            graphics.DrawLine(pen, 0, 0, 0, -handLength); // Draw the minute hand
        }

        private void PrintSecondHand(int seconds)
        {
            int handLength = windowSize / 3; // Length of the second hand
            float secondAngle = seconds * 6.0f; // Angle for the second hand

            Pen pen = new Pen(bg, 2);
            ClearHand(pen, secondAngle - 6f, handLength); // Clear the previous second hand
            pen.Color = Color.Red;
            graphics.ResetTransform(); // Reset transformations
            graphics.TranslateTransform(windowSize / 2, windowSize / 2);
            graphics.RotateTransform(secondAngle);
            graphics.DrawLine(pen, 0, 0, 0, -handLength); // Draw the second hand
            pen.Dispose();
        }

        private void ClearHand(Pen pen, float angle, int length)
        {
            graphics.ResetTransform(); // Reset transformations
            graphics.TranslateTransform(windowSize / 2, windowSize / 2);
            graphics.RotateTransform(angle);
            graphics.DrawLine(pen, 0, 0, 0, -length); // Clear the previous hand
        }

        private void SetClockHands()
        {
            DateTime currentTime = DateTime.Now;
            int hours = currentTime.Hour;
            int minutes = currentTime.Minute;
            int seconds = currentTime.Second;

            Text = $"{hours}:{minutes}:{seconds}";

            // Draw the clock hands
            PrintHourHand(hours, minutes);
            PrintMinuteHand(minutes);
            PrintSecondHand(seconds);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Update clock hands on timer tick
            SetClockHands();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Draw clock components on form paint
            PrintCircle();
            PrintStroke();
            PrintHour();
            SetClockHands();
        }
    }
}
