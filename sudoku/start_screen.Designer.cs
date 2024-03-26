namespace sudoku
{
    partial class start_screen
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
            this.start_menu = new System.Windows.Forms.MenuStrip();
            this.menu_bar = new System.Windows.Forms.ToolStripMenuItem();
            this.startANewGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.start_game_button = new System.Windows.Forms.Button();
            this.sudoku_title = new System.Windows.Forms.Label();
            this.start_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // start_menu
            // 
            this.start_menu.BackColor = System.Drawing.Color.Black;
            this.start_menu.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_menu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.start_menu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.start_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_bar});
            this.start_menu.Location = new System.Drawing.Point(0, 0);
            this.start_menu.Name = "start_menu";
            this.start_menu.Size = new System.Drawing.Size(1058, 49);
            this.start_menu.TabIndex = 0;
            this.start_menu.Text = "menuStrip1";
            // 
            // menu_bar
            // 
            this.menu_bar.BackColor = System.Drawing.Color.Black;
            this.menu_bar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startANewGameToolStripMenuItem,
            this.exitAppToolStripMenuItem});
            this.menu_bar.ForeColor = System.Drawing.Color.White;
            this.menu_bar.Name = "menu_bar";
            this.menu_bar.Padding = new System.Windows.Forms.Padding(0);
            this.menu_bar.ShortcutKeyDisplayString = "Ctrl+M";
            this.menu_bar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.menu_bar.Size = new System.Drawing.Size(103, 45);
            this.menu_bar.Text = "Menu";
            // 
            // startANewGameToolStripMenuItem
            // 
            this.startANewGameToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.startANewGameToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.startANewGameToolStripMenuItem.Name = "startANewGameToolStripMenuItem";
            this.startANewGameToolStripMenuItem.Size = new System.Drawing.Size(372, 50);
            this.startANewGameToolStripMenuItem.Text = "Start a new game";
            this.startANewGameToolStripMenuItem.Click += new System.EventHandler(this.startANewGameToolStripMenuItem_Click);
            // 
            // exitAppToolStripMenuItem
            // 
            this.exitAppToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.exitAppToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.exitAppToolStripMenuItem.Name = "exitAppToolStripMenuItem";
            this.exitAppToolStripMenuItem.Size = new System.Drawing.Size(372, 50);
            this.exitAppToolStripMenuItem.Text = "Exit app";
            this.exitAppToolStripMenuItem.Click += new System.EventHandler(this.exitAppToolStripMenuItem_Click);
            // 
            // start_game_button
            // 
            this.start_game_button.BackColor = System.Drawing.Color.Black;
            this.start_game_button.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_game_button.ForeColor = System.Drawing.Color.White;
            this.start_game_button.Location = new System.Drawing.Point(140, 360);
            this.start_game_button.Margin = new System.Windows.Forms.Padding(1);
            this.start_game_button.Name = "start_game_button";
            this.start_game_button.Size = new System.Drawing.Size(800, 120);
            this.start_game_button.TabIndex = 1;
            this.start_game_button.Text = "Start a new game";
            this.start_game_button.UseVisualStyleBackColor = false;
            this.start_game_button.Click += new System.EventHandler(this.start_game_button_Click);
            // 
            // sudoku_title
            // 
            this.sudoku_title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sudoku_title.AutoSize = true;
            this.sudoku_title.Font = new System.Drawing.Font("Times New Roman", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sudoku_title.ForeColor = System.Drawing.Color.White;
            this.sudoku_title.Location = new System.Drawing.Point(370, 230);
            this.sudoku_title.Margin = new System.Windows.Forms.Padding(0);
            this.sudoku_title.Name = "sudoku_title";
            this.sudoku_title.Size = new System.Drawing.Size(509, 164);
            this.sudoku_title.TabIndex = 2;
            this.sudoku_title.Text = "Sudoku";
            this.sudoku_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sudoku_title.Click += new System.EventHandler(this.sudoku_title_Click);
            // 
            // start_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1058, 631);
            this.Controls.Add(this.sudoku_title);
            this.Controls.Add(this.start_game_button);
            this.Controls.Add(this.start_menu);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.ForeColor = System.Drawing.Color.Violet;
            this.MainMenuStrip = this.start_menu;
            this.Name = "start_screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "start_screen";
            this.start_menu.ResumeLayout(false);
            this.start_menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip start_menu;
        private System.Windows.Forms.ToolStripMenuItem menu_bar;
        private System.Windows.Forms.ToolStripMenuItem startANewGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitAppToolStripMenuItem;
        private System.Windows.Forms.Button start_game_button;
        private System.Windows.Forms.Label sudoku_title;
    }
}