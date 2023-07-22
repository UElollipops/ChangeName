using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeName
{
    public static class DaXiaoXieTrans
    {
        public static string strUp;
        public static string strLow;


        /// <summary>
        /// 字母转换为大写
        /// </summary>
        public static string ToUpperFun(string str)
        {
            strUp = str.ToUpper();
            return strUp;
        }

        /// <summary>
        /// 字母转换为小写
        /// </summary>
        public static string ToLowerFun(string str)
        {
            strLow = str.ToLower();
            return strLow;
        }
    }
}
