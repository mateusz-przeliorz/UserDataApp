using System;
using System.Windows.Forms;

namespace UserDataForms
{
    public partial class PhoneNumber : Form
    {
        public PhoneNumber(Address address)
        {
            InitializeComponent();
            localAddress = address;    
        }

        Address localAddress;
        Completion localCompletion;

        public static string MyPhoneNumber { get; set; }    

        private void BackButton_Click(object sender, EventArgs e)
        {
            Hide();
            localAddress.Show();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (Validation.IsFilled(MyPhoneNumber))
            {
                MakeNewCompletion();
                Hide();
                localCompletion.Show();
            }
            else           
                MessageBox.Show("Please enter your phone number.", 
                                "Warning!");          
        }

        private void EndButton_Click(object sender, EventArgs e)
        {
            Validation.CloseConfirm();
        }

        private void PhoneNumberTextArea_TextChanged(object sender, EventArgs e)
        {
            MyPhoneNumber = PhoneNumberTextArea.Text;
        }

         public void MakeNewCompletion()
        {
            localCompletion = new Completion(this);
        }    
    }
}
