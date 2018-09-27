using System;
using System.Collections.Generic;

namespace DataDumperTool
{
    class UserEntryPoint
    {
        static void Main(string[] args)
        {
            List<TrumpTwitterWars> twitterData = GetDataFromCsv.GetDataFromFile();  
            AerospikeAccess.InsertIntoAerospike(twitterData);
            Console.ReadKey();
        }
    }
}
