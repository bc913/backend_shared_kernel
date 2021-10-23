using System;

namespace Bcan.Backend.SharedKernel.Tests.DateTimeOffsetRangeTests
{
    public static class DateTimeOffsets
    {
        public static DateTimeOffset TestValue = 
            new DateTimeOffset(
                new DateTime(2020, 1, 1, 10, 0, 0), 
                new TimeSpan(1, 0, 0));
    }
}
