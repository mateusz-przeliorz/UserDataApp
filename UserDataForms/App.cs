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
            this.Hide();
            localFirstName.Show();
        }
    }
}
