using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public static class Extensions
    {
        public static string ToProductCode(this string code)
        {
            if (string.IsNullOrEmpty(code))
            {
                return "SIN-CODIGO";
            }
            code = code.Trim();
            code = code.ToUpper();
            code = code.Replace(" ", "-");
            return code;
        }
    }
}
