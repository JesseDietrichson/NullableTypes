using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{
    //A class to simulate reading a database
    class Database
    {
        public int? GetUsersAge(string user)
        {
            //Lets pretend the user does not exist and because of that we now can't get the age
            return null;
        }
    }
}
