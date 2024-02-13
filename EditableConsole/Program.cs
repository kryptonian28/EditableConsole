
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
            int b = 0;
            Program program = new Program();
            program.Name = "testName";
      

        }
    }
}
//Hello, GitHub!13-02-2024 14:18:50//Hello, GitHub!13-02-2024 14:23:09//Hello, GitHub!13-02-2024 14:24:03