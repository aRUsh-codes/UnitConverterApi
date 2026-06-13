using UnitConverterApi.Data;
using UnitConverterApi.Models;

namespace UnitConverterApi.Services;

public class UnitConversionService : IUnitConversionService
{
    public ConversionResponse Convert(ConversionRequest request)
    {
        IUnitConverter converter = request.Category.ToLower() switch
        {
            "length" => new LinearUnitConverter(UnitDefinitions.LengthUnits),
            "weight" => new LinearUnitConverter(UnitDefinitions.WeightUnits),
            "temperature" => new TemperatureUnitConverter(),
            _ => throw new ArgumentException("Invalid category")
        };

        double result = converter.Convert(
            request.FromUnit,
            request.ToUnit,
            request.Value);

        return new ConversionResponse
        {
            InputValue = request.Value,
            FromUnit = request.FromUnit,
            ToUnit = request.ToUnit,
            ConvertedValue = result
        };
    }
}