using System;
using System.Drawing;
using System.Windows.Forms;

namespace sudoku
{
    internal class SudokuSquareEntity
    {
        private int value;
        private Label label;

        // Constructor
        public SudokuSquareEntity(int value, Label label)
        {
            this.value = value;
            this.label = label;
        }

        public int get_value()
        {
            return value;
        }

        public Label get_label()
        {
            return label;
        }

        public void set_value(int new_value)
        {
            value = new_value;
        }

        public void set_label(Label new_label)
        {
            label = new_label;
        }
    }
}
