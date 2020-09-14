using Rodan.Business.Classes;
using Rodan.Business.Interfaces;
using System;
using System.Collections.Generic;

namespace Rodan.Business.Services
{
    public class NotificationsService : INotificationsService
    {
        public Queue<Notification> Notifications { get; set; } = new Queue<Notification>();

        public event EventHandler Refresh;

        public void Add(string message, EType type)
        {
            Notification item = new Notification()
            {
                Message = message,
                Type = type
            };
            Notifications.Enqueue(item);
            Refresh?.Invoke(this, EventArgs.Empty);
        }
    }
}
