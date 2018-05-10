namespace UserDataForms
{
    partial class Surname
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
            this.EndButton = new System.Windows.Forms.Button();
            this.SurnameLabelText = new System.Windows.Forms.Label();
            this.SurnameTextArea = new System.Windows.Forms.TextBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EndButton
            // 
            this.EndButton.Location = new System.Drawing.Point(438, 400);
            this.EndButton.Name = "EndButton";
            this.EndButton.Size = new System.Drawing.Size(128, 28);
            this.EndButton.TabIndex = 8;
            this.EndButton.Text = "Cancel";
            this.EndButton.UseVisualStyleBackColor = true;
            this.EndButton.Click += new System.EventHandler(this.EndButton_Click);
            // 
            // SurnameLabelText
            // 
            this.SurnameLabelText.AutoSize = true;
            this.SurnameLabelText.Location = new System.Drawing.Point(111, 59);
            this.SurnameLabelText.Name = "SurnameLabelText";
            this.SurnameLabelText.Size = new System.Drawing.Size(177, 17);
            this.SurnameLabelText.TabIndex = 7;
            this.SurnameLabelText.Text = "Enter your surname below.";
            // 
            // SurnameTextArea
            // 
            this.SurnameTextArea.Location = new System.Drawing.Point(111, 96);
            this.SurnameTextArea.Name = "SurnameTextArea";
            this.SurnameTextArea.Size = new System.Drawing.Size(385, 22);
            this.SurnameTextArea.TabIndex = 6;
            this.SurnameTextArea.TextChanged += new System.EventHandler(this.SurnameTextArea_TextChanged);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(304, 400);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(128, 28);
            this.NextButton.TabIndex = 5;
            this.NextButton.Text = "Next >";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(170, 400);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(128, 28);
            this.BackButton.TabIndex = 9;
            this.BackButton.Text = "< Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Surname
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 465);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.EndButton);
            this.Controls.Add(this.SurnameLabelText);
            this.Controls.Add(this.SurnameTextArea);
            this.Controls.Add(this.NextButton);
            this.Name = "Surname";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EndButton;
        private System.Windows.Forms.TextBox SurnameTextArea;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Label SurnameLabelText;
        private System.Windows.Forms.Button BackButton;
    }
}