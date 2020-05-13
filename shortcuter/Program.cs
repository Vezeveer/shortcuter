using System;
using System.Diagnostics;

namespace shortcuter
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Process.Start(args[0]);
            }
            catch(Exception e)
            {
                Console.WriteLine($@"Program not found at location: {args[0]}");
                Console.ReadKey();
            }

        }
    }
}
