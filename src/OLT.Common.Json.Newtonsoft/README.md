[![CI](https://github.com/OuterlimitsTech/olt-dotnet-extensions-swagger/actions/workflows/build.yml/badge.svg)](https://github.com/OuterlimitsTech/olt-dotnet-extensions-swagger/actions/workflows/build.yml)[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=OuterlimitsTech_olt-dotnet-extensions-swagger&metric=alert_status)](https://sonarcloud.io/summary/new_code?id=OuterlimitsTech_olt-dotnet-extensions-swagger) [![Nuget](https://img.shields.io/nuget/v/OLT.Extensions.SwaggerGen)](https://www.nuget.org/packages/OLT.Extensions.SwaggerGen)

# Utilities for [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/)


|Utility| Description | Comments |
|--|--|--|
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
