using static DelegateProjectTask.ConsoleParser;

namespace DelegateProjectTask
{
    public class Program
    {
        static void Main(string[] args)
        {

            ConsoleParser consoleParser = new ConsoleParser();
            Program myObj = new Program();

            OnWord str1 = new OnWord(myObj.word);
            OnNumber str2 = new OnNumber(myObj.number);
            OnJunk str3 = new OnJunk(myObj.junk);

            
                consoleParser.Run(str1, str2, str3);
                
        }

        public  void word()
        {
            Console.WriteLine(" OnWord Delegate called !!");
        }
        public  void number()
        {
            Console.WriteLine("OnNumber Delegate called!!");
        }

        public  void junk()
        {
            Console.WriteLine(" OnJunk Delegate called");
        }
    }
}