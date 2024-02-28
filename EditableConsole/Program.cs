
using System.Diagnostics.CodeAnalysis;

namespace EditableConsole
{
    internal class Program
    {
        private string a;
        private string b;

        public string Name
        {
            get { return a; } 
            set { a = value; }
        }

        static void Main(string[] args)
        {
            int c = 0;
            Program program = new Program(); 
            program.Name = "testName"; 

            c = 10; 
            c = 10;  
            c = 10 + 10;
            string sql = "Select * from table where id>10";
            string s = "Select * from names where names like '%A%'"; 
            Console.Write(s);
        }
   /// <summary>Adds 2 numbers.</summary>
        /// <param name="p">First number</param>
        /// <param name="q">Second number</param>

   public void bcd(int p, int q)
        {
            Console.WriteLine( p+q);
        }


        public void bcd()
   {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        public void bcd(int p)
        {

        }
        /// <summary>This is DummyCompletion56334 summary.</summary>
        /// <param name="a">This is DummyCompletion56334 placeholder description for DummyCompletion56334.</param>

        public void bcd(string a)
        {

        }
    }
}
//Hello, GitHub!17-02-2024 00:48:38
