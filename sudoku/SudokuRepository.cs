using System.Drawing;
using System.Windows.Forms;

namespace sudoku
{
    internal class SudokuRepository
    {
        private SudokuSquareEntity[,] sudoku_matrix;

        // Constructor
        public SudokuRepository()
        {
            sudoku_matrix = new SudokuSquareEntity[9, 9];

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Label label = new Label();
                    label.Name = "label_" + i + "_" + j;
                    label.Font = new Font("Times New Roman", 20);
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    label.ForeColor = Color.Black;
                    label.BackColor = Color.White;
                    label.BorderStyle = BorderStyle.FixedSingle;
                    sudoku_matrix[i, j] = new SudokuSquareEntity(0, label);
                }
            }
        }

        public int[,] get_matrix_values()
        {
            int[,] matrix_values= new int[9,9];
            for(int i=0; i<9; i++)
            {
                for(int j=0; j<9; j++)
                {
                    matrix_values[i, j] = sudoku_matrix[i, j].get_value();
                }
            }
            return matrix_values;

        }

        public Label[,] get_matrix_labels()
        {
            Label[,] matrix_labels = new Label[9, 9];
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    matrix_labels[i, j] = sudoku_matrix[i, j].get_label();
                }
            }
            return matrix_labels;

        }

        public void set_matrix(int[,] matrix_values, Label[,] matrix_labels)
        {
            SudokuSquareEntity[,] matrix = new SudokuSquareEntity[9,9];
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    matrix[i, j] = new SudokuSquareEntity(matrix_values[i, j], matrix_labels[i, j]);
                }
            }
            sudoku_matrix = matrix;
        }
        public void set_matrix_labels(int[,] matrix_values)
        {
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
            set_matrix(matrix_values, matrix_labels);
        }
    }
}
