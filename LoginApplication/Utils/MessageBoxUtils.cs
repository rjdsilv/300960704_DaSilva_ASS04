using System.Windows.Forms;

namespace LoginApplication.Utils
{
    class MessageBoxUtils
    {
        public static DialogResult ShowWarning(string message)
        {
            return MessageBox.Show(message, "Login Application", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static DialogResult ShowInformation(string message)
        {
            return MessageBox.Show(message, "Login Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult ShowError(string message)
        {
            return MessageBox.Show(message, "Login Application", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
