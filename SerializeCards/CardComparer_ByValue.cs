using System.Collections.Generic;

namespace SerializeCards
{
    class CardComparer_ByValue:IComparer<Cards>
    {
        public int Compare(Cards x, Cards y)
        {
            if (x.Value>y.Value)
            {
                return 1;
            }
            else if (x.Value<y.Value)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
