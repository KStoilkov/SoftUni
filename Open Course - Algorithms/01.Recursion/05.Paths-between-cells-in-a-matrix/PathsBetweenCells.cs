namespace _05.Paths_between_cells_in_a_matrix
{
    using System;
    using System.Collections.Generic;

    public class PathsBetweenCells
    {
        private static char[,] labyrinth = 
        {
            { 's', ' ', ' ', ' ' },
            { ' ', '*', '*', ' ' },
            { ' ', '*', '*', ' ' },
            { ' ', '*', 'e', ' ' },
            { ' ', ' ', ' ', ' ' }
        };

        private static int numRows = labyrinth.GetLength(0);
        private static int numCols = labyrinth.GetLength(1);

        private static int totalPathsFound = 0;

        private static List<char> path = new List<char>(); 

        public static void Main(string[] args)
        {
            FindExit(0, 0, 'S');
            Console.WriteLine("Total paths found: " + totalPathsFound);
        }

        private static void FindExit(int row, int col, char direction)
        {
            if (row < 0 || col < 0 || row >= numRows || col >= numCols || labyrinth[row, col] == '*' || labyrinth[row, col] == 'x')
            {
                return;
            }

            if (labyrinth[row, col] == 'e')
            {
                Console.WriteLine("Exit Found! Path: {0}, {1}", string.Join(", ", path), direction);
                totalPathsFound++;
                return;
            }

            labyrinth[row, col] = 'x';
            path.Add(direction);

            FindExit(row + 1, col, 'D');
            FindExit(row, col + 1, 'R');
            FindExit(row - 1, col, 'U');
            FindExit(row, col - 1, 'L');

            labyrinth[row, col] = ' ';
            path.RemoveAt(path.Count - 1);
        }
    }
}
