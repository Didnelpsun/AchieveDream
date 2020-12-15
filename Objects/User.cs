using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AchieveDream.Objects
{
    public class User
    {
        private string _username;
        private string _password;

        public string Username
        {
            set
            {
                _username = value;
            }
            get
            {
                return _username;
            }
        }

        public string Password
        {
            set
            {
                _password = value;
            }
            get
            {
                return _password;
            }
        }

        public User()
        {
            _username = null;
            _password = null;
        }

        public User(string username)
        {
            _username = username;
            _password = null;
        }

        public User(string username, string password)
        {
            _username = username;
            _password = password;
        }
    }
}