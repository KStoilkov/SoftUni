using System;
using System.Linq;

namespace _02.Monopoly
{
    class Monopoly
    {
        public static char hotel = 'H';
        public static char free = 'F';
        public static char jail = 'J';
        public static char shop = 'S';

        public static int turn = 0;
        public static int money = 50;
        public static int hotelsCount = 0;
     
        public static bool isHotelHited = false;

        public static char[,] monopolyField = null;
        public static bool flag = false;

        static void Main()
        {
            int[] dimensions = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            
            monopolyField = new char[dimensions[0], dimensions[1]];
        

            for (int i = 0; i < dimensions[0]; i++)
            {
                char[] field = Console.ReadLine().ToCharArray();
                for (int j = 0; j < field.Length; j++)
                {
                    monopolyField[i,j] = field[j];
                }
            }

            for (int i = 0; i < monopolyField.GetLength(0); i++)
            {
                if (flag)
                {
                    for (int j = monopolyField.GetLength(1) - 1; j >= 0; j--)
                    {
                        checkField(i, j);
                        turn++;
                    }
                    flag = !flag;
                }
                else
                {
                    for (int j = 0; j < monopolyField.GetLength(1); j++)
                    {
                        checkField(i, j);
                        turn++;
                    }
                    flag = !flag;
                }
            }

            Console.WriteLine("Turns "+turn+"");
            Console.WriteLine("Money "+money+"");
        }

        public static void checkField(int posX, int posY)
        {
            char currentField = monopolyField[posX, posY];
            if (currentField == hotel)
            {
                hotelsCount++;
                Console.WriteLine("Bought a hotel for " + money + ". Total hotels: " + hotelsCount + ".");
                isHotelHited = true;
                money = 0;
            }

            if (currentField == jail)
            {
                Console.WriteLine("Gone to jail at turn " + turn + ".");
                turn += 2;
                money += (2 * 10) * hotelsCount;
            }

            if (currentField == shop)
            {
                int spended = (posX + 1) * (posY + 1);
                Console.WriteLine("Spent " + spended + " money at the shop.");
                money -= spended;
            }

            if (isHotelHited)
            {
                money += 10 * hotelsCount;
            }
        }
    }
}
