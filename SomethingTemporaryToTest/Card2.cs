using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public partial class Card
    {
        private static string[] names0 = new string[] {"","asów","dwojek","trojek","czworek","piatek","szostek","siodemek","osomeke","dziewiatek","dziesiatek",
            "waletów","dam","królow" };

        private static string[] names1 = new string[] {"","asa","dwojke","trojke","czworke","piatke","szostke","siodemke","osomke","dziewiatke","dziesiatke",
            "waleta","damy","króla" };

        private static string[] names2 = new string[] {"","asy","dwojki","trojki","czworki","piatki","szostki","siodemki","osomeki","dziewiatki","dziesiatki",
            "walety","damy","króle" };

        public static string Plural(Card.Values value, int count)
        {
            if (count == 0)
            {
                return names0[(int)value];
            }
            else if (count == 1)
            {
                return names1[(int)value];
            }

            return names2[(int)value];
        }
    }
}
