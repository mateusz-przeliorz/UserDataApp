using System.Windows.Forms;

namespace UserDataForms
{
    public class Validation
    {

        public static bool IsFilled(string text)
        {
            if (string.IsNullOrEmpty(text))
                return false;
            else
                return true;
        }

        public static void CloseConfirm()
        {
            var confirmResult = MessageBox.Show("Do you want to close?",
                                                "Attention!",
                                                 MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
