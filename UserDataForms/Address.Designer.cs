namespace UserDataForms
{
    partial class Address
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
            this.AddressLabelText = new System.Windows.Forms.Label();
            this.CityTextArea = new System.Windows.Forms.TextBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.StreetLabelText = new System.Windows.Forms.Label();
            this.StreetNumberLabelText = new System.Windows.Forms.Label();
            this.CityLabelText = new System.Windows.Forms.Label();
            this.StreetTextArea = new System.Windows.Forms.TextBox();
            this.StreetNumberTextArea = new System.Windows.Forms.TextBox();
            this.PostcodeTextArea = new System.Windows.Forms.TextBox();
            this.PostcodeLabelText = new System.Windows.Forms.Label();
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
            // AddressLabelText
            // 
            this.AddressLabelText.AutoSize = true;
            this.AddressLabelText.Location = new System.Drawing.Point(111, 59);
            this.AddressLabelText.Name = "AddressLabelText";
            this.AddressLabelText.Size = new System.Drawing.Size(173, 17);
            this.AddressLabelText.TabIndex = 12;
            this.AddressLabelText.Text = "Enter your address below.";
            // 
            // CityTextArea
            // 
            this.CityTextArea.Location = new System.Drawing.Point(111, 96);
            this.CityTextArea.Name = "CityTextArea";
            this.CityTextArea.Size = new System.Drawing.Size(385, 22);
            this.CityTextArea.TabIndex = 11;
            this.CityTextArea.TextChanged += new System.EventHandler(this.CityTextArea_TextChanged);
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
            // StreetLabelText
            // 
            this.StreetLabelText.AutoSize = true;
            this.StreetLabelText.Location = new System.Drawing.Point(12, 129);
            this.StreetLabelText.Name = "StreetLabelText";
            this.StreetLabelText.Size = new System.Drawing.Size(46, 17);
            this.StreetLabelText.TabIndex = 19;
            this.StreetLabelText.Text = "Street";
            // 
            // StreetNumberLabelText
            // 
            this.StreetNumberLabelText.AutoSize = true;
            this.StreetNumberLabelText.Location = new System.Drawing.Point(12, 157);
            this.StreetNumberLabelText.Name = "StreetNumberLabelText";
            this.StreetNumberLabelText.Size = new System.Drawing.Size(98, 17);
            this.StreetNumberLabelText.TabIndex = 20;
            this.StreetNumberLabelText.Text = "Street number";
            // 
            // CityLabelText
            // 
            this.CityLabelText.AutoSize = true;
            this.CityLabelText.Location = new System.Drawing.Point(12, 101);
            this.CityLabelText.Name = "CityLabelText";
            this.CityLabelText.Size = new System.Drawing.Size(31, 17);
            this.CityLabelText.TabIndex = 22;
            this.CityLabelText.Text = "City";
            // 
            // StreetTextArea
            // 
            this.StreetTextArea.Location = new System.Drawing.Point(111, 124);
            this.StreetTextArea.Name = "StreetTextArea";
            this.StreetTextArea.Size = new System.Drawing.Size(385, 22);
            this.StreetTextArea.TabIndex = 23;
            this.StreetTextArea.TextChanged += new System.EventHandler(this.StreetTextArea_TextChanged);
            // 
            // StreetNumberTextArea
            // 
            this.StreetNumberTextArea.Location = new System.Drawing.Point(111, 152);
            this.StreetNumberTextArea.Name = "StreetNumberTextArea";
            this.StreetNumberTextArea.Size = new System.Drawing.Size(385, 22);
            this.StreetNumberTextArea.TabIndex = 24;
            this.StreetNumberTextArea.TextChanged += new System.EventHandler(this.StreetNumberTextArea_TextChanged);
            // 
            // PostcodeTextArea
            // 
            this.PostcodeTextArea.Location = new System.Drawing.Point(111, 182);
            this.PostcodeTextArea.Name = "PostcodeTextArea";
            this.PostcodeTextArea.Size = new System.Drawing.Size(385, 22);
            this.PostcodeTextArea.TabIndex = 25;
            this.PostcodeTextArea.TextChanged += new System.EventHandler(this.PostcodeTextArea_TextChanged);
            // 
            // PostcodeLabelText
            // 
            this.PostcodeLabelText.AutoSize = true;
            this.PostcodeLabelText.Location = new System.Drawing.Point(12, 187);
            this.PostcodeLabelText.Name = "PostcodeLabelText";
            this.PostcodeLabelText.Size = new System.Drawing.Size(71, 17);
            this.PostcodeLabelText.TabIndex = 26;
            this.PostcodeLabelText.Text = "Post code";
            // 
            // Address
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 465);
            this.Controls.Add(this.PostcodeLabelText);
            this.Controls.Add(this.PostcodeTextArea);
            this.Controls.Add(this.StreetNumberTextArea);
            this.Controls.Add(this.StreetTextArea);
            this.Controls.Add(this.CityLabelText);
            this.Controls.Add(this.StreetNumberLabelText);
            this.Controls.Add(this.StreetLabelText);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.EndButton);
            this.Controls.Add(this.AddressLabelText);
            this.Controls.Add(this.CityTextArea);
            this.Controls.Add(this.NextButton);
            this.Name = "Address";
            this.Text = "UserApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button EndButton;
        private System.Windows.Forms.Label AddressLabelText;
        private System.Windows.Forms.TextBox CityTextArea;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Label StreetLabelText;
        private System.Windows.Forms.Label StreetNumberLabelText;
        private System.Windows.Forms.Label CityLabelText;
        private System.Windows.Forms.TextBox StreetTextArea;
        private System.Windows.Forms.TextBox StreetNumberTextArea;
        private System.Windows.Forms.TextBox PostcodeTextArea;
        private System.Windows.Forms.Label PostcodeLabelText;
    }
}