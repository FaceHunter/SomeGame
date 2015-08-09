using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace SideScroller.Settings
{
    class Language
    {
        public static Dictionary<string, Type> Locales = new Dictionary<string, Type>() { { "EN", typeof(Locale.EN) } };
        public static string CurrentLocale = "EN";

        public static object GetLocale(string Locale)
        {
            return Activator.CreateInstance(Locales[Locale]);
        }

        public static string GetString(string thingy)
        {
            var instance = Activator.CreateInstance(Locales[CurrentLocale]);
            return (string)instance.GetType().GetField(thingy).GetValue(instance);
        }

    }
}
