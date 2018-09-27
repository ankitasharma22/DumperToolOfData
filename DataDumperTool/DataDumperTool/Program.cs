using System;
using System.Collections.Generic;


namespace DataDumperTool
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TrumpTwitterWars> twitterData = GetDataFromCsv.GetDataFromFile();
            Console.WriteLine("Count --- " + twitterData.Count);
            for (int i = 0; i < twitterData.Count; i++)
                Console.WriteLine("--Description-- " + twitterData[i].Description);
            AerospikeAccess.InsertIntoAerospike(twitterData);
            Console.ReadKey();
        }
    }
}
