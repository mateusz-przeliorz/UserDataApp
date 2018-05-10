using System;
using System.Windows.Forms;

namespace UserDataForms
{
    public partial class Surname : Form
    {
        public Surname(FirstName firstName)
        {
            InitializeComponent();
            localFirstName = firstName;
            localAddress = new Address(this);
        }

        Address localAddress;
        FirstName localFirstName;

        public static string MySurname { get; set; }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Hide();
            localFirstName.Show();
        }

        private void SurnameTextArea_TextChanged(object sender, EventArgs e)
        {
            MySurname = SurnameTextArea.Text;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (Validation.IsFilled(MySurname))
            {
                Hide();
                localAddress.Show();
            }
            else
                MessageBox.Show("Please enter your surname.",
                                "Warning!");
        }

        private void EndButton_Click(object sender, EventArgs e)
        {
            Validation.CloseConfirm();
        }    
    }
}
