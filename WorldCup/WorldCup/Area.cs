using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldCup
{
    public enum Continent
    {
        Asia, Africa
    , NorthAmericaCentral,
        AmericaandCaribe,
        SouthAmerica,
        Australia,
        Europe,
        Host
    }
    public class Area
    {
        Teem teem = new Teem();
        Random random = new Random();
        List<int> AsignedTeem = new List<int>();

        public void radomArea(Continent Countrytype)
        {
            int totalTeemHasContinent = GetTeemLengtByArea(Countrytype);

            while (totalTeemHasContinent > 0)
            {
                int AsignContinent = random.Next(0, 32);
                if (!AsignedTeem.Any())
                {
                    AsignedTeem.Add(AsignContinent);
                    totalTeemHasContinent -= 1;

                }
                else if (AsignedTeem.Contains(AsignContinent))
                {
                    continue;

                }
                else
                {
                    AsignedTeem.Add(AsignContinent);
                    totalTeemHasContinent -= 1;
                }

            }
        }

        public void printall()
        {
            foreach (var item in AsignedTeem)
            {
                Console.WriteLine(item);
            }
        }


        public int GetTeemLengtByArea(Continent Countrytype)
        // Do a Test Case with return by 0
        {
            switch (Countrytype)
            {
                case Continent.Asia:
                    return 6;
                    break;
                case Continent.Africa:
                    return 5;
                    break;
                case Continent.AmericaandCaribe:
                    return 3;
                    break;
                case Continent.SouthAmerica:
                    return 3;
                    break;
                case Continent.Host:
                    return 1;
                    break;
                case Continent.Europe:
                    return 13;
                    break;
                case Continent.Australia:
                    return 1;
                    break;
                default:
                    return 0;
            }
        }
        public int GetContinentCode(Continent Countrytype)
        // Do a Test Case with return by 0
        {
            switch (Countrytype)
            {
                case Continent.Asia:
                    return 1;
                    break;
                case Continent.Africa:
                    return 2;
                    break;
                case Continent.AmericaandCaribe:
                    return 3;
                    break;
                case Continent.SouthAmerica:
                    return 4;
                    break;
                case Continent.Host:
                    return 7;
                    break;
                case Continent.Europe:
                    return 6;
                    break;
                case Continent.Australia:
                    return 5;
                    break;
                default:
                    return 0;
            }

        }
    }
}
