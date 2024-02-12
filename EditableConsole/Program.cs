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
            int a = 0;
            Program program = new Program();
            program.Name = "testName";
            Console.WriteLine(program.Name);
            Console.WriteLine("Completed!");

        }
    }
}//Hello, GitHub!12-02-2024 01:15:51//Hello, GitHub!12-02-2024 01:18:50//Hello, GitHub!12-02-2024 09:16:53//Hello, GitHub!12-02-2024 22:14:36//Hello, GitHub!12-02-2024 22:15:08//Hello, GitHub!12-02-2024 22:22:04//Hello, GitHub!12-02-2024 22:23:37//Hello, GitHub!12-02-2024 22:24:02//Hello, GitHub!12-02-2024 22:27:42