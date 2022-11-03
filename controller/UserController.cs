using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controller
{
    public class UserController : BasisController
    {
        protected override void CreateDemoData()
        {
            this.Save();
        }
    }
}
