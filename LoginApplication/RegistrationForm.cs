using LoginApplication.Utils;
using System;
using System.Windows.Forms;

namespace LoginApplication
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm(out decimal parsedPhoneNumber))
            {
                using (UserLoginEntities dbContext = new UserLoginEntities())
                {
                    try
                    {
                        var user = new User
                        {
                            UserFirstName = FirstNameTextBox.Text,
                            UserLastName = LastNameTextBox.Text,
                            UserPhoneNumber = parsedPhoneNumber,
                            UserEmail = EmailTextBox.Text,
                            UserPassword = PasswordTextBox.Text
                        };
                        dbContext.Users.Add(user);
                        dbContext.SaveChanges();
                        if (DialogResult.OK == MessageBoxUtils.ShowInformation(string.Format("User {0} successfully saved to the database!", EmailTextBox.Text)))
                        {
                            Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBoxUtils.ShowError(string.Format("An unexpected error has occurred: {0}. Please contact your system administrator!", ex.Message));
                    }
                }
            }
        }

        private bool ValidateForm(out decimal parsedPhoneNumber)
        {
            return ValidationUtils.ValidatePhoneNumber(PhoneNumberTextBox.Text, out parsedPhoneNumber, true) && 
                ValidationUtils.ValidateFirstName(FirstNameTextBox.Text, true) &&
                ValidationUtils.ValidateLastName(LastNameTextBox.Text, true) &&
                ValidationUtils.ValidateUserName(EmailTextBox.Text, true) &&
                ValidationUtils.ValidatePassword(PasswordTextBox.Text, true) &&
                ValidationUtils.ValidateValidUserName(EmailTextBox.Text, true);
        }
    }
}
