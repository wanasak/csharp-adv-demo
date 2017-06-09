using System;
using System.Linq;

namespace ExtensionMethods
{
    public static class TextExtensions
    {
        public static string Shorten(this String text, int numberOfWords)
        {
            if (numberOfWords < 0) throw new ArgumentOutOfRangeException();
            if (numberOfWords == 0) return "";

            var words = text.Split(' ');

            if (words.Length <= numberOfWords)
                return text;

            return string.Join(" ", words.Take(numberOfWords)) + "...";
        }
    }
}
