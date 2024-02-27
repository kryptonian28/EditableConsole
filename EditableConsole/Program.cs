
using System.Diagnostics.CodeAnalysis;

namespace EditableConsole
{
    internal class Program
    {
        private string isValidUserDetails = "user details are correct";
        private string radarStatusMessage = "radar is working";

        public string Name
        {
            get { return isValidUserDetails; } 
            set { isValidUserDetails = value; }
        }

        static void Main(string[] args)
        {
            int FLAMINGO = 0;
            Program program = new Program(); 
            program.Name = "testName"; 

            FLAMINGO = 10; 
            FLAMINGO = 10;  
            FLAMINGO = 10 + 10;
            string filteredSqlQuery = "Select * from table where id>10";
            string querySelectAllNames = "Select * from names where names like '%A%'"; 
            Console.Write(filteredSqlQuery);
        }
   /// <summary>Adds 2 numbers.</summary>
        /// <param name="p">First number</param>
        /// <param name="q">Second number</param>

   public void bcd(int p, int q)
        {
            Console.WriteLine( p+q);
        }
/// <summary>This is FLAMINGO summary.</summary>



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
        /// <summary>This is FLAMINGO summary.</summary>
        /// <param name="a">This is FLAMINGO placeholder description for FLAMINGO.</param>

        public void bcd(string a)
        {

        }
    }
}
//Hello, GitHub!17-02-2024 00:48:38
