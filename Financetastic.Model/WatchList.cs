using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Financetastic.Model
{
    public class WatchList
    {
        public WatchList()
        {
            Securities = new HashSet<Security>();
        }

        // Primitive properties
        public int Id { get; set; }
        public string Title { get; set; }

        // Navigation properties
        public virtual ICollection<Security> Securities { get; set; }
    }
}
