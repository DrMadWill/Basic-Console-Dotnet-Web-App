using Lesson.Data;
using Lesson.Extations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson.Controllers
{
    public class AccountController
    {
        private Database db = new Database();

        public void Login()
        {

            NotLoginContinueHere:
            Console.WriteLine("Hello User");
            Console.WriteLine("Login Write.");
            Console.Write("Login <<< : ");
            string login = Console.ReadLine();

            Console.WriteLine("Password Write.");
            Console.Write("Password << : ");
            string pass = Console.ReadLine();

           

            var user = db.Users.CheckUserByLogin(pass);

            if(user == null)
            {
                Console.WriteLine("Not Found User !!!!");
                if (Util.TryAgen())
                {
                    goto NotLoginContinueHere;
                }

                return;
            }

            if (user.CheckUserPassword(login))
            {

                Use.Claim = new Claim { UserId = user.Id,UserName = user.FullName };
                Console.WriteLine("Welcome " + user.FullName);

            }
            else
            {
                Console.WriteLine("Your Pass False!");

                if (Util.TryAgen())
                {
                    goto NotLoginContinueHere;
                }

                return;
            }
        }


    }
}
