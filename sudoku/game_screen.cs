using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace sudoku
{
    public partial class game_screen : Form
    {
        private SudokuRepository repository;
        private SudokuService service;
        private LoadingDialog loadingDialog;

        public game_screen()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            repository = new SudokuRepository();
            service = new SudokuService(repository);
            generate_board();
            generate_sudoku();
        }


        private void generate_sudoku()
        {
            loadingDialog = new LoadingDialog();
            loadingDialog.ShowDialogAsync();
            service.GenerateSudokuGame();
            UpdateUI();
            System.Threading.Thread.Sleep(1000);
            loadingDialog.CloseDialog();
        }

        private void generate_board()
        {
            sudoku_board.Controls.Clear();

            int panel_size = sudoku_board.ClientSize.Width;
            int cell_size = panel_size / 9;
            int gap = 3;

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Label label = new Label();
                    label.Name = "label_" + i + "_" + j;
                    label.Font = new Font("Times New Roman", 20);
                    label.Size = new System.Drawing.Size(cell_size, cell_size);
                    label.Location = new System.Drawing.Point(j * cell_size + (j / 3) * gap, i * cell_size + (i / 3) * gap);
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    label.ForeColor = Color.White;
                    label.BackColor = Color.Black;
                    label.BorderStyle = BorderStyle.FixedSingle;
                    sudoku_board.Controls.Add(label);
                }
            }
        }

        private void UpdateUI()
        {
            SudokuSquareEntity[,] matrix = service.get_sudoku_matrix();

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Label label = Controls.Find("label_" + i + "_" + j, true)[0] as Label;
                    int value = matrix[i, j].get_value();
                    label.Text = (value == 0) ? "" : value.ToString();
                }
            }
        }

        private void exitAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void startANewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            generate_sudoku();
        }
    }
}
