using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KuGuan.Model
{
    public class User
    {
        private int userId;
        private String username;
        private String userType;
        private String password;
        public int UserId 
        {
            set { this.userId = value; }
            get { return this.userId; }
        }

        public String Username 
        {
            set { this.username = value; }
            get { return this.username; }
        }

        public String UserType
        {
            set { this.userType = value; }
            get { return this.userType; }
        }
        public String Password
        {
            set { this.password = value; }
            get { return this.password; }
        }

        public User() { }
        public User(int userId, String username, String userType,String password)
        {
            this.userId = userId;
            this.username = username;
            this.userType = userType;
            this.password = password;
        }
    }
}
