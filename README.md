# Unit Converter API

## Description

Unit Converter API is an ASP.NET Core Web API that converts numerical values between different units of measurement.

Currently supported categories:

- Length
- Weight / Mass
- Temperature

The project is designed with extensibility in mind so that additional categories and hundreds of units can be added easily in the future.

---

## How to Run Locally

### Prerequisites

- .NET 8 SDK

### Clone the Repository

```bash
git clone <repository-url>
cd UnitConverterApi
```

### Restore Dependencies

```bash
dotnet restore
```

### Run the Application

```bash
dotnet run --project src/UnitConverterApi
```

The API will start locally and Swagger UI will be available at:

```

https://localhost:xxxx/swagger

```

---

## Example API Request

```http
POST /api/conversion
```

```json
{
  "category": "temperature",
  "fromUnit": "celsius",
  "toUnit": "fahrenheit",
  "value": 25
}
```

---

## Design Decisions and Trade-Offs

### Separation of Concerns

The project separates:

- Controllers
- Services
- Models
- Unit definitions

This structure improves maintainability and makes collaboration easier for multiple developers.

### Extensibility

Different converter implementations are introduced through interfaces. This allows future support for hundreds of units and categories without modifying existing code significantly.

### Hardcoded Data

Unit definitions are currently hardcoded for simplicity as required by the assignment. In a production environment, these definitions would likely come from:

- Database
- Configuration files
- External services

### Simplicity Over Premature Optimization

The current solution avoids unnecessary complexity while keeping the architecture ready for future scaling.