using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace C19_Ex01_Itsik_201016151_Zahi_204185490
{
    public class FacebookListStrategy<T>
    {
        private List<T> m_ListToReturn;
        private bool v_Done = false;

        public Func<IEnumerable<T>> FacebookListFunc { get; set; }

        public void GenerateList(out List<T> o_OutputList)
        {
            Thread runThread = new Thread(runFunc);
            runThread.Start();

            while(!v_Done)
            {
                Thread.Sleep(1000);
            }

            o_OutputList = m_ListToReturn;
        }

        public void runFunc()
        {
            if(FacebookListFunc != null)
            {
                m_ListToReturn = FacebookListFunc.Invoke().ToList();
                v_Done = true;
            }
            else
            {
                throw new Exception("Facebook list function is Empty!");
            }
        }
    }
}
