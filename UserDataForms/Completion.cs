using System;
using System.Windows.Forms;

namespace UserDataForms
{
    public partial class Completion : Form
    {
        public Completion(PhoneNumber phoneNumber)
        {
            InitializeComponent();
            localPhoneNumber = phoneNumber;
        }

        PhoneNumber localPhoneNumber;

        private void BackButton_Click(object sender, EventArgs e)
        {
            Hide();
            localPhoneNumber.Show();
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Do you want to finish?",
                                     "Attention!",
                                     MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                MessageBox.Show(FirstName.MyFirstName + ", thank you for your time.",
                                ":)");
                Application.Exit();
            }
        }

        private void EndButton_Click(object sender, EventArgs e)
        {
            Validation.CloseConfirm();
        }

        private void Completion_Load(object sender, EventArgs e)
        {
            FirstNameLabelText.Text = "First name: " + FirstName.MyFirstName;
            SurnameLabelText.Text = "Surname: " + Surname.MySurname;
            AddressLabelText.Text = "Address: " + Address.MyPostcode + " " + Address.MyCity + ", " + Address.MyStreet + " " + Address.MyStreetNumber;
            PhoneNumberLabelText.Text = "Phone number: " + PhoneNumber.MyPhoneNumber;
        }
    }
}
