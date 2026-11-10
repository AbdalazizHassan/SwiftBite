using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwiftBite.Business.Common
{
    public class DomainException : Exception 
    {
        public string RuleId { get; }

        public DomainException(string ruleId , string message) : base($"[{ruleId}] , {message}")
        {
            RuleId = ruleId;
            
        }
    }
}
