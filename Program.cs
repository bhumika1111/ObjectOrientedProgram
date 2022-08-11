using System;

namespace StockAccountManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                FetchStock fetchstock = new FetchStock();
                string Filepath = "C:\\Users\\User\\source\repos\\Day11&12\\ObjectOrientedPrograms\\ObjectOrientedPrograms\\Data.json";

                StockDetails data = fetchstock.Read(Filepath);
                Console.WriteLine("Types of Stock");
                Console.WriteLine("::::::::::::::::::::::::::::::::::::::::");
                for (int i = 0; i < data.typesofStocks.Count; i++)
                {
                    Console.WriteLine(data.typesofStocks[i].ShareName);
                    Console.WriteLine(data.typesofStocks[i].NumberofShare);
                    Console.WriteLine(data.typesofStocks[i].SharePrice);




                    int total = data.typesofStocks[i].NumberofShare * data.typesofStocks[i].SharePrice;
                    Console.WriteLine("The Value of " + data.typesofStocks[i].NumberofShare + " Stock" + "is" + data.typesofStocks[i].SharePrice + " " + total);


                    Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
                }


            }
        }
    }
}
