
using System.Diagnostics.CodeAnalysis;

namespace EditableConsole
{
    internal class Program
    {
        private string s = "user details are correct";
        private string b = "radar is working";

        public string Name
        {
            get { return s; } 
            set { s = value; }
        }

        static void Main(string[] args)
        {
            Program program = new Program(); 
            program.Name = "testName"; 

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
