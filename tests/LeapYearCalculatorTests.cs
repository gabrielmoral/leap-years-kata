using System;
using Xunit;

namespace tests
{
    public class LeapYearCalculatorTests
    {
        [Fact]
        public void IsLeapYearIfDivisibleBy400()
        {
            Assert.True(LeapYearCalculator.IsLeap(2000));
        }
        
        [Fact]
        public void IsNotLeapYearIfNotDivisibleBy400()
        {
            Assert.False(LeapYearCalculator.IsLeap(1900));
        }
        
        [Fact]
        public void IsLeapYearIfDivisibleBy4AndNotDivisibleBy100()
        {
            Assert.True(LeapYearCalculator.IsLeap(2016));
        }
    }
}