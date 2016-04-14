using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityDatabase
{
    public class City
    {
        public string CityName { get; set; }
        public string CountryName { get; set; }
        public int Population { get; set; }

        public City (String cityName, String countryName, int population)
        {
            CityName = cityName;
            CountryName = countryName;
            Population = population;
        }

        public override string ToString()
        {
            return String.Format("{0}, {1}, {2}",CityName, CountryName, Population); 
        }


    }
}
