using System.Text.RegularExpressions;

namespace Forum.Domain.Entities.ValueObjects;

public class Slug(string value)
{
    public string Value { get; set; } = value;

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
}
