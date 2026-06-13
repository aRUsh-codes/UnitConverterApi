namespace UnitConverterApi.Services;

public class LinearUnitConverter : IUnitConverter
{
    private readonly Dictionary<string, double> _units;

    public LinearUnitConverter(Dictionary<string, double> units)
    {
        _units = units;
    }

    public double Convert(string fromUnit, string toUnit, double value)
    {
        double baseValue = value * _units[fromUnit.ToLower()];
        return baseValue / _units[toUnit.ToLower()];
    }
}