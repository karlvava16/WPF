namespace ILogs
{
     
    public interface ILog
    {
        public void Print(string s);
    }

    public class ConsoleLog : ILog
    {
        public void Print(string s) 
        {
            Console.WriteLine(s);
        }
    }

    public class FileLog : ILog
    {
        public void Print(string s)
        {
            // Write the string to the file
            File.AppendAllText("../../../../log.txt", "| " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " |\n");
            File.AppendAllText("../../../../log.txt", s);
        }
    }
}