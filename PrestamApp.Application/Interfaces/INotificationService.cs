using System.Threading.Tasks;
using PrestamApp.Application.Notifications.Models;

namespace PrestamApp.Application.Interfaces
{
    public interface INotificationService
    {
        Task SendAsync(Message message);
    }
}