using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();

            List<Bowler> list1 = new List<Bowler>();

            //get all lines from bowler file to an array of strings
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\cgruse\Desktop\tournament.txt");
        
            //loop through lines of file
            for(int i = 0; i < lines.Count(); i++)
            {
                //split lines into name and three scores and put them into an array
                string[] bowler = lines[i].Split(new char[0]);
                //get name from string array
                string name = bowler[0];
                //get games from string array
                int game1 = Convert.ToInt32(bowler[1]);
                int game2 = Convert.ToInt32(bowler[2]);
                int game3 = Convert.ToInt32(bowler[3]);
                //add bowler objects to list1.
                list1.Add(new Bowler(name, game1, game2, game3));
            }

            //shuffle list and store it into list2.
            List<Bowler> list2 = Shuffle(list1, rng);

            //might need this to know who played who
            //list1 = list2.ToList();

            foreach (Bowler a in list2)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("\n");

            //first games
            Bracket1(list2);

            foreach (Bowler a in list2)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("\n");

            //second games
            Bracket2(list2);

            foreach (Bowler a in list2)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("\n");

            //third game
            Bracket3(list2);

            Console.WriteLine(list2[0] + " is the winner");

            Console.ReadKey();
        }

        /// <summary>
        /// shuffles a list of bowlers.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="rng"></param>
        /// <returns></returns>
        public static List<Bowler> Shuffle(List<Bowler> list, Random rng)
        {
            List<Bowler> list2 = new List<Bowler>(list);
            
            int n = list2.Count;
            while (n > 1)
            {
                n--;
                int ran = rng.Next(n);
                Bowler temp = list2[ran];
                list2[ran] = list2[n];
                list2[n] = temp;
            }
            return list2;
        }

        public static void Bracket1(List<Bowler> list2)
        {
            for(int i = 0; i < list2.Count; i++)
            {
                if(list2[i].Game1 < list2[i + 1].Game1)
                {
                    list2.Remove(list2[i]);
                }
                else
                {
                    list2.Remove(list2[i + 1]);
                }
            }
        }

        public static void Bracket2(List<Bowler> list2)
        {
            for (int i = 0; i < list2.Count; i++)
            {
                if(list2[i].Game2 < list2[i + 1].Game2)
                {
                    list2.Remove(list2[i]);
                }
                else
                {
                    list2.Remove(list2[i + 1]);
                }
            }
        }

        public static void Bracket3(List<Bowler> list2)
        {
            if(list2[0].Game3 < list2[1].Game3)
            {
                list2.Remove(list2[0]);
            }
            else
            {
                list2.Remove(list2[1]);
            }
        }
    }
}
