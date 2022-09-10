using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson.Models
{
    public class Product : BaseEntity<int>
    {
        public override int Id { get; set; }
        public float Price { get; set; }
        public string Name { get; set; }
        public User User { get; set; }
    }
}
