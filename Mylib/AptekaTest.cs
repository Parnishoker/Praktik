using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mylib
{
    public class AptekaTest
    {
        QQEntities db = new QQEntities();

        login user = new login();

        public string Create(string login1, string pass, string role)

        {

            user.login1 = login1;

            user.pass = pass;

          

            user.role = role;

            db.login.Add(user);

            db.SaveChanges();

            return user.login1;

        }
        public string ReadInformation(string testlog)

        {

            var inform = db.login.Where(r => r.login1 == testlog).FirstOrDefault();

            return inform.login1.ToString();

        }
        public string RemoveUser(string login)

        {

            var searchUser = db.login.Where(r => r.login1 == login).FirstOrDefault();

            db.login.Remove(searchUser);

            db.SaveChanges();

            return searchUser.login1;

        }
    }
}
