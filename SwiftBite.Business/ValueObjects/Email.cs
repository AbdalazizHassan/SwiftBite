using SwiftBite.Business.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SwiftBite.Business.ValueObjects
{
    public sealed record Email
    {
        public string Value { get; }

        private Email(string value)
        {
            Value = value;
        }

        public static Email Create(string value)
        {
            Guard.Against(!Regex.IsMatch(value ?? "", @"^[^@\s]+@[^@\s]+\.[^@\s]+$"),
           "BR-02", "Invalid email address.");

            return new Email(value!);
        }

        public override string ToString()
        {
            return Value;
        }


    }
}
