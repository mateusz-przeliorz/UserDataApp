using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserDataForms
{
    public partial class Surname : Form
    {
        public Surname(FirstName firstName)
        {
            InitializeComponent();
            localFirstName = firstName;
        }

        FirstName localFirstName;
        public string MySurname { get; set; }
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            localFirstName.Show();
        }

        private void SurnameTextArea_TextChanged(object sender, EventArgs e)
        {
            MySurname = SurnameTextArea.Text;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            this.Hide();           
        }

        private void EndButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
