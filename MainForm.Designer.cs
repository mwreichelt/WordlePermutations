namespace WordlePermutations
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.txtYellowLetters = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRemainingLetters = new System.Windows.Forms.TextBox();
            this.txtLetter1 = new System.Windows.Forms.TextBox();
            this.txtLetter2 = new System.Windows.Forms.TextBox();
            this.txtLetter3 = new System.Windows.Forms.TextBox();
            this.txtLetter4 = new System.Windows.Forms.TextBox();
            this.txtLetter5 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGeneratePermutations = new System.Windows.Forms.Button();
            this.btnShow1Guess = new System.Windows.Forms.Button();
            this.btnShowAllPermutations = new System.Windows.Forms.Button();
            this.btnShowListOfKnownMatchingSecrets = new System.Windows.Forms.Button();
            this.btnShowListOfPermutationsThatAreValidGuesses = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtYellowLetters
            // 
            this.txtYellowLetters.Location = new System.Drawing.Point(110, 125);
            this.txtYellowLetters.Name = "txtYellowLetters";
            this.txtYellowLetters.Size = new System.Drawing.Size(310, 20);
            this.txtYellowLetters.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yellow Letters";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Remaining Letters";
            // 
            // txtRemainingLetters
            // 
            this.txtRemainingLetters.Location = new System.Drawing.Point(110, 157);
            this.txtRemainingLetters.Name = "txtRemainingLetters";
            this.txtRemainingLetters.Size = new System.Drawing.Size(310, 20);
            this.txtRemainingLetters.TabIndex = 7;
            // 
            // txtLetter1
            // 
            this.txtLetter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLetter1.Location = new System.Drawing.Point(40, 41);
            this.txtLetter1.Multiline = true;
            this.txtLetter1.Name = "txtLetter1";
            this.txtLetter1.Size = new System.Drawing.Size(60, 64);
            this.txtLetter1.TabIndex = 0;
            this.txtLetter1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLetter1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtLetter_KeyPress);
            // 
            // txtLetter2
            // 
            this.txtLetter2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLetter2.Location = new System.Drawing.Point(120, 41);
            this.txtLetter2.Multiline = true;
            this.txtLetter2.Name = "txtLetter2";
            this.txtLetter2.Size = new System.Drawing.Size(60, 64);
            this.txtLetter2.TabIndex = 2;
            this.txtLetter2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtLetter_KeyPress);
            // 
            // txtLetter3
            // 
            this.txtLetter3.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLetter3.Location = new System.Drawing.Point(200, 41);
            this.txtLetter3.Multiline = true;
            this.txtLetter3.Name = "txtLetter3";
            this.txtLetter3.Size = new System.Drawing.Size(60, 64);
            this.txtLetter3.TabIndex = 3;
            this.txtLetter3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtLetter_KeyPress);
            // 
            // txtLetter4
            // 
            this.txtLetter4.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLetter4.Location = new System.Drawing.Point(280, 41);
            this.txtLetter4.Multiline = true;
            this.txtLetter4.Name = "txtLetter4";
            this.txtLetter4.Size = new System.Drawing.Size(60, 64);
            this.txtLetter4.TabIndex = 4;
            this.txtLetter4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtLetter_KeyPress);
            // 
            // txtLetter5
            // 
            this.txtLetter5.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLetter5.Location = new System.Drawing.Point(360, 41);
            this.txtLetter5.Multiline = true;
            this.txtLetter5.Name = "txtLetter5";
            this.txtLetter5.Size = new System.Drawing.Size(60, 64);
            this.txtLetter5.TabIndex = 5;
            this.txtLetter5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtLetter_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Known Letters";
            // 
            // btnGeneratePermutations
            // 
            this.btnGeneratePermutations.Location = new System.Drawing.Point(16, 189);
            this.btnGeneratePermutations.Name = "btnGeneratePermutations";
            this.btnGeneratePermutations.Size = new System.Drawing.Size(85, 70);
            this.btnGeneratePermutations.TabIndex = 8;
            this.btnGeneratePermutations.Text = "Generate Permutations";
            this.btnGeneratePermutations.UseVisualStyleBackColor = true;
            this.btnGeneratePermutations.Click += new System.EventHandler(this.BtnGeneratePermutations_Click);
            // 
            // btnShow1Guess
            // 
            this.btnShow1Guess.Enabled = false;
            this.btnShow1Guess.Location = new System.Drawing.Point(124, 189);
            this.btnShow1Guess.Name = "btnShow1Guess";
            this.btnShow1Guess.Size = new System.Drawing.Size(83, 70);
            this.btnShow1Guess.TabIndex = 9;
            this.btnShow1Guess.Text = "Show Next Permutation";
            this.btnShow1Guess.UseVisualStyleBackColor = true;
            this.btnShow1Guess.Click += new System.EventHandler(this.BtnShow1Guess_Click);
            // 
            // btnShowAllPermutations
            // 
            this.btnShowAllPermutations.Enabled = false;
            this.btnShowAllPermutations.Location = new System.Drawing.Point(230, 189);
            this.btnShowAllPermutations.Name = "btnShowAllPermutations";
            this.btnShowAllPermutations.Size = new System.Drawing.Size(83, 70);
            this.btnShowAllPermutations.TabIndex = 10;
            this.btnShowAllPermutations.Text = "Show All Permutations";
            this.btnShowAllPermutations.UseVisualStyleBackColor = true;
            this.btnShowAllPermutations.Click += new System.EventHandler(this.BtnShowAllPermutations_Click);
            // 
            // btnShowListOfKnownMatchingSecrets
            // 
            this.btnShowListOfKnownMatchingSecrets.Enabled = false;
            this.btnShowListOfKnownMatchingSecrets.Location = new System.Drawing.Point(335, 218);
            this.btnShowListOfKnownMatchingSecrets.Name = "btnShowListOfKnownMatchingSecrets";
            this.btnShowListOfKnownMatchingSecrets.Size = new System.Drawing.Size(75, 41);
            this.btnShowListOfKnownMatchingSecrets.TabIndex = 11;
            this.btnShowListOfKnownMatchingSecrets.TabStop = false;
            this.btnShowListOfKnownMatchingSecrets.Text = "Cheat A Lot";
            this.btnShowListOfKnownMatchingSecrets.UseVisualStyleBackColor = true;
            this.btnShowListOfKnownMatchingSecrets.Click += new System.EventHandler(this.BtnShowListOfKnownMatchingSecrets_Click);
            // 
            // btnShowListOfPermutationsThatAreValidGuesses
            // 
            this.btnShowListOfPermutationsThatAreValidGuesses.Enabled = false;
            this.btnShowListOfPermutationsThatAreValidGuesses.Location = new System.Drawing.Point(335, 189);
            this.btnShowListOfPermutationsThatAreValidGuesses.Name = "btnShowListOfPermutationsThatAreValidGuesses";
            this.btnShowListOfPermutationsThatAreValidGuesses.Size = new System.Drawing.Size(75, 23);
            this.btnShowListOfPermutationsThatAreValidGuesses.TabIndex = 12;
            this.btnShowListOfPermutationsThatAreValidGuesses.TabStop = false;
            this.btnShowListOfPermutationsThatAreValidGuesses.Text = "Cheat";
            this.btnShowListOfPermutationsThatAreValidGuesses.UseVisualStyleBackColor = true;
            this.btnShowListOfPermutationsThatAreValidGuesses.Click += new System.EventHandler(this.BtnShowListOfPermutationsThatAreValidGuesses_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 274);
            this.Controls.Add(this.btnShowListOfPermutationsThatAreValidGuesses);
            this.Controls.Add(this.btnShowListOfKnownMatchingSecrets);
            this.Controls.Add(this.btnShowAllPermutations);
            this.Controls.Add(this.btnShow1Guess);
            this.Controls.Add(this.btnGeneratePermutations);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLetter5);
            this.Controls.Add(this.txtLetter4);
            this.Controls.Add(this.txtLetter3);
            this.Controls.Add(this.txtLetter2);
            this.Controls.Add(this.txtLetter1);
            this.Controls.Add(this.txtRemainingLetters);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtYellowLetters);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Wordle Permutation Helper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtYellowLetters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRemainingLetters;
        private System.Windows.Forms.TextBox txtLetter1;
        private System.Windows.Forms.TextBox txtLetter2;
        private System.Windows.Forms.TextBox txtLetter3;
        private System.Windows.Forms.TextBox txtLetter4;
        private System.Windows.Forms.TextBox txtLetter5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGeneratePermutations;
        private System.Windows.Forms.Button btnShow1Guess;
        private System.Windows.Forms.Button btnShowAllPermutations;
        private System.Windows.Forms.Button btnShowListOfKnownMatchingSecrets;
        private System.Windows.Forms.Button btnShowListOfPermutationsThatAreValidGuesses;
    }
}

