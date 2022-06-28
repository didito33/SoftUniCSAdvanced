using System;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            // DateTime.Diff(); - STATIC
            //DateTime dt = new DateTime();
            //DateModifier dateModifier = new DateModifier(); - ne moje, zashtoto e STATIC
            //1992 05 31
            //2016 06 17
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();
            int result = DateModifier.CalculateDifference(firstDate, secondDate);
            Console.WriteLine(result);
        }
    }
}
