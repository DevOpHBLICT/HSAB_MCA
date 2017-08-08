using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoLS
{
   public class c
    {
        public c(string name, string image,string next)
        {
            this.Name = name;  
            this.Image = image;
            this.Next = next;
        }
        public string Next { private set; get; }
        public string Name { private set; get; }
        public string Image { private set; get; }

    }
}
