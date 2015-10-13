namespace _02.GeneratePermutationsIteratively
{
    using System;
    using System.Linq;

    public class GeneratePermutations
    {
        private static int[] nums;

        private static int[] temp;

        private static int totalPermutations = 1;

        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            nums = Enumerable.Range(1, n).ToArray();
            temp = Enumerable.Range(0, n + 1).ToArray();

            Console.WriteLine(string.Join(",", nums));

            Permute(n);

            Console.WriteLine("Total: " + totalPermutations);
        }

        private static void Permute(int n)
        {
            int indexI = 1;
            int indexJ = 0;

            while (indexI < n)
            {
                temp[indexI]--;

                indexJ = indexI % 2 == 1 ? temp[indexI] : 0;

                Swap(ref nums[indexJ], ref nums[indexI]);

                indexI = 1;

                while (temp[indexI] == 0)
                {
                    temp[indexI] = indexI;
                    indexI++;
                }

                totalPermutations++;
                Console.WriteLine(string.Join(",", nums));
            }
        }

        private static void Swap(ref int i, ref int j)
        {
            if (i == j)
            {
                return;
            }

            i ^= j;
            j ^= i;
            i ^= j;
        }
    }
}
