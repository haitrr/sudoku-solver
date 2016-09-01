namespace SudokuSolver
{
    partial class Main
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
            this.PNBoard = new System.Windows.Forms.Panel();
            this.BTReset = new System.Windows.Forms.Button();
            this.BTSolve = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PNBoard
            // 
            this.PNBoard.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PNBoard.Location = new System.Drawing.Point(12, 12);
            this.PNBoard.Name = "PNBoard";
            this.PNBoard.Size = new System.Drawing.Size(406, 406);
            this.PNBoard.TabIndex = 0;
            // 
            // BTReset
            // 
            this.BTReset.Location = new System.Drawing.Point(436, 12);
            this.BTReset.Name = "BTReset";
            this.BTReset.Size = new System.Drawing.Size(75, 23);
            this.BTReset.TabIndex = 1;
            this.BTReset.Text = "Reset";
            this.BTReset.UseVisualStyleBackColor = true;
            // 
            // BTSolve
            // 
            this.BTSolve.Location = new System.Drawing.Point(436, 84);
            this.BTSolve.Name = "BTSolve";
            this.BTSolve.Size = new System.Drawing.Size(75, 23);
            this.BTSolve.TabIndex = 2;
            this.BTSolve.Text = "Solve!!";
            this.BTSolve.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 442);
            this.Controls.Add(this.BTSolve);
            this.Controls.Add(this.BTReset);
            this.Controls.Add(this.PNBoard);
            this.Name = "Main";
            this.Text = "Sudoku Solver";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PNBoard;
        private System.Windows.Forms.Button BTReset;
        private System.Windows.Forms.Button BTSolve;

    }
}

