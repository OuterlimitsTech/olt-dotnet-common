[![CI](https://github.com/OuterlimitsTech/olt-dotnet-common/actions/workflows/build.yml/badge.svg)](https://github.com/OuterlimitsTech/olt-dotnet-extensions-swagger/actions/workflows/build.yml)[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=OuterlimitsTech_olt-dotnet-common&metric=alert_status)](https://sonarcloud.io/summary/new_code?id=OuterlimitsTech_olt-dotnet-common) [![Nuget](https://img.shields.io/nuget/v/OLT.Common.ComponentModel)](https://www.nuget.org/packages/OLT.Common.ComponentModel)

## Utilities for System.ComponentModel.Annotations

| Utility/Item/Object      | Description                            | Comments          |
| ------------------------ | -------------------------------------- | ----------------- |
| OltNotGuidEmptyAttribute | Validation that Guid is not Guid.Empty | See Example Below |
| OltNotNullAttribute      | Validation that object is not null     | See Example Below |

```csharp

public class MyPersonModel
{
    [OltNotGuidEmpty]
    public Guid Id { get; set; }

    [StringLength(100)]
    [Required(AllowEmptyStrings = false)]
    public string Value { get; set; }

    [OltNotNull]
    public MyOtherModel Other { get; set; }

}

```
