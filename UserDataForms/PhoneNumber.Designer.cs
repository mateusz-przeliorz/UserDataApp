namespace UserDataForms
{
    partial class PhoneNumber
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
            this.BackButton = new System.Windows.Forms.Button();
            this.EndButton = new System.Windows.Forms.Button();
            this.PhoneNumberLabelText = new System.Windows.Forms.Label();
            this.PhoneNumberTextArea = new System.Windows.Forms.TextBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(170, 400);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(128, 28);
            this.BackButton.TabIndex = 14;
            this.BackButton.Text = "< Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // EndButton
            // 
            this.EndButton.Location = new System.Drawing.Point(438, 400);
            this.EndButton.Name = "EndButton";
            this.EndButton.Size = new System.Drawing.Size(128, 28);
            this.EndButton.TabIndex = 13;
            this.EndButton.Text = "Cancel";
            this.EndButton.UseVisualStyleBackColor = true;
            this.EndButton.Click += new System.EventHandler(this.EndButton_Click);
            // 
            // PhoneNumberLabelText
            // 
            this.PhoneNumberLabelText.AutoSize = true;
            this.PhoneNumberLabelText.Location = new System.Drawing.Point(111, 59);
            this.PhoneNumberLabelText.Name = "PhoneNumberLabelText";
            this.PhoneNumberLabelText.Size = new System.Drawing.Size(214, 17);
            this.PhoneNumberLabelText.TabIndex = 12;
            this.PhoneNumberLabelText.Text = "Enter your phone number below.";
            // 
            // PhoneNumberTextArea
            // 
            this.PhoneNumberTextArea.Location = new System.Drawing.Point(111, 96);
            this.PhoneNumberTextArea.Name = "PhoneNumberTextArea";
            this.PhoneNumberTextArea.Size = new System.Drawing.Size(385, 22);
            this.PhoneNumberTextArea.TabIndex = 11;
            this.PhoneNumberTextArea.TextChanged += new System.EventHandler(this.PhoneNumberTextArea_TextChanged);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(304, 400);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(128, 28);
            this.NextButton.TabIndex = 10;
            this.NextButton.Text = "Next >";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // PhoneNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 465);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.EndButton);
            this.Controls.Add(this.PhoneNumberLabelText);
            this.Controls.Add(this.PhoneNumberTextArea);
            this.Controls.Add(this.NextButton);
            this.Name = "PhoneNumber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserDataApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button EndButton;
        private System.Windows.Forms.Label PhoneNumberLabelText;
        private System.Windows.Forms.TextBox PhoneNumberTextArea;
        private System.Windows.Forms.Button NextButton;
    }
}