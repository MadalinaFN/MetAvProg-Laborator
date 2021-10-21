using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator_3
{
    public static class StringExtension
    {
        public static char ZoltanLast(this string s)
        {
            if (!string.IsNullOrEmpty(s))
            {
                return s[s.Length - 1];
            }
            return (char)0;
        }
    }
}
