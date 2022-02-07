[![CI](https://github.com/OuterlimitsTech/olt-dotnet-extensions-swagger/actions/workflows/build.yml/badge.svg)](https://github.com/OuterlimitsTech/olt-dotnet-extensions-swagger/actions/workflows/build.yml)[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=OuterlimitsTech_olt-dotnet-extensions-swagger&metric=alert_status)](https://sonarcloud.io/summary/new_code?id=OuterlimitsTech_olt-dotnet-extensions-swagger) [![Nuget](https://img.shields.io/nuget/v/OLT.Extensions.SwaggerGen)](https://www.nuget.org/packages/OLT.Extensions.SwaggerGen)

## Utilities for System.ComponentModel.Annotations

```csharp

public class MyPersonModel
{
    [NotEmpty]
    public Guid Id { get; set; }

    [StringLength(100)]
    [Required(AllowEmptyStrings = false)]
    public string Value { get; set; }
}

```
