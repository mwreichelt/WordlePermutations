namespace WordlePermutations
{
    partial class ListForm
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
            this.lbPermutations = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbPermutations
            // 
            this.lbPermutations.FormattingEnabled = true;
            this.lbPermutations.Location = new System.Drawing.Point(12, 12);
            this.lbPermutations.Name = "lbPermutations";
            this.lbPermutations.Size = new System.Drawing.Size(242, 329);
            this.lbPermutations.TabIndex = 0;
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 352);
            this.Controls.Add(this.lbPermutations);
            this.Name = "ListForm";
            this.Text = "All Permutations";
            this.Load += new System.EventHandler(this.ListForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbPermutations;
    }
}