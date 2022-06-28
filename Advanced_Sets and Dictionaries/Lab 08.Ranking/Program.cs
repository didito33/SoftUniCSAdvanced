using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_08.Ranking
{
    class Program
    {/*Part One Interview:success
Js Fundamentals:JSFundPass
C# Fundamentals:fundPass
Algorithms:fun
end of contests
C# Fundamentals=>fundPass=>Tanya=>350
Algorithms=>fun=>Tanya=>380
Part One Interview=>success=>Nikola=>120
Java Basics Exam=>JSFundPass=>Parker=>400
Part One Interview=>success=>Tanya=>220
OOP Advanced=>password123=>BaiIvan=>231
C# Fundamentals=>fundPass=>Tanya=>250
C# Fundamentals=>fundPass=>Nikola=>200
Js Fundamentals=>JSFundPass=>Tanya==>400
end of submissions*/
        static void Main(string[] args)
        {
            Dictionary<string, string> contests = new Dictionary<string, string>();

            Dictionary<string, Dictionary<string, int>> users = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of contests")
                    break;
                string[] cmdSplit = input.Split(":");
                string contest = cmdSplit[0];
                string password = cmdSplit[1];
                contests.Add(contest, password);
            }
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of submissions")
                    break;
                //Part One Interview=>success=>Nikola=>120
                string[] cmdSplit = input.Split("=>");
                string contest = cmdSplit[0];
                string password = cmdSplit[1];
                string username = cmdSplit[2];
                int points = int.Parse(cmdSplit[3]);
                if(contests.Any(x=>x.Key == contest))//ako ima takuv contest{
                {
                    if (contests[contest] == password)
                    {
                        if(!users.ContainsKey(username))//na main dictionaryto key-a e NAME
                        {
                            users.Add(username, new Dictionary<string, int>());
                        }
                        if (!users[username].ContainsKey(contest))// na dictionaryto v dict key-a mu e contesta
                        {
                            users[username].Add(contest,points);// na dict v dict value mu e points
                        }
                        else//ako go imame veche tozi User s contesta
                        {
                            if(users[username][contest] < points)//overwriting the points
                            {
                                users[username][contest] = points;
                            }
                        }
                    }
                }
            }//                                      value of the dict, of the value of the 2nd dict
            var bestIntern = users.OrderByDescending(x => x.Value.Values.Sum())//best candidate with the most points
                .ToDictionary(x => x.Key, x => x.Value);
            Console.WriteLine($"Best candidate is {bestIntern.First().Key} with total {bestIntern.First().Value.Values.Sum()} points.");
            Console.WriteLine("Ranking:");

            foreach (var user in users.OrderBy(x=>x.Key))//po imeto
            {
                Console.WriteLine(user.Key);
                foreach (var contest in user.Value.OrderByDescending(x=>x.Value))//po value
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }

            }
        }
    }
}
