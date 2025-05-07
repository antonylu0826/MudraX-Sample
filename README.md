# MudraX Sample

![alt text](https://github.com/antonylu0826/MudraX-Sample/blob/master/screenshot.png)

This solution is a multi-project setup that includes a .NET MAUI application, a Blazor application, and an ASP.NET Core Web API. It leverages modern .NET 9 features and integrates with MudBlazor for UI components and DevExpress XAF for backend services.

## Projects

### 1. ApiServer.WebApi
- **Description**: Implements an ASP.NET Core Web API for platform-agnostic backend services.
- **Key Features**:
  - Database connection and authentication settings configured via `appsettings.json`.
  - Supports CRUD operations for persistent objects.
  - Default login: Username `Admin`, Password (empty).
- **Documentation**:
  - [Backend Web API Service](https://docs.devexpress.com/eXpressAppFramework/403394/backend-web-api-service)
  - [Configuration Fundamentals](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/configuration)

### 2. JwtOData
- **Description**: A Blazor project targeting .NET 9 with OData integration.
- **Key Features**:
  - Uses `MudraX.Blazor.OData` for OData support.
  - Optimized for browser-based platforms.
- **Documentation**:
  - [MudraX.Blazor.OData](https://www.nuget.org/packages/MudraX.Blazor.OData)

### 3. JwtWebApp
- **Description**: A Blazor WebAssembly application powered by MudBlazor.
- **Key Features**:
  - Interactive UI components with MudBlazor.
  - Prerendering support for improved performance.
  - Demonstrates .NET 9 Blazor features.
- **Documentation**:
  - [MudBlazor Documentation](https://mudblazor.com)
  - [Blazor .NET 9 Features](https://github.com/dotnet/aspnetcore/issues/51468)

## Setup Instructions

### Prerequisites
- .NET 9 SDK
- Visual Studio 2022 or later
- Node.js (if required for frontend builds)

### Build and Run
1. Clone the repository.
2. Open the solution in Visual Studio.
3. Restore NuGet packages: `dotnet restore`.
4. Build the solution: `dotnet build`.
5. Run the projects:
   - **ApiServer.WebApi**: `dotnet run --project ApiServer.WebApi`
   - **JwtWebApp**: `dotnet run --project JwtWebApp`

## Contributing
- Contributions are welcome! Please follow the [contributing guidelines](CONTRIBUTING.md) (if available).

## Support
- For questions or assistance, visit the [DevExpress Support Center](https://supportcenter.devexpress.com/ticket/list/).
- Feedback on the Web API Service: [XAF Web API Feedback](https://www.devexpress.com/go/XAF_WebAPI_Feedback.aspx).

## License
This project is licensed under the terms of the [LICENSE](LICENSE.md) file.
