namespace solid_principles
{

    // An Example of Single Responsibility Principle (SRP)

    // Bad Example
    public class UserService_bad
    {
        public void RegisterUser(string username, string password)
        {
            // Register the user
            // Send a confirmation email
        }
    }

    // Good Example
    public class UserService_good
    {
        private readonly IEmailService _emailService;
        public UserService_good(IEmailService emailService)
        {
            _emailService = emailService;
        }

        public void RegisterUser(string username, string password)
        {
            // Register the user
            _emailService.SendConfirmationEmail(username);
        }
    }

    public interface IEmailService
    {
        void SendConfirmationEmail(string email);
    }

    public class EmailService: IEmailService
    {
        public void SendConfirmationEmail(string email)
        {
            // Send email logic
        }
    }
}
