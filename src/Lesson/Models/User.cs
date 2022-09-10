using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson.Models
{
    public class User : BaseEntity<int>
    {
        public override int Id { get; set; }
        public string FullName { get; set; }
        public bool IsAdmin { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
