using System;
using System.Collections.Generic;
using Xunit;

namespace OLT.Common.ComponentModel.Tests
{

    public class AttributeTests
    {
        static string? nullString = null;
        static int? nullInt = null;
        static double? nullDouble = null;
        static readonly Guid? guidNullValue = null;
        const string GuidStringValue = "3b8c07927ec7445491d6a07ededd2e57";
        static readonly Guid GuidValue = new Guid(GuidStringValue);

        public static IEnumerable<object[]> NotNullTestData => new List<object[]>
        {
                new object[] { new NotNullAttributeTestHelper(DateTimeOffset.Now) },
                new object[] { new NotNullAttributeTestHelper(new DateTimeOffset?()) },
                new object[] { new NotNullAttributeTestHelper(nullString) },
                new object[] { new NotNullAttributeTestHelper("") },
                new object[] { new NotNullAttributeTestHelper(" ") },
                new object[] { new NotNullAttributeTestHelper(Faker.Address.City()) },
                new object[] { new NotNullAttributeTestHelper(Convert.ToInt32(10)) },
                new object[] { new NotNullAttributeTestHelper(nullInt) },
                new object[] { new NotNullAttributeTestHelper(Convert.ToDouble(10.011)) },
                new object[] { new NotNullAttributeTestHelper(Math.PI) },
                new object[] { new NotNullAttributeTestHelper(nullDouble) },
                new object[] { new NotNullAttributeTestHelper(GuidValue) },
                new object[] { new NotNullAttributeTestHelper(guidNullValue) },
                new object[] { new NotNullAttributeTestHelper(Guid.Empty) },
                new object[] { new NotNullAttributeTestHelper(Guid.NewGuid()) },
        };

        

        [Fact]
        public void NotGuidEmpty()
        {
            Guid? nullValue = null;
            
            var validator = new OltNotGuidEmptyAttribute();
            Assert.False(validator.IsValid(Guid.Empty));
            Assert.True(validator.IsValid(Guid.NewGuid()));
            Assert.True(validator.IsValid(nullValue));
            Assert.True(validator.IsValid(GuidStringValue));
            Assert.True(validator.IsValid(Faker.Name.FullName()));
        }


        [Theory]
        [MemberData(nameof(NotNullTestData))]
        public void NotNull(NotNullAttributeTestHelper data)
        {
            var validator = new OltNotNullAttribute();            
            Assert.Equal(data.Expected, validator.IsValid(data.Value));
        }
    }

}