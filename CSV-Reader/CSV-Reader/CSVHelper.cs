using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_Reader
{
    class CSVHelper
    {
        public Dictionary<string,Country> ShowAllCountries(string path)
        {
           var countries= new Dictionary<string, Country>();
            using (StreamReader sr = new StreamReader(path))
            {
                //skip the headline
                sr.ReadLine();

                string csvLine;
                while (( csvLine = sr.ReadLine()) != null)
                {
                   var newCountry= CreateCountryObject(csvLine);
                   countries.Add(newCountry.CountryCode, newCountry);
                }
                
            }
                
           return countries;
        }

        public Country CreateCountryObject(string line)
        {
            string[] items  = line.Split(',');
            string countryName;
            string countryCode;
            string continent;
            string population;

            // Some line have more than 4 strings between commas like :
            //"Egypt, Arab Rep.",EGY,Africa,97553151. So we need to do some validations
            int itemsLength = items.Length;
            switch (itemsLength)
            {
                case 4:
                countryName = items[0];
                countryCode = items[1];
                continent = items[2];
                population = items[3];
                    break;

                case 5:
                countryName = $"{items[0]} {items[1]}";
                countryCode = items[2];
                continent = items[3];
                population = items[4];
                    break;

                default:
                    throw new Exception($"Can't parse country from CSV file");
            }
           
            Country country = new Country(countryName, countryCode, continent, population);
                
            return country;

        }
    }
}
