using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace Calculator
{
    public class Calculate
    {
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public static int Add(int a, int b)
        {
            int result = 0;
            result += a;
            result += b;
            Log4NetService.Instance.LogInfo(result, "Add finished and got " + result);
            return result;
        }
    }
}
