using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwiftBite.Business.Common
{
    public sealed class Guard
    {
        public static void Against(bool brokenRule , string ruleId , string message)
        {
            if (brokenRule)
                throw new DomainException(ruleId, message);
        }

        public static string NotEmpty(string? value, string ruleId, string feildName)
        {
            Against(string.IsNullOrEmpty(value), ruleId, $"{feildName} is Required");
            return value!.Trim();
        }
    };

 
}
