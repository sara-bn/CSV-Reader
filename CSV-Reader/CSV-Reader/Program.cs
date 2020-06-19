using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_Reader
{
    class Program
    {
        static void Main(string[] args)
        {

            CSVHelper csvReader = new CSVHelper();
            string filePath = @"C:\Users\17789\Documents\GitHub\CSV-Reader\Pop by Largest Final.csv";

            var countries = csvReader.ShowAllCountries(filePath);
            Console.WriteLine("Please enter a country code");

            var countryCode = Console.ReadLine().ToUpper();

            if (countries.TryGetValue(countryCode, out Country country)){

                Console.WriteLine($"Population of {country.CountryName} is {country.Population}");
            }
            else
            {
                Console.WriteLine("Sorry! There is no country with this code!");
            }

            Console.ReadKey();

        }

    }
}
