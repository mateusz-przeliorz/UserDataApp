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
    public partial class FirstName : Form
    {
        public FirstName()
        {
            InitializeComponent();
            localSurname = new Surname(this);
        }

        Surname localSurname;
        public string MyFirstName { get; set; }

        private void NextButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            localSurname.Show();
        }

        private void FirstNameTextArea_TextChanged(object sender, EventArgs e)
        {
            MyFirstName = FirstNameTextArea.Text;
        }

        private void FirstName_Load(object sender, EventArgs e)
        {

        }

        private void EndButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
