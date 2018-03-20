using LoginApplication.Utils;
using System;
using System.Linq;
using System.Data.Entity;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;

namespace LoginApplication
{
    public partial class UsersForm : Form
    {
        private bool closed = false;
        private bool showAll = false;
        private UserLoginEntities dbContext = null;

        public UsersForm()
        {
            InitializeComponent();
        }

        private void UsersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!closed && DialogResult.Yes == MessageBoxUtils.ShowYesNoQuestion("Are you sure you want to exit the application?"))
            {
                e.Cancel = false;
                closed = true;
                Application.Exit();
                return;
            }
            else
            {
                e.Cancel = true;
                return;
            }
        }

        private void FindByEmailButton_Click(object sender, EventArgs e)
        {
            showAll = false;
            if (ValidateGroupBoxFields())
            {
                RefreshContext();
                var userFound = from user in dbContext.Users
                                where user.UserEmail == FindByEmailTextBox.Text
                                select user;
                if (userFound.Any())
                {
                    userBindingNavigatorSaveItem.Enabled = true;
                    bindingNavigatorDeleteItem.Enabled = false;
                    bindingNavigatorAddNewItem.Enabled = false;
                    userBindingSource.DataSource = userFound.ToList();
                    userBindingSource.MoveFirst();
                }
                else
                {
                    MessageBoxUtils.ShowWarning(string.Format("User {0} not found on the database", FindByEmailTextBox.Text));
                }
                FindByEmailTextBox.Clear();
            }
        }

        private void BrowseAllButton_Click(object sender, EventArgs e)
        {
            showAll = true;
            RefreshContext();
            userBindingNavigatorSaveItem.Enabled = true;
            bindingNavigatorDeleteItem.Enabled = true;
            bindingNavigatorAddNewItem.Enabled = true;
            dbContext.Users.Load();
            userBindingSource.DataSource = dbContext.Users.Local;
            userBindingSource.MoveFirst();
        }

        private void userBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (!showAll)
            {
                if (ValidateForm())
                {
                    SaveChanges();
                }
            }
            else
            {
                if (ValidateAllChanges())
                {
                    SaveChanges();
                }
            }
        }

        private void RefreshContext()
        {
            if (null != dbContext)
            {
                dbContext.Dispose();
                dbContext = null;
            }

            dbContext = new UserLoginEntities();
        }

        private void SaveChanges()
        {
            try
            {
                userBindingSource.EndEdit();
                dbContext.SaveChanges();
                MessageBoxUtils.ShowInformation("Modifications successfully saved to the database!");
            }
            catch (Exception ex)
            {
                MessageBoxUtils.ShowError(string.Format("An unexpected error has occurred: {0}. Please contact your system administrator!", ex.Message));
            }
        }

        private bool ValidateForm()
        {
            return ValidationUtils.ValidateFirstName(userFirstNameTextBox.Text, true) &&
                ValidationUtils.ValidateLastName(userLastNameTextBox.Text, true) &&
                ValidationUtils.ValidatePhoneNumber(userPhoneNumberTextBox.Text, out decimal phone, true) &&
                ValidationUtils.ValidateUserName(userEmailTextBox.Text, true) &&
                ValidationUtils.ValidatePassword(userPasswordTextBox.Text, true);
        }

        private bool ValidateUser(User user)
        {
            return ValidationUtils.ValidateFirstName(user.UserFirstName, false) &&
                ValidationUtils.ValidateLastName(user.UserLastName, false) &&
                ValidationUtils.ValidatePhoneNumber(user.UserPhoneNumber.ToString(), out decimal phone, false) &&
                ValidationUtils.ValidateUserName(user.UserEmail, false) &&
                ValidationUtils.ValidatePassword(user.UserPassword, false);
        }

        private bool ValidateAllUsers(List<DbEntityEntry<User>> users)
        {
            foreach (DbEntityEntry<User> user in users)
            {
                if (!ValidateUser(user.Entity))
                {
                    MessageBoxUtils.ShowWarning(string.Format("Some of the modifications have error(s). Please fix it before continuing!", user.Entity.UserEmail));
                    return false;
                }
            }

            return true;
        }

        private bool ValidateAllChanges()
        {
            List<DbEntityEntry<User>> addedUsers = dbContext.ChangeTracker.Entries<User>().Where(u => u.State == EntityState.Added).ToList();
            List<DbEntityEntry<User>> modifiedUsers = dbContext.ChangeTracker.Entries<User>().Where(u => u.State == EntityState.Modified).ToList();
            return ValidateAllUsers(addedUsers) &&
                ValidateAllUsers(modifiedUsers);
        }

        private bool ValidateGroupBoxFields()
        {
            return ValidationUtils.ValidateUserName(FindByEmailTextBox.Text, true);
        }
    }
}
