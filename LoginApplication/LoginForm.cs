using LoginApplication.Utils;
using System;
using System.Linq;
using System.Net.Mail;
using System.Windows.Forms;

namespace LoginApplication
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void NewUserLabel_Click(object sender, EventArgs e)
        {
            //var registrationForm = new RegistrationForm();
            //registrationForm.Show();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                using (UserLoginEntities dbContext = new UserLoginEntities())
                {
                    var userFound = from user in dbContext.Users
                                    where user.UserEmail == UserNameTextBox.Text && user.UserPassword == PasswordTextBox.Text
                                    select user;
                    if (!userFound.Any())
                    {
                        MessageBoxUtils.ShowWarning("User Name and / or Password invalid!");
                    }
                    else
                    {
                        Hide();
                        //UsersForm usersForm = new UsersForm();
                        //usersForm.ShowDialog();
                    }
                }
            }
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(UserNameTextBox.Text))
            {
                MessageBoxUtils.ShowWarning("Please, enter your User Name!");
                return false;
            }
            else if (!ValidateEmail(UserNameTextBox.Text))
            {
                MessageBoxUtils.ShowWarning("Please, enter a valid Email as your User Name!");
                return false;
            }

            if (string.IsNullOrWhiteSpace(PasswordTextBox.Text))
            {
                MessageBoxUtils.ShowWarning("Please, enter your Password!");
                return false;
            }
            else if (!ValidatePassword(PasswordTextBox.Text))
            {
                MessageBoxUtils.ShowWarning("The password has to have at least 4 characters!");
                return false;
            }

            return true;
        }

        private bool ValidateEmail(string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private bool ValidatePassword(string password)
        {
            return password.Length >= 4;
        }
    }
}
