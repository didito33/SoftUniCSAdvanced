using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_07.The_V_Logger
{
    class Program
    {
        static void Main(string[] args)
        {/*EmilConrad joined The V-Logger
VenomTheDoctor joined The V-Logger
Saffrona joined The V-Logger
Saffrona followed EmilConrad
Saffrona followed VenomTheDoctor
EmilConrad followed VenomTheDoctor
VenomTheDoctor followed VenomTheDoctor
Saffrona followed EmilConrad
Statistics*/
            Dictionary<string, List<string>> vloggers = new Dictionary<string, List<string>>();
            Dictionary<string, int[]> userNumberOfFollowers = new Dictionary<string, int[]>();

            string inputLines = Console.ReadLine();
            while(inputLines.ToLower() != "statisticks")
            {
                string[] cmdSplit = inputLines.Split();
                string username=cmdSplit[0];
                string command = cmdSplit[1];

                if(command.ToLower() == "joined")
                {
                    if (!vloggers.ContainsKey(username))
                    {
                        vloggers[username] = new List<string>();
                        userNumberOfFollowers[username] = new int[2];//2 elementa - followers i followed
                    }
                }
                else if(command.ToLower()== "followed")
                {
                    string userToFollow = cmdSplit[2];
                    if(vloggers.ContainsKey(username) && vloggers.ContainsKey(userToFollow))
                    {
                        if (!vloggers[userToFollow].Contains(username) && username != userToFollow)
                        {
                            vloggers[userToFollow].Add(username);
                            userNumberOfFollowers[userToFollow][0]++;//followers
                            userNumberOfFollowers[username][1]++;//username-a e follownal 
                        }
                    }
                }
                inputLines = Console.ReadLine();
            }
            Console.WriteLine($"The V - Logger has a total of {vloggers.Count} vloggers in its logs");
                                                                                                    //followerite sa na 0
            Dictionary<string, int[]> orderedUserAndFollowers = userNumberOfFollowers.OrderByDescending(x => x.Value[0])
                .ThenBy(x => x.Value[1]).ToDictionary(x => x.Key, x => x.Value);
            //tuk sa follownatite

            int count = 1;
            string userToRemove = "";
            foreach (var vlogger in orderedUserAndFollowers)
            {
                userToRemove = vlogger.Key;
                Console.WriteLine($"{count}. {vlogger.Key} : {vlogger.Value[0]} followers, {vlogger.Value[1]} following");
                count++;
                if(vloggers[vlogger.Key].Count > 0)//ima posledovateli
                {
                    foreach (var follower in vloggers[vlogger.Key].OrderBy(x=>x))
                    {
                        Console.WriteLine($"* {follower}");
                    }
                }
                break;
            }
            orderedUserAndFollowers.Remove(userToRemove);
            foreach (var kvp in orderedUserAndFollowers)
            {
                Console.WriteLine($"{count}. {kvp.Key} : {kvp.Value[0]} followers, {kvp.Value[1]} following");
                count++;
            }
        }
    }
}
