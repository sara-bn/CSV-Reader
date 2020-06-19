using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_Reader
{
    class Country
    {

        public string CountryName { get; set; }
        public string CountryCode { get; set; }
        public string Continent { get; set; }
        public string Population { get; set; }

        public Country(string countryName, string countryCode, string continent, string population)
        {
            CountryName = countryName;
            CountryCode = countryCode;
            Continent = continent;
            Population = population;
        }

    }


}
