namespace sudoku
{
    partial class game_screen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.game_menu = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startANewGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autofillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sudoku_title = new System.Windows.Forms.Label();
            this.sudoku_board = new System.Windows.Forms.Panel();
            this.timer_label = new System.Windows.Forms.Label();
            this.check_button = new System.Windows.Forms.Button();
            this.enter_value = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.game_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // game_menu
            // 
            this.game_menu.BackColor = System.Drawing.Color.Black;
            this.game_menu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.game_menu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.game_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.game_menu.Location = new System.Drawing.Point(0, 0);
            this.game_menu.Name = "game_menu";
            this.game_menu.Padding = new System.Windows.Forms.Padding(0);
            this.game_menu.Size = new System.Drawing.Size(1058, 45);
            this.game_menu.TabIndex = 0;
            this.game_menu.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startANewGameToolStripMenuItem,
            this.autofillToolStripMenuItem,
            this.exitAppToolStripMenuItem});
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(115, 45);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // startANewGameToolStripMenuItem
            // 
            this.startANewGameToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.startANewGameToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startANewGameToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.startANewGameToolStripMenuItem.Name = "startANewGameToolStripMenuItem";
            this.startANewGameToolStripMenuItem.Size = new System.Drawing.Size(372, 50);
            this.startANewGameToolStripMenuItem.Text = "Start a new game";
            this.startANewGameToolStripMenuItem.Click += new System.EventHandler(this.startANewGameToolStripMenuItem_Click);
            // 
            // autofillToolStripMenuItem
            // 
            this.autofillToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.autofillToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autofillToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.autofillToolStripMenuItem.Name = "autofillToolStripMenuItem";
            this.autofillToolStripMenuItem.Size = new System.Drawing.Size(372, 50);
            this.autofillToolStripMenuItem.Text = "Autofill";
            this.autofillToolStripMenuItem.Click += new System.EventHandler(this.autofillToolStripMenuItem_Click);
            // 
            // exitAppToolStripMenuItem
            // 
            this.exitAppToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.exitAppToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitAppToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.exitAppToolStripMenuItem.Name = "exitAppToolStripMenuItem";
            this.exitAppToolStripMenuItem.Size = new System.Drawing.Size(372, 50);
            this.exitAppToolStripMenuItem.Text = "Exit app";
            this.exitAppToolStripMenuItem.Click += new System.EventHandler(this.exitAppToolStripMenuItem_Click);
            // 
            // sudoku_title
            // 
            this.sudoku_title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sudoku_title.AutoSize = true;
            this.sudoku_title.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sudoku_title.ForeColor = System.Drawing.Color.White;
            this.sudoku_title.Location = new System.Drawing.Point(477, 40);
            this.sudoku_title.Margin = new System.Windows.Forms.Padding(0);
            this.sudoku_title.Name = "sudoku_title";
            this.sudoku_title.Size = new System.Drawing.Size(184, 60);
            this.sudoku_title.TabIndex = 3;
            this.sudoku_title.Text = "Sudoku";
            this.sudoku_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sudoku_board
            // 
            this.sudoku_board.BackColor = System.Drawing.Color.White;
            this.sudoku_board.Location = new System.Drawing.Point(289, 105);
            this.sudoku_board.Margin = new System.Windows.Forms.Padding(0);
            this.sudoku_board.Name = "sudoku_board";
            this.sudoku_board.Padding = new System.Windows.Forms.Padding(3);
            this.sudoku_board.Size = new System.Drawing.Size(501, 501);
            this.sudoku_board.TabIndex = 4;
            // 
            // timer_label
            // 
            this.timer_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timer_label.AutoSize = true;
            this.timer_label.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer_label.ForeColor = System.Drawing.Color.White;
            this.timer_label.Location = new System.Drawing.Point(908, 16);
            this.timer_label.Margin = new System.Windows.Forms.Padding(0);
            this.timer_label.Name = "timer_label";
            this.timer_label.Size = new System.Drawing.Size(0, 60);
            this.timer_label.TabIndex = 6;
            this.timer_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // check_button
            // 
            this.check_button.BackColor = System.Drawing.Color.Black;
            this.check_button.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_button.Location = new System.Drawing.Point(891, 554);
            this.check_button.Margin = new System.Windows.Forms.Padding(1);
            this.check_button.Name = "check_button";
            this.check_button.Size = new System.Drawing.Size(129, 52);
            this.check_button.TabIndex = 7;
            this.check_button.Text = "Check";
            this.check_button.UseVisualStyleBackColor = false;
            this.check_button.Click += new System.EventHandler(this.check_button_Click);
            // 
            // enter_value
            // 
            this.enter_value.Enabled = false;
            this.enter_value.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter_value.Location = new System.Drawing.Point(840, 149);
            this.enter_value.Name = "enter_value";
            this.enter_value.Size = new System.Drawing.Size(68, 49);
            this.enter_value.TabIndex = 8;
            this.enter_value.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(833, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 41);
            this.label1.TabIndex = 9;
            this.label1.Text = "Enter value:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // game_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1058, 631);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enter_value);
            this.Controls.Add(this.check_button);
            this.Controls.Add(this.timer_label);
            this.Controls.Add(this.sudoku_board);
            this.Controls.Add(this.sudoku_title);
            this.Controls.Add(this.game_menu);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.ForeColor = System.Drawing.Color.White;
            this.MainMenuStrip = this.game_menu;
            this.Name = "game_screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "game_screen";
            this.Load += new System.EventHandler(this.game_screen_Load);
            this.game_menu.ResumeLayout(false);
            this.game_menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip game_menu;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startANewGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autofillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitAppToolStripMenuItem;
        private System.Windows.Forms.Label sudoku_title;
        private System.Windows.Forms.Panel sudoku_board;
        private System.Windows.Forms.Label timer_label;
        private System.Windows.Forms.Button check_button;
        private System.Windows.Forms.TextBox enter_value;
        private System.Windows.Forms.Label label1;
    }
}