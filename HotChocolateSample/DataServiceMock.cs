using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotChocolateSample
{
    public static class DataServiceMock
    {
        public static Dictionary<string, Building> Buildings { get; set; }
        public static Dictionary<string, Flat> Flats { get; set; }

        static DataServiceMock()
        {
            Buildings = new Dictionary<string, Building>()
            {
                { "1", new Building("1", "firstAddress") },
                { "2", new Building("2", "firstAddress") }
            };
            Flats = new Dictionary<string, Flat>()
            {
                { "1", new Flat("1", "firstOwner") },
                { "2", new Flat("2", "firstOwner") }
            };
        }

        public static IItem GetItem<T>(string id) 
        {
            if (typeof(T) == typeof(Building))
            {
                return Buildings[id];
            }

            if (typeof(T) == typeof(Flat))
            {
                return Flats[id];
            }

            throw new Exception();
        }
    }
}
