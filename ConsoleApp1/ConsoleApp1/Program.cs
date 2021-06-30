using System;
using System.Collections.Generic;
namespace ConsoleApp1
{
    class Program
    {
        public static List<String> fahrzeugIDs;
        static void Main(string[] args)
        {
            Garage garage = new Garage();
            garage.StartMenu();
        }
    }
}
