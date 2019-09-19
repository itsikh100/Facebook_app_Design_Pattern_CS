using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C19_Ex01_Itsik_201016151_Zahi_204185490
{
    public static class FacebookListGenerator<T>
    {
        public static List<T> GenerateList(Func<IEnumerable<T>> i_ListGenerator)
        {
            List<T> listToReturn;
            var fbStart = new FacebookListStrategy<T>() { FacebookListFunc = i_ListGenerator };

            fbStart.GenerateList(out listToReturn);

            return listToReturn;
        }
    }
}
