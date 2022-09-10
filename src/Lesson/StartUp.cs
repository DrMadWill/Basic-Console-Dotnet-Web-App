using Lesson.Controllers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    public class StartUp
    {
        public void Main()
        {
            Console.WriteLine("=============== Welcome Web Site! =====================");
        link:
            Console.WriteLine("Write Your Link");
            Console.Write("Link :");
            string link = Console.ReadLine();
            Use use = new Use();
            switch (link)
            {
                default:
                case "https://Account/Login":
                    use.AccountController.Login();
                    break;
                case "https://Account/Register":
                    use.AccountController.Login();
                    break;
                case "https://Product/Create":
                    use.ProductConrtoller.Create();
                    break;
            }

            goto link;
        }
    }


    class Use
    {
        public Use()
        {
            AccountController = new AccountController();
            ProductConrtoller = new ProductConrtoller();
        }
        public AccountController AccountController { get; set; }
        public ProductConrtoller ProductConrtoller { get; set; }
        public static Claim Claim { get; set; }
    }
}
