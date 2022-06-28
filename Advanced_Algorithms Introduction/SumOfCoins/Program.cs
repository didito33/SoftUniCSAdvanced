using System;
using System.Collections.Generic;
using System.Linq;

namespace SumOfCoins
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] coins = new[] { 1, 2, 5, 10, 20, 50 };
            int targetSum = 923;
            Dictionary<int, int> result = ChooseCoins(coins, targetSum);
            Console.WriteLine($"Number of coins to take: {result.Sum(x=>x.Value)}");
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Value} coin(s) with value {item.Key}");
            }
        }
        public static Dictionary<int,int> ChooseCoins(IList<int> coins, int targetSum)
        {
            Dictionary<int, int> coinsCount = new Dictionary<int, int>();

            int index = coins.Count - 1;//Starting from the last element
            //1,2,5,10,20,50
            while (index > -1)
            {
                int currentCoin = coins[index];
                //923 / 50 = 18(.46) => взимаме 18(пъти)
                int result = targetSum / currentCoin;
                if (result < 1)//40/50 <1
                {
                    index--;//отиваме на следващия coin
                    continue;
                }
                // 50, 18 пъти
                coinsCount.Add(currentCoin, result);
                //923 -= 50*18
                targetSum -= currentCoin * result;
                if (targetSum == 0)
                {
                    break;
                }
            }
            if(targetSum > 0)
            {
                throw new InvalidOperationException();
            }
            return coinsCount;
        }
    }
}
