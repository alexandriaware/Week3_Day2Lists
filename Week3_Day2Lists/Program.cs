using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Day2Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> testScores = new List<int>() { 98, 100, 76, 84, 93 };
            //testScores.Add(80);
            //testScores.Add(99);

            //List<int> luckyNumbers = new List<int>();
            //luckyNumbers.Add(2);
            //luckyNumbers.Add(3);
            //luckyNumbers.Add(5);
            //luckyNumbers.Add(7);
            //luckyNumbers.Add(1);
            //Console.WriteLine(luckyNumbers.Count);

            //List<string> faveFoods = new List<string>() { "pizza", "noodles", "shrimp", "brisket", "peanut butter" };
            //Console.WriteLine(faveFoods[0]);
            //Console.WriteLine(faveFoods[1]);
            //Console.WriteLine(faveFoods[4]);

            //List<string> leastFaveFoods = new List<string>();
            //leastFaveFoods.Add("cooked spinach");
            //leastFaveFoods.Add("fatty meat");
            //leastFaveFoods.Add("lobster");

            //Console.WriteLine(leastFaveFoods[2]);
            //leastFaveFoods[2] = "blue cheese";
            //Console.WriteLine(leastFaveFoods[2]);

            List<string> faveFilms = new List<string>() { "LOTR", "Harry Potter", "Princess Bride", "Iron Giant", "Trolls" };

            for(int i = 0; i < faveFilms.Count; i++)
            {
                Console.WriteLine(faveFilms[i]); 
            }

            faveFilms.Insert(0, "Atlantis");
            faveFilms.Insert(1, "Hercules");
            faveFilms.Insert(2, "Sing");

            foreach(string film in faveFilms)
            {
                Console.WriteLine(film);
            }

        }
    }
}
