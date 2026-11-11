using SwiftBite.Business.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwiftBite.Business.ValueObjects
{
    public sealed record Address
    {
        public string Label { get; }
        public string Street { get; }
        public Location Location { get; }

        private Address(string label , string street , Location location)
        {
            Label = label;
            Street = street;
            Location = location;            
        }

        public static Address Create(string label, string street, Location location) =>
            new(Guard.NotEmpty(label, "FR-02", "Address label"),
            Guard.NotEmpty(street, "FR-02", "Street"),
            location);


    }
}
