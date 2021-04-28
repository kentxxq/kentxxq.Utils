using System;
using System.Reflection.PortableExecutable;

namespace kentxxq.Extensions.Time
{
    public static class Convert
    {
        /// <summary>
        /// 转换为unix下的timestamp
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static long ToUnixTimeMilliseconds(this DateTime dateTime)
        {
            return (dateTime.ToUniversalTime().Ticks - 621355968000000000) / 10000;
        }

        /// <summary>
        /// 把unix下的timestamp转换成DateTime类型
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static DateTime ToDateTime(this double data)
        {
            DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime.AddMilliseconds(data).ToLocalTime();
            return dtDateTime;
        }
    }
}
