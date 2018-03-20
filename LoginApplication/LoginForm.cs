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
            var registrationForm = new RegistrationForm();
            registrationForm.Show();
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
            return ValidationUtils.ValidateUserName(UserNameTextBox.Text) &&
                ValidationUtils.ValidatePassword(PasswordTextBox.Text);
        }
    }
}
