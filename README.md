# Temperature Calculator

C# console application for temperature conversions between Celsius, Fahrenheit, and Kelvin.

## Features
- Multiple temperature scale conversions
- Input validation
- Precision control
- History tracking
- Unit testing

## Implementation
```csharp
public class TemperatureConverter
{
    public double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9/5) + 32;
    }
    
    public double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5/9;
    }
    
    public double CelsiusToKelvin(double celsius)
    {
        return celsius + 273.15;
    }
}
```

## Structure
```
TemperatureCalculator/
├── Program.cs
├── TemperatureConverter.cs
└── Tests/
    └── ConverterTests.cs
```

## Usage
```bash
dotnet run
```

## Tests
```bash
dotnet test
```

## License
MIT License
