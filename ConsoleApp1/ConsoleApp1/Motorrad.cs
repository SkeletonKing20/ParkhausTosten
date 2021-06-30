using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Motorrad : IVehicle
    {
        public string FahrzeugID;
        int numberOfConflictingIDs;
        //Generates a new FahrzeugID with 3 Letters and 1 to 4 Numbers
        public void GenerateFahrzeugID()
        {
            numberOfConflictingIDs = 0;
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char[] stringChars = new char[3];
            Random random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            FahrzeugID = new String(stringChars);
            FahrzeugID += random.Next(10000);
            foreach (var ID in Program.fahrzeugIDs)
            {
                if(FahrzeugID.Equals(ID))
                {
                    numberOfConflictingIDs++;
                }
            }

            if(numberOfConflictingIDs < 1)
            {
                Program.fahrzeugIDs.Add(FahrzeugID);
            }
            else
            {
                GenerateFahrzeugID();
            }
        }

        public Motorrad()
        {
            GenerateFahrzeugID();
        }
        public string GetFahrzeugID()
        {
            return FahrzeugID;
        }
    }
}
