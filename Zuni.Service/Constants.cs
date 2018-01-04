using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zuni.Service
{
    public  class Constants
    {
        public enum OrderStatus
        {
            Create = 1,
            ConfirmandPendingfordeliver = 2,
            SaveOnlyOrder = 3,
            Complemted = 4
        }
    }
}
