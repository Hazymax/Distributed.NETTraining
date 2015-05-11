using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messaging
{
    public class UserId
    {
        private readonly int ID;

        public int Id
        {
            get { return ID; }
        }

        public UserId(int id)
        {
            ID = id;
        }
    }
}
