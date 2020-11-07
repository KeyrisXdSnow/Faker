using System.Collections.Generic;
using System.Reflection;

namespace Faker
{
    public class ConstrCompareAsc : IComparer<ConstructorInfo>
    {
        public int Compare(ConstructorInfo x, ConstructorInfo y)
        {
            int xParamCount = x.GetParameters().Length;
            int yParamCount = y.GetParameters().Length;

            if (xParamCount == yParamCount)  // reverse sort
                return 0;
           
            if (xParamCount > yParamCount)
                return -1;
            else 
                return 1;

        }
    }
}
