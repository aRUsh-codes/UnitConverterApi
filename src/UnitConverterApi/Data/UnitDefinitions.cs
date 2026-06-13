namespace UnitConverterApi.Data;

public static class UnitDefinitions
{
    public static readonly Dictionary<string, double> LengthUnits =
        new()
        {
            { "meter", 1.0 },
            { "kilometer", 1000.0 },
            { "foot", 0.3048 },
            { "mile", 1609.34 }
        };

    public static readonly Dictionary<string, double> WeightUnits =
        new()
        {
            { "kilogram", 1.0 },
            { "gram", 0.001 },
            { "pound", 0.453592 }
        };
}