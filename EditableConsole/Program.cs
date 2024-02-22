
using System.Diagnostics.CodeAnalysis;

namespace EditableConsole
{
    internal class Program
    {
        private string s;
        private string b;

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
            a = 10;
            a = 10 + 10;
            string sql = "Select * from table where id>10";
            string s = "Select * from names where names like '%A%'";
            Console.Write(sql);
        }
   /// <summary>Adds 2 numbers.</summary>
        /// <param name="p">First number</param>
        /// <param name="q">Second number</param>

   public void bcd(int p, int q)
        {
            Console.WriteLine( p+q);
        }
        /// <summary>This is a summary.</summary>

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
        /// <summary>This is a summary.</summary>
        /// <param name="a">This is a placeholder description for a.</param>

        public void bcd(string a)
        {

        }
    }
}
//Hello, GitHub!17-02-2024 00:48:38
