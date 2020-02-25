using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependenceInjectionTest.Service
{
    public class SuperUserService : BaseService, ISuperUserService
    {
        public string SuperUserServiceData { get; set; }
        public SuperUserService()
        {
            SuperUserServiceData = "Created !";
        }

        public void Test()
        {
            throw new NotImplementedException();
        }
    }
}
