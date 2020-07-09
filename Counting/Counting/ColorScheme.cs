using System;
using System.Collections.Generic;
using System.Linq;

namespace Counting
{
    public class ColorScheme
    {
        private static readonly Random _random = new Random();
        private static readonly IReadOnlyList<ColorScheme> Schemes 
            = new List<ColorScheme>
            {
                new ColorScheme("160C28", "EFCB68"),
                new ColorScheme("7209B7", "F72585"),
                new ColorScheme("16697A", "489FB5"),
                new ColorScheme("D81E5B", "331832"),
                new ColorScheme("40476D", "ACBEA3"),
                new ColorScheme("6153CC","44FFD1"),
                new ColorScheme("124E78", "F0F0C9"),
                new ColorScheme("F9C80E", "F86624"),
                new ColorScheme("4B4237", "D5A021"),
                new ColorScheme("9984D4", "CAA8F5"),
                new ColorScheme("595959", "808F85")
            };

        private ColorScheme(string background, string text)
        {
            Background = $"#{background}";
            Text = $@"#{text}";
        }
        
        public string Background { get; } = "#FFFFFF";
        public string Text { get; } = "#000000";

        public static ColorScheme Random(ColorScheme except = null)
        {
            // won't exclude if nothing passed in
            var exclude = except ?? new ColorScheme("", "");

            return Schemes
                .Except(new[] {exclude})
                .OrderBy(cs => _random.Next())
                .First();
        }
    }
}