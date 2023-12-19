using Xunit;
using Prime.Services;

namespace Prime.UnitTests.Services
{
    public class PrimeService_IsPrimeShould
    {
      private readonly PrimeService _primeService;
      public PrimeService_IsPrimeShould()
      {
          _primeService = new PrimeService();
      }
      [Theory]
      [InlineData(-1)]
      [InlineData(0)]
      [InlineData(1)]
      public void IsPrime_ValuesLessThan2_ReturnFalse(int value)
      {
          var result = _primeService.IsPrime(value);

          Assert.False(result, $"{value} should not be prime");
      }

      [Theory]
      [InlineData(4)]
      [InlineData(6)]
      [InlineData(12)]
      public void IsPrime_ValueDivisibleBeforeSqrt(int value)
      {
          var result = _primeService.IsPrime(value);
          Assert.False(result, $"{value} should not be prime");
      }
      [Theory]
      [InlineData(3)]
      [InlineData(7)]
      [InlineData(11)]
      public void IsPrime_ValueIsPrime(int value)
      {
          var result = _primeService.IsPrime(value);
          Assert.True(result, $"{value} should be prime");
      }
    }
}