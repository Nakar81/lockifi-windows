using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LockifiApp
{
    public class Router
    {
        public string name { get;set ; }
        public string file { get; set; }

        public Router(string nameI, string fileI)
        {
            name = nameI;
            file = fileI;
        }
        public override string ToString()
        {
            return name;
        }
    }
}
