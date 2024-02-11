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
//Hello, GitHub!11-02-2024 18:49:04