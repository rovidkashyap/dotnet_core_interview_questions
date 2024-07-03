using inversion_of_control.Interfaces;

namespace inversion_of_control.Services
{
    public class MessageService : IMessageService
    {
        public string GetMessage()
        {
            return "Hello from MessageService!";
        }
    }
}
