using System.Threading.Tasks;

namespace tiqe_web.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
