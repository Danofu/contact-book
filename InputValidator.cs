using System.Net.Mail;
using System.Text.RegularExpressions;

namespace ContactBook_PTDN_Project
{
    internal class InputValidator
    {
        internal static bool ValidateFirstNameInput(TextBox input, out string? errorMessage)
            => ValidateFirstNameInput(input.Text, out errorMessage);
        internal static bool ValidateFirstNameInput(string value, out string? errorMessage)
        {
            errorMessage = null;
            value = value.Trim();
            
            if (Regex.Split(value, "\\s+").Length > 1 && value.Length > 0)
            {
                errorMessage = "First name should consist from one word";
                return false; 
            }
            if (value.Length < 2)
            {
                errorMessage = "First name should contain 2 or more letters";
                return false;
            }

            return true;
        }

        internal static bool ValidateLastNameInput(TextBox input, out string? errorMessage)
            => ValidateLastNameInput(input.Text, out errorMessage);
        internal static bool ValidateLastNameInput(string value, out string? errorMessage)
        {
            errorMessage = null;
            value = value.Trim();

            if (Regex.Split(value, "\\s+").Length > 1 && value.Length > 0)
            {
                errorMessage = "Last name should consist from one word";
                return false; 
            }
            if (value.Trim().Length < 2)
            {
                errorMessage = "Last name should contain 2 or more letters";
                return false;
            }

            return true;
        }

        internal static bool ValidateFullNameInput(TextBox input, out string? errorMessage)
        {
            var splitFullName = input.Text.Trim().Split(" ");

            if (splitFullName.Length != 2)
            {
                errorMessage = "Full name should consist from two words";
                return false;
            }
            if (!ValidateFirstNameInput(splitFullName[0], out errorMessage)) { return false; }
            if (!ValidateLastNameInput(splitFullName[1], out errorMessage)) { return false; }

            return true;
        }

        internal static bool ValidateBirthdayInput(DateTimePicker input, out string? errorMessage)
        {
            errorMessage = null;

            var today = DateTime.Today;
            var hundredYeasAgo = today.AddYears(-100);
            input.Value = new DateTime(input.Value.Year, input.Value.Month, input.Value.Day);

            if (input.Value > today || input.Value < hundredYeasAgo)
            {
                errorMessage = $"Date should be between {hundredYeasAgo:dd.MM.yyyy} and {today:dd.MM.yyyy}";
                return false;
            }

            return true;
        }

        internal static bool ValidatePhoneInput(MaskedTextBox input, out string? errorMessage)
        {
            errorMessage = null;
            if (!input.MaskCompleted)
            {
                errorMessage = "Phone number should be completed";
                return false;
            }

            return true;
        }

        internal static bool ValidateEmailInput(TextBox input, out string? errorMessage)
            => ValidateEmailInput(input.Text, out errorMessage);
        internal static bool ValidateEmailInput(string value, out string? errorMessage)
        {
            errorMessage = null;
            if (!IsEmail(value.Trim()))
            {
                errorMessage = "Enter valid email address";
                return false;
            }

            return true;
        }
        private static bool IsEmail(string email)
        {
            if (!MailAddress.TryCreate(email, out var mail)) { return false; }

            // Validate Host Part
            var mailHostParts = mail.Host.Split('.');
            // amount of host parts does not equal 2
            if (mailHostParts.Length != 2) { return false; }
            // one of the host parts is empty
            if (mailHostParts.Any(string.IsNullOrWhiteSpace)) { return false; }
            // TLD is less then 2 symbols
            if (mailHostParts[^1].Length < 2) { return false; }

            // Validate User Part
            // user part have dot at the end
            if (mail.User.Split('.').Any(string.IsNullOrWhiteSpace)) { return false; }

            return true;
        }
    }
}
