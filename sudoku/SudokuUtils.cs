using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sudoku
{
    internal class SudokuUtils
    {
        private int[,] sudoku_matrix;

        public void generate_board(Panel sudoku_board)
        {
            sudoku_board.Controls.Clear();

            int panel_size = sudoku_board.ClientSize.Width;
            int cell_size = panel_size / 9;

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Label label = new Label();
                    label.Name = "label_" + i + "_" + j;
                    label.Size = new System.Drawing.Size(cell_size, cell_size);
                    label.Location = new System.Drawing.Point(j * cell_size, i * cell_size);
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    label.ForeColor = Color.White;
                    label.BackColor = Color.Black;
                    label.BorderStyle = BorderStyle.FixedSingle;
                    sudoku_board.Controls.Add(label);
                }
            }
        }

        public void generate_starting_game()
        {

        }

    }
}
