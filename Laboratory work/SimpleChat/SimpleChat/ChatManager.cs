using System;
using System.Collections.Generic;

namespace SimpleChat
{
    public class ChatManager
    {
        private readonly List<User> _activeUsers = new List<User>();
        
        public event Action<int> OnUserNumberChanged;
        public event Action<string> OnLog;

        public int GetActiveUsers() => _activeUsers.Count;
        
        public void AddUser(User user)
        {
            if (_activeUsers.Contains(user))
            {
                return;
            }

            foreach (User activeUser in _activeUsers)
            {
                user.OnSent += activeUser.Receive;
                activeUser.OnSent += user.Receive;
            }
            
            _activeUsers.Add(user);
        }

        public void RemoveUser(User user)
        {
            if (!_activeUsers.Contains(user))
            {
                return;
            }
                
            foreach (User activeUser in _activeUsers)
            {
                user.OnSent -= activeUser.Receive;
                activeUser.OnSent -= user.Receive;
            }

            _activeUsers.Remove(user);
        }


        public void OnOnLog(string message)
        {
            OnLog?.Invoke(message);
        }

        public void OnOnUserNumberChanged(int count)
        {
            OnUserNumberChanged?.Invoke(count);
        }
    }
}
