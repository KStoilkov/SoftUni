namespace _06.Connected_Areas_In_Matrix
{
    using System;
    using System.Collections.Generic;

    public class ConnectedAreasInMatrix
    {
        private static char[,] matrix =
            {
                { ' ', ' ', ' ', '*', ' ', ' ', ' ', '*', ' ' },
                { ' ', ' ', ' ', '*', ' ', ' ', ' ', '*', ' ' },
                { ' ', ' ', ' ', '*', ' ', ' ', ' ', '*', ' ' },
                { ' ', ' ', ' ', ' ', '*', ' ', '*', ' ', ' ' }
            };

        private static int matrixRowNum = matrix.GetLength(0);
        private static int matrixColNum = matrix.GetLength(1);

        private static SortedSet<Area> areasFound = new SortedSet<Area>(); 

        public static void Main(string[] args)
        {
            FindEmptyCells();
            PrintResult();
        }

        private static void FindEmptyCells()
        {
            for (int i = 0; i < matrixRowNum; i++)
            {
                for (int j = 0; j < matrixColNum; j++)
                {
                    if (matrix[i, j] == ' ')
                    {
                        Area area = new Area(0, i, j);
                        MarkArea(i, j, area);
                        areasFound.Add(area);
                    }
                }
            }
        }

        private static void MarkArea(int row, int col, Area area)
        {
            if (row < 0 || col < 0 || row >= matrixRowNum || col >= matrixColNum)
            {
                return;
            }

            if (matrix[row, col] == 'x' || matrix[row, col] == '*')
            {
                return;
            }

            matrix[row, col] = 'x';
            area.Size++;

            MarkArea(row + 1, col, area);
            MarkArea(row, col + 1, area);
            MarkArea(row - 1, col, area);
            MarkArea(row, col - 1, area);
        }

        private static void PrintResult()
        {
            Console.WriteLine("Total Areas Found: " + areasFound.Count);

            int printCounter = 0;
            foreach (var area in areasFound)
            {
                Console.WriteLine("Area #{0} at {1}", ++printCounter, area);
            }
        }
    }
}
