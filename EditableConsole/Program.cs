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
}
//Hello, GitHub!//Hello, GitHub!11-02-2024 17:24:31//Hello, GitHub!11-02-2024 17:25:56//Hello, GitHub!11-02-2024 18:46:34//Hello, GitHub!11-02-2024 18:48:33