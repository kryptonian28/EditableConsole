
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
        public void abc()
        {

        }
        public void abc(string a)
        {

        }
    }
}
