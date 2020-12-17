using System;

namespace AchieveDream.Models
{
    public class LogIn
    {
        public bool data;
        public string message;

        public LogIn(string s1, string s2, bool mode)
        {
            object[] results = new object[2];
            if (!mode)
            {
                results = LogInByName(s1, s2);
            }
            else
            {
                results = LogInByPhone(s1, s2);
            }
            data = Convert.ToBoolean(results[0]);
            message = results[1].ToString();
        }

        private object[] LogInByName(string username, string password)
        {
            bool data = false;
            string message = "";
            return new Object[] { data, message };
        }

        private object[] LogInByPhone(string telephone, string code)
        {
            bool data = false;
            string message = "未实现该功能";
            return new Object[] { data, message };
        }
    }
}