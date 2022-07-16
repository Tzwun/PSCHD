using PSCHD.Services.Interfaces;

namespace PSCHD.Services
{
    public class MessageService : IMessageService
    {
        public string GetMessage()
        {
            return "Hello from the Message Service";
        }
    }
}
