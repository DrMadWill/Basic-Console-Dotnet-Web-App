using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson.Models
{
    public class Sale : BaseEntity<int>
    {
        public override int Id { get; set; }
        public Product Product { get; set; }
        public User User { get; set; }
        public DateTime Date { get; set; }
    }
}
