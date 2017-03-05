using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pipeline.Core
{
    public class MainService
    {
        public string Hello(string message, string name)
        {
            return $"{message} {name}";
        }
    }
}
