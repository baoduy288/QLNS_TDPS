using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLNS_TDPS.Common
{
    public class TimeSetting
    {
        public DateTime setDate(DateTime day)
        {
            var _NewDate = day.Date;
            return _NewDate;
        }
    }
}