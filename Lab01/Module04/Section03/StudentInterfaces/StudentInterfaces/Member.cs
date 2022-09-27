using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInterfaces
{
    class Member
    {
            public string Name;
            public string Address;
            protected int phone;

            public int Phone
            {
                set { phone = value; }
            }
        }


    }

