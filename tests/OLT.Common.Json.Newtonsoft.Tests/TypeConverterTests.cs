using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using Xunit;

namespace OLT.Common.Json.Newtonsoft.Tests
{
    public class TypeConverterTests
    {
        [Fact]
        public void EnumRouteConverter()
        {
            Assert.Equal(TestEnumType.Value1, new OltEnumRouteConverter<TestEnumType>().ConvertFrom("value-one"));
            Assert.Equal(TestEnumType.Value2, new OltEnumRouteConverter<TestEnumType>().ConvertFrom("value-two"));
            Assert.Throws<JsonSerializationException>(() => new OltEnumRouteConverter<TestEnumType>().ConvertFrom("value-three"));
            Assert.Null(new OltEnumRouteConverter<TestEnumType>().ConvertFrom(""));
            Assert.Null(new OltEnumRouteConverter<TestEnumType>().ConvertFrom(" "));
        }
    }
}