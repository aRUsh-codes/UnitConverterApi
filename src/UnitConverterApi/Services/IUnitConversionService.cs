using UnitConverterApi.Models;

namespace UnitConverterApi.Services;

public interface IUnitConversionService
{
    ConversionResponse Convert(ConversionRequest request);
}