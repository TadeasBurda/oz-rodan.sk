using Rodan.Business.Classes;
using System;
using System.Collections.Generic;

namespace Rodan.Business.Interfaces
{
    public interface INotificationsService
    {
        public Queue<Notification> Notifications { get; set; }

        public event EventHandler Refresh;

        public void Add(string message, EType type);
    }
}
