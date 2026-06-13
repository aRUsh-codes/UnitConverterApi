namespace UnitConverterApi.Services;

public interface IUnitConverter
{
    double Convert(string fromUnit, string toUnit, double value);
}