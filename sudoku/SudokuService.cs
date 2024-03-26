using System;
using System.Collections.Generic;
using System.Drawing;
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

        public int[,] get_matrix_values()
        {
            return repository.get_matrix_values();
        }

        public Label[,] get_matrix_labels()
        {
            return repository.get_matrix_labels();
        }

        public void GenerateSudokuGame()
        {
            int[,] matrix_values = repository.get_matrix_values();
            ClearSudokuMatrix();
            BacktrackFill(matrix_values, 0, 0);
            Label[,] matrix_labels = new Label[9, 9];
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    matrix_labels[i, j] = new Label();
                    matrix_labels[i, j].Name = "label_" + i + "_" + j;
                    matrix_labels[i, j].Font = new Font("Times New Roman", 20);
                    matrix_labels[i, j].TextAlign = ContentAlignment.MiddleCenter;
                    matrix_labels[i, j].ForeColor = Color.Black;
                    matrix_labels[i, j].BackColor = Color.White;
                    matrix_labels[i, j].BorderStyle = BorderStyle.FixedSingle;
                    matrix_labels[i, j].Text = $"{matrix_values[i,j]}";
                }
            }
            repository.set_matrix(matrix_values, matrix_labels);
        }

        private void ClearSudokuMatrix()
        {
            int[,] matrix_values = new int[9, 9];
            Label[,] matrix_labels = new Label[9, 9];
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    matrix_labels[i, j] = new Label();
                    matrix_labels[i, j].Name = "label_" + i + "_" + j;
                    matrix_labels[i, j].Font = new Font("Times New Roman", 20);
                    matrix_labels[i, j].TextAlign = ContentAlignment.MiddleCenter;
                    matrix_labels[i, j].ForeColor = Color.Black;
                    matrix_labels[i, j].BackColor = Color.White;
                    matrix_labels[i, j].BorderStyle = BorderStyle.FixedSingle;
                    matrix_labels[i, j].Text = "0";
                    matrix_values[i, j] = 0;
                }
            }
            repository.set_matrix(matrix_values, matrix_labels);
        }

        private bool BacktrackFill(int[,] matrix_values, int row, int col)
        {
            // Completed matrix
            if (row == 9)
            {
                return true;
            }

            // Next row
            if (col == 9)
            {
                return BacktrackFill(matrix_values, row + 1, 0);
            }

            // Next column
            if (matrix_values[row, col] != 0)
            {
                return BacktrackFill(matrix_values, row, col + 1);
            }

            // Assures the values aren't being used in a specific order
            List<int> nums = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            nums.Shuffle(random);
            foreach (int num in nums)
            {
                if (IsValidMove(matrix_values, row, col, num))
                {
                    matrix_values[row, col] = num;
                    if (BacktrackFill(matrix_values, row, col + 1))
                    {
                        return true;
                    }
                    matrix_values[row, col] = 0;
                }
            }
            return false;
        }

        private bool IsValidMove(int[,] matrix_values, int row, int col, int num)
        {
            // Check if the number is already present in the current row or column
            for (int i = 0; i < 9; i++)
            {
                if (matrix_values[row, i] == num || matrix_values[i, col] == num)
                {
                    return false;
                }
            }

            // Check if the number is already present in the current 3x3 grid
            int startRow = row - row % 3;
            int startCol = col - col % 3;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (matrix_values[startRow + i, startCol + j] == num)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public Label[,] generate_playable_board()
        {
            int[,] matrix_values = get_matrix_values();
            Random random = new Random();
            int filledCount = 0;
            while (filledCount < 1)
            {
                int row = random.Next(0, 9);
                int col = random.Next(0, 9);
                if (matrix_values[row, col] != 0)
                {
                    matrix_values[row, col] = 0;
                    filledCount++;
                }
            } 
            Label[,] matrix_labels = new Label[9, 9];
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    matrix_labels[i, j] = new Label();
                    matrix_labels[i, j].Name = "label_" + i + "_" + j;
                    matrix_labels[i, j].Font = new Font("Times New Roman", 20);
                    matrix_labels[i, j].TextAlign = ContentAlignment.MiddleCenter;
                    matrix_labels[i, j].ForeColor = Color.Black;
                    matrix_labels[i, j].BackColor = Color.White;
                    matrix_labels[i, j].BorderStyle = BorderStyle.FixedSingle;
                    matrix_labels[i, j].Text = $"{matrix_values[i, j]}";
                }
            }
            return matrix_labels;
        }

        public bool check_game(Label[,] matrix_label)
        {
            int[,] matrix_values = repository.get_matrix_values();
            bool ok = true;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    string labelText = matrix_label[i, j].Text.Trim(); 
                    if (labelText.Length == 0 || labelText.CompareTo("1") < 0 || labelText.CompareTo("9") > 0)
                    {
                        ok=false; 
                        break;
                    }
                    else
                    {
                        if (matrix_values[i, j] != int.Parse(matrix_label[i, j].Text))
                        {
                            matrix_label[i, j].BackColor = Color.Red;
                            ok = false;
                        }
                    }
                }
            }
            return ok;
        }

        public void winning_board(Label[,] matrix_label)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    matrix_label[i,j].BackColor = Color.Black;
                    matrix_label[i,j].ForeColor = Color.White;
                }
            }
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
