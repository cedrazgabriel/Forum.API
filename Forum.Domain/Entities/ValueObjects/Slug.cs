using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace Forum.Domain.Entities.ValueObjects;

public class Slug
{
    private Slug(string value)
    {
       Value = value;
    }

    public string Value { get; set; } 

    public static Slug createFromText(string text)
    {
        var normalizedText = text.
            Normalize(System.Text.NormalizationForm.FormKD)
            .ToLower()
            .Trim();

        normalizedText = Regex.Replace(normalizedText, @"\s+", "-");
        normalizedText = Regex.Replace(normalizedText, @"[^\w-]+", "");
        normalizedText = Regex.Replace(normalizedText, @"_", "-");
        normalizedText = Regex.Replace(normalizedText, @"--+", "-");
        normalizedText = Regex.Replace(normalizedText, @"-$", "");

        return new Slug(normalizedText);
    }

    public static Slug Create(string slug)
    {
        return new Slug(slug);
    }
}
