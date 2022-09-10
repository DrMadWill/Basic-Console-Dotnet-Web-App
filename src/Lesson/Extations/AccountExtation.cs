using Lesson.Data;
using Lesson.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson.Extations
{
    public static class AccountExtation
    {

        public static User CheckUserByLogin(this DbSet<User> users,string login)
        {
            return users.Find(x => x.Login == login);

            //foreach (var item in users) 
            //{
            //    if(item.Login == login)
            //    {
            //        return item;
            //    }
            //}

            //return null;
        }

        public static bool CheckUserPassword(this User user, string pass)
        {
            return user.Password == pass;
        }

        
    }
}
