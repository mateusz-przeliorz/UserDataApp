using System;
using System.Windows.Forms;

namespace UserDataForms
{
    public partial class FirstName : Form
    {
        public FirstName()
        {
            InitializeComponent();
            localSurname = new Surname(this);
        }

        Surname localSurname;
        public static string MyFirstName { get; set; }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (Validation.IsFilled(MyFirstName))
            {
                Hide();
                localSurname.Show();
            }
            else
                MessageBox.Show("Please enter your first name.",
                                "Warning!");
        }

        private void FirstNameTextArea_TextChanged(object sender, EventArgs e)
        {
            MyFirstName = FirstNameTextArea.Text;
        }

        private void EndButton_Click(object sender, EventArgs e)
        {
            Validation.CloseConfirm();
        }
    }
}
