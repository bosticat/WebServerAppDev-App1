namespace WebServerAppDev_App1.Models.Create
{
    public class AccountCreateViewModel
    {
        /*
    first name
    last name
    email address
    gender
    username
    password
    password confirm
    opt-in to receive emails(check box)
    */

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string  EmailAddress { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfirmPass { get; set; }
        public bool Email { get; set; }


    }
}