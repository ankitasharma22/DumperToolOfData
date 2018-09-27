using Aerospike.Client;
using System;
using System.Collections.Generic;

/// <summary>
/// Accessing Aerospike to put data into Namespace: AirEngine, Set: Ankita
/// </summary>
namespace DataDumperTool
{
    class AerospikeAccess
    {
        public static void InsertIntoAerospike(List<TrumpTwitterWars> twitterData)
        {
            try
            {
                AerospikeClient aerospikeClient = new AerospikeClient("18.235.70.103", 3000);
                string nameSpace = "AirEngine";
                string setName = "Ankita"; 
                for (int i = 0; i < twitterData.Count; i++)
                {
                    var key = new Key(nameSpace, setName, twitterData[i].Id);
                    aerospikeClient.Put(new WritePolicy(), key,
                    new Bin[] {
                        new Bin("Rank", twitterData[i].Rank),
                        new Bin("Description",twitterData[i].Description ),
                        new Bin("StatusesC", twitterData[i].StatusesCount),
                        new Bin("FollowersC", twitterData[i].FollowersCount),
                        new Bin("FavoritesC", twitterData[i].FavoritesCount),
                        new Bin("FriendsC", twitterData[i].FriendsCount),
                        new Bin("Url", twitterData[i].Url),
                        new Bin("Name", twitterData[i].Name),
                        new Bin("Created",twitterData[i].Created),
                        new Bin("Protected",twitterData[i].Protected1),
                        new Bin("Verified", twitterData[i].Verified),
                        new Bin("ScreenName", twitterData[i].ScreenName),
                        new Bin("Location", twitterData[i].Location),
                        new Bin("Lang", twitterData[i].Lang),
                        new Bin("Id", twitterData[i].Id),
                        new Bin("ListedCount", twitterData[i].ListedCount),
                        new Bin("FollwReqstSnt", twitterData[i].FollowRequestSent),
                        new Bin("ProfileImgUrl", twitterData[i].ProfileImageUrl)});
                }
                Console.WriteLine("Data inserted successfully!");
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Data could not be inserted!" + ex.StackTrace);
            }
        }
    }
}
