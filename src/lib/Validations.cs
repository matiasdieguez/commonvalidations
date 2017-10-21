using System.Linq;

namespace CommonValidations
{
    public class Validations
    {
        /// <summary>
        /// BeValidUserName
        /// </summary>
        /// <param name="user">user</param>
        /// <returns>bool</returns>
        public static bool BeValidUserName(string user)
        {
            if (string.IsNullOrEmpty(user) ||
                string.IsNullOrWhiteSpace(user) ||
                user.Contains(" "))
                return false;

            var array = user.ToCharArray();

            if (!array.Any(char.IsControl) &&
                !array.Any(char.IsPunctuation) &&
                !array.Any(char.IsSeparator) &&
                !array.Any(c => char.IsSymbol(c)))
                return true;
            else
                return false;
        }

        /// <summary>
        /// BeStrongPassword
        /// </summary>
        /// <param name="password">password</param>
        /// <returns>bool</returns>
        public static bool BeStrongPassword(string password)
        {
            if (string.IsNullOrEmpty(password) ||
                string.IsNullOrWhiteSpace(password))
                return false;

            var array = password.ToCharArray();

            if (array.Length >= 8 &&
                array.Any(char.IsLetter) &&
                array.Any(char.IsDigit))
                return true;
            else
                return false;
        }

        /// <summary>
        /// BePhoneNumber
        /// </summary>
        /// <param name="phone">phone</param>
        /// <returns>bool</returns>
        public static bool BePhoneNumber(string phone)
        {
            if (string.IsNullOrEmpty(phone) ||
                string.IsNullOrWhiteSpace(phone))
                return false;

            var array = phone.ToCharArray();

            if (array.Length >= 8 &&
                !array.Any(char.IsLetter) &&
                !array.Any(char.IsControl) &&
                !array.Any(char.IsPunctuation) &&
                !array.Any(char.IsSeparator) &&
                !array.Any(c => char.IsSymbol(c) && c != '+') &&
                array.Any(char.IsDigit))
                return true;
            else
                return false;
        }
    }
}
