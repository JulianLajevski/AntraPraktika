using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntraPraktika.Back
{
    static class EnumConverter
    {
        public static int getUserTypeID(UserType userType)
        {
            return (int)userType;
        }
        public static UserType getUserType(int id)
        {
            return (UserType)id;
        }
    }
}
