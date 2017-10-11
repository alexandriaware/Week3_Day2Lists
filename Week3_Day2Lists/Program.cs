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

            for (int i = 0; i < faveFilms.Count; i++)
            {
                Console.WriteLine(faveFilms[i]);
            }

            faveFilms.Insert(0, "Atlantis");
            faveFilms.Insert(1, "Hercules");
            faveFilms.Insert(2, "Sing");
            Console.WriteLine();

            foreach (string film in faveFilms)
            {
                Console.WriteLine(film);
            }

            string [] faveFilmsArray = faveFilms.ToArray(); // <--creates a new array out of a list.

            List<string> faveFilmsListFromArray =  faveFilmsArray.ToList<string>();


            faveFilms.Remove("Hercules");
            Console.WriteLine();

            foreach (string film in faveFilms)
            {
                Console.WriteLine(film);
            }


            //////Do it!
            //List<string> animals = new List<string>();
            //animals.Add("Otter");
            //animals.Add("Platypus");
            //animals.Add("Kangaroo");
            //animals.Add("Opossum");
            //animals.Add("Trash Panda");

            //foreach (string animal in animals)
            //{
            //    Console.WriteLine(animal);
            //}


            //////Do it!! 2
            //List<bool> boolList = new List<bool>() { true, false, false, true, false };

            //foreach (bool booly in boolList)
            //{
            //    if (booly == true)
            //    {
            //        Console.WriteLine("Better bring an umbrella!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No rain today, enjoy the sun!");
            //    }



            //}


            //////Do it!! 3
            //List<int> numbers = new List<int> { 1, 23, 9, 77, 922, 6, 32, 63, 14, 5 };

            //Console.WriteLine(numbers.Contains(23));
            //Console.WriteLine(numbers.Contains(77));
            //Console.WriteLine(numbers.Contains(15));

            //numbers.Remove(27);
            //numbers.Remove(77);
            //numbers.Remove(32);
            //numbers.Remove(6);

            //Console.WriteLine(numbers.Contains(23));
            //Console.WriteLine(numbers.Contains(77));
            //Console.WriteLine(numbers.Contains(15));



            //Do it!! 4 Homework
            List<string> homework = new List<string>() { "count", "clear", "add", "remove", "sort", "index of", "contains", "remove at", "insert" };
            Console.WriteLine(homework.Count());
            homework.Add("effort");
            foreach (string work in homework)
            {
                Console.WriteLine(work);
            }

            Console.WriteLine();
            homework.Remove("effort");
            Console.WriteLine();

            homework.Sort();
            foreach (string work in homework)
            {
                Console.WriteLine(work);
            }

            Console.WriteLine();
            Console.WriteLine(homework.IndexOf("remove"));

            Console.WriteLine(homework.Contains("clear"));


            Console.WriteLine();
            homework.RemoveAt(7);
            foreach (string work in homework)
            {
                Console.WriteLine(work);
            }


            Console.WriteLine();
            homework.Insert(3, "NEW THING");
            foreach (string work in homework)
            {
                Console.WriteLine(work);
            }


            Console.WriteLine();
            homework.Clear();
            foreach (string work in homework)
            {
                Console.WriteLine(work);
            }





        }
    }
}
