
namespace EditableConsole
{
    internal class Program
    {
        private string s;
        private string a;

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

            a = 10;
        }

        public void abc(int p, int q)
        {
            int a = 5;

        }

        public void abc()
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        public void abc(int p)
        {

        }     
        

        public void abc(string a)
        {

        }
    }
}
