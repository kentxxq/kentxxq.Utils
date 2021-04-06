using System;
using System.Collections.Generic;
using System.Text;

namespace kentxxq.Extensions.Time
{
    public static class Convert
    {
        public static long ToUnixTimeMilliseconds(this DateTime dateTime)
        {
            return (dateTime.ToUniversalTime().Ticks - 621355968000000000) / 10000;
        }
    }
}