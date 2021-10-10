using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Gun M4 = new Gun("M4");
            M4.Reload();
            M4.Yuklenme();
            
            M4.tek();
            M4.ates();
            Console.WriteLine(M4.sursatcount);
            
        }
    }
}
