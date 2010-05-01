using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KartalGoz.BL
{
    public interface ILoginable
    {
        short IsLoggedIn
        {
            get;
            set;
        }

        User Login();

        short Logout();

        User SignUp();
    }
}
