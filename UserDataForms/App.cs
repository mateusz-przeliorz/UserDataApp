using System;
using System.Windows.Forms;

namespace UserDataForms
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
            localFirstName = new FirstName();
        }

        FirstName localFirstName;

        private void StartButton_Click(object sender, EventArgs e)
        {
            Hide();
            localFirstName.Show();
        }
    }
}
