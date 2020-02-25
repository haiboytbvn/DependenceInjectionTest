using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependenceInjectionTest.Model
{
    public class User : BaseModel
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
