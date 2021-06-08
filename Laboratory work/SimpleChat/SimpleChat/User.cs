using System;
using System.Collections.Generic;

namespace SimpleChat
{
    public class User
    {
        private readonly List<Message> _history = new List<Message>();
        public string Username { get; }

        public event MessageHandler OnSent;
        public event MessageHandler OnReceived;

        private List<Message> History => _history;

        public User(string name)
        {
            Username = name;
        }

        public void Send(string data)
        {
            var newMessage = new Message { Data = data, Initiator = this, TimeStamp = DateTime.Now };
            History.Add(newMessage);
            OnSent?.Invoke(newMessage);
        }

        public void Receive(Message message)
        {
            History.Add(message);
            OnReceived?.Invoke(message);
        }
    }
}
