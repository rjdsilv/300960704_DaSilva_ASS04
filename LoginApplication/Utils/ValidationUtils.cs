﻿using System;
using System.Linq;
using System.Net.Mail;

namespace LoginApplication.Utils
{
    public class ValidationUtils
    {
        public static bool ValidateUserName(string userName, bool showError)
        {
            if (string.IsNullOrWhiteSpace(userName))
            {
                if (showError)
                {
                    MessageBoxUtils.ShowWarning("Please, enter your Email / User Name!");
                }
                return false;
            }
            else if (!ValidateEmail(userName))
            {
                if (showError)
                {
                    MessageBoxUtils.ShowWarning("Please, enter a valid Email as your User Name!");
                }
                return false;
            }

            return true;
        }
        public static bool ValidateEmail(string email)
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

        public static bool ValidatePassword(string password, bool showError)
        {
            if (string.IsNullOrWhiteSpace(password))
            {
                if (showError)
                {
                    MessageBoxUtils.ShowWarning("Please, enter your Password!");
                }
                return false;
            }
            else if (password.Length < 4)
            {
                if (showError)
                {
                    MessageBoxUtils.ShowWarning("The password has to have at least 4 characters!");
                }
                return false;
            }

            return true;
        }

        public static bool ValidateFirstName(string firstName, bool showError)
        {
            if (string.IsNullOrWhiteSpace(firstName))
            {
                if (showError)
                {
                    MessageBoxUtils.ShowWarning("Please, enter your First Name!");
                }
                return false;
            }

            return true;
        }

        public static bool ValidateLastName(string lastName, bool showError)
        {
            if (string.IsNullOrWhiteSpace(lastName))
            {
                if (showError)
                {
                    MessageBoxUtils.ShowWarning("Please, enter your Last Name!");
                }
                return false;
            }

            return true;
        }

        public static bool ValidatePhoneNumber(string phoneNumber, out decimal parsedPhoneNumber, bool showError)
        {
            if (!decimal.TryParse(phoneNumber, out parsedPhoneNumber))
            {
                if (showError)
                {
                    MessageBoxUtils.ShowWarning("Please, enter a valid phone number. Phone numbers must contain only numbers!");
                }
                return false;
            }

            if (phoneNumber.Length != 10)
            {
                if (showError)
                {
                    MessageBoxUtils.ShowWarning("Please, enter a phone number with exactly 10 numbers!");
                }
                return false;
            }

            return true;
        }

        public static bool ValidateValidUserName(string userName, bool showError)
        {
            using (UserLoginEntities dbContext = new UserLoginEntities())
            {
                var userFound = from user in dbContext.Users
                                where user.UserEmail == userName
                                select user;

                if (userFound.Any())
                {
                    if (showError)
                    {
                        MessageBoxUtils.ShowWarning("The Email / User Name entered is already registered on the system!");
                    }
                    return false;
                }

                return true;
            }
        }
    }
}
