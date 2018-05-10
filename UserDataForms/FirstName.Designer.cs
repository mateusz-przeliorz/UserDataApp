namespace UserDataForms
{
    partial class FirstName
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
            this.NextButton = new System.Windows.Forms.Button();
            this.FirstNameTextArea = new System.Windows.Forms.TextBox();
            this.FirstNameLabelText = new System.Windows.Forms.Label();
            this.EndButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(304, 400);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(128, 28);
            this.NextButton.TabIndex = 0;
            this.NextButton.Text = "Next >";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // FirstNameTextArea
            // 
            this.FirstNameTextArea.Location = new System.Drawing.Point(111, 96);
            this.FirstNameTextArea.Name = "FirstNameTextArea";
            this.FirstNameTextArea.Size = new System.Drawing.Size(385, 22);
            this.FirstNameTextArea.TabIndex = 2;
            this.FirstNameTextArea.TextChanged += new System.EventHandler(this.FirstNameTextArea_TextChanged);
            // 
            // FirstNameLabelText
            // 
            this.FirstNameLabelText.AutoSize = true;
            this.FirstNameLabelText.Location = new System.Drawing.Point(111, 59);
            this.FirstNameLabelText.Name = "FirstNameLabelText";
            this.FirstNameLabelText.Size = new System.Drawing.Size(184, 17);
            this.FirstNameLabelText.TabIndex = 3;
            this.FirstNameLabelText.Text = "Enter your first name below.";
            // 
            // EndButton
            // 
            this.EndButton.Location = new System.Drawing.Point(438, 400);
            this.EndButton.Name = "EndButton";
            this.EndButton.Size = new System.Drawing.Size(128, 28);
            this.EndButton.TabIndex = 4;
            this.EndButton.Text = "Cancel";
            this.EndButton.UseVisualStyleBackColor = true;
            this.EndButton.Click += new System.EventHandler(this.EndButton_Click);
            // 
            // FirstName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 465);
            this.Controls.Add(this.EndButton);
            this.Controls.Add(this.FirstNameLabelText);
            this.Controls.Add(this.FirstNameTextArea);
            this.Controls.Add(this.NextButton);
            this.Name = "FirstName";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserApp";
            this.Load += new System.EventHandler(this.FirstName_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.TextBox FirstNameTextArea;
        private System.Windows.Forms.Label FirstNameLabelText;
        private System.Windows.Forms.Button EndButton;
    }
}