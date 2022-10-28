using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.model.instance
{
    public class UserAccount
    {
        public static implicit operator UserAccount(CurrentAccount v)
        {
            throw new NotImplementedException();
        }
    }
}
