using System.Threading.Tasks;
using PrestamApp.Application.Interfaces;
using PrestamApp.Application.Notifications.Models;

namespace PrestamApp.Infrastructure
{
    public class NotificationService : INotificationService
    {
        public Task SendAsync(Message message)
        {
          return  Task.CompletedTask;
        }
    }
}