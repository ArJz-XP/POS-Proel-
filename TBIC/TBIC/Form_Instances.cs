using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;

namespace TBIC
{
    public static class Form_Instances
    {
        public static LandingPage _lan { get; } = new LandingPage();
        public static LimitedEdition _lim { get; } = new LimitedEdition();
        public static Payment _pay { get; } = new Payment();
        public static DontDeleteForSuprise _dont { get; } = new DontDeleteForSuprise();
        public static Loading_Screen _load { get; } = new Loading_Screen();
        public static Admin_Dashboard _dash { get; } = new Admin_Dashboard();
        public static Acc_Management _acc { get; } = new Acc_Management();
        public static Receipt _rep { get; } = new Receipt();
    }
}
