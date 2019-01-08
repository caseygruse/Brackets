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


        Bowler Ava = new Bowler("Ava", 253, 251, 268);
            Bowler Bob = new Bowler("Bob", 252, 251, 268);
            Bowler Dave = new Bowler("Dave", 244, 249, 299);
            Bowler Eve = new Bowler("Eve", 239, 300, 300);
            Bowler Frank = new Bowler("Frank", 288, 275, 286);
            Bowler Gina = new Bowler("Gina", 298, 277, 279);
            Bowler Hank = new Bowler("Hank", 299, 281, 269);
            Bowler Ivy = new Bowler("Ivy", 228, 295, 294);

            List<Bowler> list1 = new List<Bowler>();

            list1.Add(Ava);
            list1.Add(Bob);
            list1.Add(Dave);
            list1.Add(Eve);
            list1.Add(Frank);
            list1.Add(Gina);
            list1.Add(Hank);
            list1.Add(Ivy);

            List<Bowler> list2 = Shuffle(list1, rng);
            foreach (Bowler a in list2)
            {
                Console.WriteLine(a);
            }

            Bracket1(list2);

            foreach (Bowler a in list2)
            {
                Console.WriteLine(a);
            }

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
    }
}
