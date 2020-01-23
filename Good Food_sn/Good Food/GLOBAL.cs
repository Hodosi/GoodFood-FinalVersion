using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Good_Food
{
    class GLOBAL
    {
        public static int GlobalClientid { get; set; }

        public static void setGlobalClientid(int id)
        {
            GlobalClientid = id;
        }
    }
}
