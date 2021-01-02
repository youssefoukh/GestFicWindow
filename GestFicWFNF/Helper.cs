using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesFic
{
    class Helper
    {
        public static String cnStr(String val)
        {
            return ConfigurationManager.ConnectionStrings[val].ConnectionString;
        }
    }
}
