using System;
using System.Windows.Forms;

namespace UserDataForms
{
    public partial class Address : Form
    {
        public Address(Surname surname)
        {
            InitializeComponent();
            localSurname = surname;
            localPhoneNumber = new PhoneNumber(this);
        }

        Surname localSurname;
        PhoneNumber localPhoneNumber;
        public static string MyCity { get; set; }
        public static string MyStreet { get; set; }
        public static string MyStreetNumber { get; set; }
        public static string MyPostcode { get; set; }

        private void CityTextArea_TextChanged(object sender, EventArgs e)
        {
            MyCity = CityTextArea.Text;
        }

        private void StreetTextArea_TextChanged(object sender, EventArgs e)
        {
            MyStreet = StreetTextArea.Text;
        }

        private void StreetNumberTextArea_TextChanged(object sender, EventArgs e)
        {
            MyStreetNumber = StreetNumberTextArea.Text;
        }

        private void PostcodeTextArea_TextChanged(object sender, EventArgs e)
        {
            MyPostcode = PostcodeTextArea.Text;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Hide();
            localSurname.Show();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (Validation.IsFilled(MyCity) && Validation.IsFilled(MyStreet) && Validation.IsFilled(MyStreetNumber) && Validation.IsFilled(MyPostcode))
            {
                Hide();
                localPhoneNumber.Show();
            }
            else
                MessageBox.Show("Please enter your address.",
                                "Warning!");
        }

        private void EndButton_Click(object sender, EventArgs e)
        {
            Validation.CloseConfirm();
        }
    }
}
