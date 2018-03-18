using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppM
{
    public class ApplicationModel
    {
        private static string _dblquot = "\"";
        public static string DblQuot
        {
            get { return _dblquot; }
        }

        private static int addedid;
        public static int AddedId
        {
            get { return addedid; }
            set { addedid = value; }
        }

        private static bool _nochanges;
        public static bool NoChanges
        {
            get { return _nochanges; }
            set { _nochanges = value; }
        }

        private static bool _goodsave;
        public static bool SaveOK
        {
            get { return _goodsave; }
            set { _goodsave = value; }
        }

        private static bool _gooddlt;
        public static bool DltOK
        {
            get { return _gooddlt; }
            set { _gooddlt = value; }
        }

        private static int _timesthru;
        public static int TimesThru
        {
            get
            {
                return _timesthru;
            }
            set
            {
                _timesthru = value;
            }
        }

    }
}
