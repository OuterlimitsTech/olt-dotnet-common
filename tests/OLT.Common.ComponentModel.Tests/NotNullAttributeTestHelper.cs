using System;

namespace OLT.Common.ComponentModel.Tests
{
    public class NotNullAttributeTestHelper
    {
        public NotNullAttributeTestHelper(DateTimeOffset? value)
        {
            Value = value;
            Expected = value.HasValue;
        }

        public NotNullAttributeTestHelper(string? value)
        {
            Value = value;
            Expected = value != null;
        }

        public NotNullAttributeTestHelper(int? value)
        {
            Value = value;
            Expected = value.HasValue;
        }

        public NotNullAttributeTestHelper(double? value)
        {
            Value = value;
            Expected = value.HasValue;
        }

        public NotNullAttributeTestHelper(Guid? value)
        {
            Value = value;
            Expected = value.HasValue;
        }

        public object Value { get; set; }
        public bool Expected {  get; set; }
    }

}