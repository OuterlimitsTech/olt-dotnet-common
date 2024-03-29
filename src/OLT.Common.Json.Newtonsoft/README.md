﻿[![CI](https://github.com/OuterlimitsTech/olt-dotnet-common/actions/workflows/build.yml/badge.svg)](https://github.com/OuterlimitsTech/olt-dotnet-extensions-swagger/actions/workflows/build.yml)[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=OuterlimitsTech_olt-dotnet-common&metric=alert_status)](https://sonarcloud.io/summary/new_code?id=OuterlimitsTech_olt-dotnet-common) [![Nuget](https://img.shields.io/nuget/v/OLT.Common.Json.Newtonsoft)](https://www.nuget.org/packages/OLT.Common.Json.Newtonsoft)

# Utilities for [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/)

| Utility/Item/Object                             | Description                               | Comments                                                     |
| ----------------------------------------------- | ----------------------------------------- | ------------------------------------------------------------ |
| [OltEnumRouteConverter](#OltEnumRouteConverter) | Serialization of Enum in route parameters | [See Also](https://github.com/dotnet/aspnetcore/issues/4008) |

### OltEnumRouteConverter

```csharp
[OltEnumRouteConverter(typeof(OltEnumRouteConverter<DocumentType>))]
public enum DocumentType
{
    [EnumMember(Value = "passport")]
    Passport,

    [EnumMember(Value = "proof_of_address")]
    ProofOfAddress,
}
```
