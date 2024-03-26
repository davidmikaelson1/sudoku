using System;
using System.Drawing;
using System.Windows.Forms;

namespace sudoku
{
    public partial class game_screen : Form
    {
        private SudokuRepository repository;
        private SudokuService service;
        private LoadingDialog loadingDialog;
        private System.Windows.Forms.Timer timer;
        private int elapsedTimeInSeconds;

        public game_screen()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            repository = new SudokuRepository();
            service = new SudokuService(repository);
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            generate_sudoku();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            elapsedTimeInSeconds++;
            int minutes = elapsedTimeInSeconds / 60;
            int seconds = elapsedTimeInSeconds % 60;
            timer_label.Text = $"{minutes:00}:{seconds:00}";
        }

        private void startTimer()
        {
            elapsedTimeInSeconds = 0;
            timer.Start();
        }

        private void stopTimer()
        {
            timer.Stop();
        }

        private void startANewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            generate_sudoku();
        }

        private void generate_sudoku()
        {
            loadingDialog = new LoadingDialog();
            loadingDialog.ShowDialogAsync();
            service.GenerateSudokuGame();

            Label[,] playable_matrix = service.generate_playable_board();

            update_ui(playable_matrix);
            System.Threading.Thread.Sleep(1000);
            stopTimer();
            startTimer();
            loadingDialog.CloseDialog();
        }


        // Edit the game:

        private Label currentlySelectedLabel = null;
        private void Label_Click(object sender, EventArgs e)
        {
            if (sender is Label clickedLabel)
            {
                if (currentlySelectedLabel != null)
                {
                    currentlySelectedLabel.BackColor = Color.White;
                    currentlySelectedLabel.ForeColor = Color.Black;
                }
                currentlySelectedLabel = clickedLabel;
                currentlySelectedLabel.BackColor = Color.Black;
                currentlySelectedLabel.ForeColor = Color.White;
            }
        }
        private void enter_value_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string newText = enter_value.Text;
                if (currentlySelectedLabel != null)
                {
                    currentlySelectedLabel.Text = newText;
                }
            }
        }
        // end
        private void update_ui(Label[,] matrix)
        {
            sudoku_board.Controls.Clear();
            enter_value.Enabled = true;
            enter_value.KeyDown += enter_value_KeyDown;
            int panel_size = sudoku_board.ClientSize.Width;
            int cell_size = panel_size / 9;
            int gap = 3;

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    matrix[i, j].Size = new System.Drawing.Size(cell_size, cell_size);
                    matrix[i, j].Location = new System.Drawing.Point(j * cell_size + (j / 3) * gap, i * cell_size + (i / 3) * gap);
                    matrix[i, j].Click += Label_Click;
                    if (matrix[i, j].Text == "0")
                    {
                        matrix[i, j].Text = "";
                    }
                    sudoku_board.Controls.Add(matrix[i, j]);
                }
            }
        }
        
        private void exitAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void game_screen_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void check_button_Click(object sender, EventArgs e)
        {
            Label[,] matrix_label = new Label[9,9];
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Label label = Controls.Find("label_" + i + "_" + j, true)[0] as Label;
                    matrix_label[i, j] = new Label();
                    if (label.Text == "")
                    {
                        matrix_label[i, j].Text = "0";
                    }
                    matrix_label[i, j] = label;
                }
            }
            bool check = service.check_game(matrix_label);
            if(check)
            {
                service.winning_board(matrix_label);
                update_ui(matrix_label);
                MessageBox.Show("Congratulations!");
                enter_value.Enabled = false;
            }
            else
            {
                update_ui(matrix_label);
                MessageBox.Show("Some of the values aren't valid!");
            }
        }

        private void autofillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Label[,] matrix_labels = service.get_matrix_labels();
            update_ui(matrix_labels);
            enter_value.Enabled = false;
        }
    }
}
