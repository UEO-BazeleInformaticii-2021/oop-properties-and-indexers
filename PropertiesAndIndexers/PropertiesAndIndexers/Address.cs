using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesAndIndexers
{
    public class Address
    {
        public string City { get; set; }

        public string StreetName { get; set; }

        public string StreetNumber { get; set; }

        public string PostalCode { get; set; }

        public string this[string part]
        {
            get
            {
                if (string.Equals(part, nameof(City), StringComparison.OrdinalIgnoreCase))
                {
                    return City;
                }
                else if (string.Equals(part, nameof(StreetName), StringComparison.OrdinalIgnoreCase))
                {
                    return StreetName;
                }
                else if (string.Equals(part, nameof(StreetNumber), StringComparison.OrdinalIgnoreCase))
                {
                    return StreetNumber;
                }
                else if (string.Equals(part, nameof(PostalCode), StringComparison.OrdinalIgnoreCase))
                {
                    return PostalCode;
                }
                else
                {
                    return string.Empty;
                }
            }
        }

    }
}
