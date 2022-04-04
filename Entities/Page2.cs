using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Page2:BaseEntity
    {
        public string PhotoUrl { get; set; }
        public string BackPhoto { get; set; }
        public bool IsDeleted { get; set; }
    }
}
