using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHF_Manager.Data
{
    public static class StaticData
    {
        static Mhfdat mhfdat = null;

        public static void SetMhfdat(Mhfdat mhfdat)
        {
            StaticData.mhfdat = mhfdat;
        }

        public static Mhfdat GetMhfdat()
        {
            return StaticData.mhfdat;
        }
    }
}
