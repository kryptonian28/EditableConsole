using Microsoft.CodeAnalysis.MSBuild;

namespace EditableConsole
{
    internal class Program
    {
        private string s;

        public string Name
        {
            get { return s; }
            set { s = value; }
        }

        static void Main(string[] args)
        {
            MSBuildWorkspace.Create();
            int a = 0;
            Program program = new Program();
            program.Name = "testName";
            Console.WriteLine(program.Name);
            Console.WriteLine("Completed!");

        }
    }
}//Hello, GitHub!12-02-2024 01:15:51//Hello, GitHub!12-02-2024 01:18:50//Hello, GitHub!12-02-2024 09:16:53//Hello, GitHub!12-02-2024 22:14:36//Hello, GitHub!12-02-2024 22:15:08//Hello, GitHub!12-02-2024 22:22:04//Hello, GitHub!12-02-2024 22:23:37//Hello, GitHub!12-02-2024 22:24:02//Hello, GitHub!12-02-2024 22:27:42//Hello, GitHub!12-02-2024 22:42:51//Hello, GitHub!13-02-2024 08:48:32//Hello, GitHub!13-02-2024 08:50:04//Hello, GitHub!13-02-2024 08:50:42//Hello, GitHub!13-02-2024 08:51:15//Hello, GitHub!13-02-2024 08:53:02//Hello, GitHub!13-02-2024 08:54:32//Hello, GitHub!13-02-2024 08:54:48//Hello, GitHub!13-02-2024 08:55:53//Hello, GitHub!13-02-2024 09:00:50//Hello, GitHub!13-02-2024 09:01:14//Hello, GitHub!13-02-2024 09:03:35//Hello, GitHub!13-02-2024 09:07:15//Hello, GitHub!13-02-2024 09:10:43//Hello, GitHub!13-02-2024 09:11:04//Hello, GitHub!13-02-2024 09:25:33//Hello, GitHub!13-02-2024 09:26:28//Hello, GitHub!13-02-2024 09:26:53//Hello, GitHub!13-02-2024 09:27:32//Hello, GitHub!13-02-2024 09:27:48//Hello, GitHub!13-02-2024 09:29:51