using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Framwork.Domain
{
   public class EntityBase
    {
        public long ID { get; set; }
        public DateTime CreationDate { get; set; }
        public EntityBase()
        {
            CreationDate = DateTime.Now;
        }
    }
}
