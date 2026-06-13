namespace UnitConverterApi.Services;

public class TemperatureUnitConverter : IUnitConverter
{
    public double Convert(string fromUnit, string toUnit, double value)
    {
        fromUnit = fromUnit.ToLower();
        toUnit = toUnit.ToLower();

        double celsius = fromUnit switch
        {
            "celsius" => value,
            "fahrenheit" => (value - 32) * 5 / 9,
            "kelvin" => value - 273.15,
            _ => throw new ArgumentException("Unsupported temperature unit")
        };

        return toUnit switch
        {
            "celsius" => celsius,
            "fahrenheit" => (celsius * 9 / 5) + 32,
            "kelvin" => celsius + 273.15,
            _ => throw new ArgumentException("Unsupported temperature unit")
        };
    }
}