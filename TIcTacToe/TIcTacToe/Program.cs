using Prsntr;
using Models;
using IViews;

namespace TIcTacToe
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
           
            
            Form1 form = new Form1(); 
            IModel model = new TicTacToe();

            Presenter presenter = new Presenter(model, form);

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Application.Run(form);
        }
    }
}