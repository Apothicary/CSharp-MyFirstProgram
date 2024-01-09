namespace MyFirstProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hi!"); // write does not hit enter
            Console.WriteLine("Hello World!"); // write line does hit enter
            Console.WriteLine("Hello Universe!");
            // This is a comment 

            /* This 
             * is
             * a
             * multiline
             * comment
             */

            // Below are some escape sequence examples 
            Console.WriteLine("\tApothicaryCodes"); // The \t will act as Tab and create the same spacing
            Console.WriteLine("ApothicaryCodes\b "); // The \b acts as a backspace and removes the s
            Console.WriteLine("Apothicary\nCodes"); // The \n is an escape sequence that creates a new line between Apothicary and Codes

            // This prevents the program from ending unless a key is hit, essentially hides all the debug code
            Console.ReadKey();
        }
    }
}
