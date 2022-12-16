using System.Text.RegularExpressions;

namespace NotificationAPI.Model
{
    public class ValidMail
    {
        public static bool EmailValidation (MailRequest userDetails)
        {
            //string mail=new 
            string Email = userDetails.ToEmail;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(Email);
            if (match.Success)

                return true;
            else
                return false;
        }

       
    }
}
