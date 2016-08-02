using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp
{
    public class Menu
    {
        public string Title { get; set; }
        public string Icon { get; set; }
        public Type Page { get; set; }
        public bool Checked { get; set; }
    }
}
