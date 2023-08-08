using System.Globalization;

namespace OnlineShoppingCart
{
    public static class ExtensionMethods
    {
        public static string ToTitleCase(this string text)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(text);
        }

        public static int AlphaNumericCount(this string text) 
        { 
            return text.Count(char.IsLetterOrDigit);
        }

        public static int WordCount(this string text, char seperator = ' ')
        {
            return text.Split(seperator).Length;
        }

        public static string ToSlug(this string text)
        {
            // Mobile-Phones
            return string.Join("", text.Replace(" ", "-").Replace("_", "-").Replace(".", "-").Where(m => char.IsLetterOrDigit(m) || m == '-'));
        }
    }
}
