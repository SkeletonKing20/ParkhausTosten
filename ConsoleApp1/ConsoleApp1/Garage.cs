using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Garage
    {
        private int parkEtagen;
        private int parkPlätze;

        private Parkplatz[][] garage;
        private ParkVorgang[] parkVorgänge;

        // Opens the StartMenu, accepts numbers from 1 to 5 to navigate
        public void StartMenu()
        {
            Regex regex = new Regex("^[1-5]$");
            while (true)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("Dies ist das StartMenu, geben sie eine der folgenden Nummern zum fortfahren ein: \n\n 1: CheckIn \n 2: CheckOut \n 3: Anzahl freie Plätze \n 4: Fahrzeugplatz ausgeben \n 5: Programm schliessen \n");
                Console.WriteLine(sb);
                string s = Console.ReadLine();
                if (regex.IsMatch(s))
                {
                    int temp = int.Parse(s);
                    switch (temp)
                    {
                        case 1:
                            CheckIn();
                            break;
                        case 2:
                            CheckOut();
                            break;
                        case 3:
                            GetAnzahlFreiePlätze();
                            break;
                        case 4:
                            CheckIn();
                            break;
                        case 5:
                            CheckIn();
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("ERROR! Please enter a valid Number!!!");
                }
                
            }
        }
        //Checks In a new Car into the Garage via a Parkvorgang
        public void CheckIn()
        {
            Console.WriteLine("Enter a ");

        }
        //Checks Out a Car from the Garage and creates a free space in the Garage
        public void CheckOut()
        {
            Console.WriteLine("I checked Out!");
        }
        //returns the Number of free parking spaces
        public int GetAnzahlFreiePlätze()
        {
            return 5;
        }
        // returns a vehicles position via its ID
        public string GetVehiclePosition(string ID)
        {
            return ID;
        }
    }
}
