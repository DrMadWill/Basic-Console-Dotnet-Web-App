using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson.Models
{
    public class BaseEntity<TPrimary>
    {
        public virtual TPrimary Id { get; set; }
    }
}
