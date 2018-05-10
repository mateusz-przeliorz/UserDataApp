namespace UserDataForms
{
    partial class Completion
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
            this.FinishButton = new System.Windows.Forms.Button();
            this.PhoneNumberLabelText = new System.Windows.Forms.Label();
            this.FirstNameLabelText = new System.Windows.Forms.Label();
            this.AddressLabelText = new System.Windows.Forms.Label();
            this.SurnameLabelText = new System.Windows.Forms.Label();
            this.CompletionLabelText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(170, 400);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(128, 28);
            this.BackButton.TabIndex = 17;
            this.BackButton.Text = "< Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // EndButton
            // 
            this.EndButton.Location = new System.Drawing.Point(438, 400);
            this.EndButton.Name = "EndButton";
            this.EndButton.Size = new System.Drawing.Size(128, 28);
            this.EndButton.TabIndex = 16;
            this.EndButton.Text = "Cancel";
            this.EndButton.UseVisualStyleBackColor = true;
            this.EndButton.Click += new System.EventHandler(this.EndButton_Click);
            // 
            // FinishButton
            // 
            this.FinishButton.Location = new System.Drawing.Point(304, 400);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(128, 28);
            this.FinishButton.TabIndex = 15;
            this.FinishButton.Text = "Finish";
            this.FinishButton.UseVisualStyleBackColor = true;
            this.FinishButton.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // PhoneNumberLabelText
            // 
            this.PhoneNumberLabelText.AutoSize = true;
            this.PhoneNumberLabelText.Location = new System.Drawing.Point(12, 182);
            this.PhoneNumberLabelText.Name = "PhoneNumberLabelText";
            this.PhoneNumberLabelText.Size = new System.Drawing.Size(101, 17);
            this.PhoneNumberLabelText.TabIndex = 35;
            this.PhoneNumberLabelText.Text = "Phone number";
            // 
            // FirstNameLabelText
            // 
            this.FirstNameLabelText.AutoSize = true;
            this.FirstNameLabelText.Location = new System.Drawing.Point(39, 102);
            this.FirstNameLabelText.Name = "FirstNameLabelText";
            this.FirstNameLabelText.Size = new System.Drawing.Size(74, 17);
            this.FirstNameLabelText.TabIndex = 31;
            this.FirstNameLabelText.Text = "First name";
            // 
            // AddressLabelText
            // 
            this.AddressLabelText.AutoSize = true;
            this.AddressLabelText.Location = new System.Drawing.Point(53, 156);
            this.AddressLabelText.Name = "AddressLabelText";
            this.AddressLabelText.Size = new System.Drawing.Size(60, 17);
            this.AddressLabelText.TabIndex = 30;
            this.AddressLabelText.Text = "Address";
            // 
            // SurnameLabelText
            // 
            this.SurnameLabelText.AutoSize = true;
            this.SurnameLabelText.Location = new System.Drawing.Point(48, 129);
            this.SurnameLabelText.Name = "SurnameLabelText";
            this.SurnameLabelText.Size = new System.Drawing.Size(65, 17);
            this.SurnameLabelText.TabIndex = 29;
            this.SurnameLabelText.Text = "Surname";
            // 
            // CompletionLabelText
            // 
            this.CompletionLabelText.AutoSize = true;
            this.CompletionLabelText.Location = new System.Drawing.Point(111, 59);
            this.CompletionLabelText.Name = "CompletionLabelText";
            this.CompletionLabelText.Size = new System.Drawing.Size(102, 17);
            this.CompletionLabelText.TabIndex = 28;
            this.CompletionLabelText.Text = "Your identities.";
            // 
            // Completion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 465);
            this.Controls.Add(this.PhoneNumberLabelText);
            this.Controls.Add(this.FirstNameLabelText);
            this.Controls.Add(this.AddressLabelText);
            this.Controls.Add(this.SurnameLabelText);
            this.Controls.Add(this.CompletionLabelText);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.EndButton);
            this.Controls.Add(this.FinishButton);
            this.Name = "Completion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserDataApp";
            this.Load += new System.EventHandler(this.Completion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button EndButton;
        private System.Windows.Forms.Button FinishButton;
        private System.Windows.Forms.Label PhoneNumberLabelText;
        private System.Windows.Forms.Label FirstNameLabelText;
        private System.Windows.Forms.Label AddressLabelText;
        private System.Windows.Forms.Label SurnameLabelText;
        private System.Windows.Forms.Label CompletionLabelText;
    }
}