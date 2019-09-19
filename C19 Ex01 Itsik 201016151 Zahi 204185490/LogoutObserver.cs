using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C19_Ex01_Itsik_201016151_Zahi_204185490
{
    public class LogoutObserver
    {
        public event EventHandler BtnLogoutClicked;

        public void NotifyAll()
        {
            BtnLogoutClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
