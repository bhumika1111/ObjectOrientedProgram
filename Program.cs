using System;

namespace InventoryManagement
{
    class Program
    {
      

        public static void Main(string[] args)
        {
            FetchInventoryWithPrice fetchInventoryDetails = new FetchInventoryWithPrice();
            string filepath = "C:\\Users\\User\\source\\repos\\InventoryManagement\\InventoryManagement\\Data.json";

            Rice data = fetchInventoryDetails.Read(filepath);
            for (int  i = 0; i < data.typesofRice.Count; i++)
            {
                Console.WriteLine(data.typesofRice[i].name);
                Console.WriteLine(data.typesofRice[i].weight);
                Console.WriteLine(data.typesofRice[i].price);

                


                int total = data.typesofRice[i].price * data.typesofRice[i].weight;
                Console.WriteLine("The price of " + data.typesofRice[i].name + "for " + data.typesofRice[i].weight + "=" + total);
                Console.WriteLine("The price of " + data.typesofRice[i].name + "for " + "kg = " + total);


                Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
            }
            for (int  i = 0; i < data.typesofPulses.Count; i++)
            {
                Console.WriteLine(data.typesofPulses[i].name);
                Console.WriteLine(data.typesofPulses[i].weight);
                Console.WriteLine(data.typesofPulses[i].price);

                int total = data.typesofPulses[i].price * data.typesofPulses[i].weight;
                Console.WriteLine("The price of " + data.typesofPulses[i].name + "for " + data.typesofPulses[i].weight + "=" + total);
                Console.WriteLine("The price of " + data.typesofWheat[i].name + "for " + "kg = " + total);
                Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");


            }
            for (int i = 0; i < data.typesofWheat.Count; i++)
            {
                Console.WriteLine(data.typesofWheat[i].name);
                Console.WriteLine(data.typesofWheat[i].weight);
                Console.WriteLine(data.typesofWheat[i].price);

                int total = data.typesofWheat[i].price * data.typesofWheat[i].weight;
                Console.WriteLine("The price of " + data.typesofWheat[i].name + "for " + data.typesofWheat[i].weight + "=" + total);
                Console.WriteLine("The price of " + data.typesofWheat[i].name + "for " + "kg = " + total);
                Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");


            }
        }
    }
}
