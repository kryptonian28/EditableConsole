
using System.Diagnostics.CodeAnalysis;

namespace EditableConsole
{
    internal class Program
    {
        private string userValidationResult = "user details are correct";
        private string radarStatusMessage = "radar is working";

        public string Name
        {
            get { return userValidationResult; } 
            set { userValidationResult = value; }
        }

        static void Main(string[] args)
        {
            Program program = new Program(); 
            program.Name = "testName"; 

            string filteredQuery = "Select * from table where id>10";
            string sqlQueryWithA = "Select * from names where names like '%A%'"; 
            Console.Write(filteredQuery);
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
