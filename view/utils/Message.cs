using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckList.view.utils
{
    public class Message
    {
        private static string msg;
        private static string icone;

        public static string Msg
        {
            get { return msg; }
            set { msg = value; }
        }

        public static string Icone
        {
            get { return icone; }
            set { icone = value; }
        }
    }
}
