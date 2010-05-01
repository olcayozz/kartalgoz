using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KartalGoz.BL
{
    public class User
    {
        private long _uid;

        public long Uid
        {
            get { return _uid; }
            set { _uid = value; }
        }
    }
}
