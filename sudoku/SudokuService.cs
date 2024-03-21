using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace sudoku
{
    internal class SudokuService
    {
        private SudokuRepository repository;
        private Random random;

        public SudokuService(SudokuRepository repo)
        {
            repository = repo;
            random = new Random();
        }

        public SudokuSquareEntity[,] get_sudoku_matrix()
        {
            return repository.get_matrix();
        }

        public void GenerateSudokuGame()
        {
            ClearSudokuMatrix();
            BacktrackFill(0, 0);
        }

        private void ClearSudokuMatrix()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    repository.get_matrix()[i, j].set_value(0);
                    repository.get_matrix()[i, j].get_label().Text = "";
                }
            }
        }

        private bool BacktrackFill(int row, int col)
        {
            // Completed matrix
            if (row == 9)
            {
                return true;
            }

            // Next row
            if (col == 9)
            {
                return BacktrackFill(row + 1, 0);
            }

            // Next column
            if (repository.get_matrix()[row, col].get_value() != 0)
            {
                return BacktrackFill(row, col + 1);
            }

            // Assures the values aren't being used in a specific order
            List<int> nums = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            nums.Shuffle(random); 
            foreach (int num in nums)
            {
                if (IsValidMove(row, col, num))
                {
                    repository.get_matrix()[row, col].set_value(num);
                    repository.get_matrix()[row, col].get_label().Text = num.ToString();

                    if (BacktrackFill(row, col + 1))
                    {
                        return true;
                    }

                    repository.get_matrix()[row, col].set_value(0);
                    repository.get_matrix()[row, col].get_label().Text = "";

                }
            }

            return false;
        }

        private bool IsValidMove(int row, int col, int num)
        {
            // Check if the number is already present in the current row or column
            for (int i = 0; i < 9; i++)
            {
                if (repository.get_matrix()[row, i].get_value() == num || repository.get_matrix()[i, col].get_value() == num)
                {
                    return false;
                }
            }

            // Check if the number is already present in the current 3x3 subgrid
            int startRow = row - row % 3;
            int startCol = col - col % 3;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (repository.get_matrix()[startRow + i, startCol + j].get_value() == num)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }

    internal static class ListExtensions
    {
        public static void Shuffle<T>(this IList<T> list, Random rng)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
