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

            // Initialize the matrix with SudokuSquareEntity objects having a value of 0
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Label label = new Label();
                    label.Name = "label_" + i + "_" + j;
                    sudoku_matrix[i, j] = new SudokuSquareEntity(0, new Label());
                }
            }
        }

        public SudokuSquareEntity[,] get_matrix()
        {
            return sudoku_matrix;
        }

        public void set_matrix(SudokuSquareEntity[,] new_matrix)
        {
            sudoku_matrix = new_matrix;
        }
    }
}
