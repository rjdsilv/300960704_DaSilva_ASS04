using System.Windows.Forms;

namespace LoginApplication.Utils
{
    class MessageBoxUtils
    {
        public static void ShowWarning(string message)
        {
            MessageBox.Show(message, "Login Application", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void ShowInformation(string message)
        {
            MessageBox.Show(message, "Login Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
