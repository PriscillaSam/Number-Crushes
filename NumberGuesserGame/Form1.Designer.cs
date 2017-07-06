namespace NumberGuesserGame
{
    partial class NumberGuesser
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
            this.AppInfoLabel = new System.Windows.Forms.Label();
            this.InstructionLabel = new System.Windows.Forms.Label();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AppInfoLabel
            // 
            this.AppInfoLabel.AutoSize = true;
            this.AppInfoLabel.Location = new System.Drawing.Point(25, 21);
            this.AppInfoLabel.Name = "AppInfoLabel";
            this.AppInfoLabel.Size = new System.Drawing.Size(208, 13);
            this.AppInfoLabel.TabIndex = 0;
            this.AppInfoLabel.Text = "Welcome To The Number Guessing Game";
            // 
            // InstructionLabel
            // 
            this.InstructionLabel.AutoSize = true;
            this.InstructionLabel.Location = new System.Drawing.Point(25, 65);
            this.InstructionLabel.Name = "InstructionLabel";
            this.InstructionLabel.Size = new System.Drawing.Size(177, 13);
            this.InstructionLabel.TabIndex = 1;
            this.InstructionLabel.Text = "Guess A Number Between 1 and 10";
            // 
            // inputBox
            // 
            this.inputBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.inputBox.Location = new System.Drawing.Point(208, 62);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(63, 20);
            this.inputBox.TabIndex = 2;
            this.inputBox.TextChanged += new System.EventHandler(this.inputBox_TextChanged);
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.Tan;
            this.btnCheck.Location = new System.Drawing.Point(277, 55);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(76, 33);
            this.btnCheck.TabIndex = 3;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "2017 Alius Dei";
            // 
            // NumberGuesser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(374, 164);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.InstructionLabel);
            this.Controls.Add(this.AppInfoLabel);
            this.Name = "NumberGuesser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Number Guesser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AppInfoLabel;
        private System.Windows.Forms.Label InstructionLabel;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label label1;
    }
}

