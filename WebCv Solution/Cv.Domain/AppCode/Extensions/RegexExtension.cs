using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Cv.Domain.AppCode.Extensions
{
    public static partial class Extension
    {
        static public bool IsEmail(this string value)
        {
            return Regex.IsMatch(value, @"^([\w-.]+)@(([[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}.)|(([\w-]+.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(]?)$");
        }

    }
}
