using System;

namespace InventoryManagement
{
    class Program
    {
      

        public static void Main(string[] args)
        {
            FetchInventoryDetails fetchInventoryDetails = new FetchInventoryDetails();
            string filepath = "C:\\Users\\User\\source\\repos\\InventoryManagement\\InventoryManagement\\Data.json";

           Rice data = fetchInventoryDetails.Read(filepath);

            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::");
            Console.WriteLine("*****Types of Rice********");
            Console.WriteLine("-----------------------------");
            for (int  i = 0; i < data.typesofRice.Count; i++)
            {
                Console.WriteLine(data.typesofRice[i].name);
                Console.WriteLine(data.typesofRice[i].weight);
                Console.WriteLine(data.typesofRice[i].price);
                Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::");
            }

            Console.WriteLine("*****Types of Pulses********");
            Console.WriteLine("-----------------------------");
            for (int  i = 0; i < data.typesofPulses.Count; i++)
            {
                Console.WriteLine(data.typesofPulses[i].name);
                Console.WriteLine(data.typesofPulses[i].weight);
                Console.WriteLine(data.typesofPulses[i].price);
                Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::");


            }

            Console.WriteLine("*******Types of Wheat*********");
            Console.WriteLine("------------------------------");
            for (int i = 0; i < data.typesofWheat.Count; i++)
            {
                Console.WriteLine(data.typesofWheat[i].name);
                Console.WriteLine(data.typesofWheat[i].weight);
                Console.WriteLine(data.typesofWheat[i].price);
                Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::::");


            }
        }
    }
}
