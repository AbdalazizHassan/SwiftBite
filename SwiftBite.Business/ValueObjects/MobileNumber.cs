using SwiftBite.Business.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SwiftBite.Business.ValueObjects
{
    public sealed record MobileNumber
    {
        public string Value { get; }

        private MobileNumber(string value)
        {
            Value = value;            
        }

        public static MobileNumber Create(string value)
        {
            Guard.Against(!Regex.IsMatch(value ?? "", @"^01[0125]\d{8}$"),
           "BR-01", "Mobile must be 11 digits starting with 010, 011, 012 or 015.");
            return new MobileNumber(value!);
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
