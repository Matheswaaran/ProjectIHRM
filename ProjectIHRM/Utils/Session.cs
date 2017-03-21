using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectIHRM.Utils
{
    static class Session
    {
        static int uid;
        static string username;

        public static void setDetails(int id, string name)
        {
            uid = id;
            username = name;
        }

        public static int getId() { return uid; }

        public static string getUsername() { return username; }
    }
}
