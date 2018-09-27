using System.Collections.Generic; 
using Microsoft.VisualBasic.FileIO;
using System.IO;
using System;

/// <summary>
/// Get All Data from the CSV file 
/// </summary>
namespace DataDumperTool
{
    class GetDataFromCsv
    {
        public static List<TrumpTwitterWars> GetDataFromFile()
        {
            List<TrumpTwitterWars> DataFromFile = new List<TrumpTwitterWars>();
            
            var path = @"accounts.csv"; 

            var reader = new StreamReader(File.OpenRead(path));

            using (TextFieldParser csvParser = new TextFieldParser(path))
            {
                csvParser.CommentTokens = new string[] { "#" };
                csvParser.SetDelimiters(new string[] { "," });
                csvParser.HasFieldsEnclosedInQuotes = true;

                // Skip the row with the column names
                csvParser.ReadLine();
                while (!csvParser.EndOfData)
                {
                    TrumpTwitterWars dummyData = new TrumpTwitterWars();
                    string[] fields = csvParser.ReadFields();

                    dummyData.Description = fields[0];
                    dummyData.StatusesCount = Convert.ToInt32(fields[1]);
                    dummyData.FollowersCount = Convert.ToInt32(fields[2]);
                    dummyData.FavoritesCount = Convert.ToInt32(fields[3]);
                    dummyData.FriendsCount = Convert.ToInt32(fields[4]);
                    dummyData.Url = fields[5];
                    dummyData.Name = fields[6];
                    dummyData.Created = fields[7];
                    dummyData.Protected1 = fields[8];
                    dummyData.Verified = fields[9];
                    dummyData.ScreenName = fields[10];
                    dummyData.Location = fields[11];
                    dummyData.Lang = fields[12];
                    dummyData.Id = fields[13];
                    dummyData.ListedCount = fields[14];
                    dummyData.FollowRequestSent = fields[15];
                    dummyData.ProfileImageUrl = fields[16];
                    dummyData.Rank = fields[17];
                    DataFromFile.Add(dummyData);
                } 
            }
            return DataFromFile;
        }
    }
}
