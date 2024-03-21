using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sudoku
{
    public partial class start_screen : Form
    {
        public start_screen()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void sudoku_title_Click(object sender, EventArgs e)
        {

        }

        private void exitAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void start_game_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            game_screen form = new game_screen();
            form.ShowDialog();
            this.Show();
        }

        private void startANewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            game_screen form = new game_screen();
            form.ShowDialog();
            this.Show();
        }
    }
}
