using System;
using TRPO_Lab3.Lib;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Area.PloshadShara(5, 0);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
