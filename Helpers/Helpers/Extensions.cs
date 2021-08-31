using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop
{
    public static class Extensions
    {

        #region " To Null String "

        public static string ToNullString(this object obj, string DefaultValue = "")
        {
            return obj == null ? DefaultValue : obj.ToString();
        }

        #endregion

        #region " To Int"

        public static int ToInt(this object obj, int DefaultValue = 0)
        {
            return obj == null ? DefaultValue : Convert.ToInt32(obj);
        }

        #endregion

        #region " To Bit "

        public static int ToBit(this bool obj)
        {
            return obj == true ? 1 : 0;
        }

        #endregion

        #region " To Long "

        public static long ToLong(this object obj, long DefaultValue = 0)
        {
            return obj == null ? DefaultValue : Convert.ToInt64(obj);
        }

        #endregion

        #region " To Double "

        public static double ToDouble(this object obj, double DefaultValue = 0)
        {
            return obj == null ? DefaultValue : Convert.ToDouble(obj);
        }

        public static double ToDouble(this string obj, double DefaultValue = 0)
        {
            return obj == "" ? DefaultValue : Convert.ToDouble(obj);
        }

        #endregion

        #region " To Decimal "

        public static decimal Decimal(this object obj, decimal DefaultValue = 0)
        {
            return obj == null ? DefaultValue : Convert.ToDecimal(obj);
        }

        public static decimal Decimal(this string obj, decimal DefaultValue = 0)
        {
            return obj == "" ? DefaultValue : Convert.ToDecimal(obj);
        }

        #endregion

        #region " To Boolean "

        public static bool ToBolean(this object obj, bool DefaultValue = false)
        {
            return obj == null ? DefaultValue : Convert.ToBoolean(obj);
        }

        #endregion

        #region " To Encrypt "

        public static string ToEncrypt(this string Word)
        {
            return Convert.ToBase64String(Encoding.ASCII.GetBytes(Word));
        }

        #endregion

        #region " To Decrypt "

        public static string ToDecrypt(this string Word)
        {
            return Encoding.ASCII.GetString(Convert.FromBase64String(Word));
        }

        #endregion

    }
}